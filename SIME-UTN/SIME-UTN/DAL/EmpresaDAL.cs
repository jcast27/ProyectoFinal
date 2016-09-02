using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace SIME_UTN.DAL
{
    class EmpresaDAL
    {
        static Empresa viejaEmpresa = null;
        internal static bool ObtenerEmpresaByID(int idEmpresa)
        {
            Empresa unEmpresa = new Empresa();
            SqlCommand comando = new SqlCommand("sp_SELECT_Empresa_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            bool existe = false;
            comando.Parameters.AddWithValue("@idempresa", idEmpresa);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                if (ds.Tables[0].Rows.Count > 0)
                {
                    existe = true;
                }
            }

         

            return existe;
        }

        internal static void EliminarEmpresa(Empresa empresaEstaticap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Empresa_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempresa", empresaEstaticap.idEmpresa);



            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(empresaEstaticap,usuarioLogueadop, accion, null);
        }

        internal static void GuardarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            viejaEmpresa = new Empresa();
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Empresa");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", unaEmpresap.nombre);
            comando.Parameters.AddWithValue("@cedula", unaEmpresap.cedulaJuridica);
            comando.Parameters.AddWithValue("@telefono", unaEmpresap.telefono);
            comando.Parameters.AddWithValue("@estado", unaEmpresap.estado);
            viejaEmpresa = ObtenerEmpresaPorId(unaEmpresap.idEmpresa);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaEmpresap, usuarioLogueadop, accion, null);
        }

        internal static void ActualizarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            viejaEmpresa = new Empresa();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_Empresa");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idempresa", unaEmpresap.idEmpresa);
            comando.Parameters.AddWithValue("@nombre", unaEmpresap.nombre);
            comando.Parameters.AddWithValue("@cedula", unaEmpresap.cedulaJuridica);
            comando.Parameters.AddWithValue("@telefono", unaEmpresap.telefono);
            comando.Parameters.AddWithValue("@estado", unaEmpresap.estado);
            viejaEmpresa = ObtenerEmpresaPorId(unaEmpresap.idEmpresa);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaEmpresap, usuarioLogueadop, accion, null);
        }

        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="unProductop"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="productoEliminadop"></param>
        public static void GuardarLog(Empresa unaEmpresap, string usuarioLogueado, string accion, string productoEliminadop)
        {
            Empresa nuevaEmpresa = new Empresa();
            string descripcion = "";
            string estado = "";

            if (accion == "Eliminar")
            {
                descripcion = "Producto eliminada: " + productoEliminadop;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nProducto";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Nombre: " + unaEmpresap.nombre + "\r\nCedula Juridica: " + unaEmpresap.cedulaJuridica + "\r\nTelefono: " + unaEmpresap.telefono + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                nuevaEmpresa = ObtenerEmpresaPorId(unaEmpresap.idEmpresa);

                estado = "Activo";
                descripcion = "\r\nEmpresa";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nNombre: " + viejaEmpresa.nombre + "\r\nCedula Juridica: " + viejaEmpresa.cedulaJuridica + "\r\nTelefono: " + viejaEmpresa.telefono + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nNombre: " + nuevaEmpresa.nombre + "\r\nCedula Juridica: " + nuevaEmpresa.cedulaJuridica + "\r\nTelefono: " + nuevaEmpresa.telefono + "\r\nEstado: " + estado;
            }

            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueado);
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fechamodificacion", fecha);
            comando.Parameters.AddWithValue("@estado", 1);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }

        private static Empresa ObtenerEmpresaPorId(int idEmpresa)
        {
            Empresa unaEmpresa = new Empresa();
            SqlCommand comando = new SqlCommand("sp_SELECT_Empresa_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idempresa", idEmpresa);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {


                    unaEmpresa.idEmpresa = Convert.ToInt32(dr["idempresa"].ToString());
                    unaEmpresa.nombre = dr["nombre"].ToString();
                    unaEmpresa.cedulaJuridica = dr["cedula"].ToString();
                    unaEmpresa.telefono = dr["telefono"].ToString();
                    unaEmpresa.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;


                }
            }

            return unaEmpresa;
        }
    }
}

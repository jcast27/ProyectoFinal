using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class UnidadMedidaDAL
    {
        static UnidadMedida viejaUnidadMedida = null;
        internal static void EliminarUnidad(int unidadId, string unidadp, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_UnidadMedidaProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idunidadmedida", unidadId);
          

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLoguadop, accion, unidadp);
        }

        internal static bool ObtenerUnidadByID(int idUnidad)
        {
            bool existe = false;
            string sql = @"sp_SELECT_UnidadMedidaProducto_ByID";

            List<UnidadMedida> lista = new List<UnidadMedida>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idunidadmedida", idUnidad);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    existe = true;
                }

            }
            return existe;
        }

        internal static UnidadMedida ObtenerUnidadMediadById(int idUnidad)
        {
            bool existe = false;
            UnidadMedida unaUnidad = new UnidadMedida();
            string sql = @"sp_SELECT_UnidadMedidaProducto_ByID";

            List<UnidadMedida> lista = new List<UnidadMedida>();

            SqlCommand comando = new SqlCommand(sql);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idunidadmedida", idUnidad);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                   
                    unaUnidad.idUnidadMedida = Convert.ToInt32(dr["idunidadmedida"].ToString());
                    unaUnidad.codigo = dr["codigo"].ToString();
                    unaUnidad.descripcion = dr["descripcion"].ToString();
                    unaUnidad.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                  
                }

            }
            return unaUnidad;
        }

        internal static void ActualizarUnidad(UnidadMedida unaUnidadp, string usuarioLogueadop)
        {
            viejaUnidadMedida = new UnidadMedida();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_UnidadMedidaProducto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idunidadmedida", unaUnidadp.idUnidadMedida);
            comando.Parameters.AddWithValue("@codigo", unaUnidadp.codigo);
            comando.Parameters.AddWithValue("@descripcion", unaUnidadp.descripcion);
            comando.Parameters.AddWithValue("@Decimales", unaUnidadp.decimales);
            comando.Parameters.AddWithValue("@estado", unaUnidadp.estado);
            viejaUnidadMedida = ObtenerUnidadMediadById(unaUnidadp.idUnidadMedida);
           
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaUnidadp, usuarioLogueadop, accion, null);
        }


        internal static void GuardarUnidad(UnidadMedida unaUnidad, string usuarioLogueadop)
        {
            viejaUnidadMedida = new UnidadMedida();
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_UnidadMedidaProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigo", unaUnidad.codigo);
            comando.Parameters.AddWithValue("@descripcion", unaUnidad.descripcion);
            comando.Parameters.AddWithValue("@Decimales", unaUnidad.decimales);
            comando.Parameters.AddWithValue("@estado", unaUnidad.estado);
            viejaUnidadMedida = ObtenerUnidadMediadById(unaUnidad.idUnidadMedida);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(unaUnidad, usuarioLogueadop, accion, null);
        }

        internal static List<UnidadMedida> ObtenerUnidades()
        {
            List<UnidadMedida> listaUnidad = new List<UnidadMedida>();
            SqlCommand comando = new SqlCommand("sp_SELECT_UnidadMedidaProducto_All");
            comando.CommandType = CommandType.StoredProcedure;
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UnidadMedida unaUnidad = new UnidadMedida();
                    unaUnidad.idUnidadMedida = Convert.ToInt32(dr["idunidadmedida"].ToString());
                    unaUnidad.codigo = dr["codigo"].ToString();
                    unaUnidad.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    listaUnidad.Add(unaUnidad);
                }
            }

            return listaUnidad;
        }
        internal static bool ObtenerUnidadesConDecimales(string descripcionp)
        {
            bool decimales = false;
            SqlCommand comando = new SqlCommand("sp_SELECT_UnidadMedidaProducto_WithDecimal");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", descripcionp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    decimales = true;
                }
            }

            return decimales;
        }
        public static void GuardarLog(UnidadMedida unaMedidap, string usuarioLogueado, string accion, string unidadEliminada)
        {
            UnidadMedida nevaUnidadMedida = new UnidadMedida();
            string descripcion = "";
            string estado = "";


            if (accion == "Eliminar")
            {
                descripcion = "Unidad de medida eliminada: " + unidadEliminada;
                estado = "Desactivado";
            }
            if (accion == "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nUnidad de Medida";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Codigo: " + unaMedidap.codigo + "\r\nUnidad de Medida: " + unaMedidap.descripcion + "\r\nDecimales: " + unaMedidap.decimales == "0" ? "No" : "Si" + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                
                nevaUnidadMedida = ObtenerUnidadMediadById(unaMedidap.idUnidadMedida);
                estado = "Activo";
                descripcion = "\r\nUnidad de Medida";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio" + "\r\nCodigo: " + unaMedidap.codigo + "\r\nUnidad de Medida: " + unaMedidap.descripcion + "\r\nDecimales: " + unaMedidap.decimales == "0" ? "No" : "Si" + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nCodigo: " + nevaUnidadMedida.codigo + "\r\nUnidad de Medida: " + nevaUnidadMedida.descripcion + "\r\nDecimales: " + nevaUnidadMedida.decimales == "0" ? "No" : "Si" + "\r\nEstado: " + estado;
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
    }
}

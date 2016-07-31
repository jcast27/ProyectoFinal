using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class UbicacionDAL
    {
        static Ubicacion viejaUbicacion = null;
        /// <summary>
        /// Metodo que obtiene una lista de ubicaciones
        /// </summary>
        /// /// <returns></returns>
        public static List<Ubicacion> ObtenerUbicacions()
        {
            string sql = @"sp_SELECT_Ubicacion_All";

            List<Ubicacion> lista = new List<Ubicacion>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Ubicacion unUbicacion = new Ubicacion();
                        unUbicacion.idUbicacion = Convert.ToInt32(dr["IDUbicacion"].ToString());
                        unUbicacion.nombre = dr["Nombre"].ToString();
                        unUbicacion.otraSennas = dr["OtrasSennas"].ToString();
                        unUbicacion.area = dr["Area"].ToString();
                        unUbicacion.Departamento = DepartamentoDAL.ObtenerDepartamentoID(Convert.ToInt32(dr["IDDepartamento"].ToString()));
                        unUbicacion.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;
                        lista.Add(unUbicacion);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        /// <summary>
        /// Metodo que desabilita una ubicacion por el ID
        /// </summary>
        /// <param name="idUbicacionp"></param>
        /// <param name="nombrep"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void EliminarUbicacion(int idUbicacionp, string nombrep, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Ubicacion_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            
            comando.Parameters.AddWithValue("@idubicacion", idUbicacionp);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(null, usuarioLogueadop, accion, nombrep);
        }

        /// <summary>
        /// Metodo que guarda una nueva ubicacion
        /// </summary>
        /// <param name="Ubicacionp"></param>
        /// <param name="usuarioLogueadop"></param>
        public static void GuardarUbicacion(Ubicacion Ubicacionp,string usuarioLogueadop)
        {
            viejaUbicacion = new Ubicacion();
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Ubicacion");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", Ubicacionp.nombre);
            comando.Parameters.AddWithValue("@otrassennas", Ubicacionp.otraSennas);
            comando.Parameters.AddWithValue("@iddepartamento", Ubicacionp.Departamento.idDepartamento);
            comando.Parameters.AddWithValue("@estado", Ubicacionp.estado);
            viejaUbicacion = ObtenerUbicacionID(Ubicacionp.idUbicacion);
           

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(Ubicacionp, usuarioLogueadop, accion, null);
        }

        /// <summary>
        /// Metodo que obtiene una Ubicacion por el ID
        /// </summary>
        /// <param name="idUbicacionp"></param>
        /// /// <returns></returns>
        public static Ubicacion ObtenerUbicacionID(int idUbicacionp)
        {
            string sql = @"sp_SELECT_Ubicacion_ByID";

            List<Ubicacion> lista = new List<Ubicacion>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDUbicacion", idUbicacionp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Ubicacion unUbicacion = new Ubicacion();
                    unUbicacion.idUbicacion = Convert.ToInt32(ds.Tables[0].Rows[0]["IDUbicacion"].ToString());
                    unUbicacion.nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    unUbicacion.otraSennas = ds.Tables[0].Rows[0]["OtrasSennas"].ToString();
                    //unUbicacion.area = ds.Tables[0].Rows[0]["Area"].ToString();
                    unUbicacion.Departamento = DepartamentoDAL.ObtenerDepartamentoID(Convert.ToInt32(ds.Tables[0].Rows[0]["IDDepartamento"].ToString()));
                    //unUbicacion.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unUbicacion;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Metodo que valida si la ubicacion existe o no
        /// </summary>
        /// <param name="idUbicacionp"></param>
        /// /// <returns></returns>
        public static bool ValidarUbicacionID(int idUbicacionp)
        {
            bool existe = false;
            string sql = @"sp_SELECT_Ubicacion_ByID";

            List<Ubicacion> lista = new List<Ubicacion>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDUbicacion", idUbicacionp);

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

        /// <summary>
        /// Metodo que actualiza una actualizacion
        /// </summary>
        /// <param name="Ubicacionp"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarUbicacion(Ubicacion Ubicacionp, string usuarioLogueadop)
        {
            viejaUbicacion = new Ubicacion();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_Ubicacion");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idubicacion", Ubicacionp.idUbicacion);
            comando.Parameters.AddWithValue("@nombre", Ubicacionp.nombre);
            comando.Parameters.AddWithValue("@otrassennas", Ubicacionp.otraSennas);
            comando.Parameters.AddWithValue("@iddepartamento", Ubicacionp.Departamento.idDepartamento);
            viejaUbicacion = ObtenerUbicacionID(Ubicacionp.idUbicacion);
           
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            GuardarLog(Ubicacionp, usuarioLogueadop, accion, null);
        }

        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="ubicacionp"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="ubicacionEliminadap"></param>
        public static void GuardarLog(Ubicacion ubicacionp, string usuarioLogueado, string accion, string ubicacionEliminadap)
        {
            Ubicacion nuevaUbicacion = new Ubicacion();
            string descripcion = "";
            string estado = "";
            if (accion == "Eliminar")
            {
                descripcion = "Mezcla eliminada: " + ubicacionEliminadap;
                estado = "Desactivado";
            }
            if(accion== "Insertar")
            {
                estado = "Activo";
                descripcion = "\r\nUbicaciones";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Ubicacion: " + ubicacionp.nombre + "\r\nOtras Senas: " + ubicacionp.otraSennas +"\r\nDepartamento: " + ubicacionp.Departamento.descripcion + "\r\nEstado: " + estado;

            }
            if (accion == "Modificar")
            {
                nuevaUbicacion = ObtenerUbicacionID(ubicacionp.idUbicacion);
                
                estado = "Activo";
                descripcion = "\r\nUbicaciones";
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Antes del Cambio"+"\r\nUbicacion: " + viejaUbicacion.nombre + "\r\nOtras Senas: " + viejaUbicacion.otraSennas +"\r\nDepartamento: "+ viejaUbicacion.Departamento.descripcion + "\r\nEstado: " + estado;
                descripcion += "\r\n-----------------------------------------------------------------------\r\n";
                descripcion += "Despues del Cambio" + "\r\nUbicacion: " + nuevaUbicacion.nombre + "\r\nOtras Senas: " + nuevaUbicacion.otraSennas + "\r\nDepartamento: " + nuevaUbicacion.Departamento.descripcion + "\r\nEstado: " + estado;
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

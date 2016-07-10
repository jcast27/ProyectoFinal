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
        internal static void EliminarUnidad(int unidadId, string unidadp, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_UnidadMedidaProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idunidadmedida", unidadId);
            GuardarLog(null, usuarioLoguadop, accion, unidadp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
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

        internal static void ActualizarUnidad(UnidadMedida unaUnidadp, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_UnidadMedidaProducto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idunidadmedida", unaUnidadp.idUnidadMedida);
            comando.Parameters.AddWithValue("@codigo", unaUnidadp.codigo);
            comando.Parameters.AddWithValue("@descripcion", unaUnidadp.descripcion);
            comando.Parameters.AddWithValue("@Decimales", unaUnidadp.decimales);
            comando.Parameters.AddWithValue("@estado", unaUnidadp.estado);
            GuardarLog(unaUnidadp, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }


        internal static void GuardarUnidad(UnidadMedida unaUnidad, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_UnidadMedidaProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@codigo", unaUnidad.codigo);
            comando.Parameters.AddWithValue("@descripcion", unaUnidad.descripcion);
            comando.Parameters.AddWithValue("@Decimales", unaUnidad.decimales);
            comando.Parameters.AddWithValue("@estado", unaUnidad.estado);

            GuardarLog(unaUnidad, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
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

            string descripcion = "";
            string estado = "";
            if (unaMedidap == null)
            {
                descripcion = "Unidad de medida eliminada: " + unidadEliminada;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Codigo: " + unaMedidap.codigo + "\r\nUnidad de Medida: " + unaMedidap.descripcion + "\r\nDecimales: " + unaMedidap.decimales == "0" ? "No":"Si" + "\r\nEstado: " + estado;

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

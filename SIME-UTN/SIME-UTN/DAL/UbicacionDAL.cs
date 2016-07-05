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
                        unUbicacion.departamento = DepartamentoDAL.ObtenerDepartamentoID(Convert.ToInt32(dr["IDDepartamento"].ToString()));
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

        public static void GuardarUbicacion(Ubicacion Ubicacionp)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Ubicacion");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDUbicacion", Ubicacionp.idUbicacion);
            comando.Parameters.AddWithValue("@Nombre", Ubicacionp.nombre);
            comando.Parameters.AddWithValue("@OtrasSennas", Ubicacionp.otraSennas);
            comando.Parameters.AddWithValue("@Area", Ubicacionp.area);
            comando.Parameters.AddWithValue("@IDDepartamento", Ubicacionp.departamento.idDepartamento);
            comando.Parameters.AddWithValue("@Estado", Ubicacionp.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

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
                    unUbicacion.area = ds.Tables[0].Rows[0]["Area"].ToString();
                    unUbicacion.departamento = DepartamentoDAL.ObtenerDepartamentoID(Convert.ToInt32(ds.Tables[0].Rows[0]["IDDepartamento"].ToString()));
                    //unUbicacion.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unUbicacion;
                }
                else
                {
                    return null;
                }
            }
        }

        internal static void DesactivarUbicacion(string UbicacionIdp, string accion)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Ubicacion_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDUbicacion", UbicacionIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarUbicacion(Ubicacion Ubicacionp)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Ubicacion");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDUbicacion", Ubicacionp.idUbicacion);
            comando.Parameters.AddWithValue("@Nombre", Ubicacionp.nombre);
            comando.Parameters.AddWithValue("@OtrasSennas", Ubicacionp.otraSennas);
            comando.Parameters.AddWithValue("@Area", Ubicacionp.area);
            comando.Parameters.AddWithValue("@IDDepartamento", Ubicacionp.departamento.idDepartamento);
            comando.Parameters.AddWithValue("@Estado", Ubicacionp.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

    }
}

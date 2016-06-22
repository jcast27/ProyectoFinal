using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class ActivoDAL
    {
        public static List<Activo> ObtenerActivos()
        {
            string sql = @"sp_SELECT_Activo_All";

            List<Activo> lista = new List<Activo>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Activo unActivo = new Activo();
                        unActivo.idActivo = Convert.ToInt32(dr["IDActivo"].ToString());
                        unActivo.numeroSerie = dr["NumeroSerie"].ToString();
                        unActivo.descripcion = dr["Descripcion"].ToString();
                        unActivo.idCategoria = Convert.ToInt32(dr["IDCategoria"].ToString());
                        unActivo.annoIngreso = Convert.ToDateTime(dr["AnnoIngreso"].ToString());
                        unActivo.valor = Convert.ToDouble(dr["Valor"].ToString());
                        unActivo.idUbicacion = Convert.ToInt32(dr["IDUbicacion"].ToString());
                        unActivo.marca = dr["Marca"].ToString();
                        unActivo.modelo = dr["Modelo"].ToString();
                        unActivo.patrimonio = dr["Patrimonio"].ToString();
                        unActivo.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;
                       
                        lista.Add(unActivo);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static void GuardarActivo(Activo Activop)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Activo");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDActivo", Activop.idActivo);
            comando.Parameters.AddWithValue("@NumeroSerie", Activop.numeroSerie);
            comando.Parameters.AddWithValue("@Descripcion", Activop.descripcion);
            comando.Parameters.AddWithValue("@IDCategoria", Activop.idCategoria);
            comando.Parameters.AddWithValue("@AnnoIngreso", Activop.annoIngreso);
            comando.Parameters.AddWithValue("@Valor", Activop.valor);
            comando.Parameters.AddWithValue("@IDUbicacion", Activop.idUbicacion);
            comando.Parameters.AddWithValue("@Marca", Activop.marca);
            comando.Parameters.AddWithValue("@Modelo", Activop.modelo);
            comando.Parameters.AddWithValue("@Patrimonio", Activop.patrimonio);
            comando.Parameters.AddWithValue("@Estado", Activop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static Activo ObtenerActivoID(int idActivop)
        {
            string sql = @"sp_SELECT_Activo_ByID";

            List<Activo> lista = new List<Activo>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDActivo", idActivop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Activo unActivo = new Activo();
                    unActivo.idActivo = Convert.ToInt32(ds.Tables[0].Rows[0]["IDActivo"].ToString());
                    unActivo.numeroSerie = ds.Tables[0].Rows[0]["NumeroSerie"].ToString();
                    unActivo.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unActivo.idCategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["IDCategoria"].ToString());
                    unActivo.annoIngreso = Convert.ToDateTime(ds.Tables[0].Rows[0]["AnnoIngreso"].ToString());
                    unActivo.valor = Convert.ToDouble(ds.Tables[0].Rows[0]["Valor"].ToString());
                    unActivo.idUbicacion = Convert.ToInt32(ds.Tables[0].Rows[0]["IDUbicacion"].ToString());
                    unActivo.marca = ds.Tables[0].Rows[0]["Marca"].ToString();
                    unActivo.modelo = ds.Tables[0].Rows[0]["Modelo"].ToString();
                    unActivo.patrimonio = ds.Tables[0].Rows[0]["Patrimonio"].ToString();
                    unActivo.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unActivo;
                }
                else
                {
                    return null;
                }
            }
        }


        internal static void DesactivarActivo(string ActivoIdp, string accion)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Activo_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDActivo", ActivoIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarActivo(Activo Activop)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Activo");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDActivo", Activop.idActivo);
            comando.Parameters.AddWithValue("@NumeroSerie", Activop.numeroSerie);
            comando.Parameters.AddWithValue("@Descripcion", Activop.descripcion);
            comando.Parameters.AddWithValue("@IDCategoria", Activop.idCategoria);
            comando.Parameters.AddWithValue("@AnnoIngreso", Activop.annoIngreso);
            comando.Parameters.AddWithValue("@Valor", Activop.valor);
            comando.Parameters.AddWithValue("@IDUbicacion", Activop.idUbicacion);
            comando.Parameters.AddWithValue("@Marca", Activop.marca);
            comando.Parameters.AddWithValue("@Modelo", Activop.modelo);
            comando.Parameters.AddWithValue("@Patrimonio", Activop.patrimonio);
            comando.Parameters.AddWithValue("@Estado", Activop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}

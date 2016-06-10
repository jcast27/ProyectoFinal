using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class CategoriaItemDAL
    {
        /*public static List<Categoria> ObtenerCategorias()
        {
            string sql = @"sp_SELECT_Categoria_All";

            List<Categoria> lista = new List<Categoria>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Categoria unCategoria = new Categoria();
                        unCategoria.idCategoria = Convert.ToInt32(dr["IDCategoria"].ToString());
                        unCategoria.descripcion = dr["Descripcion"].ToString();
                        unCategoria.pertenencia = dr["Pertenencia"].ToString();
                        unCategoria.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;
                        lista.Add(unCategoria);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static Categoria ObtenerCategoriaporNombre(string descripcion)
        {
            string sql = @"sp_SELECT_Categoria_ByDescripcion";

            List<Categoria> lista = new List<Categoria>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Descripcion", descripcion);

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Categoria unCategoria = new Categoria();
                    unCategoria.idCategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["IDCategoria"].ToString());
                    unCategoria.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unCategoria.pertenencia = ds.Tables[0].Rows[0]["Pertenencia"].ToString();
                    unCategoria.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unCategoria;
                }
                else
                {
                    return null;
                }
            }
        }*/

        public static void GuardarCategoria(CategoriaItem CI)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_CategoriaItems");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", CI.idCategoria);
            comando.Parameters.AddWithValue("@IDItem", CI.idItem);

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                db.ExecuteNonQuery(comando);
            }

        }

        public static List<CategoriaItem> ObtenerCategoriaItemID(int idCategoriap)
        {
            string sql = @"sp_SELECT_CategoriaItems_ByID";

            List<CategoriaItem> lista = new List<CategoriaItem>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDCategoria", idCategoriap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    CategoriaItem unCategoria = new CategoriaItem();
                    unCategoria.idCategoria = Convert.ToInt32(dr["IDCategoria"].ToString());
                    unCategoria.idItem = Convert.ToInt32(dr["IDItem"].ToString());
                    lista.Add(unCategoria);
                }
            }
            return lista;
        }


        internal static void EliminarCategoria(string CategoriaIdp)
        {
            SqlCommand comando = new SqlCommand("sp_DELETE_Categoria_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", CategoriaIdp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                db.ExecuteNonQuery(comando);
            }
        }

    }
}

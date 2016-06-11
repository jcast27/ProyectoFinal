using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class CategoriaDAL
    {
        public static List<Categoria> ObtenerCategorias(string pertenece)
        {
            string sql = @"sp_SELECT_Categoria_All";

            List<Categoria> lista = new List<Categoria>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Pertenece", pertenece);

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

                        List<CategoriaItem> listaCI = CategoriaItemDAL.ObtenerCategoriaItemID(unCategoria.idCategoria);
                        List<Item> listaItems = new List<Item>();
                        foreach (CategoriaItem ci in listaCI)
                        {
                             listaItems.Add(ItemDAL.ObtenerItemID(ci.idItem));
                        }

                        unCategoria.listaItems = listaItems;

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

                    List<CategoriaItem> listaCI = CategoriaItemDAL.ObtenerCategoriaItemID(unCategoria.idCategoria);
                    List<Item> listaItems = new List<Item>();
                    foreach (CategoriaItem ci in listaCI)
                    {
                        listaItems.Add(ItemDAL.ObtenerItemID(ci.idItem));
                    }

                    unCategoria.listaItems = listaItems;

                    return unCategoria;
                }
                else
                {
                    return null;
                }
            }
        }

        public static int GuardarCategoria(Categoria Categoriap)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Categoria");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Descripcion", Categoriap.descripcion);
            comando.Parameters.AddWithValue("@Pertenencia", Categoriap.pertenencia);
            comando.Parameters.AddWithValue("@Estado", Categoriap.estado);

            int idCategoria = 0;

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");
                idCategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            }

            return idCategoria;
        }

        public static Categoria ObtenerCategoriaID(int idCategoriap)
        {
            string sql = @"sp_SELECT_Categoria_ByID";

            List<Categoria> lista = new List<Categoria>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDCategoria", idCategoriap);

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

                    List<CategoriaItem> listaCI = CategoriaItemDAL.ObtenerCategoriaItemID(unCategoria.idCategoria);
                    List<Item> listaItems = new List<Item>();
                    foreach (CategoriaItem ci in listaCI)
                    {
                        listaItems.Add(ItemDAL.ObtenerItemID(ci.idItem));
                    }

                    unCategoria.listaItems = listaItems;

                    return unCategoria;
                }
                else
                {
                    return null;
                }
            }
        }


        internal static void DesactivarCategoria(string CategoriaIdp, string accion)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Categoria_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", CategoriaIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void ActualizarCategoria(Categoria Categoriap)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Categoria");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", Categoriap.idCategoria);
            comando.Parameters.AddWithValue("@Descripcion", Categoriap.descripcion);
            comando.Parameters.AddWithValue("@Pertenencia", Categoriap.pertenencia);
            comando.Parameters.AddWithValue("@Estado", Categoriap.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default"))
            {
                db.ExecuteNonQuery(comando);
            }
        }

    }
}

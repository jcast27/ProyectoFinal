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
        public static void GuardarCategoriaItem(CategoriaItem CI)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_CategoriaItems");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", CI.idCategoria);
            comando.Parameters.AddWithValue("@IDItem", CI.idItem);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
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

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
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


        internal static void EliminarCategoriaItem(string CategoriaIdp)
        {
            SqlCommand comando = new SqlCommand("sp_DELETE_CategoriaItems_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCategoria", CategoriaIdp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void GuardarLog(CategoriaItem CI, string usuarioLogueado, string accion)
        {

            string descripcion = "Categoria: " + CI.idCategoria + "\r\nItem: " + CI.idItem;

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

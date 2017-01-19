using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class ItemDAL
    {
        public static List<Item> ObtenerItems()
        {
            string sql = @"sp_SELECT_Item_All";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Item unItem = new Item();
                        unItem.idItem = Convert.ToInt32(dr["IDItem"].ToString());
                        unItem.descripcion = dr["Descripcion"].ToString();
                        unItem.seccion = dr["Seccion"].ToString();
                        unItem.estado = dr["Estado"].ToString().Equals("True") ? 1 : 0;
                        lista.Add(unItem);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static Item ObtenerItemporNombre(string descripcion)
        {
            string sql = @"sp_SELECT_Item_ByDescripcion";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Descripcion", descripcion);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Item unItem = new Item();
                    unItem.idItem = Convert.ToInt32(ds.Tables[0].Rows[0]["IDItem"].ToString());
                    unItem.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unItem.seccion = ds.Tables[0].Rows[0]["Seccion"].ToString();
                    unItem.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unItem;
                }
                else
                {
                    return null;
                }
            }
        }

        public static void GuardarItem(Item Itemp, string user)
        {
            SqlCommand comando = new SqlCommand("sp_INSERT_Item");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDItem", Itemp.idItem);
            comando.Parameters.AddWithValue("@Descripcion", Itemp.descripcion);
            comando.Parameters.AddWithValue("@Seccion", Itemp.seccion);
            comando.Parameters.AddWithValue("@Estado", Itemp.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(Itemp, user, "Insertar", "");

        }

        public static Item ObtenerItemID(int idItemp)
        {
            string sql = @"sp_SELECT_Item_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IDItem", idItemp);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Item unItem = new Item();
                    unItem.idItem = Convert.ToInt32(ds.Tables[0].Rows[0]["IDItem"].ToString());
                    unItem.descripcion = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    unItem.seccion = ds.Tables[0].Rows[0]["Seccion"].ToString();
                    unItem.estado = ds.Tables[0].Rows[0]["Estado"].ToString().Equals("True") ? 1 : 0;

                    return unItem;
                }
                else
                {
                    return null;
                }
            }
        }


        internal static void EliminarItem(string ItemIdp, string accion, string user)
        {
            accion = accion.Equals("Habilitar") ? "1" : "0";

            SqlCommand comando = new SqlCommand("sp_DISABLE_Item_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDItem", ItemIdp);
            comando.Parameters.AddWithValue("@estado", accion);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(null, user, "Eliminar", ItemIdp);
        }

        internal static void ActualizarItem(Item Itemp, string user)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Item");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDItem", Itemp.idItem);
            comando.Parameters.AddWithValue("@Descripcion", Itemp.descripcion);
            comando.Parameters.AddWithValue("@Seccion", Itemp.seccion);
            comando.Parameters.AddWithValue("@Estado", Itemp.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            GuardarLog(Itemp, user, "Modificar", "");

        }

        public static void GuardarLog(Item item, string usuarioLogueado, string accion, string itemEliminado)
        {

            string descripcion = "";
            int estado = 0;
            if (item == null)
            {
                descripcion = "Item deshabilitado: " + itemEliminado;
            }
            else
            {
                estado = 1;
                descripcion = "Item #: " + item.idItem + "\r\nDescripción: " + item.descripcion +
                    "\r\nSección: " + item.seccion + "\r\nSección: " + item.estado;
            }

            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueado);
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fechamodificacion", fecha);
            comando.Parameters.AddWithValue("@estado", estado);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data.SqlClient;
using System.Data;
using SIME_UTN.DTOs;

namespace SIME_UTN.DAL
{
    class RegistroBodegaDAL
    {

        /// <summary>
        /// Metodo que elimina una Bodega
        /// </summary>
        /// <param name="idBodegap"></param>
        /// <param name="bodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void EliminarBodega(int idBodegap, string bodegap, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_RegistroBodega_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodega", idBodegap);
            GuardarLog(null, usuarioLogueadop, accion, bodegap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            int estado = 0;
            DesableTipodeBodega(idBodegap);
        }


        /// <summary>
        /// Metodo que obtiene una bodega por meido del ID
        /// </summary>
        /// <param name="idRegistroBodega"></param>
        /// <returns></returns>
        internal static bool ObtenerBodegaByID(int idRegistroBodega)
        {
            bool existe = false;
            string sql = @"sp_SELECT_RegistroBodega_ByID";

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idregistrobodega",idRegistroBodega);

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
        /// Metodo que obtiene una lista de Bodegas
        /// </summary>
        /// <returns></returns>
        internal static List<RegistroBodegaTipoBodegaDTO> ObtenertBodegas()
        {
            List<RegistroBodegaTipoBodegaDTO> listaBodegas = new List<RegistroBodegaTipoBodegaDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RegistroBodegaTipoBodegaDTO unaBodega = new RegistroBodegaTipoBodegaDTO();
                    unaBodega.idregistrobodega = Convert.ToInt32(dr["idregistrobodega"].ToString());
                    unaBodega.nombre = dr["nombre"].ToString();
                    unaBodega.descripcion = dr["descripcion"].ToString();
                    unaBodega.tipobodega = dr["tipobodega"].ToString();
                    unaBodega.estado = Convert.ToInt32(dr["estado"]);
                    listaBodegas.Add(unaBodega);
                }
            }

            return listaBodegas;
        }

        /// <summary>
        /// Metodo que actualiza los campos de una bodega
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            List<InventarioProducto> listInventario = new List<InventarioProducto>();
            string accion = "";
            accion = "Modificar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", unaBodegap.idRegistroBodega);
            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);
            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

            if (unaBodegap.TipoBodega.idTipoBodega != 1)
            {

                CambiarTipodeBodega(unaBodegap.idRegistroBodega);
            }else
            {
                EliminaripodeBodega(unaBodegap.idRegistroBodega);
                listInventario = AsociarBodegaConInventario();
                foreach (InventarioProducto unInvetario in listInventario)
                {
                    InsertarInvetarioEnBodega(unInvetario,unaBodegap.idRegistroBodega);
                }
            }
        }


        /// <summary>
        /// Metodo que cambia el tipo de bodega y actualiza el campo contenido de los productos asociado a la bodega, segun el tipo de bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        internal static void CambiarTipodeBodega(int idRegistroBodegap)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Bodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Metodo que desabilita los productos asociado a la bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        internal static void DesableTipodeBodega(int idRegistroBodegap)
        {
            SqlCommand comando = new SqlCommand("sp_Desable_Bodega");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Metodo que elimina los productos asociado a la bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        internal static void EliminaripodeBodega(int idRegistroBodegap)
        {
            SqlCommand comando = new SqlCommand("sp_DeleteBodegaInventario_ByID");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDBodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }



        /// <summary>
        /// Metodo que guarda una nueva Bodega
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void GuardarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            List<InventarioProducto> listInventario = new List<InventarioProducto>();
            string accion = "";
            accion = "Insertar";
            int ultimiIdInsertado = 0;
            SqlCommand comando = new SqlCommand("sp_INSERT_RegistroBodega");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombre", unaBodegap.nombre);
            comando.Parameters.AddWithValue("@descripcion", unaBodegap.descripcion);
            comando.Parameters.AddWithValue("@tipo", unaBodegap.TipoBodega.idTipoBodega);
            comando.Parameters.AddWithValue("@estado", unaBodegap.estado);


            GuardarLog(unaBodegap, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    ultimiIdInsertado = Convert.ToInt32(dr["IDRegistroBodega"].ToString());

                }
            }
   
                listInventario = AsociarBodegaConInventario();
                foreach(InventarioProducto unInvetario in listInventario)
                {
                    if (unaBodegap.TipoBodega.idTipoBodega == 1)
                     {
                        InsertarInvetarioEnBodega(unInvetario, ultimiIdInsertado);
                        }else
                        {
                            InsertarInvetarioEnBodega(unInvetario, ultimiIdInsertado);
                            CambiarTipodeBodega(ultimiIdInsertado);
                        }
                }
            
        }


        /// <summary>
        /// Metodo optiene los productos del inventario y los asocia a la bodega si esta es fisica
        /// </summary>
        /// <param name="unInvetariop"></param>
        /// <param name="ultimiIdInsertadop"></param>
        internal static void InsertarInvetarioEnBodega(InventarioProducto unInvetariop, int ultimiIdInsertadop)
        {

            SqlCommand comando1 = new SqlCommand("sp_INSERT_Bodega");
            comando1.CommandType = CommandType.StoredProcedure;

            comando1.Parameters.AddWithValue("@idregistrobodega", ultimiIdInsertadop);
            comando1.Parameters.AddWithValue("@idproducto", unInvetariop.idProducto.idProducto);
            comando1.Parameters.AddWithValue("@codigoavatar", unInvetariop.codigoAvatar);
            comando1.Parameters.AddWithValue("@descripcion", unInvetariop.descripcion);
            comando1.Parameters.AddWithValue("@idunidadmedida", unInvetariop.idUnidadMedida.idUnidadMedida);
            comando1.Parameters.AddWithValue("@contenido", unInvetariop.stockActual);
            comando1.Parameters.AddWithValue("@estado", unInvetariop.estado);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando1);
            }
        }

        /// <summary>
        /// Metodo optiene los productos del inventario para poder asociarlos
        /// </summary>
        /// <returns></returns>
        internal static List<InventarioProducto> AsociarBodegaConInventario()
        {
            List<InventarioProducto> listInventario = new List<InventarioProducto>();
            SqlCommand comando = new SqlCommand("sp_SELECT_InventarioProducto_All");
            comando.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    InventarioProducto inventario = new InventarioProducto();
                    Producto unProducto = new Producto();
                    UnidadMedida unidadMedida = new UnidadMedida();
                    inventario.idInventarioProducto = Convert.ToInt32(dr["idinventarioproducto"].ToString());
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    inventario.idProducto = unProducto;
                    inventario.codigoAvatar = dr["codigoavatar"].ToString();
                    inventario.descripcion = dr["descripcion"].ToString();
                    unidadMedida.idUnidadMedida = Convert.ToInt32(dr["idunidadmedida"].ToString());
                    inventario.idUnidadMedida = unidadMedida;
                    inventario.stockActual = float.Parse(dr["stockactual"].ToString());
                    inventario.stockMinimo = float.Parse(dr["stockminimo"].ToString());
                    inventario.stockMaximo = float.Parse(dr["stockmaximo"].ToString());
                    inventario.estado = Convert.ToInt32(dr["estado"]);
                    listInventario.Add(inventario);
                }
            }
            return listInventario;
        }

        /// <summary>
        /// Metodo guarda todo cambio en la tabla log
        /// </summary>
        /// <param name="unaBodegap"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="bodegaEliminadap"></param>
        private static void GuardarLog(RegistroBodega unaBodegap, string usuarioLogueadop, string accion, string bodegaEliminadap)
        {
            string descripcion = "";
            string estado = "";
            if (unaBodegap == null)
            {
                descripcion = "Producto eliminado: " + bodegaEliminadap;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Bodega: " + unaBodegap.nombre + "\r\nDescripcion: " + unaBodegap.descripcion + "\r\nTipo de Bodega: " + unaBodegap.TipoBodega.descripcion + "\r\nEstado: " + estado;

            }
            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueadop);
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

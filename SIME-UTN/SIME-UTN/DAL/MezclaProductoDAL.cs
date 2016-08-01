using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;
using System.Data.SqlClient;
using System.Data;
using SIME_UTN.Entities;

namespace SIME_UTN.DAL
{
    class MezclaProductoDAL
    {

        /// <summary>
        /// Metodo que guarda los productos de una mezcla
        /// </summary>
        /// <param name="unaMezclaProductoUnidadDTOp"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void GuardarMezclaProducto(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTOp, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_MezclaProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmezcla", unaMezclaProductoUnidadDTOp.idMezcla);
            comando.Parameters.AddWithValue("@idproducto", unaMezclaProductoUnidadDTOp.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida", unaMezclaProductoUnidadDTOp.idUnidadMedida);
            comando.Parameters.AddWithValue("@cantidad", unaMezclaProductoUnidadDTOp.cantidad);
            comando.Parameters.AddWithValue("@estado", unaMezclaProductoUnidadDTOp.estado);


           //GuardarLog(unaMezclaProductoUnidadDTOp, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }


        /// <summary>
        /// Metodo que actualiza los productos de una mezcla
        /// </summary>
        /// <param name="unaMezclaProductoUnidadDTOp"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void ActualizarMezclaProducto(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTOp, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_MezclaProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmezcla", unaMezclaProductoUnidadDTOp.idMezcla);
            comando.Parameters.AddWithValue("@idproducto", unaMezclaProductoUnidadDTOp.idProducto);
            comando.Parameters.AddWithValue("@cantidad", unaMezclaProductoUnidadDTOp.cantidad);
            comando.Parameters.AddWithValue("@estado", unaMezclaProductoUnidadDTOp.estado);

            //GuardarLog(unaMezclaProductoUnidadDTOp, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Metodo que verificar si existe una mezcla y su producto por los IDs
        /// </summary>
        /// <param name="idMezclap"></param>
        /// <param name="idProductop"></param>
        /// <returns></returns>
        internal static bool ObtenerMezclaProductoByID(int idMezclap,int idProductop)
        {
            bool existe = false;
            string sql = @"sp_SELECT_MezclaProducto_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idmezcla", idMezclap);
            command.Parameters.AddWithValue("@idproducto", idProductop);

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
        /// Metodo que desabilita un producto de la mezcla por el ID de la mezcla y del producto
        /// </summary>
        /// <param name="unProductop"></param>
        /// <param name="idMezclap"></param>
        /// <param name="usuarioLogueadop"></param>
        internal static void EliminarProductoDeMezcla(Producto unProductop,int idMezclap,string usuarioLogueadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DESABLE_MezclaProducto_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmezcla", idMezclap);
            comando.Parameters.AddWithValue("@idproducto", unProductop.idProducto);
            //GuardarLog(null, usuarioLogueadop, accion, unProductop.nombreProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Metodo que optiene una lista de productos por medio de ID de la mazcla
        /// </summary>
        /// <param name="idRegistroMezclap"></param>
        /// <returns></returns>
        internal static List<ProductoDTO> ObtenerProductosPorIdMezcla(int idRegistroMezclap)
        {
            List<ProductoDTO> listaProductosDTO = new List<ProductoDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_MezclaProducto_ByID_DTO");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idmezcla", idRegistroMezclap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ProductoDTO unProducto = new ProductoDTO();
                    unProducto.idProducto = int.Parse(dr["IDProducto"].ToString());
                    unProducto.codigoAvatar = dr["CodigoAvatar"].ToString();
                    unProducto.nombreProducto = dr["Nombre"].ToString();
                    unProducto.unidadMedida = dr["UnidadMedida"].ToString();
                    unProducto.cantidad = Double.Parse(dr["Cantidad"].ToString());
                    listaProductosDTO.Add(unProducto);
                }
            }

            return listaProductosDTO;
        }


        /// <summary>
        /// Metodo que genera un log para toda transaccion
        /// </summary>
        /// <param name="unaMezclaProductoUnidadDTOp"></param>
        /// <param name="usuarioLogueadop"></param>
        /// <param name="accion"></param>
        /// <param name="mezclaProductoEliminadap"></param>
       /* public static void GuardarLog(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTOp, string usuarioLogueadop, string accion, string mezclaProductoEliminadap)
        {

            string descripcion = "";
            string estado = "";
            if (unaMezclaProductoUnidadDTOp == null)
            {
                descripcion = "Producto eliminado de la Mezcla: " + mezclaProductoEliminadap;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Mezcla: " + unaMezclaProductoUnidadDTOp.nombreMezcla + "\r\nProducto: " + unaMezclaProductoUnidadDTOp.nombreProducto + "\r\nUnidad De Medida: " + unaMezclaProductoUnidadDTOp.nombreUnidadMedida +"\r\nCantidad: " + unaMezclaProductoUnidadDTOp.cantidad + "\r\nEstado: " +estado;

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

        }*/
    }
}

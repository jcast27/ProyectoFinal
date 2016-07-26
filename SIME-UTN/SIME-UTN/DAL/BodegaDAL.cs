using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;
using System.Data.SqlClient;
using System.Data;

namespace SIME_UTN.DAL
{
    class BodegaDAL
    {


        /// <summary>
        /// Metodo que optine una lista de Productos por medio del ID de registro Bodega
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        ///  /// <returns></returns>
        internal static List<PBodega> ObtenerProductosPorIdBodega(int idRegistroBodegap)
        {
            List<PBodega> listaProductos = new List<PBodega>();
            SqlCommand comando = new SqlCommand("sp_SELECT_Bodega_ByIDBodega");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idbodega", idRegistroBodegap);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PBodega unProducto = new PBodega();
                    //unProducto.idBodega = Convert.ToInt32(dr["idbodega"].ToString());
                    unProducto.RegistroBodega = RegistroBodegaDAL.ObtenerBodega(Convert.ToInt32(dr["idregistrobodega"].ToString()));
                    unProducto.Producto = ProductoDAL.ObtenerProductoPorCodigoAvatar(dr["codigoavatar"].ToString());
                    unProducto.UnidadMedida = UnidadMedidaDAL.ObtenerUnidadMediadById(Convert.ToInt32(dr["idunidadmedida"].ToString()));
                    unProducto.contenido = double.Parse(dr["contenido"].ToString());
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }

        /// <summary>
        /// Metodo que actualiza la cantidad de una que no sea fisica
        /// </summary>
        /// <param name="idRegistroBodegap"></param>
        /// <param name="idProductop"></param>
        /// <param name="cantidadp"></param>
        internal static void ActualizarCantidad(int idRegistroBodegap, int idProductop, double cantidadp)
        {

            SqlCommand comando = new SqlCommand("sp_UPDATE_Bodega_Cantidad");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
            comando.Parameters.AddWithValue("@idproducto", idProductop);
            comando.Parameters.AddWithValue("@Contenido", cantidadp);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        internal static void CambiarCantidadyActualizarla(int idRegistroBodegap, int idProducto, double ucantidad, double cantidad)
        {
            SqlCommand comando = new SqlCommand("sp_UPDATE_Bodega_Update_Cantidad");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idregistrobodega", idRegistroBodegap);
            comando.Parameters.AddWithValue("@idproducto", idProducto);
            comando.Parameters.AddWithValue("@UContenido", ucantidad);
            comando.Parameters.AddWithValue("@Contenido", cantidad);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }
    }
}

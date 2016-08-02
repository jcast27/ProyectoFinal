using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data;
using System.Data.SqlClient;
using SIME_UTN.DTOs;

namespace SIME_UTN.DAL
{
    class TrasladoProductoInterDAL
    {

        /// <summary>
        /// Metodo que optiene una lista de productos
        /// </summary>
        /// <param name="filtroNombreProductop"></param>
        /// <returns></returns>
        internal static List<TrasladoProductoInterDTO> ObtenerProductosPorIdTraslado(int idTrasladop)
        {
            List<TrasladoProductoInterDTO> listaProductosDTO = new List<TrasladoProductoInterDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_TrasladoProductoInter_ByID_DTO");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", idTrasladop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TrasladoProductoInterDTO unProducto = new TrasladoProductoInterDTO();
                    unProducto.idProducto = int.Parse(dr["IDProducto"].ToString());
                    unProducto.codigoAvatar = dr["CodigoAvatar"].ToString();
                    unProducto.nombreProducto = dr["Nombre"].ToString();
                    unProducto.idUnidadMedida = int.Parse(dr["IDUnidadMedida"].ToString());
                    unProducto.nombreUnidadMedida = dr["UnidadMedida"].ToString();
                    unProducto.unidades = int.Parse(dr["Unidades"].ToString());
                    unProducto.contenido = double.Parse(dr["Cantidad"].ToString());
                    listaProductosDTO.Add(unProducto);
                }
            }

            return listaProductosDTO;
        }


        /// <summary>
        /// Metodo que actualiza los productos de un traslado
        /// </summary>
        /// <param name="trasladoInterDTOp"></param>
        internal static void ActualizarTrasladoProductos(TrasladoProductoInterDTO trasladoInterDTOp, TrasladoProducto trasladop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_UPDATE_TrasladoProductoInter");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", trasladoInterDTOp.idTraslado);
            comando.Parameters.AddWithValue("@idproducto", trasladoInterDTOp.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida", trasladoInterDTOp.idUnidadMedida);
            comando.Parameters.AddWithValue("@Unidades", trasladoInterDTOp.unidades);
            comando.Parameters.AddWithValue("@estado", trasladoInterDTOp.estado);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
            
           

        }

        internal static double ObtenerUltimaCantidadDelTraslado(TrasladoProductoInterDTO trasladoInterDTOp)
        {
            List<TrasladoProductoInterDTO> listaProductosDTO = new List<TrasladoProductoInterDTO>();
            double cantidad = 0;
            SqlCommand comando = new SqlCommand("sp_SELECT_TrasladoCantidad");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idTraslado", trasladoInterDTOp.idTraslado);
            comando.Parameters.AddWithValue("@idProducto", trasladoInterDTOp.idProducto);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    cantidad = Double.Parse(dr["cantidad"].ToString());

                }
            }

            return cantidad;
        }

        /// <summary>
        /// Metodo que valida si el producto existe en le traslado
        /// </summary>
        /// <param name="idTrasladop"></param>
        /// <param name="idProductop"></param>
        /// <returns></returns>
        internal static bool ValidarTrasladoProducto(int idTrasladop, int idProductop)
        {
            bool existe = false;
            string sql = @"sp_SELECT_TrasladoProductoInter_ByID";

            List<Item> lista = new List<Item>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idtraslado", idTrasladop);
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
        /// Metodo que guarda los productos de un traslado
        /// </summary>
        /// <param name="unaMezclaProductoUnidadDTOp"></param>
        internal static void GuardarTrasladoProductos(TrasladoProductoInterDTO trasladoInterDTOp,TrasladoProducto trasladop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_TrasladoProductoInter");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idtraslado", trasladoInterDTOp.idTraslado);
            comando.Parameters.AddWithValue("@idproducto", trasladoInterDTOp.idProducto);
            comando.Parameters.AddWithValue("@idunidadmedida", trasladoInterDTOp.idUnidadMedida);
            comando.Parameters.AddWithValue("@unidades", trasladoInterDTOp.unidades);
            comando.Parameters.AddWithValue("@estado", trasladoInterDTOp.estado);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
  

        }
    }
}

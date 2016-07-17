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
                    unProducto.cantidad = Double.Parse(dr["Cantidad"].ToString());
                    listaProductosDTO.Add(unProducto);
                }
            }

            return listaProductosDTO;
        }
    }
}

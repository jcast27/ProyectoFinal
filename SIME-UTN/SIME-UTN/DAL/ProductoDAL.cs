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
    class ProductoDAL
    {
        internal static List<ProductoCategoriaUnidadMedidaDTO> ObtenertPorNombreDTO(string filtroNombreProductop)
        {
            List<ProductoCategoriaUnidadMedidaDTO> listaProductos = new List<ProductoCategoriaUnidadMedidaDTO>();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_By_Filter");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@filter", filtroNombreProductop);
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");

            
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ProductoCategoriaUnidadMedidaDTO unProducto = new ProductoCategoriaUnidadMedidaDTO();
                        unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                        unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                        unProducto.nombreProducto = dr["nombre"].ToString();
                        unProducto.descripcion = dr["descripcion"].ToString();
                        unProducto.categoria = dr["categoria"].ToString();
                        unProducto.ubicacion = dr["ubicacion"].ToString();
                        unProducto.unidadMedida = dr["unidadmedida"].ToString();
                        unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                        listaProductos.Add(unProducto);
                    }
            }

            return listaProductos;
        }

        internal static List<Producto> ObtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            SqlCommand comando = new SqlCommand("sp_SELECT_Producto_All");
            comando.CommandType = CommandType.StoredProcedure;
            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(comando, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Producto unProducto = new Producto();
                    unProducto.idProducto = Convert.ToInt32(dr["idproducto"].ToString());
                    unProducto.codigoAvatar = dr["codigoavatar"].ToString();
                    unProducto.nombreProducto = dr["nombre"].ToString();
                    unProducto.descripcion = dr["descripcion"].ToString();
                    unProducto.idCategoria.idCategoria = int.Parse(dr["categoria"].ToString());
                    unProducto.ubicacion = dr["ubicacion"].ToString();
                    unProducto.idUnidadMedida.idUnidadMedida = int.Parse(dr["unidadmedida"].ToString());
                    unProducto.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }
    }
}

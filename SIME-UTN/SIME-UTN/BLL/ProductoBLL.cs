using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class ProductoBLL
    {
        internal static List<ProductoCategoriaUnidadMedidaDTO> ObtenertPorNombreDTO(string filtroNombreProductop)
        {
            return ProductoDAL.ObtenertPorNombreDTO(filtroNombreProductop);
        }

        internal static List<Producto> ObtenerProductos()
        {
           return ProductoDAL.ObtenerProductos();
        }

        internal static void GuardarProducto(Producto unProductop,string usuarioLogueadop)
        {
            if (ProductoDAL.ObtenerProductoByID(unProductop.idProducto) == false)
            {

                ProductoDAL.GuardarProducto(unProductop, usuarioLogueadop);
            }
            else
            {
                ProductoDAL.ActualizarProducto(unProductop, usuarioLogueadop);
            }
           
        }

        internal static void EliminarUsuario(int productoIDp,string productop,string usuarioLoguadop)
        {
            ProductoDAL.EliminarUsuario(productoIDp,productop,usuarioLoguadop);
        }

        internal static Producto ObtenerProductoPorCodigoAvatar(string codigoAvatarp)
        {
            return ProductoDAL.ObtenerProductoPorCodigoAvatar(codigoAvatarp);
        }
    }
}

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
    }
}

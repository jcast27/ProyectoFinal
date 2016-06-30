using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorProducto
    {
        public static Producto producto;
        public static string nombreProducto;
        public static GestorProducto instancia;

        public GestorProducto()
        {
            producto = new Producto();
        }

        public static GestorProducto GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorProducto();
            }

            return instancia;
        }

        internal List<ProductoCategoriaUnidadMedidaDTO> ObtenertPorNombreDTO(string filtroNombreProductop)
        {
            return ProductoBLL.ObtenertPorNombreDTO(filtroNombreProductop);
        }

        internal List<Producto> ObtenerProductos()
        {
            return ProductoBLL.ObtenerProductos();
        }
    }
}

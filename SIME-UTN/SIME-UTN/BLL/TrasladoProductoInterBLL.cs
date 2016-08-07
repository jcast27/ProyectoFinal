using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class TrasladoProductoInterBLL
    {
        internal static List<TrasladoProductoInterDTO> ObtenerProductosPorIdTraslado(int idTrasladop)
        {
            return DAL.TrasladoProductoInterDAL.ObtenerProductosPorIdTraslado(idTrasladop);
        }

        internal static void GuardarTrasladoProductos(PBodega productoBodega, TrasladoProducto trasladop)
        {
            if (DAL.TrasladoProductoInterDAL.ValidarTrasladoProducto(trasladop.idTraslado, productoBodega.Producto.idProducto) ==true)
            {
                double cantidad = TrasladoProductoInterDAL.ObtenerUltimaCantidadDelTraslado(productoBodega, trasladop);
            
                DAL.TrasladoProductoInterDAL.ActualizarTrasladoProductos(productoBodega, trasladop);
                BodegaDAL.CambiarCantidadyActualizarla(trasladop.BodegaOrigen.idRegistroBodega, productoBodega.Producto.idProducto, cantidad, productoBodega.unidades);
            }
            else
            {
                DAL.TrasladoProductoInterDAL.GuardarTrasladoProductos(productoBodega, trasladop);
                BodegaDAL.ActualizarCantidad(trasladop.BodegaOrigen.idRegistroBodega, productoBodega.Producto.idProducto, productoBodega.unidades,trasladop.idTraslado);
            }
           
        }
    }
}

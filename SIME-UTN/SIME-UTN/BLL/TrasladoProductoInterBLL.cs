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

        internal static void GuardarTrasladoProductos(TrasladoProductoInterDTO trasladoInterDTOp,TrasladoProducto trasladop)
        {
            if (DAL.TrasladoProductoInterDAL.ValidarTrasladoProducto(trasladoInterDTOp.idTraslado, trasladoInterDTOp.idProducto) ==true)
            {
                DAL.TrasladoProductoInterDAL.ActualizarTrasladoProductos(trasladoInterDTOp, trasladop);
            }
            else
            {
                DAL.TrasladoProductoInterDAL.GuardarTrasladoProductos(trasladoInterDTOp,trasladop);
            }
           
        }
    }
}

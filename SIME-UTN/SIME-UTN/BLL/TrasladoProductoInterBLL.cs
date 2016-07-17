using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.DTOs;

namespace SIME_UTN.BLL
{
    class TrasladoProductoInterBLL
    {
        internal static List<TrasladoProductoInterDTO> ObtenerProductosPorIdTraslado(int idTrasladop)
        {
            return DAL.TrasladoProductoInterDAL.ObtenerProductosPorIdTraslado(idTrasladop);
        }
    }
}

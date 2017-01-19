using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;

namespace SIME_UTN.BLL
{
    class BodegaBLL
    {
        internal static List<PBodega> ObtenerProductosPorIdBodega(int idRegistroBodegap)
        {
           return DAL.BodegaDAL.ObtenerProductosPorIdBodega(idRegistroBodegap);
        }
    }
}

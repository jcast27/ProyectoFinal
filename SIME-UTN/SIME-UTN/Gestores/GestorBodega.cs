using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;
using SIME_UTN.DTOs;

namespace SIME_UTN.Gestores
{
    class GestorBodega
    {
        public static PBodega bodega;
        public static GestorBodega instancia;

        public GestorBodega()
        {
            bodega = new PBodega();
        }

        public static GestorBodega GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorBodega();
            }

            return instancia;
        }

        internal List<PBodega> ObtenerProductosPorIdBodega(int idRegistroBodegap)
        {
            return BLL.BodegaBLL.ObtenerProductosPorIdBodega(idRegistroBodegap);
        }
    }
}

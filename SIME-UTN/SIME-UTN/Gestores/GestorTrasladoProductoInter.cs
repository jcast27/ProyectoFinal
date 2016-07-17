using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;
using SIME_UTN.DTOs;

namespace SIME_UTN.Gestores
{
    class GestorTrasladoProductoInter
    {
        public static TrasladoProductoInter traslado;
        public static GestorTrasladoProductoInter instancia;

        public GestorTrasladoProductoInter()
        {
            traslado = new TrasladoProductoInter();
        }

        public static GestorTrasladoProductoInter GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorTrasladoProductoInter();
            }

            return instancia;
        }

        internal List<TrasladoProductoInterDTO> ObtenerProductosPorIdTraslado(int idTrasladop)
        {
           return BLL.TrasladoProductoInterBLL.ObtenerProductosPorIdTraslado(idTrasladop);
        }

        internal void GuardarTrasladoProductos(TrasladoProductoInterDTO trasladoInterDTOp, TrasladoProducto trasladop)
        {
            BLL.TrasladoProductoInterBLL.GuardarTrasladoProductos(trasladoInterDTOp,trasladop);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;

namespace SIME_UTN.BLL
{
    class TrasladoProductoBLL
    {
        internal static void DeclinarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            List<TrasladoProductoInterDTO> listaProductosDTO = new List<TrasladoProductoInterDTO>();
            listaProductosDTO = TrasladoProductoInterDAL.ObtenerProductosPorIdTraslado(trasladoEstatico.idTraslado);
            DAL.TrasladoProductoDAL.DeclinarTraslado(trasladoEstatico, usuarioLogueadop);
            TrasladoProductoDAL.VolverProductoEliminadoABodega(trasladoEstatico, listaProductosDTO);
        }

        internal static string ObtenerSiguienteNumeroTraslado()
        {
            return DAL.TrasladoProductoDAL.ObtenerSiguienteNumeroTraslado();
        }

        internal static void GuardarTraslado(TrasladoProducto trasladop, string usuarioLogueadop)
        {
            if (DAL.TrasladoProductoDAL.ObtenerTrasladoByID(trasladop.idTraslado) == true)
            {
                TrasladoProductoDAL.ActualizarTraslado(trasladop, usuarioLogueadop);
            }else
            {
                TrasladoProductoDAL.GuardarTraslado(trasladop, usuarioLogueadop);
            }
        }

        internal static void AceptarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            DAL.TrasladoProductoDAL.AceptarTraslado(trasladoEstatico, usuarioLogueadop);

            List<TrasladoProductoInterDTO> listaProductosDTO = new List<TrasladoProductoInterDTO>();
            listaProductosDTO = TrasladoProductoInterDAL.ObtenerProductosPorIdTraslado(trasladoEstatico.idTraslado);
            if (trasladoEstatico.TipoTraslado.descripcion == "Traslado")
            {
                DAL.TrasladoProductoDAL.TrasladarProductosABodegaDestino(trasladoEstatico, listaProductosDTO);
            }
            else
            {
                DAL.TrasladoProductoDAL.VolverProductoEliminadoABodega(trasladoEstatico, listaProductosDTO);
            }
        }
    }
}

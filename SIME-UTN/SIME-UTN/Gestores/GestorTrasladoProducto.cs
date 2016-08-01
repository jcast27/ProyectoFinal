using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorTrasladoProducto
    {
        public static TrasladoProducto traslado;
        public static GestorTrasladoProducto instancia;

        public GestorTrasladoProducto()
        {
            traslado = new TrasladoProducto();
        }

        public static GestorTrasladoProducto GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorTrasladoProducto();
            }

            return instancia;
        }

        internal void DeclinarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            TrasladoProductoBLL.DeclinarTraslado(trasladoEstatico, usuarioLogueadop);
        }

        internal string ObtenerSiguienteNumeroTraslado()
        {
            return TrasladoProductoBLL.ObtenerSiguienteNumeroTraslado();
        }

        internal void GuardarTraslado(TrasladoProducto trasladop, string usuarioLogueadop)
        {
            TrasladoProductoBLL.GuardarTraslado(trasladop, usuarioLogueadop);
        }

        internal void AceptarTraslado(TrasladoProducto trasladoEstatico, string usuarioLogueadop)
        {
            TrasladoProductoBLL.AceptarTraslado(trasladoEstatico, usuarioLogueadop);
        }
    }
}

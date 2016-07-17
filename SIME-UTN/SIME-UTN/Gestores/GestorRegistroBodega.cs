using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;
using SIME_UTN.DTOs;

namespace SIME_UTN.Gestores
{
    class GestorRegistroBodega
    {
        public static RegistroBodega registroBodega;
        public static string nombreBodega;
        public static GestorRegistroBodega instancia;

        public GestorRegistroBodega()
        {
            registroBodega = new RegistroBodega();
        }

        public static GestorRegistroBodega GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorRegistroBodega();
            }

            return instancia;
        }

        internal void EliminarBodega(int idBodegap, string bodegap, string usuarioLogueadop)
        {
            RegistroBodegaBLL.EliminarBodega(idBodegap,bodegap,usuarioLogueadop);
        }

        internal void AgregarBodega(RegistroBodega unaBodegap)
        {
            registroBodega = unaBodegap;
        }

        internal List<RegistroBodegaTipoBodegaDTO> ObtenertBodegas()
        {
            return RegistroBodegaBLL.ObtenertBodegas();
        }

        internal void GuardarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            RegistroBodegaBLL.GuardarBodega(unaBodegap,usuarioLogueadop);
        }

        internal RegistroBodega ObtenerBodegaPorIDRegistro(int idRegistroBodegap)
        {
            return RegistroBodegaBLL.ObtenerBodegaPorIDRegistro(idRegistroBodegap);
        }
    }
}

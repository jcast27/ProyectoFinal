using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class RegistroBodegaBLL
    {
        internal static void EliminarBodega(int idBodegap, string bodegap, string usuarioLogueadop)
        {
            RegistroBodegaDAL.EliminarBodega(idBodegap,bodegap,usuarioLogueadop);
        }

        internal static void GuardarBodega(RegistroBodega unaBodegap, string usuarioLogueadop)
        {
            if (RegistroBodegaDAL.ObtenerBodegaByID(unaBodegap.idRegistroBodega) == false)
            {

                RegistroBodegaDAL.GuardarBodega(unaBodegap, usuarioLogueadop);
            }
            else
            {
                RegistroBodegaDAL.ActualizarBodega(unaBodegap, usuarioLogueadop);
            }
        }

        internal static List<RegistroBodegaTipoBodegaDTO> ObtenertBodegas()
        {
            return RegistroBodegaDAL.ObtenertBodegas();
        }
    }
}

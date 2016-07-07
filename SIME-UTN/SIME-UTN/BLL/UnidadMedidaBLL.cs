using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class UnidadMedidaBLL
    {
        internal static List<UnidadMedida> ObtenerUnidades()
        {
            return UnidadMedidaDAL.ObtenerUnidades();
        }

        internal static void GuardarUnidad(UnidadMedida unaUnidad, string usuarioLogueadop)
        {
            if (UnidadMedidaDAL.ObtenerUnidadByID(unaUnidad.idUnidadMedida) == false)
            {

                UnidadMedidaDAL.GuardarUnidad(unaUnidad, usuarioLogueadop);
            }
            else
            {
                UnidadMedidaDAL.ActualizarUnidad(unaUnidad, usuarioLogueadop);
            }

        }

        internal static void EliminarUnidad(int unidadId, string unidadP, string usuarioLoguadop)
        {
            UnidadMedidaDAL.EliminarUnidad(unidadId, unidadP, usuarioLoguadop);
        }
    }
}

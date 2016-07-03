using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class ActivoBLL
    {

        public static List<Activo> ObtenerActivos()
        {
            return ActivoDAL.ObtenerActivos();
        }

        internal static void GuardarActivo(Activo Activop)
        {
            if (ActivoDAL.ObtenerActivoID(Activop.idActivo) == null)
            {
                ActivoDAL.GuardarActivo(Activop);
            }
            else
            {
                ActivoDAL.ActualizarActivo(Activop);
            }
        }


        internal static Activo ObtenerActivoID(int ActivoIdp)
        {
            return ActivoDAL.ObtenerActivoID(ActivoIdp);
        }

        internal static void DesactivarActivo(string ActivoIdp, string accion)
        {
            ActivoDAL.DesactivarActivo(ActivoIdp, accion);
        }

    }
}

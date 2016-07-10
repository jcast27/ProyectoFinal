using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class RegistroMezclaBLL
    {
        internal static int GuardarRegistroMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            return DAL.RegistroMezclaDAL.GuardarRegistroMezcla(unaMezclap, usuarioLogueadop);
        }

        internal static void ActualizarMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            DAL.RegistroMezclaDAL.ActualizarMezcla(unaMezclap,usuarioLogueadop);
        }
    }
}

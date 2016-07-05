using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class FormularioBLL
    {

        internal static int GuardarFormulario(Formulario Formulariop)
        {
            return FormularioDAL.GuardarFormulario(Formulariop);
        }


        internal static Formulario ObtenerFormularioID(int FormularioIdp)
        {
            return FormularioDAL.ObtenerFormularioID(FormularioIdp);
        }

        internal static List<Formulario> ObtenerFormularios()
        {
            return FormularioDAL.ObtenerFormularios();
        }

    }
}

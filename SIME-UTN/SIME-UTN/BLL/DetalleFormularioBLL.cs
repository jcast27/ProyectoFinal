using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class DetalleFormularioBLL
    {
        internal static void GuardarDF(DetalleFormulario DFp)
        {
            DetalleFormularioDAL.GuardarDetalleFormulario(DFp);
        }


        internal static List<DetalleFormulario> ObtenerDFID(int DFp)
        {
            return DetalleFormularioDAL.ObtenerDetalleFormularioID(DFp);
        }

    }
}

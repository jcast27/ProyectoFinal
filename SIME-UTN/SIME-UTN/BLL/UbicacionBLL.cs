using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class UbicacionBLL
    {
        internal static void EliminarUbicacion(int idUbicacionp, string nombrep, string usuarioLogueadop)
        {
            DAL.UbicacionDAL.EliminarUbicacion(idUbicacionp,nombrep,usuarioLogueadop);
        }

        internal static void GuardarUbicacion(Ubicacion unaUbicacionp, string usuarioLogueadop)
        {
            if (DAL.UbicacionDAL.ValidarUbicacionID(unaUbicacionp.idUbicacion) != true)
            {
                DAL.UbicacionDAL.GuardarUbicacion(unaUbicacionp, usuarioLogueadop);
            }else
            {
                DAL.UbicacionDAL.ActualizarUbicacion(unaUbicacionp, usuarioLogueadop);
            }
        }
    }
}

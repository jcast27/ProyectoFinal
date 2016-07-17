using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class TrasladoProductoBLL
    {
        internal static void EliminarTraslado(int idTrasladop, string usuarioLogueadop)
        {
            DAL.TrasladoProductoDAL.EliminarTraslado(idTrasladop, usuarioLogueadop);
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;

namespace SIME_UTN.BLL
{
    class TrasladoProductoBLL
    {
        internal static void EliminarTraslado(int idTrasladop, string usuarioLogueadop)
        {
            DAL.TrasladoProductoDAL.EliminarTraslado(idTrasladop, usuarioLogueadop);
        }
    }
}

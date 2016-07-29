using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class DespachoBLL
    {

        internal static void GuardarDespacho(int idDespacho, PBodega Bodegap)
        {
            DespachoDAL.guardarDespachoDetalle(idDespacho, Bodegap);
        }

        internal static int GuardarDespacho(int idBodega, UsuarioTable user, string descripcion, Funcionario funcionario)
        {
            return DespachoDAL.GuardarDespacho(idBodega, user, descripcion, funcionario);
        }

    }
}

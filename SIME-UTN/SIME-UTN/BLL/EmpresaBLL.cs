using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class EmpresaBLL
    {
        internal static void GuardarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            if (EmpresaDAL.ObtenerEmpresaByID(unaEmpresap.idEmpresa) == false)
            {

                EmpresaDAL.GuardarEmpresa(unaEmpresap, usuarioLogueadop);

            }
            else
            {
                EmpresaDAL.ActualizarEmpresa(unaEmpresap, usuarioLogueadop);
            }
        }

        internal static void EliminarEmpresa(Empresa empresaEstaticap, string usuarioLogueadop)
        {
            EmpresaDAL.EliminarEmpresa(empresaEstaticap, usuarioLogueadop);
        }
    }
}

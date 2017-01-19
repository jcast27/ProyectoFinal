using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class DepartamentoBLL
    {
        public static List<Departamento> ObtenerDepartamentos()
        {
            return DepartamentoDAL.ObtenerDepartamentos();
        }

        internal static void GuardarDepartamento(Departamento Departamentop, string usuarioLogueadop)
        {
            if (DepartamentoDAL.ObtenerDepartamentoID(Departamentop.idDepartamento) == null)
            {
                DepartamentoDAL.GuardarDepartamento(Departamentop, usuarioLogueadop);
            }
            else
            {
                DepartamentoDAL.ActualizarDepartamento(Departamentop, usuarioLogueadop);
            }
        }

        internal static Departamento ObtenerDepartamentoID(int DepartamentoIdp)
        {

            return DepartamentoDAL.ObtenerDepartamentoID(DepartamentoIdp);
        }

        internal static void EliminarDepartamento(int deptoId, string depto, string usuarioLoguadop)
        {
            DepartamentoDAL.EliminarDepartamento(deptoId, depto, usuarioLoguadop);
        }
    }
}

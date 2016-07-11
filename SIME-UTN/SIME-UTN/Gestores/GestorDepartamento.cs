using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorDepartamento
    {
        public static Departamento Departamento;
        public static string NombreDepto;
        public static GestorDepartamento instancia;

        public GestorDepartamento()
        {
            Departamento = new Departamento();
        }

        public static GestorDepartamento GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorDepartamento();
            }

            return instancia;
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            return DepartamentoBLL.ObtenerDepartamentos();
        }

        public void AgregarDepartamento(Departamento departamentop)
        {
            Departamento = departamentop;
        }

        public Departamento ObtenerDepartamento()
        {
            return Departamento;
        }

        public void GuardarDepartamento(Departamento unDeptop, string usuarioLogueadop)
        {
            DepartamentoBLL.GuardarDepartamento(unDeptop, usuarioLogueadop);
        }

        public Departamento ObtenerDepartamentoId(int deptoIdp)
        {
            return DepartamentoBLL.ObtenerDepartamentoID(deptoIdp);
        }

        internal void EliminarDepartamento(int deptoId, string deptop, string usuarioLoguadop)
        {
            DepartamentoBLL.EliminarDepartamento(deptoId, deptop, usuarioLoguadop);
        }
    }
}

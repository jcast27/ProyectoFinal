using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorEmpresa
    {
        public static Empresa empresa;
        public static GestorEmpresa instancia;

        public GestorEmpresa()
        {
            empresa = new Empresa();
        }

        public static GestorEmpresa GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorEmpresa();
            }

            return instancia;
        }

        internal void AgregarEmpresa(Empresa unaEmpresa)
        {
            empresa = unaEmpresa;
        }

        internal void GuardarEmpresa(Empresa unaEmpresap, string usuarioLogueadop)
        {
            BLL.EmpresaBLL.GuardarEmpresa(unaEmpresap, usuarioLogueadop);
        }

        internal void EliminarEmpresa(Empresa empresaEstaticap, string usuarioLogueadop)
        {
            BLL.EmpresaBLL.EliminarEmpresa(empresaEstaticap,usuarioLogueadop);
        }
    }
}

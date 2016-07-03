using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class FuncionarioBLL
    {

        public static List<Funcionario> ObtenerFuncionarios()
        {
            return FuncionarioDAL.ObtenerFuncionarios();
        }

        internal static void GuardarFuncionario(Funcionario Funcionariop)
        {
            if (FuncionarioDAL.ObtenerFuncionarioID(Funcionariop.idFuncionario) == null)
            {
                FuncionarioDAL.GuardarFuncionario(Funcionariop);
            }
            else
            {
                FuncionarioDAL.ActualizarFuncionario(Funcionariop);
            }
        }

        internal static Funcionario ObtenerFuncionarioID(int FuncionarioIdp)
        {
            return FuncionarioDAL.ObtenerFuncionarioID(FuncionarioIdp);
        }

        internal static void DesactivarFuncionario(string FuncionarioIdp, string accion)
        {
            FuncionarioDAL.DesactivarFuncionario(FuncionarioIdp, accion);
        }

    }
}

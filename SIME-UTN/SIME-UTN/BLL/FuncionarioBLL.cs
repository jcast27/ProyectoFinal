
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class FuncionarioBLL
    {
        public static List<Funcionario> ObtenerFuncionarios()
        {
            return FuncionarioDAL.ObtenerFuncionarios();
        }

        public static Funcionario ObtenerFuncionarioID(int idFuncionariop)
        {
            return FuncionarioDAL.ObtenerFuncionarioID(idFuncionariop);
        }

        internal static void GuardarFuncionario(Funcionario funcionarioP)
        {

            if (FuncionarioDAL.ObtenerFuncionarioID(funcionarioP.idFuncionario) == null)
            {
               FuncionarioDAL.GuardarFuncionario(funcionarioP);
            }
            else
            {
                FuncionarioDAL.ActualizarFuncionario(funcionarioP);
            }
            
        }

        internal static void DesactivarFuncionario(string FuncionarioIdp, string accion)
        {
            FuncionarioDAL.DesactivarFuncionario(FuncionarioIdp, accion);
        }

        internal static void ActualizarFuncionario(Funcionario funcionariop)
        {
            FuncionarioDAL.ActualizarFuncionario(funcionariop);
        }
    }
}

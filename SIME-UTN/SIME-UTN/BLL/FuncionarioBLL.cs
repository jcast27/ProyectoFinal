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

        internal static void GuardarFuncionario(Funcionario Funcionariop, string usuarioLogueadop)
        {
            if (FuncionarioDAL.ObtenerFuncionarioID(Funcionariop.idFuncionario) == null)
            {
                FuncionarioDAL.GuardarFuncionario(Funcionariop, usuarioLogueadop);
            }
            else
            {
                FuncionarioDAL.ActualizarFuncionario(Funcionariop, usuarioLogueadop);
            }
        }

        internal static Funcionario ObtenerFuncionarioID(int FuncionarioIdp)
        {
            
            return FuncionarioDAL.ObtenerFuncionarioID(FuncionarioIdp);
        }

        /*  internal static void DesactivarFuncionario(string FuncionarioIdp, string accion)
          {
              FuncionarioDAL.DesactivarFuncionario(FuncionarioIdp, accion);
          }*/

        internal static void EliminarFuncionario(int funcionarioIdp, string funcionariop, string usuarioLoguadop)
        {
            FuncionarioDAL.EliminarFuncionario(funcionarioIdp, funcionariop, usuarioLoguadop);
        }

        internal static void ActualizarFuncionario(Funcionario funcionariop, string usuarioLogueadop)
        {
            FuncionarioDAL.ActualizarFuncionario(funcionariop, usuarioLogueadop);
        }
    }
}

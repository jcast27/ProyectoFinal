using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;
using SIME_UTN.BLL;
using System.Windows.Forms;

namespace SIME_UTN.Gestores
{
    class GestorFuncionario
    {
        public static Funcionario Funcionario;
        public static string NombreFuncionario;
        public static GestorFuncionario instancia;

        public GestorFuncionario()
        {
            Funcionario = new Funcionario();
        }
        public static GestorFuncionario GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorFuncionario();
            }

            return instancia;
        }

        public List<Funcionario> ObtenerFuncionarios()
        {
            return FuncionarioBLL.ObtenerFuncionarios();
        }

        public void AgregarFuncionario(Funcionario Funcionariop)
        {
            Funcionario = Funcionariop;
        }

        public Funcionario ObtenerFuncionario()
        {
            return Funcionario;
        }

        public void GuardarFuncionario(Funcionario unFuncionariop, string usuarioLogueadop)
        {
            FuncionarioBLL.GuardarFuncionario(unFuncionariop, usuarioLogueadop);
        }

        public Funcionario ObtenerFuncionarioId(int FuncionarioIdp)
        {
            return FuncionarioBLL.ObtenerFuncionarioID(FuncionarioIdp);
        }

       /* public void DesactivarFuncionario(string FuncionarioIdp, string accion)
        {
            FuncionarioBLL.DesactivarFuncionario(FuncionarioIdp, accion);
        }*/

        internal void EliminarFuncionario(int funcionarioId, string funcionariop, string usuarioLoguadop)
        {
            FuncionarioBLL.EliminarFuncionario(funcionarioId, funcionariop, usuarioLoguadop);
        }

    }
}

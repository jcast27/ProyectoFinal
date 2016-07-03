using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;

namespace SIME_UTN.Gestores
{
    class GestorFuncionario
    {
        public static Funcionario funcionario;
        public static string nombreFuncionario;
        public static GestorFuncionario instancia;

        public GestorFuncionario()
        {
            funcionario = new Funcionario();
        }

        public static GestorFuncionario GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorFuncionario();
            }

            return instancia;
        }


    }
}

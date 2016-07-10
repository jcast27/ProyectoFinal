using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;

namespace SIME_UTN.Gestores
{
    class GestorDepartamento
    {
        public static Departamento departamento;
        public static GestorDepartamento instancia;

        public GestorDepartamento()
        {
            departamento = new Departamento();
        }

        public static GestorDepartamento GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorDepartamento();
            }

            return instancia;
        }
    }
}

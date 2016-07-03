using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Funcionario
    {
        public int idFuncionario { set; get; }
        public string nombre { set; get; }
        public string cedula { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }
        public int idDepartamento { set; get; }
        public int estado { set; get; }

        public Funcionario() { }
    }
}

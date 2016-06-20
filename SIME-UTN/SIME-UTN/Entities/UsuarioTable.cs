using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME_UTN.Entities
{
  public  class UsuarioTable
    {

        public int codigoUsuario { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string perfil { get; set; }
        public string contrasena { get; set; }
        public int estado { get; set; }

        public UsuarioTable() { }

        public override string ToString()
        {
            return codigoUsuario.ToString();
        }

    }
}

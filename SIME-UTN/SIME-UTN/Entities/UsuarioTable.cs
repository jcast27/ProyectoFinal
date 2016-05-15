using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME_UTN.Entities
{
    class UsuarioTable
    {

        public int codigoUsuario { get; set; }
        public string usuario { get; set; }
        public string perfil { get; set; }
        public string contrasena { get; set; }

        public UsuarioTable() { }

        public override string ToString()
        {
            return codigoUsuario.ToString();
        }

    }
}

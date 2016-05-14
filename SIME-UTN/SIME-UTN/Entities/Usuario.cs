using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME_UTN.Entities
{
    class Usuario
    {
        private static Usuario instancia;

        public string usuario { set; get; }
        public string contrasenna { set; get; }

        public static Usuario GetInstance()
        {

            if (instancia == null)
                instancia = new Usuario();

            return instancia;

        }

    }

}

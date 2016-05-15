using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME_UTN.Entities
{
    class UsuarioDB
    {
        private static UsuarioDB instancia;

        public string usuario { set; get; }
        public string contrasenna { set; get; }

        public static UsuarioDB GetInstance()
        {

            if (instancia == null)
                instancia = new UsuarioDB();

            return instancia;

        }

    }

}

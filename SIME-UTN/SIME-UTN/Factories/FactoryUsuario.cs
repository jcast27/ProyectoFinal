using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;

namespace SIME_UTN.Factories
{
    class FactoryUsuario
    {
        public static Usuario CrearUsuario()
        {
            Usuario userp = null;
            userp = new Usuario();
            return userp;
        }
    }
}

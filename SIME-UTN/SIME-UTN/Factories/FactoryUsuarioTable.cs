using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;

namespace SIME_UTN.Factories
{
    class FactoryUsuarioTable
    {
        public static UsuarioTable CrearUsuario()
        {
            UsuarioTable userp = null;
            userp = new UsuarioTable();
            return userp;
        }
    }
}

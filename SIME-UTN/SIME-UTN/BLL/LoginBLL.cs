using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.DAL;

namespace SIME_UTN.BLL
{
    class LoginBLL
    {
        public static void Conexion(String pUsuario, String pContrasena)
        {
            LoginDAL.Conexion(pUsuario, pContrasena);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIME_UTN.DAL
{
    class LoginDAL
    {
        internal static void Conexion(string pUsuario, string pContrasena)
        {
            DataBase db = null;

            try
            {
                db = DataBaseFactory.CreateDataBase("default", pUsuario, pContrasena);

            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {

                if (db != null)
                    db.Dispose();
            }
        }
    }
}

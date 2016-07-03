using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    public class Encriptar
    {
        #region Metodos

        public string Cifrar(string Encript)
        {
            String strEncriptar = "";
            strEncriptar = Convert.ToBase64String(new System.Text.ASCIIEncoding().GetBytes(Encript));
            return strEncriptar;
        }

        public string Descifrar(string Encript)
        {
            string strDencriptar = "";
            if (Encript != "")
            {
                try
                {
                    strDencriptar = new System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(Encript));
                }
                catch (System.IO.IOException e)
                {
                    return "Nothing";
                }
            }
            return strDencriptar;
        }

        #endregion
    }
}

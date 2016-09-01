using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
   public class Empresa
    {
        public int idEmpresa { set; get; }
        public string nombre { set; get; }
        public string cedulaJuridica { set; get; }
        public string telefono { set; get; }
        public int estado { set; get; }

        public Empresa() { }
    }
}

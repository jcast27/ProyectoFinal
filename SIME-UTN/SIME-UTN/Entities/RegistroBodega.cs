using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
  public class RegistroBodega
    {
        public int idRegistroBodega { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public TipoBodega TipoBodega { set; get; }
        public int estado { set; get; }

        public RegistroBodega() { }

    }
}

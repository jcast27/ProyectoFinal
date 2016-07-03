using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
  public  class UnidadMedida
    {
        public int idUnidadMedida { set; get; }
        public string descripcion { set; get; }
        public int estado { set; get; }

        public UnidadMedida() { }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

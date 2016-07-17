using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
   public class TipoTraslado
    {
        public int idTipoTraslado { set; get; }
        public string descripcion  { set; get; }
        public int estado { set; get; }

        public TipoTraslado() { }
    }
}

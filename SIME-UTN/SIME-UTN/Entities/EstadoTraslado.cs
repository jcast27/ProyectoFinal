using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
   public class EstadoTraslado
    {
        public int idEstadoTraslado { set; get; }
        public string descripcion { set; get; }
        public int estado { set; get; }

        public EstadoTraslado() { }
    }
}

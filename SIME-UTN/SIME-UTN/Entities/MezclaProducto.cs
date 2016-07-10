using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
   public class MezclaProducto
    {
        public Mezcla Mezcla { set; get; }
        public Producto Producto { set; get; }
        public UnidadMedida UnidadMedida { set; get; }
        public float Cantidad { set; get; }
        public int estado { set; get; }

        public MezclaProducto() { }


    }
}

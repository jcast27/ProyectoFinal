using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
  public  class TrasladoProductoInter
    {
       public TrasladoProducto TrasladoProducto { set; get; }
       public Producto Producto { set; get; }
       public  UnidadMedida UnidadMedida { set; get; }
       public float cantidad { set; get; }

        public TrasladoProductoInter() { }
    }
}

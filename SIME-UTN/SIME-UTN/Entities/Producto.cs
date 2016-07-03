using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
   public class Producto
    {
        public int idProducto { set; get; }
        public string codigoAvatar { set; get; }
        public string nombreProducto { set; get; }
        public string descripcion { set; get; }
        public Categoria Categoria { set; get; }
        public Ubicacion Ubicacion { set; get; }
        public UnidadMedida UnidadMedida { set; get; }
        public int estado { set; get; }

        public Producto() { }

        public override string ToString()
        {
            return descripcion;
        }

    }
}

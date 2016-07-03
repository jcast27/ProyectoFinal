using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class InventarioProducto
    {
        public int idInventarioProducto { set; get; }
        public string codigoAvatar { set; get; }
        public Producto idProducto { set; get; } 
        public string descripcion { set; get; }
        public UnidadMedida idUnidadMedida { set; get; }
        public float stockActual { set; get; }
        public float stockMinimo { set; get; }
        public float stockMaximo { set; get; }
        public int estado { set; get; }

        public InventarioProducto() { }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

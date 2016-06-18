using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Producto
    {
        public int idProducto { set; get; }
        public string codigoAvatar { set; get; }
        public string nombreProducto { set; get; }
        public string descripcion { set; get; }
        public Categoria idCategoria { set; get; }
        public string ubicacion { set; get; }
        public UnidadMedida idUnidadMedida { set; get; }
        public int estado { set; get; }

        public Producto() { }

        public override string ToString()
        {
            return descripcion;
        }

    }
}

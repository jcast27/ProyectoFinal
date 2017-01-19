using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
    class ProductoDTO
    {
        public int idProducto { set; get; }
        public string codigoAvatar { set; get; }
        public string nombreProducto { set; get; }
        public double cantidad { set; get; }
        public int presentacion { set; get; }
        public string unidadMedida { set; get; }
        public string cantidadPorEmpaque { set; get; }
        public int estado { set; get; }
    }
}

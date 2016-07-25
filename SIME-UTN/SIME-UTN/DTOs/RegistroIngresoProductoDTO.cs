using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
    public class RegistroIngresoProductoDTO
    {
        public int idIngreso { set; get; }

        public int idBodega { set; get; }
        public int idProducto { set; get; }
        public string nombreProducto { set; get; }
        public int cantidadPorEmpaque { set; get; }

        public string codigoAvatar { set; get; }
        public double uCantidad { set; get; }
        public double cantidad { set; get; }
        public double costoPorEmpaque { set; get; }
        public int Idunidad { set; get; }
        public string unidadMedida { set; get; }
        public string fechaCaducidad { set; get; }
        public int estado { set; get; }

        public RegistroIngresoProductoDTO() { }
    }
}

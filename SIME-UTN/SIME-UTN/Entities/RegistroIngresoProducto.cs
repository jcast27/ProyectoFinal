using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    public class RegistroIngresoProducto
    {
        public int idIngresoProducto { set; get; }
        public int idProducto { set; get; }
        public int cantidadPorEmpaque { set; get; }
        public double cantidad { set; get; }
        public double costoPorEmpaque { set; get; }
        public int estado { set; get; }

        public RegistroIngresoProducto() { }

    }
}

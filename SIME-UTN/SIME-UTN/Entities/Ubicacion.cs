using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    public class Ubicacion
    {
        public int idUbicacion { set; get; }
        public string nombre { set; get; }
        public string area { set; get; }
        public string otraSennas { set; get; }
        public Departamento departamento { set; get; }
        public int estado { set; get; }

        public Ubicacion() { }

    }
}

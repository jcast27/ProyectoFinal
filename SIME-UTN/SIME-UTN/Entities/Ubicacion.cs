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
        public string otrasSennas { set; get; }
        public int idDepartamento { set; get; }
    }
}

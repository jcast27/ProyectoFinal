using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Activo
    {
        public int idActivo { set; get; }
        public string nombre { set; get; }
        public string numeroSerie { set; get; }
        public string descripcion { set; get; }
        public int idCategoria { set; get; }
        public DateTime annoIngreso { set; get; }
        public double valor { set; get; }
        public int idUbicacion { set; get; }
        public string marca { set; get; }
        public string modelo { set; get; }
        public string patrimonio { set; get; }
        public int estado { set; get; }

        public Activo() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
  public class Mezcla
    {
        public int idRegistroMezcla { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public Categoria Categoria { set; get; }
        public int estado { set; get; }

        public Mezcla() { }

    }
}

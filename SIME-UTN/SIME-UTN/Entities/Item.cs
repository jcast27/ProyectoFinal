using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Item
    {
        public int idItem { set; get; }
        public string descripcion { set; get; }
        public string seccion { set; get; }
        public int estado { set; get; }

        public Item() { }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

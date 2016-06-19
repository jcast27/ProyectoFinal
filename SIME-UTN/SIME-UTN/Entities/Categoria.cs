using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Categoria
    {
        public int idCategoria { set; get; }
        public string descripcion { set; get; }
        public string pertenencia { set; get; }
        public int estado { set; get; }
        public List<Item> listaItems { set; get; }

        public Categoria() { }


    }
}

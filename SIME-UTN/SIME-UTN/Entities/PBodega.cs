using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
  public class PBodega
    {
        public int idBodega { set; get; }
        public RegistroBodega RegistroBodega { set; get; }
        public Producto Producto { set; get; }
        public UnidadMedida UnidadMedida { set; get; }
        public double contenido { set; get; }
        public int estado { set; get; }

        public PBodega() { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class DetalleFormulario
    {
        public int idFormulario { set; get; }
        public int idItem { set; get; }
        public string valor { set; get; }

        public DetalleFormulario() { }

    }
}

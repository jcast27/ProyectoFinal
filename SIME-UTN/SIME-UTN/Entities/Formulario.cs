using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    class Formulario
    {
        public int idFormulario { set; get; }
        public string cliente { set; get; }
        public Activo activo { set; get; }
        public DateTime fecha { set; get; }
        public Funcionario funcionario { set; get; }
        public string observaciones { set; get; }
        public List<DetalleFormulario> listaDF { set; get; }

        public Formulario() { }

    }
}

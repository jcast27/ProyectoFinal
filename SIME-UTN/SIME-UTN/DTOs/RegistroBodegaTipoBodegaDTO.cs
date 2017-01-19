using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
   public class RegistroBodegaTipoBodegaDTO
    {
        public int idregistrobodega { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public string tipobodega { set; get; }
        public int estado { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
    class TrasladoProductoInterDTO
    {
        public int idTraslado { set; get; }
        public int idProducto { set; get; }
        public string nombreProducto { set; get; }
        public string codigoAvatar { set; get; }
        public int idUnidadMedida { set; get; }
        public string nombreUnidadMedida { set; get; }
        public double contenido { set; get; }
        public int unidades { set; get; }
        public int estado { set; get; }
    }
}

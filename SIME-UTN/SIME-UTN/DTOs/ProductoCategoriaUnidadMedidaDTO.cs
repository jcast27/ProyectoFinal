using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
   public class ProductoCategoriaUnidadMedidaDTO
    {
        public int idProducto { set; get; }
        public string codigoAvatar { set; get; }
        public string nombreProducto { set; get; }
        public string descripcion { set; get; }
        public string categoria { set; get; }
        public string ubicacion { set; get; }
        public string unidadMedida { set; get; }
        public int estado { set; get; }
    }
}

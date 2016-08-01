using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
   public class ProductoCategoriaUnidadMedidaDTO
    {
        public int idProducto { set; get; }
        public string CodigoAvatar { set; get; }
        public string NombreProducto { set; get; }
        public string Descripcion { set; get; }
        public string Categoria { set; get; }
        public string Ubicacion { set; get; }
        public string UnidadMedida { set; get; }
        public string presentacion { set; get; }
    }
}

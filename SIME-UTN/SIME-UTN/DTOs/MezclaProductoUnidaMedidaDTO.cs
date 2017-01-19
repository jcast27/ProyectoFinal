﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.DTOs
{
  public class MezclaProductoUnidaMedidaDTO
    {
        public int idMezcla { set; get; }
        public string nombreMezcla { set; get; }
        public int idProducto { set; get; }
        public string nombreProducto { set; get; }
        public int idUnidadMedida { set; get; }
        public string nombreUnidadMedida { set; get; }
        public double cantidad { set; get; }
        public int estadoMezcla { set; get; }
        public int estadoProducto { set; get; }

        public MezclaProductoUnidaMedidaDTO() { }
    }
}

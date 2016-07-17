using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;

namespace SIME_UTN.Entities
{
   public class TrasladoProducto
    {
        public int idTraslado { set; get; }
        public RegistroBodega BodegaOrigen { set; get; }
        public RegistroBodega BodegaDestino { set; get; }
        public UsuarioTable Usuario { set; get; }
        public string observaciones { set; get; }
        public string fechaTraslado { set; get; }
        public TipoTraslado TipoTraslado { set; get; }
        public EstadoTraslado EstadoTraslado { set; get; }
        public int estado { set; get; }

        public TrasladoProducto() { }

    }
}

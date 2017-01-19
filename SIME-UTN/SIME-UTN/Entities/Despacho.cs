using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    public class Despacho
    {
        public int idDespacho { set; get; }
        public int idBodega { set; get; }
        public int idUsuario { set; get; }
        public int idFuncionario { set; get; }
        public int idUbicacion { set; get; }
        public string descripcion { set; get; }
        public DateTime fechaDespacho { set; get; }
        public int estado { set; get; }

        public Despacho() { }
    }
}

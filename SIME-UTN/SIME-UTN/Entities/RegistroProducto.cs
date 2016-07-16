using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Entities
{
    public class RegistroProducto
    {

        public int idIngresoProducto { set; get; }
        public UsuarioTable Usuario { set; get; }
        //public UsuarioDB idUsuario { set; get; }
        public string descripcion { set; get; }
        public string solicitudAvatar { set; get; }
        public string fechaIngreso { set; get; }
        public string fechaCaducidad { set; get; }
        public int estado { set; get; }

        public RegistroProducto() { }
    }
}

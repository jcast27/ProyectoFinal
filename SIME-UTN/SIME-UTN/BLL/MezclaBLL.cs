using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class MezclaBLL
    {
        public static void agregarMezcla(int idBodega, Producto mezcla, int contenido)
        {
            MezclaDAL.agregarMezcla(idBodega, mezcla, contenido);
        }

        public static void removerComponentes(int idBodega, int idProducto, int contenido, int unidades)
        {
            MezclaDAL.removerComponentes(idBodega, idProducto, contenido, unidades);
        }
    }
}

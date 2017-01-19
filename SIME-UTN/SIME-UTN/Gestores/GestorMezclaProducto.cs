using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorMezclaProducto
    {
        public static MezclaProducto mezclaProducto;
        public static GestorMezclaProducto instancia;

        public GestorMezclaProducto()
        {
            mezclaProducto = new MezclaProducto();
        }

        public static GestorMezclaProducto GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorMezclaProducto();
            }

            return instancia;
        }

        internal void GuardarMezclaProducto(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTO, string usuarioLogueado)
        {
            BLL.MezclaProductoBLL.ModificarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);
        }

        internal List<ProductoDTO> ObtenerProductosPorIdMezcla(int idRegistroMezclap)
        {
            return BLL.MezclaProductoBLL.ObtenerProductosPorIdMezcla(idRegistroMezclap);
        }

        internal void EliminarProductoDeMezcla(Producto unProductop,int idMezclap,string usuarioLogueadop)
        {
            BLL.MezclaProductoBLL.EliminarProductoDeMezcla(unProductop,idMezclap,usuarioLogueadop);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.DAL;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;

namespace SIME_UTN.BLL
{
    class MezclaProductoBLL
    {
        internal static void GuardarMezclaProducto(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTO, string usuarioLogueado)
        {

                DAL.MezclaProductoDAL.GuardarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);

        }

        internal static List<ProductoDTO> ObtenerProductosPorIdMezcla(int idRegistroMezclap)
        {
            return DAL.MezclaProductoDAL.ObtenerProductosPorIdMezcla(idRegistroMezclap);
        }

        internal static void EliminarProductoDeMezcla(Producto unProductop,int idMezclap,string usuarioLogueadop)
        {
            DAL.MezclaProductoDAL.EliminarProductoDeMezcla(unProductop,idMezclap,usuarioLogueadop);
        }

        internal static void ModificarMezclaProducto(MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTO, string usuarioLogueado)
        {
            if(DAL.MezclaProductoDAL.ObtenerMezclaProductoByID(unaMezclaProductoUnidadDTO.idMezcla, unaMezclaProductoUnidadDTO.idProducto) == true)
            {
                DAL.MezclaProductoDAL.ActualizarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);
            }else
            {
                DAL.MezclaProductoDAL.GuardarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);
            }
           
        }
    }
}

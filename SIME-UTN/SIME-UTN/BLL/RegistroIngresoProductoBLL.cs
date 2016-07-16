using SIME_UTN.DAL;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class RegistroIngresoProductoBLL
    {
        internal static void GuardarIngresoProducto(RegistroIngresoProductoDTO unIngProdDTO, string usuarioLogueado)
        {

            RegistroIngresoProductoDAL.GuardarIngresoProducto(unIngProdDTO, usuarioLogueado);

        }

        internal static List<RegistroIngresoProductoDTO> ObtenerProductosPorIdRegistro(int idRegIngrProd)
        {
            return RegistroIngresoProductoDAL.ObtenerProductosPorIdRegistro(idRegIngrProd);
        }

        internal static void EliminarIngresoDeProducto(Producto unProductop, int idIngProd, string usuarioLogueadop)
        {
            RegistroIngresoProductoDAL.EliminarIngresoDeProducto(unProductop, idIngProd, usuarioLogueadop);
        }

        internal static void ModificarIngresoProducto(RegistroIngresoProductoDTO unIngProd, string usuarioLogueado)
        {
            if (RegistroIngresoProductoDAL.ObtenerIngresoProductoByID(unIngProd.idIngreso, unIngProd.idProducto) == true)
            {
                RegistroIngresoProductoDAL.ActualizarIngresoProducto(unIngProd, usuarioLogueado);
            }
            else
            {
                RegistroIngresoProductoDAL.GuardarIngresoProducto(unIngProd, usuarioLogueado);
            }

        }
    }
}

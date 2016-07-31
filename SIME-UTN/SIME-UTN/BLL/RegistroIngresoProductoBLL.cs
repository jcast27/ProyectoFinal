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


        internal static List<RegistroIngresoProductoDTO> ObtenerProductosPorIdRegistro(int idRegIngrProd)
        {
            return RegistroIngresoProductoDAL.ObtenerProductosPorIdRegistro(idRegIngrProd);
        }

        internal static void EliminarIngresoDeProducto(int idRegistroBodegap,Producto unProductop, int idIngProd, string usuarioLogueadop)
        {
            List<RegistroIngresoProductoDTO> listregistriIngresoProducto = new List<RegistroIngresoProductoDTO>();
            listregistriIngresoProducto = RegistroIngresoProductoDAL.ObtenerProductosPorIdRegistro(idIngProd);

            RegistroIngresoProductoDAL.EliminarIngresoDeProducto(idRegistroBodegap,unProductop, idIngProd, usuarioLogueadop);

            RegistroIngresoProductoDAL.DescargarInvetarioRegistroProductoEliminado(idRegistroBodegap, listregistriIngresoProducto);
        }

        internal static void ModificarIngresoProducto(RegistroIngresoProductoDTO unIngProd, string usuarioLogueado)
        {
            string accion = "";
            double cantidad = 0;
            if (RegistroIngresoProductoDAL.ObtenerIngresoProductoByID(unIngProd.idIngreso, unIngProd.idProducto) == true)
            {
                accion = "Modificar";
                cantidad = RegistroIngresoProductoDAL.ActualizarIngresoProducto(unIngProd, usuarioLogueado);
                RegistroIngresoProductoDAL.ActualizarInventarioCantidad(unIngProd.idBodega, unIngProd.idProducto, cantidad, unIngProd.uCantidad, accion);
            }
            else
            {
               
                accion = "Insertar";
                cantidad =RegistroIngresoProductoDAL.GuardarIngresoProducto(unIngProd, usuarioLogueado);
                RegistroIngresoProductoDAL.ActualizarInventarioCantidad(unIngProd.idBodega, unIngProd.idProducto, cantidad, 0, accion);
            }

        }
    }
}

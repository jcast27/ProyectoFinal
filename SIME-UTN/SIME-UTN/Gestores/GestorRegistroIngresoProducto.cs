﻿using SIME_UTN.BLL;
using SIME_UTN.DTOs;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Gestores
{
    class GestorRegistroIngresoProducto
    {
        public static RegistroIngresoProducto ingresoProducto;
        public static GestorRegistroIngresoProducto instancia;

        public GestorRegistroIngresoProducto()
        {
            ingresoProducto = new RegistroIngresoProducto();
        }

        public static GestorRegistroIngresoProducto GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorRegistroIngresoProducto();
            }

            return instancia;
        }

        internal void GuardarIngresoProducto(RegistroIngresoProductoDTO unIngProdDTO, string usuarioLogueado)
        {
            RegistroIngresoProductoBLL.GuardarIngresoProducto(unIngProdDTO, usuarioLogueado);
        }

        internal List<RegistroIngresoProductoDTO> ObtenerProductosPorIdRegistro(int idRegIngProd)
        {
            return RegistroIngresoProductoBLL.ObtenerProductosPorIdRegistro(idRegIngProd);
        }

        internal void EliminarIngresoDeProducto(Producto unProductop, int idIngProd, string usuarioLogueadop)
        {
            RegistroIngresoProductoBLL.EliminarIngresoDeProducto(unProductop, idIngProd, usuarioLogueadop);
        }

        internal void ModificarIngresoProducto(RegistroIngresoProductoDTO unIngProd, string usuarioLogueado)
        {
            RegistroIngresoProductoBLL.ModificarIngresoProducto(unIngProd, usuarioLogueado);
        }

    }
}
﻿using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class RegistroProductoBLL
    {
        internal static int GuardarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            return RegistroProductoDAL.GuardarRegistroProducto(unRegProd, usuarioLogueadop);
        }

        internal static void ActualizarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            RegistroProductoDAL.ActualizarRegistroProducto(unRegProd, usuarioLogueadop);
        }

        internal static void EliminarRegistroProducto(int idRegProd, string nombrep, string usuarioLogueadop)
        {
            RegistroProductoDAL.EliminarRegistroProducto(idRegProd, nombrep, usuarioLogueadop);
        }

    }
}

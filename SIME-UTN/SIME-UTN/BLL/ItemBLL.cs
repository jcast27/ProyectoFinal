﻿using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class ItemBLL
    {

        public static List<Item> ObtenerItems()
        {
            return ItemDAL.ObtenerItems();
        }

        internal static void GuardarItem(Item Itemp)
        {
            if (ItemDAL.ObtenerItemID(Itemp.idItem) == null)
            {
                ItemDAL.GuardarItem(Itemp);
            }
            else
            {
                ItemDAL.ActualizarItem(Itemp);
            }
        }


        internal static Item ObtenerItemID(int ItemIdp)
        {
            return ItemDAL.ObtenerItemID(ItemIdp);
        }

        internal static Item ObtenerItemDescripcion(string descripcion)
        {
            return ItemDAL.ObtenerItemporNombre(descripcion);
        }

        internal static void EliminarItem(string ItemIdp, string accion)
        {
            ItemDAL.EliminarItem(ItemIdp, accion);
        }
    }
}

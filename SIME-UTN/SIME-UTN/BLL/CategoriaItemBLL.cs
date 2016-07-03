using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class CategoriaItemBLL
    {
        internal static void GuardarCategoriaItem(CategoriaItem CategoriaItemp)
        {
            CategoriaItemDAL.GuardarCategoriaItem(CategoriaItemp);
        }


        internal static List<CategoriaItem> ObtenerCategoriaItemID(int CategoriaItemIdp)
        {
            return CategoriaItemDAL.ObtenerCategoriaItemID(CategoriaItemIdp);
        }

        internal static void EliminarCategoriaItem(string CategoriaItemIdp)
        {
            CategoriaItemDAL.EliminarCategoriaItem(CategoriaItemIdp);
        }

    }
}

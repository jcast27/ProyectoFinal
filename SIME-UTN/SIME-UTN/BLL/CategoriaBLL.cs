using SIME_UTN.DAL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.BLL
{
    class CategoriaBLL
    {
        public static List<Categoria> ObtenerCategorias()
        {
            return CategoriaDAL.ObtenerCategorias();
        }

        internal static void GuardarCategoria(Categoria Categoriap)
        {
            if (CategoriaDAL.ObtenerCategoriaID(Categoriap.idCategoria) == null)
            {
                CategoriaDAL.GuardarCategoria(Categoriap);
            }
            else
            {
                CategoriaDAL.ActualizarCategoria(Categoriap);
            }
        }


        internal static Categoria ObtenerCategoriaID(int CategoriaIdp)
        {
            return CategoriaDAL.ObtenerCategoriaID(CategoriaIdp);
        }

        internal static Categoria ObtenerCategoriaDescripcion(string descripcion)
        {
            return CategoriaDAL.ObtenerCategoriaporNombre(descripcion);
        }

        internal static void DesactivarCategoria(string CategoriaIdp, string accion)
        {
            CategoriaDAL.DesactivarCategoria(CategoriaIdp, accion);
        }

    }
}

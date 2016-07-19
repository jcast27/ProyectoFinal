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
        public static List<Categoria> ObtenerCategorias(string pertenece)
        {
            return CategoriaDAL.ObtenerCategorias(pertenece);
        }

        internal static int GuardarCategoria(Categoria Categoriap, string user)
        {
            int id = 0;
            if (CategoriaDAL.ObtenerCategoriaID(Categoriap.idCategoria) == null)
            {
                id = CategoriaDAL.GuardarCategoria(Categoriap, user);
            }
            else
            {
                CategoriaDAL.ActualizarCategoria(Categoriap, user);
            }
            return id;
        }


        internal static Categoria ObtenerCategoriaID(int CategoriaIdp)
        {
            return CategoriaDAL.ObtenerCategoriaID(CategoriaIdp);
        }

        internal static Categoria ObtenerCategoriaDescripcion(string descripcion)
        {
            return CategoriaDAL.ObtenerCategoriaporNombre(descripcion);
        }

        internal static void DesactivarCategoria(string CategoriaIdp, string accion, string user)
        {
            CategoriaDAL.DesactivarCategoria(CategoriaIdp, accion, user);
        }

    }
}

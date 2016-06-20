using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIME_UTN.Entities;
using SIME_UTN.Factories;
using SIME_UTN.BLL;
using System.Windows.Forms;

namespace SIME_UTN.Gestores
{
    sealed class GestorCategoria
    {
    public static Categoria categoria;
    public static string NombreCategoria;
    public static GestorCategoria instancia;

        public GestorCategoria()
        {
            categoria = new Categoria();
        }
        public static GestorCategoria GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorCategoria();
            }

            return instancia;
        }

        public List<Categoria> ObtenerCategorias(string pertenece)
        {
            return CategoriaBLL.ObtenerCategorias(pertenece);
        }

        public Categoria ObtenerCategoriaDescripcion(string descripcion)
        {
            return CategoriaBLL.ObtenerCategoriaDescripcion(descripcion);
        }

        public void AgregarCategoria(Categoria categoriap)
        {
            categoria = categoriap;
        }

        public Categoria ObtenerCategoria()
        {
            return categoria;
        }

        public int GuardarCategoria()
        {
            return CategoriaBLL.GuardarCategoria(categoria);
        }

        public Categoria ObtenerCategoriaId(int categoriaIdp)
        {
            return CategoriaBLL.ObtenerCategoriaID(categoriaIdp);
        }

        public void DesactivarCategoria(string categoriaIdp, string accion)
        {
            CategoriaBLL.DesactivarCategoria(categoriaIdp, accion);
        }

    }
}

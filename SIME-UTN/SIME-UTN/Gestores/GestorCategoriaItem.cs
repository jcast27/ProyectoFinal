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
    sealed class GestorCategoriaItem
    {
    public static CategoriaItem CI;
    public static string NombreCategoria;
    public static GestorCategoriaItem instancia;

        public GestorCategoriaItem()
        {
            CI = new CategoriaItem();
        }
        public static GestorCategoriaItem GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorCategoriaItem();
            }

            return instancia;
        }

        public void AgregarCategoriaItem(CategoriaItem categoriap)
        {
            CI = categoriap;
        }

        public CategoriaItem ObtenerCategoriaItem()
        {
            return CI;
        }

        public void GuardarCategoriaItem()
        {
            CategoriaItemBLL.GuardarCategoriaItem(CI);
        }

        public List<CategoriaItem> ObtenerCategoriaItemId(int categoriaIdp)
        {
            return CategoriaItemBLL.ObtenerCategoriaItemID(categoriaIdp);
        }

        public void EliminarCategoriaItem(string categoriaIdp)
        {
            CategoriaItemBLL.EliminarCategoriaItem(categoriaIdp);
        }

    }
}

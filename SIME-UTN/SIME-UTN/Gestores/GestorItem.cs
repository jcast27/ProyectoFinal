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
    sealed class GestorItem
    {
    public static Item item;
    public static string NombreItem;
    public static GestorItem instancia;

        public GestorItem()
        {
            item = new Item();
        }
        public static GestorItem GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorItem();
            }

            return instancia;
        }

        public List<Item> ObtenerItems()
        {
            return ItemBLL.ObtenerItems();
        }

        public Item ObtenerItemDescripcion(string descripcion)
        {
            return ItemBLL.ObtenerItemDescripcion(descripcion);
        }

        public void AgregarItem(Item Itemp)
        {
            item = Itemp;
        }

        public Item ObtenerItem()
        {
            return item;
        }

        public void GuardarItem(string user)
        {
            ItemBLL.GuardarItem(item, user);
        }

        public Item ObtenerItemId(int ItemIdp)
        {
            return ItemBLL.ObtenerItemID(ItemIdp);
        }

        public void EliminarItem(string ItemIdp, string accion, string user)
        {
            ItemBLL.EliminarItem(ItemIdp, accion, user);
        }

    }
}

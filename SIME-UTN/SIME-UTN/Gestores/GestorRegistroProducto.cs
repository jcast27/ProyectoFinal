using SIME_UTN.BLL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Gestores
{
    class GestorRegistroProducto
    {
        public static RegistroProducto regProd;
        public static GestorRegistroProducto instancia;

        public GestorRegistroProducto()
        {
            regProd = new RegistroProducto();
        }

        public static GestorRegistroProducto GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorRegistroProducto();
            }

            return instancia;
        }

        internal int GuardarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            return RegistroProductoBLL.GuardarRegistroProducto(unRegProd, usuarioLogueadop);
        }

        internal void ActualizarRegistroProducto(RegistroProducto unRegProd, string usuarioLogueadop)
        {
            RegistroProductoBLL.ActualizarRegistroProducto(unRegProd, usuarioLogueadop);
        }

        internal void EliminarRegistroProducto(int idRegProdp, string nombrep, string usuarioLogueadop)
        {
            RegistroProductoBLL.EliminarRegistroProducto(idRegProdp, nombrep, usuarioLogueadop);
        }
    }
}

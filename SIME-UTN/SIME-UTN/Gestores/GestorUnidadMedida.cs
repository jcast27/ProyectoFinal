using SIME_UTN.BLL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Gestores
{
    class GestorUnidadMedida
    {
        public static UnidadMedida unidad;
        public static string descripcionMedida;
        public static GestorUnidadMedida instancia;

        public GestorUnidadMedida()
        {
            unidad = new UnidadMedida();
        }

        public static GestorUnidadMedida GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorUnidadMedida();
            }

            return instancia;
        }

        internal List<UnidadMedida> ObtenerUnidades()
        {
            return UnidadMedidaBLL.ObtenerUnidades();
        }
        public void AgregarUnidad(UnidadMedida unidadp)
        {
            unidad = unidadp;
        }

        internal void GuardarUnidad(UnidadMedida unaUnidadp, string usuarioLogueadop)
        {
            UnidadMedidaBLL.GuardarUnidad(unaUnidadp, usuarioLogueadop);
        }

        internal void EliminarUnidad(int unidadId, string unidadp, string usuarioLoguadop)
        {
            UnidadMedidaBLL.EliminarUnidad(unidadId, unidadp, usuarioLoguadop);
        }
    }
}

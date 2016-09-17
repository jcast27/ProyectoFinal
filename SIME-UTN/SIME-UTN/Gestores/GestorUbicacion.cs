using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{
    class GestorUbicacion
    {
        public static Ubicacion ubicacion;
        public static GestorUbicacion instancia;

        public GestorUbicacion()
        {
            ubicacion = new Ubicacion();
        }

        public static GestorUbicacion GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorUbicacion();
            }

            return instancia;
        }

        internal void EliminarUbicacion(int idUbicacionp, string nombrep, string usuarioLogueadop)
        {
            BLL.UbicacionBLL.EliminarUbicacion(idUbicacionp,nombrep,usuarioLogueadop);
        }

        internal void AgregarUbicacion(Ubicacion unaUbicacionp)
        {
            ubicacion = unaUbicacionp;
        }

        internal void GuardarUbicacion(Ubicacion unaUbicacionp, string usuarioLogueadop)
        {
            BLL.UbicacionBLL.GuardarUbicacion(unaUbicacionp,usuarioLogueadop);
        }

        internal List<Ubicacion> ObtenerUbicacion()
        {
            return BLL.UbicacionBLL.ObtenerUbicacion();
        }
    }
}

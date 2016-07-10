using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using SIME_UTN.BLL;

namespace SIME_UTN.Gestores
{

    class GestorMezcla
    {
        public static Mezcla mezcla;
        public static GestorMezcla instancia;

        public GestorMezcla()
        {
            mezcla = new Mezcla();
        }

        public static GestorMezcla GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorMezcla();
            }

            return instancia;
        }

        internal int GuardarRegistroMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            return BLL.RegistroMezclaBLL.GuardarRegistroMezcla(unaMezclap, usuarioLogueadop);
        }

        internal void ActualizarMezcla(Mezcla unaMezclap, string usuarioLogueadop)
        {
            BLL.RegistroMezclaBLL.ActualizarMezcla(unaMezclap,usuarioLogueadop);
        }

        internal void EliminarMezcla(int idRegistroMezclap, string nombrep, string usuarioLogueadop)
        {
            BLL.RegistroMezclaBLL.EliminarMezcla(idRegistroMezclap,nombrep,usuarioLogueadop);
        }
    }
}

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
    sealed class GestorActivo
    {
    public static Activo Activo;
    public static string NombreActivo;
    public static GestorActivo instancia;

        public GestorActivo()
        {
            Activo = new Activo();
        }
        public static GestorActivo GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorActivo();
            }

            return instancia;
        }

        public List<Activo> ObtenerActivos()
        {
            return ActivoBLL.ObtenerActivos();
        }

        public void AgregarActivo(Activo Activop)
        {
            Activo = Activop;
        }

        public Activo ObtenerActivo()
        {
            return Activo;
        }

        public void GuardarActivo()
        {
            ActivoBLL.GuardarActivo(Activo);
        }

        public Activo ObtenerActivoId(int ActivoIdp)
        {
            return ActivoBLL.ObtenerActivoID(ActivoIdp);
        }

        public void DesactivarActivo(string ActivoIdp, string accion)
        {
            ActivoBLL.DesactivarActivo(ActivoIdp, accion);
        }

    }
}

using SIME_UTN.BLL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Gestores
{
    class GestorFormulario
    {

        public static Formulario Formulario;
        public static string NombreFormulario;
        public static GestorFormulario instancia;

        public GestorFormulario()
        {
            Formulario = new Formulario();
        }
        public static GestorFormulario GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorFormulario();
            }

            return instancia;
        }

        public void AgregarFormulario(Formulario Formulariop)
        {
            Formulario = Formulariop;
        }

        public Formulario ObtenerFormulario()
        {
            return Formulario;
        }

        public int GuardarFormulario()
        {
            return FormularioBLL.GuardarFormulario(Formulario);
        }

        public Formulario ObtenerFormularioId(int FormularioIdp)
        {
            return FormularioBLL.ObtenerFormularioID(FormularioIdp);
        }

        public List<Formulario> ObtenerFormularios()
        {
            return FormularioBLL.ObtenerFormularios();
        }

    }
}

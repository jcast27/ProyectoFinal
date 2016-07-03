using SIME_UTN.BLL;
using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIME_UTN.Gestores
{
    class GestorDetalleFormulario
    {

        public static DetalleFormulario DetalleFormulario;
        public static string NombreDetalleFormulario;
        public static GestorDetalleFormulario instancia;

        public GestorDetalleFormulario()
        {
            DetalleFormulario = new DetalleFormulario();
        }
        public static GestorDetalleFormulario GetInstance()
        {
            if (instancia == null)
            {
                instancia = new GestorDetalleFormulario();
            }

            return instancia;
        }

        public void AgregarDetalleFormulario(DetalleFormulario DetalleFormulariop)
        {
            DetalleFormulario = DetalleFormulariop;
        }

        public DetalleFormulario ObtenerDetalleFormulario()
        {
            return DetalleFormulario;
        }

        public void GuardarDetalleFormulario()
        {
            DetalleFormularioBLL.GuardarDF(DetalleFormulario);
        }

        public List<DetalleFormulario> ObtenerDetalleFormularioId(int DetalleFormularioIdp)
        {
            return DetalleFormularioBLL.ObtenerDFID(DetalleFormularioIdp);
        }
    }
}

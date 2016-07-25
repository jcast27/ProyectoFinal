using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIME_UTN.UI.Reportes
{
    public partial class frmReporte : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DateTime fecha;
        public frmReporte(string nombre, string user)
        {
            InitializeComponent();
            cargarReporte(nombre, user);
        }

        public void cargarReporte(string nombre, string user)
        {

            XtraReport reporte = new XtraReport();

            switch (nombre)
            {
                case ("btnActivo"):
                    reporte = new rptActivo(user);
                    break;
                case ("btnFormulario"):
                    reporte = new rptFormulario(user);
                    break;
                case ("btnFormularioFecha"):
                    //reporte = new rptFormularioFecha(user, fecha);
                    break;
                default:
                    break;
            }

            documentViewer.DocumentSource = reporte;
        }
    }
}

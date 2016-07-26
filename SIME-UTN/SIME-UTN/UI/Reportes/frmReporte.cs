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
                    reporte = new rptFormularioFecha(user);
                    break;
                case ("btnItem"):
                    reporte = new rptFormularioFecha(user);
                    break;
                case ("btnBodega"):
                    reporte = new rptBodega(user);
                    break;
                case ("btnBodegaN"):
                    reporte = new rptBodegaNumero(user);
                    break;
                case ("btnTraslado"):
                    reporte = new rptTraslado(user);
                    break;
                case ("btnTrasladoFecha"):
                    reporte = new rptTrasladoFecha(user);
                    break;
                case ("btnTrasladoUser"):
                    reporte = new rptTrasladoUser(user);
                    break;
                default:
                    break;
            }

            documentViewer.DocumentSource = reporte;
        }
    }
}

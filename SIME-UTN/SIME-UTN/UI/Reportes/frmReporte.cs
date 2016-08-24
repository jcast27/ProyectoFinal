﻿using DevExpress.XtraReports.UI;
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
        public frmReporte(string nombre, string user, int id)
        {
            InitializeComponent();
            cargarReporte(nombre, user, id);
        }

        public void cargarReporte(string nombre, string user, int id)
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
                    reporte = new rptItem(user);
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
                case ("btnMinimo"):
                    reporte = new rptMinimo(user);
                    break;
                case ("imprimir"):
                    reporte = new rptImprimirForm(user);
                    reporte.Parameters["Id"].Value = id;
                    break;
                default:
                    break;
            }

            documentViewer.DocumentSource = reporte;
        }


        private void printPreviewRibbonPageGroup8_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            this.Close();
        }

    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using SIME_UTN.Gestores;
using SIME_UTN.Entities;
using SIME_UTN.DTOs;
using System.Collections.Generic;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptCostos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCostos(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }


        private void rptCostos_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            e.ParametersInformation[0].Parameter.Value = DateTime.Now;
            e.ParametersInformation[1].Parameter.Value = DateTime.Now;

            List<RegistroProducto> listRP = new List<RegistroProducto>();
            List<int> ids = new List<int>();
            GestorRegistroProducto gRP = new GestorRegistroProducto();
            listRP = gRP.ObtenerIngresos();
            foreach (RegistroProducto RP in listRP)
            {
                ids.Add(RP.idIngresoProducto);
            }
            e.ParametersInformation[2].Parameter.Value = ids;
        }
    }
}

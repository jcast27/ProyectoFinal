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
    public partial class rptTrasladoFecha : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTrasladoFecha(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void rptTraslado_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            e.ParametersInformation[0].Parameter.Value = DateTime.Now;
            e.ParametersInformation[1].Parameter.Value = DateTime.Now;

            List<RegistroBodegaTipoBodegaDTO> listaBodega = new List<RegistroBodegaTipoBodegaDTO>();
            List<int> idsBodega = new List<int>();
            GestorRegistroBodega gRB = new GestorRegistroBodega();
            listaBodega = gRB.ObtenertBodegas();
            foreach (RegistroBodegaTipoBodegaDTO b in listaBodega)
            {
                idsBodega.Add(b.idregistrobodega);
            }
            e.ParametersInformation[2].Parameter.Value = idsBodega;
        }
    }
}

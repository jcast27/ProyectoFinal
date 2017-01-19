using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptFormulario : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFormulario(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void rptFormulario_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {

            e.ParametersInformation[0].Parameter.Value = DateTime.Now;
            e.ParametersInformation[1].Parameter.Value = DateTime.Now;
        }
    }
}

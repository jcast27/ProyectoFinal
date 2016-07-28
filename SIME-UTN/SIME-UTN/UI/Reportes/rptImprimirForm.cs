using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptImprimirForm : DevExpress.XtraReports.UI.XtraReport
    {
        public rptImprimirForm(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

    }
}

﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace SIME_UTN.UI.Reportes
{
    public partial class rptTrasladoUser : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTrasladoUser(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIME_UTN.UI
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            // Cambiar color
            this.pBSplashScreen.ForeColor = Color.Aqua;
            // Incrementar el progressbar en 1
            this.pBSplashScreen.Increment(1);
            if (this.pBSplashScreen.Value == 100)
                this.timer.Stop();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void frmSplashScreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}

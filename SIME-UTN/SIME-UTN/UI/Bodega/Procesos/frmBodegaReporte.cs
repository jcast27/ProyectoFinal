using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIME_UTN.Entities;
using SIME_UTN.Gestores;
using Microsoft.VisualBasic;
using SIME_UTN.UI.Reportes;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmBodegaReporte : Form
    {
        private string user = "";

        public frmBodegaReporte(string userp)
        {
            InitializeComponent();
            user = userp;
        }

        private void frmFormReporte_Load(object sender, EventArgs e)
        {
            Location = new Point(150, 176);
            Height = Owner.Height - 176;
            Width = Owner.Width - 300;
            Icon = Properties.Resources.Icono;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmReporte frm = new frmReporte(btn.Name, user, 0);
            frm.ShowDialog(this);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
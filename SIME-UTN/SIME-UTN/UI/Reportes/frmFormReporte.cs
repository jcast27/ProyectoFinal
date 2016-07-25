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

namespace SIME_UTN.UI.Reportes
{
    public partial class frmFormReporte : Form
    {
        private string user = "";

        public frmFormReporte(string userp)
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
            if (btn.Name.Contains("Fecha"))
            {
                Interaction.InputBox("Ingresar fecha de Inicio", "Fecha", "");
            }

            frmReporte frm = new frmReporte(btn.Name, user);
            frm.ShowDialog(this);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

//string x = MousePosition.X.ToString();
//string y = MousePosition.Y.ToString();
//MessageBox.Show("X: " + x + "\nY: " + y);
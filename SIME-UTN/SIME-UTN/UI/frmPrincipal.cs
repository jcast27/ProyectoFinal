using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIME_UTN.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void usuariosTSMI_Click(object sender, EventArgs e)
        {
            frmUsuarios ofrmUsuario = new frmUsuarios();
            ofrmUsuario.MdiParent = this;
            ofrmUsuario.Show();
        }

 
    }
}

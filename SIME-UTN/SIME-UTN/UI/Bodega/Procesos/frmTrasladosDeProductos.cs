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

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmTrasladosDeProductos : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        static string nombre = "";
        public frmTrasladosDeProductos()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

    

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdTrasladoProductos ofrmAdTrasladoProducto = new frmAdTrasladoProductos();
            ofrmAdTrasladoProducto.ShowDialog(this);
          
        }

        private void frmTrasladosDeProductos_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }
    }
}
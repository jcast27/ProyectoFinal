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
    public partial class frmDespachoProducto : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestor = null;
        public frmDespachoProducto()
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
            frmAdDespachoProductos ofrmAdDespachoProducto = new frmAdDespachoProductos();
            ofrmAdDespachoProducto.ShowDialog(this);
          
        }

        private void frmDespachoProducto_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetTipoBodegaDespacho.sp_SELECT_TipoBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_TipoBodega_AllTableAdapter.Fill(this.dataSetTipoBodegaDespacho.sp_SELECT_TipoBodega_All);
            // TODO: This line of code loads data into the 'dataSetBodegaDespacho.sp_SELECT_RegistroBodega_By_Type' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_By_TypeTableAdapter.Fill(this.dataSetBodegaDespacho.sp_SELECT_RegistroBodega_By_Type);

        }
    }
}
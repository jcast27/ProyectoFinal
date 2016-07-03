using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdUnidadMedida : DevExpress.XtraEditors.XtraForm
    {
        public frmAdUnidadMedida()
        {
            InitializeComponent();
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void frmAdBodega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTBodega.TipoBodega' table. You can move, or remove it, as needed.
            this.tipoBodegaTableAdapter.Fill(this.dataSetTBodega.TipoBodega);

        }
    }
}
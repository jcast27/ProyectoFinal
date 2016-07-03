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

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmBodegas : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestorUsuario = null;
        GestorRegistroBodega gestorBodega = null;
        static RegistroBodega bodegaEstatico = null;
        TipoBodega unTipoBodega = null;
       
        public frmBodegas()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }


        /// <summary>
        /// Metodo que llama al formulario AdBodega para guardar una nueva bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdBodega ofrmAdBodega = new frmAdBodega();
            ofrmAdBodega.ShowDialog(this);
            frmBodegas_Load(null, null);
        }


        /// <summary>
        /// Metodo que llama al formulario AdBodega para modificar una bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdBodega ofrmAdBodega = new frmAdBodega(bodegaEstatico);
            ofrmAdBodega.ShowDialog(this);
            frmBodegas_Load(null, null);
        }

        private void frmBodegas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTipoBodega.sp_SELECT_TipoBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_TipoBodega_AllTableAdapter.Fill(this.dataSetTipoBodega.sp_SELECT_TipoBodega_All);
            // TODO: This line of code loads data into the 'dataSetRegistroBodega.sp_SELECT_RegistroBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_AllTableAdapter.Fill(this.dataSetRegistroBodega.sp_SELECT_RegistroBodega_All);
            gestorBodega = GestorRegistroBodega.GetInstance();
            bodegaEstatico = new RegistroBodega();
            UsuarioLogueado();
        }


        /// <summary>
        /// Metodo que permite extrae la bodega seleccionada del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCBodegas_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                unTipoBodega = new TipoBodega();
                System.Data.DataRowView row = null;
                bodegaEstatico.idRegistroBodega = int.Parse(gridView1.GetFocusedRowCellValue("idregistrobodega").ToString());
                bodegaEstatico.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();
                bodegaEstatico.descripcion = gridView1.GetFocusedRowCellValue("descripcion").ToString();
                unTipoBodega.idTipoBodega = int.Parse(gridView1.GetFocusedRowCellValue("tipo").ToString());
                row = LookUpTipoBodega.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("tipo").ToString())) as DataRowView;
                unTipoBodega.descripcion = row.Row["descripcion"].ToString();
                bodegaEstatico.TipoBodega = unTipoBodega;

            }
            catch (ApplicationException app)
            {
                MessageBox.Show(app.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Metodo que desactiva una bodega
        /// </summary>
        public void DesactivarBodega()
        {
            string bodega = gridView1.GetFocusedRowCellValue("nombre").ToString(); ;
            int idBodega = Int32.Parse(gridView1.GetFocusedRowCellValue("idregistrobodega").ToString());

            if (MessageBox.Show("¿Seguro que desea eliminar la bodega: " + bodega + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorBodega.EliminarBodega(idBodega, bodega, usuarioLogueado);
                MessageBox.Show("La Bodega: " + bodega + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmBodegas_Load(null, null);

            }
        }


        /// <summary>
        /// Invoca al metodo eliminar bodega, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarBodega();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoca al metodo desactivar la bodega, al seleccionar un row del grid y pulsar el boton eliminar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarBodega();
        }

     
    }
}
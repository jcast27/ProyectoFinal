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
    public partial class frmDepartamentos : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestorUsuario = null;
        //GestorRegistroBodega gestorBodega = null;
        // static RegistroBodega bodegaEstatico = null;
        // TipoBodega unTipoBodega = null;
        GestorDepartamento gestorDepto = null;
        Departamento deptoEstatico = null;
        static string nombre = "";

        public frmDepartamentos()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }


        /// <summary>
        /// Metodo que llama al formulario AdDepartamento para guardar una nueva Departamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdDepartamento ofrAdDepartamento = new frmAdDepartamento();
            ofrAdDepartamento.ShowDialog(this);
            frmDepartamentos_Load(null, null);
        }


        /// <summary>
        /// Metodo que llama al formulario AdDepartamento para modificar una Departamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdDepartamento ofrAdDepartamento = new frmAdDepartamento(deptoEstatico);
            ofrAdDepartamento.ShowDialog(this);
            frmDepartamentos_Load(null, null);

        }




        /// <summary>
        /// Metodo que permite extrae un Departamento seleccionado del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                deptoEstatico.idDepartamento = int.Parse(gridView1.GetFocusedRowCellValue("iddepartamento").ToString());
                deptoEstatico.descripcion = gridView1.GetFocusedRowCellValue("descripcion").ToString();

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
        /// Metodo que desactiva un Departamento
        /// </summary>
        public void DesactivarDepartamento()
        {
            string depto = gridView1.GetFocusedRowCellValue("descripcion").ToString(); ;
            int deptoId = Int32.Parse(gridView1.GetFocusedRowCellValue("iddepartamento").ToString());

            if (MessageBox.Show("¿Seguro que desea eliminar al departamento " + depto + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorDepto.EliminarDepartamento(deptoId, depto, usuarioLogueado);
                MessageBox.Show("El Departamento " + depto + " fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDepartamentos_Load(null, null);

            }
        }


        /// <summary>
        /// Invoca al metodo eliminar Departamento, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarDepartamento();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoca al metodo desactivar un Departamento, al seleccionar un row del grid y pulsar el boton eliminar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarDepartamento();
        }


        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRDepartamento.sp_SELECT_Departamento_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Departamento_AllTableAdapter.Fill(this.dataSetRDepartamento.sp_SELECT_Departamento_All);
            UsuarioLogueado();
            gestorDepto = GestorDepartamento.GetInstance();
            deptoEstatico = new Departamento();
        }
    }
}
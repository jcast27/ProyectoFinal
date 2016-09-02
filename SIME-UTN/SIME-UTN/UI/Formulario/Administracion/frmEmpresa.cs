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

namespace SIME_UTN.UI.Formulario.Administracion
{
    public partial class frmEmpresa : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestorUsuario = null;
        static Empresa empresaEstatica = null;
        Empresa unaEmpresa = null;
        GestorEmpresa gestorEmpresa = null;
       
        public frmEmpresa()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }


        /// <summary>
        /// Metodo que llama al formulario AdUbicacion para guardar una nueva Ubicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdEmpresas ofrAdUbicaciones = new frmAdEmpresas();
            ofrAdUbicaciones.ShowDialog(this);
            frmEmpresa_Load(null, null);

        }


        /// <summary>
        /// Metodo que llama al formulario AdUbicacion para modificar una Ubicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdEmpresas ofrAdEmpresa= new frmAdEmpresas(empresaEstatica);
            ofrAdEmpresa.ShowDialog(this);
            frmEmpresa_Load(null, null);

        }




        /// <summary>
        /// Metodo que permite extrae la Ubicacion seleccionada del grid y colocar la Información en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCUbicaciones_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = false;
                mBtnEliminar.Enabled = false;
                empresaEstatica.idEmpresa = int.Parse(gridView1.GetFocusedRowCellValue("idempresa").ToString());
                if (empresaEstatica.idEmpresa != 0)
                {
                    mBtnModificar.Enabled = true;
                    mBtnEliminar.Enabled = true;
                    empresaEstatica.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();
                    empresaEstatica.cedulaJuridica = gridView1.GetFocusedRowCellValue("cedula").ToString();
                    empresaEstatica.telefono = gridView1.GetFocusedRowCellValue("telefono").ToString();
                }

            }
            catch (ApplicationException app)
            {
                MessageBox.Show(app.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Metodo que desactiva una Ubicacion
        /// </summary>
        public void DesactivarUbicaciones()
        {
            gestorEmpresa = new GestorEmpresa();
            unaEmpresa = new Empresa();
            try
            {
                empresaEstatica.idEmpresa = int.Parse(gridView1.GetFocusedRowCellValue("idempresa").ToString());
                empresaEstatica.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();
                empresaEstatica.cedulaJuridica = gridView1.GetFocusedRowCellValue("cedula").ToString();
                empresaEstatica.telefono = gridView1.GetFocusedRowCellValue("telefono").ToString();


                if (MessageBox.Show("¿Seguro que desea eliminar la empresa " + empresaEstatica.nombre + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorEmpresa.EliminarEmpresa(empresaEstatica, usuarioLogueado);
                    MessageBox.Show("La empresa " + empresaEstatica.nombre + " fue eliminada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmEmpresa_Load(null, null);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Invoca al metodo eliminar Ubicacion, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarUbicaciones();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoca al metodo desactivar la Ubicacion, al seleccionar un row del grid y pulsar el boton eliminar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarUbicaciones();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEmpresa.sp_SELECT_Empresa_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Empresa_AllTableAdapter.Fill(this.dataSetEmpresa.sp_SELECT_Empresa_All);
            empresaEstatica = new Empresa();
            mBtnModificar.Enabled = false;
            mBtnEliminar.Enabled = false;
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == DialogResult.OK)
            {
                gCEmpresas.ExportToXlsx(sfdRuta.FileName);
            }
        }
    }
}
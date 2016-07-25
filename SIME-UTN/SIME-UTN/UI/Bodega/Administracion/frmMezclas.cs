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
    public partial class frmMezclas : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestorUsuario = null;
        static Mezcla mezclaEstatica = null;
        GestorMezcla gestorMezcla = null;
        Mezcla unaMezcla = null;
        public frmMezclas()
        {
            InitializeComponent();
          
        }

        /// <summary>
        /// Metodo que que optiene el usuario que esta logueado en el momento
        /// </summary>
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }


        /// <summary>
        /// Metodo que llama al formulario AdMezcla para guardar una nueva Mezcla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdMezclas ofrmAdMezclas = new frmAdMezclas();
            ofrmAdMezclas.ShowDialog(this);
            frmMezclas_Load(null, null);
        }


        /// <summary>
        /// Metodo que llama al formulario AdMezcla para modificar una Mezcla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdMezclas ofrmAdMezclas = new frmAdMezclas(mezclaEstatica);
            ofrmAdMezclas.ShowDialog(this);
            frmMezclas_Load(null, null);
        }

        /// <summary>
        /// Metodo que desactiva una Ubicacion
        /// </summary>
        public void DesactivarMezclas()
        {
            gestorMezcla = new GestorMezcla();
            unaMezcla = new Mezcla();
            try
            {
                unaMezcla.idRegistroMezcla = int.Parse(gridView1.GetFocusedRowCellValue("idregistromezcla").ToString());
                unaMezcla.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();


                if (MessageBox.Show("¿Seguro que desea eliminar la mezcla " + unaMezcla.nombre + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorMezcla.EliminarMezcla(unaMezcla.idRegistroMezcla, unaMezcla.nombre, usuarioLogueado);
                    MessageBox.Show("La mezcla " + unaMezcla.nombre + " fue eliminada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMezclas_Load(null, null);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Invoca al metodo eliminar Mezcla, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarMezclas();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoca al metodo desactivar la Mezcla, al seleccionar un row del grid y pulsar el boton eliminar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarMezclas();
        }

        private void frmMezclas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRMezclas.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetRMezclas.Producto);
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetRMezclas.sp_SELECT_RegistroMezcla_All' table. You can move, or remove it, as needed.
            UsuarioLogueado();
            mezclaEstatica = new Mezcla();

        }

        /// <summary>
        /// Metodo que permite extrae la Mezcla seleccionada del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCMezclas_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                mezclaEstatica.idRegistroMezcla = int.Parse(gridView1.GetFocusedRowCellValue("idregistromezcla").ToString());
                mezclaEstatica.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();
                mezclaEstatica.descripcion = gridView1.GetFocusedRowCellValue("descripcion").ToString();
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
    }
}
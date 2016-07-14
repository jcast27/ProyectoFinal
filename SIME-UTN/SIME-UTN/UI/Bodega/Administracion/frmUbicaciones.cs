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
    public partial class frmUbicaciones : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestorUsuario = null;
        static Ubicacion ubicacionEstatica = null;
        Ubicacion unaUbicacion = null;
        GestorUbicacion gestorUbicacion = null;
        Departamento unDepartamento = null;
       
        public frmUbicaciones()
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
            frmAdUbicaciones ofrAdUbicaciones = new frmAdUbicaciones();
            ofrAdUbicaciones.ShowDialog(this);
            frmUbicaciones_Load(null, null);
        }


        /// <summary>
        /// Metodo que llama al formulario AdUbicacion para modificar una Ubicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdUbicaciones ofrAdUbicaciones = new frmAdUbicaciones(ubicacionEstatica);
            ofrAdUbicaciones.ShowDialog(this);
            frmUbicaciones_Load(null, null);
        }




        /// <summary>
        /// Metodo que permite extrae la Ubicacion seleccionada del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCUbicaciones_Click(object sender, EventArgs e)
        {
            unDepartamento = new Departamento();
            System.Data.DataRowView row = null;
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                ubicacionEstatica.idUbicacion= int.Parse(gridView1.GetFocusedRowCellValue("idubicacion").ToString());
                ubicacionEstatica.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();
                ubicacionEstatica.otraSennas = gridView1.GetFocusedRowCellValue("otrassennas").ToString();
                unDepartamento.idDepartamento = int.Parse(gridView1.GetFocusedRowCellValue("iddepartamento").ToString());
                row = LookUpDepartamento.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("iddepartamento").ToString())) as DataRowView;
                unDepartamento.descripcion = row.Row["descripcion"].ToString();
                ubicacionEstatica.Departamento = unDepartamento;

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
        /// Metodo que desactiva una Ubicacion
        /// </summary>
        public void DesactivarUbicaciones()
        {
            gestorUbicacion = new GestorUbicacion();
            unaUbicacion = new Ubicacion();
            try
            {
                ubicacionEstatica.idUbicacion = int.Parse(gridView1.GetFocusedRowCellValue("idubicacion").ToString());
                ubicacionEstatica.nombre = gridView1.GetFocusedRowCellValue("nombre").ToString();


                if (MessageBox.Show("¿Seguro que desea eliminar la ubicacion " + ubicacionEstatica.nombre + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorUbicacion.EliminarUbicacion(ubicacionEstatica.idUbicacion,ubicacionEstatica.nombre, usuarioLogueado);
                    MessageBox.Show("La ubicacion " + ubicacionEstatica.nombre + " fue eliminada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUbicaciones_Load(null, null);

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

        private void frmUbicaciones_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetDepartamento.sp_SELECT_Departamento_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Departamento_AllTableAdapter.Fill(this.dataSetDepartamento.sp_SELECT_Departamento_All);
            // TODO: This line of code loads data into the 'dataSetRegistrarUbicacion.sp_SELECT_Ubicacion_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Ubicacion_AllTableAdapter.Fill(this.dataSetRegistrarUbicacion.sp_SELECT_Ubicacion_All);
            UsuarioLogueado();
            ubicacionEstatica = new Ubicacion();

        }
    }
}
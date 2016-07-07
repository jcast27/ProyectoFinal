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
    public partial class frmUnidadesMedida : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        static string nombre = "";
        GestorUnidadMedida gestorUnidad = null;
        UnidadMedida unidadEstatica = null;
        public frmUnidadesMedida()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetUnidadMedida.UnidadMedidaProducto' Puede moverla o quitarla según sea necesario.
            this.unidadMedidaProductoTableAdapter.Fill(this.dataSetUnidadMedida.UnidadMedidaProducto);
            UsuarioLogueado();
            gestorUnidad = GestorUnidadMedida.GetInstance();
            unidadEstatica = new UnidadMedida();


        }

        public void DesactivarUnidad()
        {
            string unidad = gridView1.GetFocusedRowCellValue("Descripcion").ToString(); ;
            int unidadId = Int32.Parse(gridView1.GetFocusedRowCellValue("IDUnidadMedida").ToString());

            if (MessageBox.Show("¿Seguro que desea eliminar la unidad de medida " + unidad + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorUnidad.EliminarUnidad(unidadId, unidad, usuarioLogueado);
                MessageBox.Show("La Unidad de Medida " + unidad + " fue eliminada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUnidad_Load(null, null);

            }
        }

    
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarUnidad();
                e.Handled = true;
            }

        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdUnidadMedida ofrmAdUnidadMedida = new frmAdUnidadMedida(unidadEstatica);
            ofrmAdUnidadMedida.ShowDialog(this);
            frmUnidad_Load(null, null);
        }

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdUnidadMedida ofrmAdUnidadMedida = new frmAdUnidadMedida();
            ofrmAdUnidadMedida.ShowDialog(this);
            frmUnidad_Load(null, null);
        }

        private void gCUnidadesMedida_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                unidadEstatica.idUnidadMedida = int.Parse(gridView1.GetFocusedRowCellValue("IDUnidadMedida").ToString());
                unidadEstatica.codigo = gridView1.GetFocusedRowCellValue("Codigo").ToString();
                unidadEstatica.descripcion = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                
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

        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarUnidad();
        }
    }
}
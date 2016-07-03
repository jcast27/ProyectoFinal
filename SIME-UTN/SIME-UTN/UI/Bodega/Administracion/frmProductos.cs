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
    public partial class frmProductos : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestorUsuario = null;
        GestorProducto gestorProducto = null;
        Producto productoEstatico = null;
        public frmProductos()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }



        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdProducto ofrmAdProducto = new frmAdProducto();
            ofrmAdProducto.ShowDialog(this);
            frmProductos_Load(null, null);
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUbicacion.sp_SELECT_Ubicacion_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Ubicacion_AllTableAdapter.Fill(this.dataSetUbicacion.sp_SELECT_Ubicacion_All);
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.UnidadMedidaProducto' table. You can move, or remove it, as needed.
            this.unidadMedidaProductoTableAdapter.Fill(this.dataSetUnidadMedida.UnidadMedidaProducto);
            // TODO: This line of code loads data into the 'dataSetCategorias.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dataSetCategorias.Categoria);
            // TODO: This line of code loads data into the 'dataSetProducto.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.dataSetProducto.Producto);
            UsuarioLogueado();
            gestorProducto = GestorProducto.GetInstance();
            productoEstatico = new Producto();


        }

        private void gCProductos_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                Categoria unaCategoria = new Categoria();
                Ubicacion unaUbicacion = new Ubicacion();
                UnidadMedida unaUnidadMedida = new UnidadMedida();
                System.Data.DataRowView row = null;
                productoEstatico.idProducto = int.Parse(gridView1.GetFocusedRowCellValue("IDProducto").ToString());
                productoEstatico.codigoAvatar = gridView1.GetFocusedRowCellValue("CodigoAvatar").ToString();
                productoEstatico.nombreProducto = gridView1.GetFocusedRowCellValue("Nombre").ToString();
                productoEstatico.descripcion = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                unaCategoria.idCategoria = int.Parse(gridView1.GetFocusedRowCellValue("IDCategoria").ToString());
                row = LookUpCategoria.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("IDCategoria").ToString()))as DataRowView;
                unaCategoria.descripcion = row.Row["Descripcion"].ToString();
                productoEstatico.Categoria = unaCategoria;
                unaUbicacion.idUbicacion = int.Parse(gridView1.GetFocusedRowCellValue("IDUbicacion").ToString());
                row = LookUpUbicacion.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("IDUbicacion").ToString())) as DataRowView;
                unaUbicacion.nombre = row.Row["Nombre"].ToString();
                productoEstatico.Ubicacion = unaUbicacion;
                unaUnidadMedida.idUnidadMedida = int.Parse(gridView1.GetFocusedRowCellValue("IDUnidadMedida").ToString());
                row = LookUpUnidadMedida.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("IDUnidadMedida").ToString())) as DataRowView;
                unaUnidadMedida.descripcion = row.Row["Descripcion"].ToString();
                productoEstatico.UnidadMedida = unaUnidadMedida;
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

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdProducto ofrmAdProducto = new frmAdProducto(productoEstatico);
            ofrmAdProducto.ShowDialog(this);
            frmProductos_Load(null, null);
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string producto = gridView1.GetFocusedRowCellValue("Nombre").ToString(); ;
            int productoID = Int32.Parse(gridView1.GetFocusedRowCellValue("IDProducto").ToString());

                if (MessageBox.Show("¿Seguro que desea eliminar al producto " + producto + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorProducto.EliminarUsuario(productoID,producto,usuarioLogueado);
                    MessageBox.Show("El Producto " + producto + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmProductos_Load(null, null);

            }

                e.Handled = true;
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIME_UTN.DTOs;
using SIME_UTN.Gestores;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmAdRegistroProducto : DevExpress.XtraEditors.XtraForm
    {
        static List<ProductoDTO> lista = new List<ProductoDTO>();
        GestorUsuarioTable gestor = null;
        public frmAdRegistroProducto()
        {
            InitializeComponent();
           
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            txtUsuario.Text = gestor.ObtenerUsuarioLogeado();
        }

        public void CargarGrid()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Productos";
            dt.Columns.Add(new DataColumn("CodigoProducto"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Cantidad"));
            dt.Columns.Add(new DataColumn("UnidadMedida"));
            dt.Columns.Add(new DataColumn("CantidadPorEmpaque"));

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoProducto"] = lista[i].codigoAvatar;
                    dr["Nombre"] = lista[i].nombreProducto;
                    dr["Cantidad"] = lista[i].cantidad;
                    dr["UnidadMedida"] = lista[i].unidadMedida;
                    dr["CantidadPorEmpaque"] = lista[i].cantidadPorEmpaque;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCRegistroProducto.DataSource = dt;
        }


        private void txtECodigoProducto_Click(object sender, EventArgs e)
        {
            frmFiltroProductos ofrmFiltroProductos = new frmFiltroProductos();
            ofrmFiltroProductos.ShowDialog(this);
            this.txtECodigoProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.codigoAvatar;
            this.txtNombreProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.nombreProducto;
            txtUnidadMedida.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.unidadMedida;
        }

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            ProductoDTO unProducto = new ProductoDTO();
            unProducto.codigoAvatar = txtECodigoProducto.Text;
            unProducto.nombreProducto = txtNombreProducto.Text;
            unProducto.cantidad = double.Parse(txtCantidad.Text);
            unProducto.unidadMedida = txtUnidadMedida.Text;
            unProducto.cantidadPorEmpaque = double.Parse(txtCantidadXEmpaque.Text);
            lista.Add(unProducto);
            this.CargarGrid();
            CambiarEstado(EstadoMantenimiento.Agregar);
        }

        private void frmAdRegistroProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.UnidadMedidaProducto' table. You can move, or remove it, as needed.
            UsuarioLogueado();
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    lista.Clear();
                    gCRegistroProducto.DataSource = null;
                    gridView1.Columns.Clear();
                    txtSolicitudAvatar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    dateFechaIngreso.Enabled = true;
                    dateFechaCaducidad.Enabled = true;
                    txtSolicitudAvatar.Text = "";
                    txtDescripcion.Text = "";
                    dateFechaIngreso.Text = "";
                    dateFechaCaducidad.Text = "";
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    break;

                case EstadoMantenimiento.Editar:
                    break;

                case EstadoMantenimiento.Agregar:
                    txtSolicitudAvatar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    dateFechaIngreso.Enabled = false;
                    dateFechaCaducidad.Enabled = false;
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    break;
            }
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }
    }
}
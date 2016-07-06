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
    public partial class frmAdTrasladoProductos : DevExpress.XtraEditors.XtraForm
    {
        static List<ProductoDTO> lista = new List<ProductoDTO>();
        GestorUsuarioTable gestor = null;
        public frmAdTrasladoProductos()
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
            dt.TableName = "Prodcutos";
            dt.Columns.Add(new DataColumn("CodigoProducto"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Cantidad"));
            dt.Columns.Add(new DataColumn("UnidadMedida"));

            try
            {
               
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoProducto"] = lista[i].codigoAvatar;
                    dr["Nombre"] = lista[i].nombreProducto;
                    dr["Cantidad"] = lista[i].cantidad;
                    dr["UnidadMedida"] = lista[i].unidadMedida;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCProductos.DataSource = dt;
        }

        private void txtECodigoProducto_Click(object sender, EventArgs e)
        {
            frmFiltroProductos ofrmFiltroProductos = new frmFiltroProductos();
            ofrmFiltroProductos.ShowDialog(this);
            this.txtECodigoProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.CodigoAvatar;
            this.txtNombreProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.NombreProducto;
            txtUnidadMedida.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.UnidadMedida;
        }

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ProductoDTO unProducto = new ProductoDTO();
            unProducto.codigoAvatar = txtECodigoProducto.Text;
            unProducto.nombreProducto = txtNombreProducto.Text;
            unProducto.cantidad = double.Parse(txtCantidad.Text);
            unProducto.unidadMedida = txtUnidadMedida.Text;
            lista.Add(unProducto);
            this.CargarGrid();
            CambiarEstado(EstadoMantenimiento.Agregar);
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    lista.Clear();
                    gCProductos.DataSource = null;
                    gridView2.Columns.Clear();
                    dateFechaTraslado.Enabled = true;
                    txtObservaciones.Enabled = true;
                    cmbTipoTraslado.Enabled = true;
                    cmbTipoTraslado.SelectedIndex = -1;
                    dateFechaTraslado.Text = "";
                    txtObservaciones.Text = "";
                    txtNombreProducto.Text = "";
                    txtECodigoProducto.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                 
                    break;

                case EstadoMantenimiento.Editar:
                    break;

                case EstadoMantenimiento.Agregar:
                    dateFechaTraslado.Enabled = false;
                    txtObservaciones.Enabled = false;
                    cmbTipoTraslado.Enabled = false;
                    txtNombreProducto.Text = "";
                    txtECodigoProducto.Text = "";
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

        private void frmAdTrasladoProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTipoTraslado.TipoTraslado' table. You can move, or remove it, as needed.
            this.tipoTrasladoTableAdapter.Fill(this.dataSetTipoTraslado.TipoTraslado);
            // TODO: This line of code loads data into the 'dataSetTipoTraslado.TipoTraslado' table. You can move, or remove it, as needed.
            UsuarioLogueado();
            cmbTipoTraslado.SelectedIndex = -1;

        }

        private void btnEBodegaOrigen_Click(object sender, EventArgs e)
        {
            frmFiltroBodegas ofrmFiltroBodega = new frmFiltroBodegas();
            ofrmFiltroBodega.ShowDialog(this);

            this.btnEBodegaOrigen.Text = ofrmFiltroBodega.BodegaSeleccionada == null ? "" : ofrmFiltroBodega.BodegaSeleccionada.nombre;
            this.lblIDBodegaOrigen.Text = ofrmFiltroBodega.BodegaSeleccionada == null ? "" : ofrmFiltroBodega.BodegaSeleccionada.idregistrobodega.ToString();

        }

        private void BtnEBodegaDestino_Click(object sender, EventArgs e)
        {
            frmFiltroBodegas ofrmFiltroBodega = new frmFiltroBodegas();
            ofrmFiltroBodega.ShowDialog(this);

            this.BtnEBodegaDestino.Text = ofrmFiltroBodega.BodegaSeleccionada == null ? "" : ofrmFiltroBodega.BodegaSeleccionada.nombre;
            this.lblIDBodegaDestino.Text = ofrmFiltroBodega.BodegaSeleccionada == null ? "" : ofrmFiltroBodega.BodegaSeleccionada.idregistrobodega.ToString();
        }
    }
}
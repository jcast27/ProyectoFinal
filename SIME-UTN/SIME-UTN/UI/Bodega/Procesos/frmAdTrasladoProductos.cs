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

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmAdTrasladoProductos : DevExpress.XtraEditors.XtraForm
    {
        static List<ProductoDTO> lista = new List<ProductoDTO>();
        public frmAdTrasladoProductos()
        {
            InitializeComponent();
        }

        public void CargarGrid()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Prodcutos";
            dt.Columns.Add(new DataColumn("CodigoProducto"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Cantidad"));

            try
            {
               
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoProducto"] = lista[i].codigoAvatar;
                    dr["Nombre"] = lista[i].nombreProducto;
                    dr["Cantidad"] = lista[i].cantidad;
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
            this.txtECodigoProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.codigoAvatar;
            this.txtNombreProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.nombreProducto;
        }

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ProductoDTO unProducto = new ProductoDTO();
            unProducto.codigoAvatar = txtECodigoProducto.Text;
            unProducto.nombreProducto = txtNombreProducto.Text;
            unProducto.cantidad = double.Parse(txtCantidad.Text);
            lista.Add(unProducto);
            this.CargarGrid();
        }
    }
}
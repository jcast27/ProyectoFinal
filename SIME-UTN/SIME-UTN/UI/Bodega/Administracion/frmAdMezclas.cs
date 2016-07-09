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
using SIME_UTN.UI.Bodega.Procesos;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdMezclas : DevExpress.XtraEditors.XtraForm
    {
        static List<ProductoDTO> lista = new List<ProductoDTO>();
        GestorUsuarioTable gestor = null;
        
        public frmAdMezclas()
        {
            InitializeComponent();
           
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
        }

  


        private void txtECodigoProducto_Click(object sender, EventArgs e)
        {
            frmFiltroProductos ofrmFiltroProductos = new frmFiltroProductos();
            ofrmFiltroProductos.ShowDialog(this);
            this.txtECodigoProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.CodigoAvatar;
            this.txtNombreProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.NombreProducto;
            txtUnidadMedida.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.UnidadMedida;
            txtCantidad.Enabled = true;
        }
        public void CargarGrid()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Productos";
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
            this.gCRegistroProducto.DataSource = dt;
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
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.Text = "";
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtNombre.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    break;

                case EstadoMantenimiento.Editar:
                    break;

                case EstadoMantenimiento.Agregar:
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //e.Handled = true;
            //return;
            //}

            if (txtUnidadMedida.Text.Equals("Gramos"))
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {

                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }

                bool IsDec = false;
                int nroDec = 0;

                for (int i = 0; i < txtCantidad.Text.Length; i++)
                {
                    if (txtCantidad.Text[i] == '.')
                        IsDec = true;

                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }


                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;

            }
        }


    }
}
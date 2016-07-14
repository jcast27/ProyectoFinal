using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SIME_UTN.UI.Bodega.Inventarios
{
    public partial class frmInventarioMaximo : DevExpress.XtraEditors.XtraForm
    {
        public frmInventarioMaximo()
        {
            InitializeComponent();
        }

        private void frmInventarioMaximo_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.sp_SELECT_UnidadMedidaProducto_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter.Fill(this.dataSetUnidadMedida.sp_SELECT_UnidadMedidaProducto_All);

            // TODO: esta línea de código carga datos en la tabla 'dataSetProductos.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSetProductos.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInventario.InventarioProducto' Puede moverla o quitarla según sea necesario.
            this.inventarioProductoTableAdapter.Fill(this.dataSetInventario.InventarioProducto);

        }
    }
}
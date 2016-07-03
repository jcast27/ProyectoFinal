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
            // TODO: esta línea de código carga datos en la tabla 'dataSetUnidadMedida.UnidadMedidaProducto' Puede moverla o quitarla según sea necesario.
            this.unidadMedidaProductoTableAdapter.Fill(this.dataSetUnidadMedida.UnidadMedidaProducto);
            // TODO: esta línea de código carga datos en la tabla 'dataSetProductos.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSetProductos.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dataSetInventario.InventarioProducto' Puede moverla o quitarla según sea necesario.
            this.inventarioProductoTableAdapter.Fill(this.dataSetInventario.InventarioProducto);

        }
    }
}
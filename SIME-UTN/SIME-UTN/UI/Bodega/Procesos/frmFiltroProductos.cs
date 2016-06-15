using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIME_UTN.Gestores;
using SIME_UTN.DTOs;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmFiltroProductos : DevExpress.XtraEditors.XtraForm
    {
        GestorProducto gestor = null;
        private ProductoCategoriaUnidadMedidaDTO productoseleccionado;

        public ProductoCategoriaUnidadMedidaDTO Productoseleccionado
        {
            get { return productoseleccionado; }
            set { productoseleccionado = value; }
        }

        public frmFiltroProductos()
        {
            InitializeComponent();
        }

        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                RefrescaLista(this.txtNombreProducto.Text.Trim());

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescaLista(string filtroNombreProductop)
        {
            try
            {
                gestor = GestorProducto.GetInstance();
                if (String.IsNullOrEmpty(filtroNombreProductop) == true)
                {
                    this.gCProductos.DataSource = null;
                    return;
                }
                List<ProductoCategoriaUnidadMedidaDTO> lista = gestor.ObtenertPorNombreDTO(filtroNombreProductop);
                this.gCProductos.DataSource = null;
                this.gCProductos.DataSource = lista;



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "Macrobiotica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gCProductos_Click(object sender, EventArgs e)
        {
            try
            {

                productoseleccionado = ((List<ProductoCategoriaUnidadMedidaDTO>)gridView1.DataSource)[gridView1.FocusedRowHandle] as ProductoCategoriaUnidadMedidaDTO;
                Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
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
using SIME_UTN.Entities;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmAdTrasladoProductos : DevExpress.XtraEditors.XtraForm
    {
        static List<TrasladoProductoInterDTO> lista = new List<TrasladoProductoInterDTO>();
        GestorUsuarioTable gestor = null;
        string usuarioLogueado = "";
        TrasladoProducto traslado = new TrasladoProducto();
        GestorTrasladoProductoInter gestorTrasladoPInter = null;
        
        static TrasladoProducto trasladoEstatico = null;
        public frmAdTrasladoProductos()
        {
            InitializeComponent();
        }

        public frmAdTrasladoProductos(TrasladoProducto trasladoEstaticop)
        {
            InitializeComponent();
            trasladoEstatico = new TrasladoProducto();
            trasladoEstatico = trasladoEstaticop;
            gCTraslados();
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
                    dr["UnidadMedida"] = lista[i].nombreUnidadMedida;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCProductos.DataSource = dt;
        }

        public void gCTraslados()
        {
            gestorTrasladoPInter = new GestorTrasladoProductoInter();

            try
            {
                txtNumeroTraslado.Text = trasladoEstatico.idTraslado.ToString();
                txtUsuario.Text = trasladoEstatico.Usuario.usuario;
                dateFechaTraslado.Text = trasladoEstatico.fechaTraslado;
                txtObservaciones.Text = trasladoEstatico.observaciones;
                lista = gestorTrasladoPInter.ObtenerProductosPorIdTraslado(trasladoEstatico.idTraslado);
                CargarGrid();

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
            TrasladoProductoInterDTO unProducto = new TrasladoProductoInterDTO();
            unProducto.codigoAvatar = txtECodigoProducto.Text;
            unProducto.nombreProducto = txtNombreProducto.Text;
            unProducto.cantidad = double.Parse(txtCantidad.Text);
            unProducto.nombreUnidadMedida = txtUnidadMedida.Text;
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
            // TODO: This line of code loads data into the 'dataSetTPRegistroBodegaD.sp_SELECT_RegistroBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_AllTableAdapter1.Fill(this.dataSetTPRegistroBodegaD.sp_SELECT_RegistroBodega_All);
            // TODO: This line of code loads data into the 'dataSetTPRegistroBodega.sp_SELECT_RegistroBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_AllTableAdapter.Fill(this.dataSetTPRegistroBodega.sp_SELECT_RegistroBodega_All);
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetTipoTraslado.TipoTraslado' table. You can move, or remove it, as needed.
            this.tipoTrasladoTableAdapter.Fill(this.dataSetTipoTraslado.TipoTraslado);
            // TODO: This line of code loads data into the 'dataSetTipoTraslado.TipoTraslado' table. You can move, or remove it, as needed.
            UsuarioLogueado();
           if (trasladoEstatico == null)
            {
                cmbBodegaDestino.SelectedIndex = -1;
                cmbBodegaOrigen.SelectedIndex = -1;
                cmbTipoTraslado.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cmbBodegaDestino.Items.Count; i++)
                {
                    string value = cmbBodegaDestino.GetItemText(cmbBodegaDestino.Items[i]);
                    if (value == trasladoEstatico.BodegaDestino.nombre)
                    {
                        cmbBodegaDestino.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cmbBodegaOrigen.Items.Count; i++)
                {
                    string value = cmbBodegaOrigen.GetItemText(cmbBodegaOrigen.Items[i]);
                    if (value == trasladoEstatico.BodegaOrigen.nombre)
                    {
                        cmbBodegaOrigen.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cmbTipoTraslado.Items.Count; i++)
                {
                    string value = cmbTipoTraslado.GetItemText(cmbTipoTraslado.Items[i]);
                    if (value == trasladoEstatico.TipoTraslado.descripcion)
                    {
                        cmbTipoTraslado.SelectedIndex = i;
                    }
                }
            }

        }

      
    }
}
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
    public partial class frmModTrasladoProductos : DevExpress.XtraEditors.XtraForm
    {
        static List<TrasladoProductoInterDTO> lista = new List<TrasladoProductoInterDTO>();
        static List<PBodega> listaPBodega = new List<PBodega>();
        GestorUsuarioTable gestor = null;
        string usuarioLogueado = "";
        TrasladoProducto traslado = new TrasladoProducto();
        GestorTrasladoProductoInter gestorTrasladoPInter = null;
        GestorTrasladoProducto gestorTraslado = null;
        GestorBodega gestorBodega = null;
        GestorProducto gestorProducto = null;


        static TrasladoProducto trasladoEstatico = null;
        public frmModTrasladoProductos(TrasladoProducto trasladoEstaticop)
        {
            InitializeComponent();
            trasladoEstatico = new TrasladoProducto();
            lista.Clear();
            listaPBodega.Clear();
            trasladoEstatico = trasladoEstaticop;
            gCTraslados();
            CambiarEstado(EstadoMantenimiento.Editar);
            RefrescarBodega(trasladoEstaticop.idTraslado);
        }
        private void RefrescarBodega(int idBodega)
        {
            gestorTrasladoPInter = new GestorTrasladoProductoInter();
            List<TrasladoProductoInterDTO> lista = new List<TrasladoProductoInterDTO>();
            lista = gestorTrasladoPInter.ObtenerProductosPorIdTraslado(idBodega);
            gCProductos.DataSource = lista;
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            txtUsuario.Text = gestor.ObtenerUsuarioLogeado();
            usuarioLogueado = txtUsuario.Text;
        }

        public string ObtenerFecha()
        {
            DateTime date = DateTime.Now;
            string fecha = date.ToString("MM/dd/yyyy");
            return fecha;
        }


        public void gCTraslados()
        {
            gestorTrasladoPInter = new GestorTrasladoProductoInter();
            gestorBodega = new GestorBodega();
            try
            {
                txtNumeroTraslado.Text = trasladoEstatico.idTraslado.ToString();
                txtUsuario.Text = trasladoEstatico.Usuario.usuario;
                txtFechaTraslado.Text = trasladoEstatico.fechaTraslado;
                txtObservaciones.Text = trasladoEstatico.observaciones;
                lista = gestorTrasladoPInter.ObtenerProductosPorIdTraslado(trasladoEstatico.idTraslado);
                listaPBodega = gestorBodega.ObtenerProductosPorIdBodega(trasladoEstatico.BodegaOrigen.idRegistroBodega);



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

        public void GuardarCambiosTraslado()
        {
            traslado = new TrasladoProducto();
            gestorTrasladoPInter = new GestorTrasladoProductoInter();
            TipoTraslado tipoTraslado = new TipoTraslado();
            gestorTraslado = new GestorTrasladoProducto();
            gestor = new GestorUsuarioTable();
            EstadoTraslado estadoTraslado = new EstadoTraslado();
            Producto producto = new Producto();
            gestorProducto = new GestorProducto();
            GestorRegistroBodega gestorRBodega = new GestorRegistroBodega();
            try
            {
                traslado.idTraslado = int.Parse(txtNumeroTraslado.Text);
                traslado.BodegaOrigen = gestorRBodega.ObtenerBodegaPorIDRegistro(int.Parse(cmbBodegaOrigen.SelectedValue.ToString()));
                traslado.BodegaDestino = gestorRBodega.ObtenerBodegaPorIDRegistro(int.Parse(cmbBodegaDestino.SelectedValue.ToString()));
                traslado.Usuario = gestor.ValidarUsuarioPorUsuario(usuarioLogueado);
                traslado.fechaTraslado = txtFechaTraslado.Text;
                tipoTraslado.idTipoTraslado = int.Parse(cmbTipoTraslado.SelectedValue.ToString());
                tipoTraslado.descripcion = cmbTipoTraslado.GetItemText(cmbTipoTraslado.Items[cmbTipoTraslado.SelectedIndex]);
                traslado.TipoTraslado = tipoTraslado;
                traslado.observaciones = txtObservaciones.Text;
                estadoTraslado.idEstadoTraslado = 1;
                estadoTraslado.descripcion = "En proceso";
                traslado.EstadoTraslado = estadoTraslado;
                traslado.estado = 1;
                gestorTraslado.GuardarTraslado(traslado,usuarioLogueado);

                MessageBox.Show("El traslado # " + traslado.idTraslado + " fue modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


  
        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    lista.Clear();
                    gCProductos.DataSource = null;
                    gridView2.Columns.Clear();
                    txtObservaciones.Enabled = true;
                    cmbTipoTraslado.Enabled = true;
                    cmbTipoTraslado.SelectedIndex = -1;
                    txtObservaciones.Text = "";
                 
                    break;

                case EstadoMantenimiento.Editar:
                    mBtnModificar.Visible = true;
                    txtNumeroTraslado.Enabled = false;
                    cmbBodegaOrigen.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtFechaTraslado.Enabled = false;



                    break;

                case EstadoMantenimiento.Agregar:
                    break;
            }
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


        public bool ValidarCamposModificar()
        {
            bool error = false;

            if (txtNumeroTraslado.Text.Trim() == "")
            {
                epError.SetError(txtNumeroTraslado, "Campo Requerido");
                txtNumeroTraslado.Focus();
                error = true;
            }
            if (cmbBodegaOrigen.SelectedIndex == -1)
            {
                epError.SetError(cmbBodegaOrigen, "Campo Requerido");
                cmbBodegaOrigen.Focus();
                error = true;
            }
            if (cmbBodegaDestino.SelectedIndex == -1)
            {
                epError.SetError(cmbBodegaDestino, "Campo Requerido");
                cmbBodegaDestino.Focus();
                error = true;
            }

            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Campo Requerido");
                txtUsuario.Focus();
                error = true;
            }
            if (txtFechaTraslado.Text.Trim() == "")
            {
                epError.SetError(txtFechaTraslado, "Campo Requerido");
                txtFechaTraslado.Focus();
                error = true;
            }
            if (cmbTipoTraslado.SelectedIndex == -1)
            {
                epError.SetError(cmbTipoTraslado, "Campo Requerido");
                cmbTipoTraslado.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCamposModificar() != true)
            {
                GuardarCambiosTraslado();
            }
        }


    }
}
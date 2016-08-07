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
        static List<PBodega> listaPBodega = new List<PBodega>();
        GestorUsuarioTable gestor = null;
        string usuarioLogueado = "";
        TrasladoProducto traslado = new TrasladoProducto();
        GestorTrasladoProductoInter gestorTrasladoPInter = null;
        GestorTrasladoProducto gestorTraslado = null;
        GestorBodega gestorBodega = null;
        GestorProducto gestorProducto = null;


        static TrasladoProducto trasladoEstatico = null;
        public frmAdTrasladoProductos()
        {
          
            InitializeComponent();
            lista.Clear();
            listaPBodega.Clear();
            gestorTraslado = new GestorTrasladoProducto();
            txtNumeroTraslado.Text = gestorTraslado.ObtenerSiguienteNumeroTraslado();
            txtFechaTraslado.Text = ObtenerFecha();
        }

        private void RefrescarBodega(int idBodega)
        {
            gestorBodega = new GestorBodega();
            List<PBodega> lista = new List<PBodega>();
            lista = gestorBodega.ObtenerProductosPorIdBodega(idBodega);
            gCBodega.DataSource = lista;
            gCProductos.DataSource = null;
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
            List<PBodega> lista = (List<PBodega>)gCProductos.DataSource;
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

                if (lista.Count != 0)
                {
                    foreach (PBodega productoBodega in lista)
                    {
                        productoBodega.estado = 1;
                        gestorTrasladoPInter.GuardarTrasladoProductos(productoBodega, traslado);
                    }

                }


                    MessageBox.Show("El traslado # " + traslado.idTraslado + " fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int validarCampos(int cantProd, int cantDesp)
        {

            int r = cantDesp;

            if (int.TryParse(txtCantidadProd.Text, out cantDesp))
            {
                if (cantDesp > 0)
                {
                    r = int.Parse(txtCantidadProd.Text);
                    epError.Clear();
                }
                else
                {
                    epError.SetError(txtCantidadProd, "Cantidad no válida");
                    txtCantidadProd.Focus();
                    r = 0;
                }
            }
            else
            {
                epError.SetError(txtCantidadProd, "Cantidad no válida");
                txtCantidadProd.Focus();
                r = 0;
            }

            cantProd = cantProd - cantDesp;

            if (cantProd < 0)
            {
                epError.SetError(txtCantidadProd, "Productos Insuficientes");
                txtCantidadProd.Focus();
                r = 0;
            }


            return r;
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
                    mBtnAceptar.Visible = false;
                    txtNumeroTraslado.Enabled = false;
                    cmbBodegaOrigen.Enabled = false;
                    cmbBodegaDestino.Enabled = false;
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

        private void mBtnAceptar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            if( ValidarCampos() != true)
            {
                GuardarCambiosTraslado();
            }
            
        }

        public bool ValidarCampos()
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
            if (txtObservaciones.Text.Trim() == "")
            {
                epError.SetError(txtObservaciones, "Campo Requerido");
                txtObservaciones.Focus();
                error = true;
            }

            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }


        private void cmbBodegaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBodegaOrigen.SelectedIndex >= 0)
            {
                gestorBodega = new GestorBodega();
                int idBodega = int.Parse(cmbBodegaOrigen.SelectedValue.ToString());
                RefrescarBodega(idBodega);

            }
          
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                gridView1.ActiveFilterString = "[Producto.nombreProducto] LIKE '%%'";
            }
            else
            {
                gridView1.ActiveFilterString = "[Producto.nombreProducto] LIKE '%" + txtBuscar.Text + "%'";
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtCantidadProd.Clear();
                txtCantidadProd.Focus();
            }
        }

        public void TrasladarProductos()
        {
            int cantProd = int.Parse(gridView1.GetFocusedRowCellValue("unidades").ToString());

            int cantTras = validarCampos(cantProd, 0);

            if (cantTras > 0)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("Producto.idProducto").ToString());

                List<PBodega> listaProd = (List<PBodega>)gCBodega.DataSource;

                int indexProd = listaProd.FindIndex(a => a.Producto.idProducto == id);

                listaProd[indexProd].unidades -= int.Parse(cantTras.ToString());

                List<PBodega> listaDesp = new List<PBodega>();

                if (gCProductos.DataSource != null)
                {
                    listaDesp = (List<PBodega>)gCProductos.DataSource;
                }

                int indexDesp = listaDesp.FindIndex(a => a.Producto.idProducto == id);

                if (indexDesp == -1)
                {
                    PBodega nuevo = new PBodega();
                    nuevo.estado = listaProd[indexProd].estado;
                    nuevo.idBodega = listaProd[indexProd].idBodega;
                    nuevo.Producto = listaProd[indexProd].Producto;
                    nuevo.RegistroBodega = listaProd[indexProd].RegistroBodega;
                    nuevo.UnidadMedida = listaProd[indexProd].UnidadMedida;
                    nuevo.contenido = cantTras;
                    nuevo.unidades = int.Parse(cantTras.ToString());
                    listaDesp.Add(nuevo);
                }
                else
                {
                    listaDesp[indexDesp].unidades += int.Parse(cantTras.ToString());
                }


                gCBodega.DataSource = null;
                gCProductos.DataSource = null;

                gCBodega.DataSource = listaProd;
                gCProductos.DataSource = listaDesp;

                txtCantidadProd.Clear();
                txtBuscar.Clear();
                txtBuscar.Focus();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TrasladarProductos();
        }

        /// <summary>
        /// Invoca al metodo que permite hacerle las validacions pertinentes al campo cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidadProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void txtRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int cantProd = int.Parse(gridView2.GetFocusedRowCellValue("unidades").ToString());

                int cantDevol = validarCampos(cantProd, 0);

                if (cantDevol > 0)
                {
                    int id = int.Parse(gridView2.GetFocusedRowCellValue("Producto.idProducto").ToString());

                    List<PBodega> listaProd = (List<PBodega>)gCBodega.DataSource;
                    List<PBodega> listaDesp = listaDesp = (List<PBodega>)gCProductos.DataSource;

                    int indexProd = listaProd.FindIndex(a => a.Producto.idProducto == id);
                    int indexDesp = listaDesp.FindIndex(a => a.Producto.idProducto == id);

                    listaProd[indexProd].unidades += int.Parse(cantDevol.ToString());

                    double prodDesp = listaDesp[indexDesp].unidades - cantDevol;

                    if (prodDesp == 0)
                    {
                        listaDesp.RemoveAt(indexDesp);
                    }
                    else
                    {
                        listaDesp[indexDesp].unidades -= int.Parse(cantDevol.ToString());
                    }

                    gCBodega.DataSource = null;
                    gCProductos.DataSource = null;

                    gCBodega.DataSource = listaProd;
                    gCProductos.DataSource = listaDesp;
                }
            }
            catch (Exception)
            { }
        }

        private void txtCantidadProd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TrasladarProductos();
                txtCantidadProd.Clear();
            }
        }
    }
}
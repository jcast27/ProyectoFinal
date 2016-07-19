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
        GestorUnidadMedida gestorUnidadMedida = null;
        GestorProducto gestorProducto = null;


        static TrasladoProducto trasladoEstatico = null;
        public frmAdTrasladoProductos()
        {
            InitializeComponent();
            gestorTraslado = new GestorTrasladoProducto();
            txtNumeroTraslado.Text = gestorTraslado.ObtenerSiguienteNumeroTraslado();
            txtFechaTraslado.Text = ObtenerFecha();
        }

        public frmAdTrasladoProductos(TrasladoProducto trasladoEstaticop)
        {
            InitializeComponent();
            trasladoEstatico = new TrasladoProducto();
            trasladoEstatico = trasladoEstaticop;
            gCTraslados();
            CambiarEstado(EstadoMantenimiento.Editar);
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
            string fecha = date.ToString("dd/MM/yyyy");
            return fecha;
        }

        public void CargarGridProductos()
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

        public void CargarGridBodegaOrigen()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Prodcutos";
            dt.Columns.Add(new DataColumn("CodigoProducto"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Cantidad"));
            dt.Columns.Add(new DataColumn("UnidadMedida"));

            try
            {

                for (int i = 0; i < listaPBodega.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoProducto"] = listaPBodega[i].Producto.codigoAvatar;
                    dr["Nombre"] = listaPBodega[i].Producto.nombreProducto;
                    dr["Cantidad"] = listaPBodega[i].contenido;
                    dr["UnidadMedida"] = listaPBodega[i].UnidadMedida.descripcion;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCBodega.DataSource = dt;
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
                CargarGridProductos();
                CargarGridBodegaOrigen();


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

        public void GuardarCambiosTraslado(string accionp)
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
                traslado.EstadoTraslado = estadoTraslado;
                traslado.estado = 1;
                gestorTraslado.GuardarTraslado(traslado,usuarioLogueado);

                if (lista.Count != 0)
                {
                    foreach (TrasladoProductoInterDTO trasladoInterDTO in lista)
                    {
                        producto = gestorProducto.ObtenerProductoPorCodigoAvatar(trasladoInterDTO.codigoAvatar);
                        trasladoInterDTO.idProducto = producto.idProducto;
                        trasladoInterDTO.idTraslado = traslado.idTraslado;
                        trasladoInterDTO.idUnidadMedida = producto.UnidadMedida.idUnidadMedida;
                        trasladoInterDTO.estado = 1;
                        gestorTrasladoPInter.GuardarTrasladoProductos(trasladoInterDTO,traslado);
                    }

                }

                if (accionp == "Modificar")
                {
                    MessageBox.Show("El traslado # " + traslado.idTraslado + " fue modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("El traslado # " + traslado.idTraslado + " fue agregado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

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
            bool cantidadSuficiente = false;
            bool existeProducto = false;

            //se valida que los campos requeridos no esten vacios
            if (ValidarCamposAgregarProducto() != true)
            {

                unProducto.codigoAvatar = txtECodigoProducto.Text;
                unProducto.cantidad = double.Parse(txtCantidad.Text);

                //se compara la cantida por agregar, contra la cantidad el producto en bodega
                foreach (PBodega productoBodega in listaPBodega)
                {
                    if (productoBodega.Producto.codigoAvatar == unProducto.codigoAvatar)
                    {
                        existeProducto = true;
                        if (productoBodega.contenido >= unProducto.cantidad)
                        {
                            cantidadSuficiente = true;
                        }  
                    }
                }

                // se valida si el producto por agregar ya existe en la bodega, de lo contrario no se puede agregar
                if (existeProducto == true)
                {

                    if (cantidadSuficiente == false)
                    {
                        MessageBox.Show("La cantidad digitda es mayor que la cantida en bodega para este producto, digitar otra cantidad", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        int index = 0;
                        bool existe = false;
                        if (lista.Count != 0)
                        {
                            existe = true;

                            // se valida si se agregar un producto repetido, de ser asi, se elimina y se vuelve agregar a la lista
                            foreach (TrasladoProductoInterDTO unProductoDTO in lista)
                            {
                                if (unProductoDTO.codigoAvatar == txtECodigoProducto.Text)
                                {
                                    lista.RemoveAt(index);
                                    break;
                                }
                                index++;
                            }
                        }

                        unProducto.nombreProducto = txtNombreProducto.Text;
                        unProducto.nombreUnidadMedida = txtUnidadMedida.Text;

                        if (existe == true)
                        {
                            lista.Insert(index, unProducto);
                        }
                        else
                        {
                            lista.Add(unProducto);
                        }
                        this.CargarGridProductos();
                        CambiarEstado(EstadoMantenimiento.Agregar);
                    }
                }else
                {
                    MessageBox.Show("El producto seleccionado no existe en la bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CambiarEstado(EstadoMantenimiento.Agregar);
                }
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
                    txtNombreProducto.Text = "";
                    txtECodigoProducto.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                 
                    break;

                case EstadoMantenimiento.Editar:
                    mBtnAceptar.Visible = false;
                    mBtnModificar.Visible = true;
                    txtNumeroTraslado.Enabled = false;
                    cmbBodegaOrigen.Enabled = false;
                    cmbBodegaDestino.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtFechaTraslado.Enabled = false;


                    break;

                case EstadoMantenimiento.Agregar:
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


        /// <summary>
        /// Invoca al metodo que permite hacerle las validacions pertinentes al campo cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            gestorUnidadMedida = new GestorUnidadMedida();
            if (gestorUnidadMedida.ObtenerUnidadesConDecimales(txtUnidadMedida.Text) != true)
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

        /// <summary>
        /// Metodo que valida los campos requeridos para poder agregar productos al traslado
        /// </summary>
        /// <returns></returns>
        public bool ValidarCamposAgregarProducto()
        {
            bool error = false;
            if (txtECodigoProducto.Text.Trim() == "")
            {
                epError.SetError(txtECodigoProducto, "Campo Requerido");
                txtECodigoProducto.Focus();
                error = true;
            }
            if (txtCantidad.Text.Trim() == "")
            {
                epError.SetError(txtCantidad, "Campo Requerido");
                txtCantidad.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }

        private void mBtnAceptar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            if( ValidarCampos() != true)
            {
                GuardarCambiosTraslado("Guardar");
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
                GuardarCambiosTraslado("Modificar");
            }
        }

        private void cmbBodegaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBodegaOrigen.SelectedIndex >= 0)
            {
                gestorBodega = new GestorBodega();
                int idBodega = int.Parse(cmbBodegaOrigen.SelectedValue.ToString());
                listaPBodega = gestorBodega.ObtenerProductosPorIdBodega(idBodega);
                lista.Clear();
                CargarGridBodegaOrigen();
            }
          
        }
    }
}
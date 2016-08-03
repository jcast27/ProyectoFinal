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
    public partial class frmAdRegistroProducto : DevExpress.XtraEditors.XtraForm
    {
        static List<RegistroIngresoProductoDTO> lista = new List<RegistroIngresoProductoDTO>();
        RegistroIngresoProductoDTO unRegDTO = null;
        RegistroProducto unRegProd = null;
        Producto unProducto = null;
        GestorProducto gestorProducto = null;
        GestorRegistroProducto gestorReg = null;
        GestorUnidadMedida gestorUnidadMedida = null;
        GestorRegistroIngresoProducto gestRegIngProd = null;
        GestorUsuarioTable gestor = null;
        static string usuarioLogueado = "";
        static RegistroProducto registroEstatico = null;
        public frmAdRegistroProducto()
        {
            InitializeComponent();
            txtFechaRecibido.Text = ObtenerFecha();
            lista.Clear();
        }

        public frmAdRegistroProducto(RegistroProducto registroEstaticop)
        {

            InitializeComponent();
            mBtnEliminar.Visible = true;
            mBtnNuevo.Visible = false;
            mBtnAceptar.Visible = false;
            mBtnModificar.Visible = true;
            registroEstatico = new RegistroProducto();
            registroEstatico = registroEstaticop;
            gCRegistroProductos();
            cmbBodega.Enabled = false;
        }

        public string ObtenerFecha()
        {
            DateTime date = DateTime.Now;
            string fecha = date.ToString("MM/dd/yyyy");
            return fecha;
        }

        public void gCRegistroProductos()
        {
            gestRegIngProd = new GestorRegistroIngresoProducto();

            try
            {
                lblIdRegProd.Text = registroEstatico.idIngresoProducto.ToString();
                txtSolicitudAvatar.Text = registroEstatico.solicitudAvatar.ToString();
                txtDescripcion.Text = registroEstatico.descripcion;
                txtFechaRecibido.Text = registroEstatico.fechaIngreso.ToString();
                lista = gestRegIngProd.ObtenerProductosPorIdRegistro(registroEstatico.idIngresoProducto);
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

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

        public void CargarGrid()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Productos";
            dt.Columns.Add(new DataColumn("CodigoAvatar"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("UnidadMedida"));
            dt.Columns.Add(new DataColumn("CantidadPorEmpaque"));
            dt.Columns.Add(new DataColumn("CostoEmpaque"));
            dt.Columns.Add(new DataColumn("FechaCaducidad"));

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoAvatar"] = lista[i].codigoAvatar;
                    dr["Nombre"] = lista[i].nombreProducto;
                    dr["UnidadMedida"] = lista[i].unidadMedida;
                    dr["CantidadPorEmpaque"] = lista[i].cantidadPorEmpaque;
                    dr["CostoEmpaque"] = lista[i].costoPorEmpaque;
                    dr["FechaCaducidad"] = lista[i].fechaCaducidad;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCRegistroProducto.DataSource = dt;
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
            if (ValidarCamposAgregarRegistroProducto() != true)
            {
                int index = 0;
                bool existe = false;
                double ultimaCantidad = 0;
                if (lista.Count != 0)
                {
                    existe = true;
                    foreach (RegistroIngresoProductoDTO unIngProdDTO in lista)
                    {
                        if (unIngProdDTO.codigoAvatar == txtECodigoProducto.Text)
                        {
                            ultimaCantidad = unIngProdDTO.uCantidad;
                            lista.RemoveAt(index);
                            break;
                        }
                        index++;
                    }
                }

                RegistroIngresoProductoDTO unIngProd = new RegistroIngresoProductoDTO();
                unIngProd.codigoAvatar = txtECodigoProducto.Text;
                unIngProd.nombreProducto = txtNombreProducto.Text;
                unIngProd.unidadMedida = txtUnidadMedida.Text;
                unIngProd.cantidadPorEmpaque = Int16.Parse(txtCantidadXEmpaque.Text);
                unIngProd.costoPorEmpaque = double.Parse(txtCosto.Text);
                unIngProd.fechaCaducidad = dateFechaCaducidad.Text;
                unIngProd.uCantidad = ultimaCantidad;
                if (existe == true)
                {
                    lista.Insert(index, unIngProd);
                }
                else
                {
                    lista.Add(unIngProd);
                }
                
                this.CargarGrid();
                CambiarEstado(EstadoMantenimiento.Agregar);
            }
        }

        private void frmAdRegistroProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBodegas.sp_SELECT_RegistroBodega_LessVirtual' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_LessVirtualTableAdapter.Fill(this.dataSetBodegas.sp_SELECT_RegistroBodega_LessVirtual);
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.UnidadMedidaProducto' table. You can move, or remove it, as needed.
            UsuarioLogueado();
            txtUsuario.Text = usuarioLogueado;
            if (registroEstatico == null)
            {
                cmbBodega.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cmbBodega.Items.Count; i++)
                {
                    string value = cmbBodega.GetItemText(cmbBodega.Items[i]);
                    if (value == registroEstatico.Bodega.nombre)
                    {
                        cmbBodega.SelectedIndex = i;
                    }
                }
            }
       
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    lista.Clear();
                    gCRegistroProducto.DataSource = null;
                    gridView1.Columns.Clear();
                    txtSolicitudAvatar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    dateFechaCaducidad.Enabled = true;
                    txtSolicitudAvatar.Text = "";
                    txtDescripcion.Text = "";
                    dateFechaCaducidad.Text = "";
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtUnidadMedida.Text = "";
                    txtCosto.Text = "";
                    break;

                case EstadoMantenimiento.Editar:
                    cmbBodega.Enabled = false;
                    txtECodigoProducto.Enabled = false;
                    txtCantidadXEmpaque.Enabled = false;
                    txtCosto.Enabled = false;
                    dateFechaCaducidad.Enabled = false;
                    
                    break;

                case EstadoMantenimiento.Agregar:
                    txtSolicitudAvatar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtUnidadMedida.Text = "";
                    txtCosto.Text = "";
                    dateFechaCaducidad.Text = "";
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

        private void txtCantidadXEmpaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtCosto.Text.Length; i++)
            {
                if (txtCosto.Text[i] == '.')
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

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DesabilitarProductosDeRegistros();
                e.Handled = true;
            }
        }

        public void DesabilitarProductosDeRegistros()
        {
            gestRegIngProd = new  GestorRegistroIngresoProducto();
            unProducto = new Producto();
            unProducto.codigoAvatar = gridView1.GetFocusedRowCellValue("CodigoAvatar").ToString();

            try
            {

                if (lblIdRegProd.Text != "")
                {

                    foreach (RegistroIngresoProductoDTO unProductoDTO in lista)
                    {
                        if (unProductoDTO.codigoAvatar == unProducto.codigoAvatar)
                        {
                            unProducto.idProducto = unProductoDTO.idProducto;
                            unProducto.nombreProducto = unProductoDTO.nombreProducto;
                        }
                    }

                    if (MessageBox.Show("¿Seguro que desea eliminar al producto " + unProducto.nombreProducto + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gestRegIngProd.EliminarIngresoDeProducto(registroEstatico.Bodega.idRegistroBodega,unProducto, int.Parse(lblIdRegProd.Text), usuarioLogueado);
                        MessageBox.Show("El producto " + unProducto.nombreProducto + " fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista.Clear();
                        gCRegistroProductos();
                    }

                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar al producto " + gridView1.GetFocusedRowCellValue("Nombre").ToString() + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (RegistroIngresoProductoDTO unProductoDTO in lista)
                        {
                            if (unProductoDTO.codigoAvatar == unProducto.codigoAvatar)
                            {
                                lista.Remove(unProductoDTO);
                                break;
                            }
                        }
                        MessageBox.Show("El producto " + gridView1.GetFocusedRowCellValue("Nombre").ToString() + " fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gCRegistroProducto_Click(object sender, EventArgs e)
        {
            mBtnEliminar.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidadXEmpaque.Enabled = true;
            txtECodigoProducto.Text = gridView1.GetFocusedRowCellValue("CodigoAvatar").ToString();
            txtNombreProducto.Text = gridView1.GetFocusedRowCellValue("Nombre").ToString();
            txtUnidadMedida.Text = gridView1.GetFocusedRowCellValue("UnidadMedida").ToString();
            txtCantidadXEmpaque.Text = gridView1.GetFocusedRowCellValue("CantidadPorEmpaque").ToString();
            txtCosto.Text = gridView1.GetFocusedRowCellValue("CostoEmpaque").ToString();
            dateFechaCaducidad.Text = gridView1.GetFocusedRowCellValue("FechaCaducidad").ToString();
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCamposModificar() != true)
            {
                GuardarCambiosRegistroProductos("Modificar");
            }
        }

        public bool ValidarCamposModificar()
        {
            epError.Clear();
            bool error = false;
           
            if (txtSolicitudAvatar.Text.Trim() == "")
            {
                epError.SetError(txtSolicitudAvatar, "Campo Requerido");
                txtSolicitudAvatar.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Campo Requerido");
                txtUsuario.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }

        public bool ValidarCampos()
        {
            epError.Clear();
            bool error = false;
          
            if (txtSolicitudAvatar.Text.Trim() == "")
            {
                epError.SetError(txtSolicitudAvatar, "Campo Requerido");
                txtSolicitudAvatar.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "Campo Requerido");
                txtUsuario.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }
        public bool ValidarCamposAgregarRegistroProducto()
        {
            epError.Clear();
            bool error = false;
            if (txtECodigoProducto.Text.Trim() == "")
            {
                epError.SetError(txtECodigoProducto, "Campo Requerido");
                txtECodigoProducto.Focus();
                error = true;
            }
            if (txtCantidadXEmpaque.Text.Trim() == "")
            {
                epError.SetError(txtCantidadXEmpaque, "Campo Requerido");
                txtCantidadXEmpaque.Focus();
                error = true;
            }
            if (dateFechaCaducidad.Text.Trim() == "")
            {
                epError.SetError(dateFechaCaducidad, "Campo Requerido");
                dateFechaCaducidad.Focus();
                error = true;
            }
            if (txtCosto.Text.Trim() == "")
            {
                epError.SetError(txtCosto, "Campo Requerido");
                txtCosto.Focus();
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
            if (ValidarCampos() != true)
            {
                GuardarCambiosRegistroProductos("Guardar");
            }
        }

        public void GuardarCambiosRegistroProductos(string accionp)
        {
            unRegProd = new RegistroProducto();
            unRegDTO = new RegistroIngresoProductoDTO();
            unProducto = new Producto();
            gestorProducto = new GestorProducto();
            gestorReg = new GestorRegistroProducto();
            gestRegIngProd = new GestorRegistroIngresoProducto();
            RegistroBodega bodega = new RegistroBodega();
            UsuarioTable user = new UsuarioTable();
            gestor = new GestorUsuarioTable();
            try
            {
                user = gestor.ValidarUsuarioPorUsuario(usuarioLogueado);
                unRegProd.Usuario = user;
                unRegProd.descripcion = txtDescripcion.Text;
                unRegProd.solicitudAvatar = txtSolicitudAvatar.Text;
                unRegProd.fechaIngreso = txtFechaRecibido.Text;
                bodega.idRegistroBodega = int.Parse(cmbBodega.SelectedValue.ToString());
                bodega.nombre = cmbBodega.GetItemText(cmbBodega.Items[cmbBodega.SelectedIndex]);
                unRegProd.Bodega = bodega;
                unRegProd.estado = 1;

                if (accionp == "Modificar")
                {
                    unRegProd.idIngresoProducto = int.Parse(lblIdRegProd.Text);
                    gestorReg.ActualizarRegistroProducto(unRegProd, usuarioLogueado);


                }
                else
                {
                    unRegProd.idIngresoProducto = gestorReg.GuardarRegistroProducto(unRegProd, usuarioLogueado);
                }

                foreach (RegistroIngresoProductoDTO unRegIngDTO in lista)
                {
                    unProducto = gestorProducto.ObtenerProductoPorCodigoAvatar(unRegIngDTO.codigoAvatar);
                    unRegDTO.idIngreso = unRegProd.idIngresoProducto;
                    unRegDTO.idBodega = unRegProd.Bodega.idRegistroBodega;
                    unRegDTO.idProducto = unProducto.idProducto;
                    unRegDTO.uCantidad = unRegIngDTO.uCantidad;
                    unRegDTO.nombreProducto = unProducto.nombreProducto;
                    unRegDTO.Idunidad = unProducto.UnidadMedida.idUnidadMedida;
                    unRegDTO.fechaCaducidad = unRegIngDTO.fechaCaducidad;
                    unRegDTO.unidadMedida = unProducto.UnidadMedida.descripcion;
                    unRegDTO.codigoAvatar = unProducto.codigoAvatar;
                    unRegDTO.cantidadPorEmpaque = unRegIngDTO.cantidadPorEmpaque;
                    unRegDTO.costoPorEmpaque = unRegIngDTO.costoPorEmpaque;
                    unRegDTO.estado = 1;
                    gestRegIngProd.ModificarIngresoProducto(unRegDTO, usuarioLogueado);
                }

               
                
                if (accionp == "Modificar")
                {
                    MessageBox.Show("El registro " + unRegProd.descripcion + " fue modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El registro " + unRegProd.descripcion + " fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }



                CambiarEstado(EstadoMantenimiento.Editar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesabilitarProductosDeRegistros();
        }
    }
}
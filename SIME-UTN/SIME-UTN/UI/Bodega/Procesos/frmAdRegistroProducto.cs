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
        }

        public void gCRegistroProductos()
        {
            gestRegIngProd = new GestorRegistroIngresoProducto();

            try
            {
                lblIdRegProd.Text = registroEstatico.idIngresoProducto.ToString();
                //txtNumeroIngreso.Text = registroEstatico.idIngresoProducto.ToString();
                txtSolicitudAvatar.Text = registroEstatico.solicitudAvatar.ToString();
                 // registroEstatico.Usuario.ToString();
                txtDescripcion.Text = registroEstatico.descripcion;
                dateFechaIngreso.Text = registroEstatico.fechaIngreso.ToString();
                dateFechaCaducidad.Text = registroEstatico.fechaCaducidad.ToString();
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
            dt.Columns.Add(new DataColumn("Cantidad"));
            dt.Columns.Add(new DataColumn("UnidadMedida"));
            dt.Columns.Add(new DataColumn("CantidadPorEmpaque"));
            dt.Columns.Add(new DataColumn("CostoEmpaque"));

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoAvatar"] = lista[i].codigoAvatar;
                    dr["Nombre"] = lista[i].nombreProducto;
                    dr["Cantidad"] = lista[i].cantidad;
                    dr["UnidadMedida"] = lista[i].unidadMedida;
                    dr["CantidadPorEmpaque"] = lista[i].cantidadPorEmpaque;
                    dr["CostoEmpaque"] = lista[i].costoPorEmpaque;
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

        public bool ValidarCamposAgregarRegistroProducto()
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
            if (txtCantidadXEmpaque.Text.Trim() == "")
            {
                epError.SetError(txtCantidadXEmpaque, "Campo Requerido");
                txtCantidadXEmpaque.Focus();
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

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCamposAgregarRegistroProducto() != true)
            {
                int index = 0;
                bool existe = false;
                if (lista.Count != 0)
                {
                    existe = true;
                    foreach (RegistroIngresoProductoDTO unIngProdDTO in lista)
                    {
                        if (unIngProdDTO.codigoAvatar == txtECodigoProducto.Text)
                        {
                            lista.RemoveAt(index);
                            break;
                        }
                        index++;
                    }
                }

                RegistroIngresoProductoDTO unIngProd = new RegistroIngresoProductoDTO();
                unIngProd.codigoAvatar = txtECodigoProducto.Text;
                unIngProd.nombreProducto = txtNombreProducto.Text;
                unIngProd.cantidad = double.Parse(txtCantidad.Text);
                unIngProd.unidadMedida = txtUnidadMedida.Text;
                unIngProd.cantidadPorEmpaque = Int16.Parse(txtCantidadXEmpaque.Text);
                unIngProd.costoPorEmpaque = double.Parse(txtCosto.Text);
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
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.UnidadMedidaProducto' table. You can move, or remove it, as needed.
            UsuarioLogueado();
            txtUsuario.Text = usuarioLogueado;
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
                    dateFechaIngreso.Enabled = true;
                    dateFechaCaducidad.Enabled = true;
                    txtSolicitudAvatar.Text = "";
                    txtDescripcion.Text = "";
                    dateFechaIngreso.Text = "";
                    dateFechaCaducidad.Text = "";
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    txtCosto.Text = "";
                    break;

                case EstadoMantenimiento.Editar:
                    break;

                case EstadoMantenimiento.Agregar:
                    txtSolicitudAvatar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    dateFechaIngreso.Enabled = false;
                    dateFechaCaducidad.Enabled = false;
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidadXEmpaque.Text = "";
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    txtCosto.Text = "";
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
                        gestRegIngProd.EliminarIngresoDeProducto(unProducto, int.Parse(lblIdRegProd.Text), usuarioLogueado);
                        MessageBox.Show("El Producto " + unProducto.nombreProducto + " fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("El Producto " + gridView1.GetFocusedRowCellValue("Nombre").ToString() + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCantidad.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidadXEmpaque.Enabled = true;
            txtECodigoProducto.Text = gridView1.GetFocusedRowCellValue("CodigoAvatar").ToString();
            txtNombreProducto.Text = gridView1.GetFocusedRowCellValue("Nombre").ToString();
            txtCantidad.Text = gridView1.GetFocusedRowCellValue("Cantidad").ToString();
            txtUnidadMedida.Text = gridView1.GetFocusedRowCellValue("UnidadMedida").ToString();
            txtCantidadXEmpaque.Text = gridView1.GetFocusedRowCellValue("CantidadPorEmpaque").ToString();
            txtCosto.Text = gridView1.GetFocusedRowCellValue("CostoEmpaque").ToString();
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
            if (dateFechaCaducidad.Text.Trim() == "")
            {
                epError.SetError(dateFechaCaducidad, "Campo Requerido");
                dateFechaCaducidad.Focus();
                error = true;
            }
            if (dateFechaIngreso.Text.Trim() == "")
            {
                epError.SetError(dateFechaIngreso, "Campo Requerido");
                dateFechaIngreso.Focus();
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
            if (dateFechaCaducidad.Text.Trim() == "")
            {
                epError.SetError(dateFechaCaducidad, "Campo Requerido");
                dateFechaCaducidad.Focus();
                error = true;
            }
            if (dateFechaIngreso.Text.Trim() == "")
            {
                epError.SetError(dateFechaIngreso, "Campo Requerido");
                dateFechaIngreso.Focus();
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
            UsuarioTable user = new UsuarioTable();
            gestor = new GestorUsuarioTable();
            // unaMezcla = new Mezcla();
            // unaMezclaProductoUnidadDTO = new MezclaProductoUnidaMedidaDTO();
            // unProducto = new Producto();
            //gestorProducto = new GestorProducto();
            //gestorMezcla = new GestorMezcla();
            //gestorMezclaProducto = new GestorMezclaProducto();
            try
            {
                if (accionp == "Modificar")
                {
                    //UsuarioTable user = new UsuarioTable();
                    user = gestor.ValidarUsuarioPorUsuario(usuarioLogueado);
                    unRegProd.Usuario = user;
                    unRegProd.descripcion = txtDescripcion.Text;
                    unRegProd.solicitudAvatar = txtSolicitudAvatar.Text;
                    unRegProd.fechaIngreso = dateFechaIngreso.Text;
                    unRegProd.fechaCaducidad = dateFechaCaducidad.Text;
                    unRegProd.estado = 1;
                    unRegProd.idIngresoProducto = int.Parse(lblIdRegProd.Text); //o el txtNumeroIngreso????
                    gestorReg.ActualizarRegistroProducto(unRegProd, usuarioLogueado);
                    // unaMezcla.idRegistroMezcla = int.Parse(lblIdMezcla.Text

                    foreach (RegistroIngresoProductoDTO unRegIngDTO in lista)
                    {
                        unProducto = gestorProducto.ObtenerProductoPorCodigoAvatar(unRegIngDTO.codigoAvatar);
                        unRegDTO.idIngreso = unRegProd.idIngresoProducto;
                        unRegDTO.idProducto = unProducto.idProducto;
                        unRegDTO.nombreProducto = unProducto.nombreProducto;
                        unRegDTO.Idunidad = unProducto.UnidadMedida.idUnidadMedida;
                        unRegDTO.unidadMedida = unProducto.UnidadMedida.descripcion;
                        unRegDTO.codigoAvatar = unProducto.codigoAvatar;
                        unRegDTO.cantidad = unRegIngDTO.cantidad;
                        unRegDTO.cantidadPorEmpaque = unRegIngDTO.cantidadPorEmpaque;
                        unRegDTO.costoPorEmpaque = unRegIngDTO.costoPorEmpaque;
                        unRegDTO.estado = 1;
                        gestRegIngProd.ModificarIngresoProducto(unRegDTO, usuarioLogueado);
                    }

                }
                else
                {
                    
                    user = gestor.ValidarUsuarioPorUsuario(usuarioLogueado);
                    unRegProd.Usuario = user;
                    unRegProd.descripcion = txtDescripcion.Text;
                    unRegProd.solicitudAvatar = txtSolicitudAvatar.Text;
                    unRegProd.fechaIngreso = dateFechaIngreso.Text;
                    unRegProd.fechaCaducidad = dateFechaCaducidad.Text;
                    unRegProd.estado = 1;
                    unRegProd.idIngresoProducto = gestorReg.GuardarRegistroProducto(unRegProd, usuarioLogueado);
                    
                    foreach (RegistroIngresoProductoDTO unRegIngDTO in lista)
                    {
                        unProducto = gestorProducto.ObtenerProductoPorCodigoAvatar(unRegIngDTO.codigoAvatar);
                        unRegDTO.idIngreso = unRegProd.idIngresoProducto;
                        unRegDTO.idProducto = unProducto.idProducto;
                        unRegDTO.nombreProducto = unProducto.nombreProducto;
                        unRegDTO.Idunidad = unProducto.UnidadMedida.idUnidadMedida;
                        unRegDTO.unidadMedida = unProducto.UnidadMedida.descripcion;
                        unRegDTO.codigoAvatar = unProducto.codigoAvatar;
                        unRegDTO.cantidad = unRegIngDTO.cantidad;
                        unRegDTO.cantidadPorEmpaque = unRegIngDTO.cantidadPorEmpaque;
                        unRegDTO.costoPorEmpaque = unRegIngDTO.costoPorEmpaque;
                        unRegDTO.estado = 1;
                        gestRegIngProd.GuardarIngresoProducto(unRegDTO, usuarioLogueado);
                    }
                }
                
                if (accionp == "Modificar")
                {
                    MessageBox.Show("El Registro " + unRegProd.descripcion + " fue modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Registro " + unRegProd.descripcion + " fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
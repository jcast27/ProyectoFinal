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
using SIME_UTN.Entities;
using System.Threading;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdMezclas : DevExpress.XtraEditors.XtraForm
    {
        static List<ProductoDTO> listaProductoDTO = new List<ProductoDTO>();
        Mezcla unaMezcla = null;
        MezclaProductoUnidaMedidaDTO unaMezclaProductoUnidadDTO = null;
        Producto unProducto = null;
        GestorProducto gestorProducto = null;
        GestorUsuarioTable gestorUsuario = null;
        GestorUnidadMedida gestorUnidadMedida = null;
        GestorMezcla gestorMezcla = null;
        GestorMezclaProducto gestorMezclaProducto = null;
        static string usuarioLogueado="";
        static Mezcla mezclaEstatica = null;

        public frmAdMezclas()
        {
            InitializeComponent();
           
        }

        public frmAdMezclas(Mezcla mezclaEstaticap)
        {
           
            InitializeComponent();
            mBtnEliminar.Visible = true;
            mBtnNuevo.Visible = false;
            mBtnGuardar.Visible = false;
            mBtnModificar.Visible = true;
            mezclaEstatica = new Mezcla();
            mezclaEstatica = mezclaEstaticap;
            gCMezclas();
        }

        /// <summary>
        /// Metodo que obtiene el usuario loguado
        /// </summary>
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }



        /// <summary>
        /// Metodo que permite llamar a un ventana filtro para seleccionar el producto que se quiere agregar a la mezcla
        /// </summary>
        private void txtECodigoProducto_Click(object sender, EventArgs e)
        {
            frmFiltroProductos ofrmFiltroProductos = new frmFiltroProductos();
            ofrmFiltroProductos.ShowDialog(this);
            this.txtECodigoProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.CodigoAvatar;
            this.txtNombreProducto.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.NombreProducto;
            txtUnidadMedida.Text = ofrmFiltroProductos.Productoseleccionado == null ? "" : ofrmFiltroProductos.Productoseleccionado.UnidadMedida;
            txtCantidad.Enabled = true;
        }


        /// <summary>
        /// Metodo que permite ir agregando al grid los productos que van a conformar la mezcla
        /// </summary>
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

                for (int i = 0; i < listaProductoDTO.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoProducto"] = listaProductoDTO[i].codigoAvatar;
                    dr["Nombre"] = listaProductoDTO[i].nombreProducto;
                    dr["Cantidad"] = listaProductoDTO[i].cantidad;
                    dr["UnidadMedida"] = listaProductoDTO[i].unidadMedida;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCRegistroProducto.DataSource = dt;
        }

        /// <summary>
        /// Metodo que permite agregar un Producto de la mezcla
        /// </summary>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCamposAgregarProducto() != true)
            {
                int index = 0;
                bool existe = false;
                if (listaProductoDTO.Count != 0)
                {
                    existe = true;
                    foreach (ProductoDTO unProductoDTO in listaProductoDTO)
                    {
                        if (unProductoDTO.codigoAvatar == txtECodigoProducto.Text)
                        {
                            listaProductoDTO.RemoveAt(index);
                            break;
                        }
                        index++;
                    }
                }

                ProductoDTO unProducto = new ProductoDTO();
                unProducto.codigoAvatar = txtECodigoProducto.Text;
                unProducto.nombreProducto = txtNombreProducto.Text;
                unProducto.cantidad = double.Parse(txtCantidad.Text);
                unProducto.unidadMedida = txtUnidadMedida.Text;
                if (existe == true)
                {
                    listaProductoDTO.Insert(index, unProducto);
                }
                else
                {
                    listaProductoDTO.Add(unProducto);
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
        }


        /// <summary>
        /// Cambiar el estad de los objetos al seleccionar Nuevo,Editar,Borrar o Ninguno
        /// </summary>
        /// <param name="estado"></param>
        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    epError.Clear();
                    lblIdMezcla.Text = "";
                    listaProductoDTO.Clear();
                    gCRegistroProducto.DataSource = null;
                    gridView1.Columns.Clear();
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.Text = "";
                    txtECodigoProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtNombre.Text = "";
                    txtCantidad.Enabled = false;
                    txtCantidad.Text = "";
                    txtUnidadMedida.Text = "";
                    break;

                case EstadoMantenimiento.Editar:
                    this.Close();
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


        /// <summary>
        /// Metodo que permite limpiar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }



        /// <summary>
        /// Metodo que permite salir de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Invoca al metodo que permite hacerle las validacions pertinentes al campo cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            gestorUnidadMedida = new GestorUnidadMedida();
            if (gestorUnidadMedida.ObtenerUnidadesConDecimales(txtUnidadMedida.Text)!=true)
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
        /// Metodo que asigan los valores del grid control a cada una de la cajas de texto
        /// </summary>
        public void gCMezclas()
        {
            gestorMezclaProducto = new GestorMezclaProducto();

            try
            {
                lblIdMezcla.Text = mezclaEstatica.idRegistroMezcla.ToString();
                txtNombre.Text = mezclaEstatica.nombre;
                txtDescripcion.Text = mezclaEstatica.descripcion;
                listaProductoDTO = gestorMezclaProducto.ObtenerProductosPorIdMezcla(mezclaEstatica.idRegistroMezcla);
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


        /// <summary>
        /// Metodo que guarda los cambios ya sea una nueva mezcla o o si se modifica dicha mezcla
        /// </summary>
        /// <param name="accionp"></param>
        public void GuardarCambiosMezcla(string accionp)
        {
            unaMezcla = new Mezcla();
            unaMezclaProductoUnidadDTO = new MezclaProductoUnidaMedidaDTO();
            unProducto = new Producto();
            gestorProducto = new GestorProducto();
            gestorMezcla = new GestorMezcla();
            gestorMezclaProducto = new GestorMezclaProducto();
            try
            {
                if (accionp == "Modificar")
                {
                    unaMezcla.nombre = txtNombre.Text;
                    unaMezcla.descripcion = txtDescripcion.Text;
                    unaMezcla.estado = 1;
                    unaMezcla.idRegistroMezcla = int.Parse(lblIdMezcla.Text);
                    gestorMezcla.ActualizarMezcla(unaMezcla, usuarioLogueado);
                    foreach (ProductoDTO unProductoDTO in listaProductoDTO)
                    {
                        unProducto = gestorProducto.ObtenerProductoPorCodigoAvatar(unProductoDTO.codigoAvatar);
                        unaMezclaProductoUnidadDTO.idMezcla = unaMezcla.idRegistroMezcla;
                        unaMezclaProductoUnidadDTO.nombreMezcla = unaMezcla.nombre;
                        unaMezclaProductoUnidadDTO.idProducto = unProducto.idProducto;
                        unaMezclaProductoUnidadDTO.nombreProducto = unProductoDTO.nombreProducto;
                        unaMezclaProductoUnidadDTO.idUnidadMedida = unProducto.UnidadMedida.idUnidadMedida;
                        unaMezclaProductoUnidadDTO.nombreUnidadMedida = unProductoDTO.unidadMedida;
                        unaMezclaProductoUnidadDTO.cantidad = unProductoDTO.cantidad;
                        unaMezclaProductoUnidadDTO.estado = 1;
                        gestorMezclaProducto.ModificarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);
                    }

                }else
                {
                    unaMezcla.nombre = txtNombre.Text;
                    unaMezcla.descripcion = txtDescripcion.Text;
                    unaMezcla.estado = 1;
                    unaMezcla.idRegistroMezcla = gestorMezcla.GuardarRegistroMezcla(unaMezcla, usuarioLogueado);

                    foreach (ProductoDTO unProductoDTO in listaProductoDTO)
                    {
                        unProducto = gestorProducto.ObtenerProductoPorCodigoAvatar(unProductoDTO.codigoAvatar);
                        unaMezclaProductoUnidadDTO.idMezcla = unaMezcla.idRegistroMezcla;
                        unaMezclaProductoUnidadDTO.nombreMezcla = unaMezcla.nombre;
                        unaMezclaProductoUnidadDTO.idProducto = unProducto.idProducto;
                        unaMezclaProductoUnidadDTO.nombreProducto = unProductoDTO.nombreProducto;
                        unaMezclaProductoUnidadDTO.idUnidadMedida = unProducto.UnidadMedida.idUnidadMedida;
                        unaMezclaProductoUnidadDTO.nombreUnidadMedida = unProductoDTO.unidadMedida;
                        unaMezclaProductoUnidadDTO.cantidad = unProductoDTO.cantidad;
                        unaMezclaProductoUnidadDTO.estado = 1;
                        gestorMezclaProducto.GuardarMezclaProducto(unaMezclaProductoUnidadDTO, usuarioLogueado);

                    }
                }




                if (accionp == "Modificar")
                {
                    MessageBox.Show("La Mezcla " + unaMezcla.nombre + " fue modificada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Mezcla " + unaMezcla.nombre + " fue agregada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                CambiarEstado(EstadoMantenimiento.Editar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Invoca al metodo desactivar mezcla, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DesabilitarProductosDeMezclas();
                e.Handled = true;
            }

        }


        /// <summary>
        /// Metodo que permite quitar un Producto de la mezcla
        /// </summary>
        public void DesabilitarProductosDeMezclas()
        {
            gestorMezclaProducto = new GestorMezclaProducto();
            unProducto = new Producto();
            unProducto.codigoAvatar = gridView1.GetFocusedRowCellValue("CodigoProducto").ToString();

            try
            {

                if (lblIdMezcla.Text != "")
                {

                    foreach (ProductoDTO unProductoDTO in listaProductoDTO)
                    {
                        if (unProductoDTO.codigoAvatar == unProducto.codigoAvatar)
                        {
                            unProducto.idProducto = unProductoDTO.idProducto;
                            unProducto.nombreProducto = unProductoDTO.nombreProducto;
                        }
                    }

                    if (MessageBox.Show("¿Seguro que desea eliminar al producto " + unProducto.nombreProducto + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        gestorMezclaProducto.EliminarProductoDeMezcla(unProducto, int.Parse(lblIdMezcla.Text), usuarioLogueado);
                        MessageBox.Show("El Producto " + unProducto.nombreProducto + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listaProductoDTO.Clear();
                        gCMezclas();
                    }

                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar al producto " + gridView1.GetFocusedRowCellValue("Nombre").ToString() + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ProductoDTO unProductoDTO in listaProductoDTO)
                        {
                            if (unProductoDTO.codigoAvatar == unProducto.codigoAvatar)
                            {
                                listaProductoDTO.Remove(unProductoDTO);
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


        /// <summary>
        /// Metodo que permite extrae el Producto seleccionado del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCRegistroProducto_Click(object sender, EventArgs e)
        {
            mBtnEliminar.Enabled = true;
            txtCantidad.Enabled = true;
            txtECodigoProducto.Text = gridView1.GetFocusedRowCellValue("CodigoProducto").ToString();
            txtNombreProducto.Text = gridView1.GetFocusedRowCellValue("Nombre").ToString();
            txtUnidadMedida.Text = gridView1.GetFocusedRowCellValue("UnidadMedida").ToString();
            txtCantidad.Text = gridView1.GetFocusedRowCellValue("Cantidad").ToString();
        }


        /// <summary>
        /// Metodo que modifica una mezcla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCamposModificar() != true)
            {
                GuardarCambiosMezcla("Modificar");
            }

          
        }


        /// <summary>
        /// Metodo que desabilita un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesabilitarProductosDeMezclas();
        }


        /// <summary>
        /// Metodo que valida los campos requeridos para poder modficar
        /// </summary>
        /// <returns></returns>
        public bool ValidarCamposModificar()
        {
            bool error = false;
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Campo Requerido");
                txtNombre.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }


        /// <summary>
        /// Metodo que valida los campos requeridos para poder agregar nuevas mezclas
        /// </summary>
        /// <returns></returns>
        public bool ValidarCampos()
        {
            bool error = false;
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Campo Requerido");
                txtNombre.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
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


        /// <summary>
        /// Metodo que valida los campos requeridos para poder agregar productos a la mezcla
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


        /// <summary>
        /// Metodo que guarda una nueva mezcla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() != true)
            {
                GuardarCambiosMezcla("Guardar");
            }
        }
    }
}
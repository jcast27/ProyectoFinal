using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIME_UTN.Entities;
using DevExpress.XtraEditors.Controls;
using SIME_UTN.Gestores;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdProducto : DevExpress.XtraEditors.XtraForm
    {
        Producto unProducto = null;
        Categoria unaCategoria = null;
        Ubicacion unaUbicacion = null;
        UnidadMedida unaUnidadMedida = null;
        GestorProducto gestorProducto = null;
        Producto productoEstatico = null;
        public frmAdProducto()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
           
        }
        public frmAdProducto(Producto productoEstaticop)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            productoEstatico = new Producto();
            productoEstatico = productoEstaticop;
            gCProducto();

        }
        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void frmAdProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUbicacion.sp_SELECT_Ubicacion_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Ubicacion_AllTableAdapter.Fill(this.dataSetUbicacion.sp_SELECT_Ubicacion_All);
            // TODO: This line of code loads data into the 'dataSetCategorias.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dataSetCategorias.Categoria);
            // TODO: This line of code loads data into the 'dataSetUnidadMedida.UnidadMedidaProducto' table. You can move, or remove it, as needed.
            this.unidadMedidaProductoTableAdapter.Fill(this.dataSetUnidadMedida.UnidadMedidaProducto);
            // TODO: This line of code loads data into the 'dataSetCategorias.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dataSetCategorias.Categoria);
            if (productoEstatico == null)
            {
                cmbCategoria.SelectedIndex = -1;
                cmbUnidadMedida.SelectedIndex = -1;
                cmbUbicacion.SelectedIndex = -1;
            }else
            {
                for (int i = 0; i < cmbCategoria.Items.Count; i++)
                {
                    string value = cmbCategoria.GetItemText(cmbCategoria.Items[i]);
                    if (value == productoEstatico.Categoria.descripcion)
                    {
                        cmbCategoria.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cmbUbicacion.Items.Count; i++)
                {
                    string value = cmbUbicacion.GetItemText(cmbUbicacion.Items[i]);
                    if (value == productoEstatico.Ubicacion.nombre)
                    {
                        cmbUbicacion.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cmbUnidadMedida.Items.Count; i++)
                {
                    string value = cmbUnidadMedida.GetItemText(cmbUnidadMedida.Items[i]);
                    if (value == productoEstatico.UnidadMedida.descripcion)
                    {
                        cmbUnidadMedida.SelectedIndex = i;
                    }
                }
            }
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
                    txtNombreProducto.Text = "";
                    txtDescripcion.Text = "";
                    txtCodigoAvatar.Text = "";
                    cmbCategoria.SelectedIndex = -1;
                    cmbUbicacion.SelectedIndex = -1;
                    cmbUnidadMedida.SelectedIndex = -1;
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCProducto()
        {

            try
            {
                txtNombreProducto.Text = productoEstatico.nombreProducto;
                txtDescripcion.Text = productoEstatico.descripcion;
                txtCodigoAvatar.Text = productoEstatico.codigoAvatar;
                lblCodigoProducto.Text = productoEstatico.idProducto.ToString();

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

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestorProducto = GestorProducto.GetInstance();
            unProducto = new Producto();
            unaCategoria = new Categoria();
            unaUbicacion = new Ubicacion();
            unaUnidadMedida = new UnidadMedida();
            try
            {


                string ID = lblCodigoProducto.Text;
                unProducto.idProducto = int.Parse(ID);
                unProducto.nombreProducto = txtNombreProducto.Text;
                unProducto.descripcion = txtDescripcion.Text;
                unProducto.codigoAvatar = txtCodigoAvatar.Text;
                unaCategoria.idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                unProducto.Categoria = unaCategoria;
                unaUbicacion.idUbicacion = int.Parse(cmbUbicacion.SelectedValue.ToString());
                unProducto.Ubicacion = unaUbicacion;
                unaUnidadMedida.idUnidadMedida = int.Parse(cmbUnidadMedida.SelectedValue.ToString());
                unProducto.UnidadMedida = unaUnidadMedida;
                unProducto.estado = 1;
                gestorProducto.AgregarProducto(unProducto);
                gestorProducto.GuardarProducto(unProducto);
                CambiarEstado(EstadoMantenimiento.Editar);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestorProducto = GestorProducto.GetInstance();
            unProducto = new Producto();
            unaCategoria = new Categoria();
            unaUbicacion = new Ubicacion();
            unaUnidadMedida = new UnidadMedida();
            try
            {
                unProducto.nombreProducto = txtNombreProducto.Text;
                unProducto.descripcion = txtDescripcion.Text;
                unProducto.codigoAvatar = txtCodigoAvatar.Text;
                unaCategoria.idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                unProducto.Categoria = unaCategoria;
                unaUbicacion.idUbicacion = int.Parse(cmbUbicacion.SelectedValue.ToString());
                unProducto.Ubicacion = unaUbicacion;
                unaUnidadMedida.idUnidadMedida = int.Parse(cmbUnidadMedida.SelectedValue.ToString());
                unProducto.UnidadMedida = unaUnidadMedida;
                unProducto.estado = 1;
                gestorProducto.AgregarProducto(unProducto);
                gestorProducto.GuardarProducto(unProducto);
                CambiarEstado(EstadoMantenimiento.Editar);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
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
using SIME_UTN.Gestores;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdBodega : DevExpress.XtraEditors.XtraForm
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestorUsuario = null;
        GestorRegistroBodega gestorBodega = null;
        static RegistroBodega bodegaEstatico = null;
        RegistroBodega unaBodega = null;
        TipoBodega unTipoBodega = null;
        Ubicacion unaUbicacion = null;

        public frmAdBodega()
        {
            InitializeComponent();
            this.cmbTipoBodega.SelectedIndex = - 1;
            mBtnModificar.Visible = false;
        }

        public frmAdBodega(RegistroBodega bodegaEstaticop)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            this.cmbTipoBodega.SelectedIndex = -1;
            bodegaEstatico = new RegistroBodega();
            bodegaEstatico = bodegaEstaticop;
            gCBodegas();
        }

        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void frmAdBodega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUbicacion.sp_SELECT_Ubicacion_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Ubicacion_AllTableAdapter.Fill(this.dataSetUbicacion.sp_SELECT_Ubicacion_All);
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetTipoBodegaCMB.sp_SELECT_TipoBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_TipoBodega_AllTableAdapter.Fill(this.dataSetTipoBodegaCMB.sp_SELECT_TipoBodega_All);
            UsuarioLogueado();
            if (bodegaEstatico == null)
            {
                cmbTipoBodega.SelectedIndex = -1;

            }
            else
            {
                for (int i = 0; i < cmbTipoBodega.Items.Count; i++)
                {
                    string value = cmbTipoBodega.GetItemText(cmbTipoBodega.Items[i]);
                    if (value == bodegaEstatico.TipoBodega.descripcion)
                    {
                        cmbTipoBodega.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < cmbUbicacion.Items.Count; i++)
                {
                    string value = cmbUbicacion.GetItemText(cmbUbicacion.Items[i]);
                    if (value == bodegaEstatico.Ubicacion.nombre)
                    {
                        cmbUbicacion.SelectedIndex = i;
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
                    txtBodega.Text = "";
                    txtDescripcion.Text = "";
                    cmbTipoBodega.SelectedIndex = -1;
                    chkedEstado.Checked = false;
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        /// <summary>
        /// Metodo que asigan los valores del grid control a cada una de la cajas de texto
        /// </summary>
        public void gCBodegas()
        {

            try
            {
                txtBodega.Text = bodegaEstatico.nombre;
                txtDescripcion.Text = bodegaEstatico.descripcion;
                lblCodigoBodega.Text = bodegaEstatico.idRegistroBodega.ToString();

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
            if (ValidarCampos() == false)
            {
                string accion = "Modificar";
                GuardarCambiosBodega(accion);
            }
        }

        /// <summary>
        /// Metodo que guarda los cambios ya sea un nuevo producto o si se modifica dicho producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void GuardarCambiosBodega(string accionp)
        {
            gestorBodega = GestorRegistroBodega.GetInstance();
            unaBodega = new RegistroBodega();
            unTipoBodega = new TipoBodega();
            unaUbicacion = new Ubicacion();
            try
            {

                unaBodega.nombre = txtBodega.Text;
                unaBodega.descripcion = txtDescripcion.Text;
                unTipoBodega.idTipoBodega = int.Parse(cmbTipoBodega.SelectedValue.ToString());
                unTipoBodega.descripcion = cmbTipoBodega.GetItemText(cmbTipoBodega.Items[cmbTipoBodega.SelectedIndex]);
                unaBodega.TipoBodega = unTipoBodega;
                unaUbicacion.idUbicacion = int.Parse(cmbUbicacion.SelectedValue.ToString());
                unaUbicacion.nombre = cmbUbicacion.GetItemText(cmbUbicacion.Items[cmbUbicacion.SelectedIndex]);
                unaBodega.Ubicacion = unaUbicacion;
                unaBodega.estado = 1;
                if (accionp == "Modificar")
                {
                    string idBodega = lblCodigoBodega.Text;
                    unaBodega.idRegistroBodega = int.Parse(idBodega);
                    gestorBodega.AgregarBodega(unaBodega);
                    gestorBodega.GuardarBodega(unaBodega,usuarioLogueado);
                    MessageBox.Show("La Bodega: " + unaBodega.nombre + " fue modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gestorBodega.AgregarBodega(unaBodega);
                    gestorBodega.GuardarBodega(unaBodega, usuarioLogueado);
                    MessageBox.Show("La Bodega: " + unaBodega.nombre + " fue agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CambiarEstado(EstadoMantenimiento.Editar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                string accion = "";
                GuardarCambiosBodega(accion);
            }
        }
        public bool ValidarCampos()
        {
            bool error = false;
            if (txtBodega.Text.Trim() == "")
            {
                epError.SetError(txtBodega, "Campo Requerido");
                txtBodega.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
            if (cmbTipoBodega.SelectedIndex == -1)
            {
                epError.SetError(cmbTipoBodega, "Campo Requerido");
                cmbTipoBodega.Focus();
                error = true;
            }
            if (cmbUbicacion.SelectedIndex == -1)
            {
                epError.SetError(cmbUbicacion, "Campo Requerido");
                cmbUbicacion.Focus();
                error = true;
            }
            if (chkedEstado.Checked == false)
            {
                epError.SetError(chkedEstado, "Campo Requerido");
                chkedEstado.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }
            return error;
        }
    }
}
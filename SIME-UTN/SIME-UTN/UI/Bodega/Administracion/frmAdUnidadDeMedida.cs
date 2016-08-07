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
using SIME_UTN.Entities;

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdUnidadMedida : DevExpress.XtraEditors.XtraForm
    {
        UnidadMedida unaUnidadMedida = null;
        GestorUnidadMedida gestorUnidad = null;
        GestorUsuarioTable gestorUsuario = null;
        UnidadMedida unidadEstatica = null;
        static string usuarioLogueado = "";
        public frmAdUnidadMedida()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
        }

        public frmAdUnidadMedida(UnidadMedida unidadEstaticaP)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            unidadEstatica = new UnidadMedida();
            unidadEstatica = unidadEstaticaP;
            gCUnidadesMedida();

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

        private void frmAdUnidadMedida_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCUnidadesMedida()
        {

            try
            {
                txtCodigo.Text = unidadEstatica.codigo;
                txtDescripcion.Text = unidadEstatica.descripcion;
                lblCodigoUnidad.Text = unidadEstatica.idUnidadMedida.ToString();
                if (unidadEstatica.decimales == 1)
                {
                    chkDecimales.Checked = true;
                }else
                {
                    chkDecimales.Checked = false;
                }

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

        public void GuardarCambiosUnidad(string accionp)
        {
            gestorUnidad = GestorUnidadMedida.GetInstance();
            unaUnidadMedida = new UnidadMedida();
            try
            {
                unaUnidadMedida.descripcion = txtDescripcion.Text;
                unaUnidadMedida.codigo = txtCodigo.Text;
                unaUnidadMedida.estado = 1;
                if (chkDecimales.Checked == true)
                {
                    unaUnidadMedida.decimales = 1;
                }else
                {
                    unaUnidadMedida.decimales = 0;
                }

                if (accionp == "Modificar")
                {
                    string idUnidad = lblCodigoUnidad.Text;
                    unaUnidadMedida.idUnidadMedida = int.Parse(idUnidad);
                    gestorUnidad.AgregarUnidad(unaUnidadMedida);
                    gestorUnidad.GuardarUnidad(unaUnidadMedida, usuarioLogueado);
                    MessageBox.Show("La unidad de medida " + unaUnidadMedida.descripcion + " fue modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gestorUnidad.AgregarUnidad(unaUnidadMedida);
                    gestorUnidad.GuardarUnidad(unaUnidadMedida, usuarioLogueado);
                    MessageBox.Show("La unidad de medida " + unaUnidadMedida.descripcion + " fue agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CambiarEstado(EstadoMantenimiento.Editar);

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
                GuardarCambiosUnidad(accion);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambiosUnidad("");
            }
        }

        public bool ValidarCampos()
        {
            bool error = false;
            if (txtCodigo.Text.Trim() == "")
            {
                epError.SetError(txtCodigo, "Campo Requerido");
                txtCodigo.Focus();
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
    }
}
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
    public partial class frmAdUbicaciones : DevExpress.XtraEditors.XtraForm
    {
        UnidadMedida unaUnidadMedida = null;
        GestorUnidadMedida gestorUnidad = null;
        GestorUsuarioTable gestorUsuario = null;
        UnidadMedida unidadEstatica = null;
        static string usuarioLogueado = "";
        public frmAdUbicaciones()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
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

        private void frmAdUbicaciones_Load(object sender, EventArgs e)
        {
            UsuarioLogueado();
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombre.Text = "";
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
  
            try
            {
               

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

            return error;
        }


    }
}
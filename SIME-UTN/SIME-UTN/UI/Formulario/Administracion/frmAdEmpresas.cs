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

namespace SIME_UTN.UI.Formulario.Administracion
{
    public partial class frmAdEmpresas : DevExpress.XtraEditors.XtraForm
    {
        GestorUsuarioTable gestorUsuario = null;
        GestorEmpresa gestorEmpresa = null;
        static Empresa empresaEstatica = null;
        Empresa unaEmpresa = null;
        static string usuarioLogueado = "";
        public frmAdEmpresas()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
            empresaEstatica = null;
        }

        public frmAdEmpresas(Empresa empresaEstaticap)
        {
            InitializeComponent();
            empresaEstatica = new Empresa();
            empresaEstatica = empresaEstaticap;
            mBtnGuardar.Visible = false;
            mBtnModificar.Visible = true;
            gCUEmpresa();
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

        private void frmAdEmpresas_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetUDepartamento.sp_SELECT_Departamento_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Departamento_AllTableAdapter.Fill(this.dataSetUDepartamento.sp_SELECT_Departamento_All);
            UsuarioLogueado();
        }


        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtTelefono.Text = "";
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCUEmpresa()
        {

            try
            {
                lblIdEmpresa.Text = empresaEstatica.idEmpresa.ToString();
                txtNombre.Text = empresaEstatica.nombre;
                txtTelefono.Text = empresaEstatica.telefono;
                txtCedula.Text = empresaEstatica.cedulaJuridica;

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

        public void GuardarCambios(string accionp)
        {
            gestorEmpresa = new GestorEmpresa();
            unaEmpresa = new Empresa();
            try
            {
                unaEmpresa.nombre = txtNombre.Text;
                unaEmpresa.cedulaJuridica = txtCedula.Text;
                unaEmpresa.telefono = txtTelefono.Text;
                unaEmpresa.estado = 1;
                if (accionp == "Modificar")
                {
                    string idEmpresa= lblIdEmpresa.Text;
                    unaEmpresa.idEmpresa = int.Parse(idEmpresa);
                    gestorEmpresa.AgregarEmpresa(unaEmpresa);
                    gestorEmpresa.GuardarEmpresa(unaEmpresa, usuarioLogueado);
                    MessageBox.Show("La Empresa " + unaEmpresa.nombre + " fue modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  
                    gestorEmpresa.AgregarEmpresa(unaEmpresa);
                    gestorEmpresa.GuardarEmpresa(unaEmpresa, usuarioLogueado);
                    MessageBox.Show("La Empresa" + unaEmpresa.nombre + " fue agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CambiarEstado(EstadoMantenimiento.Editar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Campo Requerido");
                txtCedula.Focus();
                error = true;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                epError.SetError(txtTelefono, "Campo Requerido");
                txtTelefono.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }

            return error;
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }

        private void mBtnModificar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambios("Modificar");
            }
        }

        private void mBtnGuardar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambios("");
            }
        }
    }
}
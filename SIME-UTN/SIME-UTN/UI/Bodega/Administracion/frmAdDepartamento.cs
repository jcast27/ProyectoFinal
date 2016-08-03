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
    public partial class frmAdDepartamento : DevExpress.XtraEditors.XtraForm
    {
        Departamento unDepto = null;
        GestorDepartamento gestorDepto = null;
        GestorUsuarioTable gestorUsuario = null;
        Departamento deptoEstatico = null;
        static string usuarioLogueado = "";
        public frmAdDepartamento()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
        }



        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        public frmAdDepartamento(Departamento deptoEstaticop)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            deptoEstatico = new Departamento();
            deptoEstatico = deptoEstaticop;
            gCDepartamento();

        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void frmAdDepartamento_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombre.Text = "";
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCDepartamento()
        {

            try
            {
                txtNombre.Text = deptoEstatico.descripcion;
                lblCodigoDepartamento.Text = deptoEstatico.idDepartamento.ToString();

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

        public void GuardarCambiosDepartamento(string accionp)
        {
            gestorDepto = GestorDepartamento.GetInstance();
            unDepto = new Departamento();

            try
            {
                unDepto.descripcion = txtNombre.Text;
                unDepto.estado = 1;

                if (accionp == "Modificar")
                {
                    string idDepto = lblCodigoDepartamento.Text;
                    unDepto.idDepartamento = int.Parse(idDepto);
                    gestorDepto.AgregarDepartamento(unDepto);
                    gestorDepto.GuardarDepartamento(unDepto, usuarioLogueado);
                    MessageBox.Show("El departamento " + unDepto.descripcion + " fue modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gestorDepto.AgregarDepartamento(unDepto);
                    gestorDepto.GuardarDepartamento(unDepto, usuarioLogueado);
                    MessageBox.Show("El departamento " + unDepto.descripcion + " fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GuardarCambiosDepartamento(accion);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambiosDepartamento("");
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
            return error;
        }


    }
}
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
    public partial class frmAdFuncionario : DevExpress.XtraEditors.XtraForm
    {
        Funcionario unFuncionario = null;
        Departamento unDepto = null;
        GestorFuncionario gestorFuncionario = null;
        GestorUsuarioTable gestorUsuario = null;
        Funcionario funcionarioEstatico = null;
        static string usuarioLogueado = "";


        public frmAdFuncionario()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
        }

        public frmAdFuncionario(Funcionario funcionarioEstaticop)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            funcionarioEstatico = new Funcionario();
            funcionarioEstatico = funcionarioEstaticop;
            gCFuncionario();

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

        private void frmAdFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDepartamento.sp_SELECT_Departamento_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Departamento_AllTableAdapter.Fill(this.dataSetDepartamento.sp_SELECT_Departamento_All);
            Icon = Properties.Resources.Icono;
          

            UsuarioLogueado();
            if (funcionarioEstatico == null)
            {
                cmbDepartamento.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cmbDepartamento.Items.Count; i++)
                {
                    string value = cmbDepartamento.GetItemText(cmbDepartamento.Items[i]);
                    if (value == funcionarioEstatico.Departamento.descripcion)
                    {
                        cmbDepartamento.SelectedIndex = i;
                    }
                }
            }
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombreFuncionario.Text = "";
                    txtCedula.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    cmbDepartamento.SelectedIndex = -1;
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCFuncionario()
        {

            try
            {
                txtNombreFuncionario.Text = funcionarioEstatico.nombre;
                txtCedula.Text = funcionarioEstatico.cedula;
                txtCorreo.Text = funcionarioEstatico.correo;
                txtTelefono.Text = funcionarioEstatico.telefono;
                lblCodigoFuncionario.Text = funcionarioEstatico.idFuncionario.ToString();

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

        public void GuardarCambiosFuncionario(string accionp)
        {
            gestorFuncionario = GestorFuncionario.GetInstance();
            unFuncionario = new Funcionario();
            unDepto = new Departamento();
            try
            {
                unFuncionario.nombre = txtNombreFuncionario.Text;
                unFuncionario.cedula = txtCedula.Text;
                unFuncionario.correo = txtCorreo.Text;
                unFuncionario.telefono = txtTelefono.Text;
                unDepto.idDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                unDepto.descripcion = cmbDepartamento.GetItemText(cmbDepartamento.Items[cmbDepartamento.SelectedIndex]);
                unFuncionario.Departamento = unDepto;
                unFuncionario.estado = 1;
                if (accionp == "Modificar")
                {
                    string idFuncionario = lblCodigoFuncionario.Text;
                    unFuncionario.idFuncionario = int.Parse(idFuncionario);
                    gestorFuncionario.AgregarFuncionario(unFuncionario);
                    gestorFuncionario.GuardarFuncionario(unFuncionario, usuarioLogueado);
                    MessageBox.Show("El funcionario " + unFuncionario.nombre + " fue modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gestorFuncionario.AgregarFuncionario(unFuncionario);
                    gestorFuncionario.GuardarFuncionario(unFuncionario, usuarioLogueado);
                    MessageBox.Show("El funcionario " + unFuncionario.nombre + " fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtNombreFuncionario.Text.Trim() == "")
            {
                epError.SetError(txtNombreFuncionario, "Campo Requerido");
                txtNombreFuncionario.Focus();
                error = true;
            }
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Campo Requerido");
                txtCedula.Focus();
                error = true;
            }
            if (txtCorreo.Text.Trim() == "")
            {
                epError.SetError(txtCorreo, "Campo Requerido");
                txtCorreo.Focus();
                error = true;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                epError.SetError(txtTelefono, "Campo Requerido");
                txtTelefono.Focus();
                error = true;
            }
            if (cmbDepartamento.SelectedIndex == -1)
            {
                epError.SetError(cmbDepartamento, "Campo Requerido");
                cmbDepartamento.Focus();
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
            if (ValidarCampos() == false)
            {
                string accion = "Modificar";
                GuardarCambiosFuncionario(accion);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambiosFuncionario("");
            }
        }
    }
}
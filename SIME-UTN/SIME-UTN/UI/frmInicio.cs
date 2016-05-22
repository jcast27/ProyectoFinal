using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SIME_UTN.Gestores;
using SIME_UTN.Entities;

namespace SIME_UTN.UI
{
    public partial class frmInicio : Form
    {
        private int contador = 0;
        GestorUsuarioTable gestor = null;
        public frmInicio()
        {

            InitializeComponent();

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text.Trim().Length != 0)
            {
                this.errorProvider1.Clear();
            }
            else
            {
                this.errorProvider1.SetError(txtUsuario, "Usuario requerido");
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (this.txtContrasena.Text.Trim().Length != 0)
            {
                this.errorProvider1.Clear();
            }
            else
            {
                this.errorProvider1.SetError(txtContrasena, "Usuario requerido");
            }
        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();

            if (this.txtUsuario.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtUsuario, "Usuario requerido");
                txtUsuario.Focus();
                return;
            }

            if (this.txtContrasena.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtUsuario, "Contraseña requerida");
                txtContrasena.Focus();
                return;
            }

            try
            {
                gestor = GestorUsuarioTable.GetInstance();
                UsuarioDB oUsuario = UsuarioDB.GetInstance();
                oUsuario.usuario = txtUsuario.Text.Trim();

                //Se utliza el gestor User, para almacenar el usuario que ingresa al programa
                gestor.InsertarNombreUsuario(txtUsuario.Text.Trim());
                oUsuario.contrasenna = txtContrasena.Text.Trim();
                //  validar la conexion 
                BLL.LoginBLL.Conexion(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                // devolver OK
                this.DialogResult = DialogResult.OK;
                // Cerrar ventana de Login
                Close();
            }
            catch (Exception error)
            {
                // se devuelve Cancel
                this.DialogResult = DialogResult.Cancel;

                // Incrementar el contador
                contador++;

                // Si el mensaje es "Error de inicio de sesión del usuario" es un error de usuario inválido 
                if (error.Message.Trim().Contains("Error de inicio de sesión del usuario") == true || error.Message.Trim().Contains("Login failed") == true)
                    MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    // otro Error
                    MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si el contador es 3 cierre la aplicación
                if (contador == 3)
                {
                    Close();
                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

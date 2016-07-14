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
        private int modulo = 0;
        GestorUsuarioTable gestor = null;
        public int Modulo
        {
            get
            {
                return modulo;
            }

            set
            {
                modulo = value;
            }
        }

        public frmInicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que valida el Usuario y crea una conexion a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                this.errorProvider1.SetError(txtContrasena, "Contraseña requerida");
                txtContrasena.Focus();
                return;
            }

            if (cmbModulo.SelectedIndex == -1)
            {
                this.errorProvider1.SetError(cmbModulo, "Modulo requerida");
                cmbModulo.Focus();
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
                // modulo seleccionado
                Modulo = cmbModulo.SelectedIndex;
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


        /// <summary>
        /// Metodo que cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            validateKey(e);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            validateKey(e);
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            validateKey(e);
        }

        private void cmbModulo_KeyDown(object sender, KeyEventArgs e)
        {
            validateKey(e);
        }

        private void validateKey(KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }
    }
}

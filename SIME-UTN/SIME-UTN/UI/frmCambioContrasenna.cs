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

namespace SIME_UTN.UI
{
    public partial class frmCambioContrasenna : DevExpress.XtraEditors.XtraForm
    {
        GestorUsuarioTable gestor = null;

        public frmCambioContrasenna(string usuarioLogueado)
        {
            InitializeComponent();
            txtUsuario.Text = usuarioLogueado;
        }



        /// <summary>
        /// Metodo que valida el Usuario y crea una conexion a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            this.errorProvider1.Clear();

            if (this.txtUsuario.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtUsuario, "Usuario requerido");
                txtUsuario.Focus();
                return;
            }

            if (this.txtContrasennaAntigua.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtContrasennaAntigua, "Contraseña requerida");
                txtContrasennaAntigua.Focus();
                return;
            }
            if (this.txtContrasennaNueva.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtContrasennaNueva, "Contraseña requerida");
                txtContrasennaNueva.Focus();
                return;
            }
            if (this.txtConfirmarContrasenna.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtConfirmarContrasenna, "Contraseña requerida");
                txtConfirmarContrasenna.Focus();
                return;
            }

            try
            {

                if (txtContrasennaNueva.Text.Trim() == txtConfirmarContrasenna.Text.Trim())
                {
                    bool cambio = false;
                    gestor = GestorUsuarioTable.GetInstance();
                    UsuarioTable oUsuario = new UsuarioTable();
                    UsuarioDB oUsuarioDB = UsuarioDB.GetInstance();
                    Encriptar encriptar = new Encriptar();
                    oUsuario = gestor.ValidarUsuarioPorUsuario(txtUsuario.Text.Trim());
                    if (oUsuario != null)
                    {
                        if (encriptar.Descifrar(oUsuario.contrasena) == txtContrasennaAntigua.Text.Trim())
                        {
                            oUsuarioDB.usuario = oUsuario.usuario;
                            oUsuarioDB.contrasenna = encriptar.Descifrar(oUsuario.contrasena);
                            cambio = gestor.CambiarContrasenna(txtUsuario.Text.Trim(), txtContrasennaAntigua.Text.Trim(), txtContrasennaNueva.Text.Trim());
                            if (cambio == true)
                            {
                                oUsuarioDB.usuario = txtUsuario.Text.Trim();
                                oUsuarioDB.contrasenna = txtContrasennaNueva.Text.Trim();
                                MessageBox.Show("Contraseña fue cambiada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Antigua Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtContrasennaAntigua.Text = "";

                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarContrasenna.Text = "";
                    txtContrasennaNueva.Text = "";
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

  
    }
}
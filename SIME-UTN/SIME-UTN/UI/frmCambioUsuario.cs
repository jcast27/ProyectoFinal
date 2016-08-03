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
    public partial class frmCambioUsuario : DevExpress.XtraEditors.XtraForm
    {
        GestorUsuarioTable gestor = null;

        public frmCambioUsuario(string usuarioLogueado)
        {
            InitializeComponent();
            lblSesion.Text = "En Sesion: " + usuarioLogueado;
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

            if (this.txtContrasenna.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtContrasenna, "Contraseña requerida");
                txtContrasenna.Focus();
                return;
            }

            gestor = GestorUsuarioTable.GetInstance();
                UsuarioTable oUsuario = new UsuarioTable();
                UsuarioDB oUsuario1 = UsuarioDB.GetInstance();
                oUsuario1.usuario = txtUsuario.Text.Trim();
                Encriptar encriptar = new Encriptar();
                oUsuario1.contrasenna = txtContrasenna.Text.Trim();
                oUsuario = gestor.ValidarUsuarioPorUsuario(txtUsuario.Text.Trim());

                if(oUsuario != null)
                {
                   
                if (encriptar.Descifrar(oUsuario.contrasena) == txtContrasenna.Text.Trim())
                    {
                    //Se utliza el gestor User, para almacenar el usuario que ingresa al programa
                 
                    gestor.InsertarNombreUsuario(txtUsuario.Text.Trim());
                       

                    //ValidarUsuarioPorUsuario


                    //  validar la conexion 
                    BLL.LoginBLL.Conexion(txtUsuario.Text.Trim(), txtContrasenna.Text.Trim());
                        // devolver OK
                        this.DialogResult = DialogResult.OK;
                        // Cerrar ventana de Login
                        MessageBox.Show("Usuario fue cambiado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    Close();
                    }else
                    {
                        MessageBox.Show("Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenna.Text = "";
                   
                    }

                }else
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContrasenna.Text = "";
            }

               
               
        }

        private void frmCambioUsuario_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }
    }
}
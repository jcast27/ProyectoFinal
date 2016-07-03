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
    public partial class frmAdUsuario : DevExpress.XtraEditors.XtraForm
    {
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        static UsuarioTable usuarioStatic = new UsuarioTable();
        static string usuarioLogueado = "";
        public frmAdUsuario()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }


        public frmAdUsuario(UsuarioTable usuarioStaticp)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            usuarioStatic = usuarioStaticp;
            gCUsuarios();
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
            this.Close();
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
                    txtNombre.Text = "";
                    txtApellido1.Text = "";
                    txtApellido2.Text = "";
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtConfirmacion.Text = "";
                    txtNombre.Enabled = true;
                    txtApellido1.Enabled = true;
                    txtApellido2.Enabled = true;
                    txtPassword.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    txtConfirmacion.Enabled = false;
                    this.txtPassword.Enabled = true;
                    this.txtConfirmacion.Enabled = true;
                    this.chkAdministrador.Enabled = true;
                    this.chkDespachador.Enabled = true;
                    this.chkAdministrador.Checked = false;
                    this.chkDespachador.Checked = false;
                    break;

                case EstadoMantenimiento.Editar:
                    this.chkAdministrador.Enabled = true;
                    this.chkDespachador.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido1.Enabled = true;
                    txtApellido2.Enabled = true;
                    txtPassword.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    txtConfirmacion.Enabled = false;
                    break;
                case EstadoMantenimiento.Agregar:
                    txtNombre.Enabled = false;
                    txtApellido1.Enabled = false;
                    txtApellido2.Enabled = false;
                    txtPassword.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    txtConfirmacion.Enabled = false;
                    this.chkAdministrador.Enabled = false;
                    this.chkDespachador.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Metodo que valida los campos antes de guardar el usuario
        /// </summary>
        public void ValidarCampos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                ePError.SetError(txtNombre, "Campo Usuario en Blanco");
                txtNombre.Focus();
            }
            else
            {
                ePError.Clear();
            }
            if (txtPassword.Text.Trim() == "")
            {
                ePError.SetError(txtPassword, "Campo Password en Blanco");
                txtPassword.Focus();
            }
            else
            {
                ePError.Clear();
            }
            if (txtConfirmacion.Text.Trim() == "")
            {
                ePError.SetError(txtConfirmacion, "Campo Confirmacion en Blanco");
                txtConfirmacion.Focus();
            }
            else
            {
                ePError.Clear();
            }
        }

        #region Checkbox de Agregar Usuarios y Permisos

        /// <summary>
        /// Metodo que valida que checkbox esta o no seleecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAdministrador_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkAdministrador.Checked)
            {


                chkDespachador.Checked = false;

            }
            else
            {

                chkAdministrador.Checked = false;
                chkDespachador.Checked = true;


            }

        }

        /// <summary>
        /// Metodo que valida que checkbox esta o no seleecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkDespachador_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkDespachador.Checked)
            {

                chkAdministrador.Checked = false;
            }
            else
            {


                chkDespachador.Checked = false;
                chkAdministrador.Checked = true;

            }
        }


        #endregion



        private void frmAdUsuario_Load(object sender, EventArgs e)
        {

            UsuarioLogueado();
        }

        private void gCUsuarios()
        {
            CambiarEstado(EstadoMantenimiento.Editar);

            try
            {
                string perfil = "";
                lblCodigoUsuario.Text = usuarioStatic.codigoUsuario.ToString();
                txtNombre.Text = usuarioStatic.nombre;
                txtApellido1.Text = usuarioStatic.apellido1;
                txtApellido2.Text = usuarioStatic.apellido2;
                txtUsuario.Text = usuarioStatic.usuario;
                perfil = usuarioStatic.perfil;
                if (perfil.Equals("Administrador"))
                {
                    this.chkAdministrador.Checked = true;
                    this.chkDespachador.Checked = false;
                }
                else
                {
                    if (perfil.Equals("Despachador"))
                    {
                        this.chkAdministrador.Checked = false;
                        this.chkDespachador.Checked = true;
                    }
                    else
                    {
                        this.chkAdministrador.Checked = false;
                        this.chkDespachador.Checked = false;
                    }
                }


                CambiarEstado(EstadoMantenimiento.Editar);



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
            gestor = GestorUsuarioTable.GetInstance();
            usuario = new UsuarioTable();
            try
            {


                string ID = lblCodigoUsuario.Text;
                usuario.codigoUsuario = int.Parse(ID);
                usuario.nombre = txtNombre.Text;
                usuario.apellido1 = txtApellido1.Text;
                usuario.apellido2 = txtApellido2.Text;
                usuario.usuario = txtUsuario.Text;
                if (chkAdministrador.Checked)
                {
                    usuario.perfil = "Administrador";
                }
                if (chkDespachador.Checked)
                {
                    usuario.perfil = "Despachador";
                }
                usuario.estado = 1;
                gestor.AgregarUsuario(usuario);
                gestor.GuardarUsuario(usuarioLogueado);
                MessageBox.Show("El Usuario " + usuario.usuario + " fue modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CambiarEstado(EstadoMantenimiento.Nuevo);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnGuardar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuario = new UsuarioTable();

            try
            {
                if (txtPassword.Text.Trim() != "" && txtConfirmacion.Text.Trim() != "")
                {
                    if (txtPassword.Text.Equals(txtConfirmacion.Text))
                    {

                        usuario.nombre = txtNombre.Text;
                        usuario.apellido1 = txtApellido1.Text;
                        usuario.apellido2 = txtApellido2.Text;
                        usuario.contrasena = txtPassword.Text;
                        string user = (txtNombre.Text.Substring(0, 1) + txtApellido1.Text).ToLower();
                        int numeroUsuario = gestor.ValidarUsuario(user);
                        if (numeroUsuario == 0)
                        {

                        }
                        else
                        {
                            user += numeroUsuario;
                        }

                        usuario.usuario = user;

                        if (chkAdministrador.Checked)
                        {
                            usuario.perfil = "Administrador";
                        }
                        if (chkDespachador.Checked)
                        {
                            usuario.perfil = "Despachador";
                        }
                        usuario.estado = 1;


                        gestor.AgregarUsuario(usuario);
                        gestor.GuardarUsuario(usuarioLogueado);
                        txtUsuario.Text = user;
                        MessageBox.Show("El Usuario " + usuario.usuario + " fue agregado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CambiarEstado(EstadoMantenimiento.Nuevo);
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Confirmar contrasena", "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
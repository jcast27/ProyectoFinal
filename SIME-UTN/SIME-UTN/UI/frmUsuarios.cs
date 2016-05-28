using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIME_UTN.Entities;
using SIME_UTN.Gestores;

namespace SIME_UTN.UI
{
    public partial class frmUsuarios : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        static string nombre = "";
        public  frmUsuarios()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sIMEUTNDataSet.Usuario' table. You can move, or remove it, as needed.

            try
            {

                RefrescarLista();
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

       

        /// <summary>
        /// Actualiza el datagridview con los usuarios agredados
        /// </summary>
       private void RefrescarLista()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Usuarios";
            dt.Columns.Add(new DataColumn("CodigoUsuario"));
            dt.Columns.Add(new DataColumn("Usuario"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("PrimerApellido"));
            dt.Columns.Add(new DataColumn("SegundoApellido"));
            dt.Columns.Add(new DataColumn("Perfil"));

            try
            {
                gestor = GestorUsuarioTable.GetInstance();
               
                List<UsuarioTable> lista = new List<UsuarioTable>(gestor.ObtenerUsuarios());
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoUsuario"] = lista[i].codigoUsuario;
                    dr["Usuario"] = lista[i].usuario;
                    dr["Nombre"] = lista[i].nombre;
                    dr["PrimerApellido"] = lista[i].apellido1;
                    dr["SegundoApellido"] = lista[i].apellido2;
                    dr["Perfil"] = lista[i].perfil;
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.gCUsuarios.DataSource = dt;
        }   


        /// <summary>
        /// Cambiar el estad de los objetos al seleccionar Nuevo,Editar,Borrar o Ninguno
        /// </summary>
        /// <param name="estado"></param>
        public  void CambiarEstado(EstadoMantenimiento estado)
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
                    this.mBtnNuevo.Enabled = true;
                    this.mBtnAgregar.Enabled = true;
                    this.mBtnModificar.Enabled = false;
                    this.mBtnEliminar.Enabled = false;
                    this.txtPassword.Enabled = true;
                    this.txtConfirmacion.Enabled = true;
                    this.chkAdministrador.Enabled = true;
                    this.chkDespachador.Enabled = true;
                    this.chkAdministrador.Checked = false;
                    this.chkDespachador.Checked = false;
                    break;

                case EstadoMantenimiento.Editar:
                    this.mBtnNuevo.Enabled = false;
                    this.mBtnAgregar.Enabled = false;
                    this.mBtnModificar.Enabled = true;
                    this.mBtnEliminar.Enabled = true;
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
        /// Metodo que cierra la ventana Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripbtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /// <summary>
        /// Metodo que cierra la ventana Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /// <summary>
        /// Manda a llamar al metodo Refresca Lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
           RefrescarLista();
        }





        #region Checkbox de Agregar Usuarios y Permisos
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

        public void validarCheckBox()
        {

        }
        #endregion

        #region Checkbox de Modificar y Eliminar Usuarios


        #endregion

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
          
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                this.UsuarioLogueado();
                string usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString(); ;
                int UsuarioID = Int32.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());
                if (usuario == usuarioLogueado)
                {
                    MessageBox.Show("El usuario: "+ usuario +" tiene sesiones abierta, no se puede eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { 

                if (MessageBox.Show("¿Seguro que desea eliminar al Usuario " + usuario + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestor.EliminarUsuario(UsuarioID, usuario);
                        MessageBox.Show("El Usuario " + usuario + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CambiarEstado(EstadoMantenimiento.Nuevo);
                   RefrescarLista();
                }

                e.Handled = true;
            }
            }




        }
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


        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
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
                        gestor.GuardarUsuario();
                        txtUsuario.Text = user;
                        MessageBox.Show("El Usuario " + usuario.usuario + " fue agregado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CambiarEstado(EstadoMantenimiento.Agregar);
                        RefrescarLista();
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

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
            
        }

        private void gCUsuarios_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Editar);
            gestor = GestorUsuarioTable.GetInstance();
            try
            {
                string perfil = "";
                lblCodigoUsuario.Text = gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString();
                txtNombre.Text  = gridView1.GetFocusedRowCellValue("Nombre").ToString();
                txtApellido1.Text = gridView1.GetFocusedRowCellValue("PrimerApellido").ToString();
                txtApellido2.Text = gridView1.GetFocusedRowCellValue("SegundoApellido").ToString();
                txtUsuario.Text = gridView1.GetFocusedRowCellValue("Usuario").ToString();
                perfil = gridView1.GetFocusedRowCellValue("Perfil").ToString();
                if (perfil.Equals("Administrador"))
                {
                    this.chkAdministrador.Checked = true;
                    this.chkDespachador.Checked = false;
                }else
                {
                    if (perfil.Equals("Despachador"))
                    {
                        this.chkAdministrador.Checked = false;
                        this.chkDespachador.Checked = true;
                    }else
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

                gestor.AgregarUsuario(usuario);
                gestor.GuardarUsuario();
                MessageBox.Show("El Usuario " + usuario.usuario + " fue modificado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CambiarEstado(EstadoMantenimiento.Nuevo);
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.UsuarioLogueado();
            string usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString();
            int UsuarioID = int.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());
            if (usuario == usuarioLogueado)
            {
                MessageBox.Show("El usuario: " + usuario + " tiene sesiones abierta, no se puede eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (MessageBox.Show("¿Seguro que desea eliminar al Usuario " + usuario + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestor.EliminarUsuario(UsuarioID, usuario);
                    MessageBox.Show("El Usuario " + usuario + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CambiarEstado(EstadoMantenimiento.Nuevo);
                    RefrescarLista();
                }
            }
        }

        private  void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }
        public  void Limpear()
        {
            frmUsuarios NewForm = new frmUsuarios();
            this.Show();
            this.Hide();
            this.Dispose(false);
        }
    }
}
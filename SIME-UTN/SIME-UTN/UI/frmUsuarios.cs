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
        public frmUsuarios()
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
        public void CambiarEstado(EstadoMantenimiento estado)
        {
            usuario = new UsuarioTable();
          




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
                    break;
                case EstadoMantenimiento.Editar:



                    break;
                case EstadoMantenimiento.Borrar:
                    txtNombre.Clear();
                    txtPassword.Clear();
                    break;
                case EstadoMantenimiento.Ninguno:
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
        /// Manda a llamar al metodo Refresca Lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            RefrescarLista();
            ePError.Clear();
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
              
                chkAdministrador.Enabled = true;

            }
            else
            {

                chkAdministrador.Enabled = true;
                chkAdministrador.Checked = false;

            }

        }

        private void chkJefe_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void chkAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdministrador.Checked)
            {

                chkAdministrador.Enabled = true;


            }
            else
            {



                chkAdministrador.Checked = false;

            }

        }
        #endregion

        #region Checkbox de Modificar y Eliminar Usuarios






        #endregion

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuario = new UsuarioTable();
            try
            {
                usuario.codigoUsuario = Int32.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());
                usuario.usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString();
                usuario.perfil = gridView1.GetFocusedRowCellValue("Perfil").ToString();

                gestor.AgregarUsuario(usuario);
                gestor.GuardarUsuario();
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


        private void bBtnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuario = new UsuarioTable();
            try
            {
                if (txtPassword.Text.Trim() != "" && txtConfirmacion.Text.Trim() != "")
                {
                    if (txtPassword.Text.Equals(txtConfirmacion.Text))
                    {
                        cmbUsuarioId.DataSource = GestorUsuarioTable.OptenerId();
                        string ID = (cmbUsuarioId.SelectedValue.ToString());
                        usuario.codigoUsuario = int.Parse(ID);
                        usuario.nombre = txtNombre.Text;
                        usuario.apellido1 = txtApellido1.Text;
                        usuario.apellido2 = txtApellido2.Text;
                        usuario.contrasena = txtPassword.Text;
                        string user = (txtNombre.Text.Substring(0, 1) + txtApellido1.Text).ToLower();
                        int numeroUsuario= gestor.ValidarUsuario(user);
                        if (numeroUsuario==0)
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
                        //CambiarEstado(EstadoMantenimiento.Borrar);
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


    }
}
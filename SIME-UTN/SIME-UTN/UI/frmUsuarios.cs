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
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        public frmUsuarios()
        {
            InitializeComponent();
          

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
            dt.Columns.Add(new DataColumn("Perfil"));

            try
            {
                gestor = GestorUsuarioTable.GetInstance();
                this.lstUsuarios.Items.Clear();
                CambiarEstado(EstadoMantenimiento.Ninguno);
                List<UsuarioTable> lista = new List<UsuarioTable>(gestor.ObtenerUsuarios());
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["CodigoUsuario"] = lista[i].codigoUsuario;
                    dr["Usuario"] = lista[i].usuario;
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
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Enabled = false;
            txtUsuario.Clear();
            txtPassword.Enabled = false;
            txtPassword.Clear();
            chkAdministrador.Enabled = false;
            txtConfirmacion.Text = "";


            chkAdministrador.Checked = false;



            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtUsuario.Enabled = true;
                    txtUsuario.Text = "";
                    txtPassword.Enabled = true;
                    txtPassword.Text = "";
                    chkAdministrador.Enabled = true;
                    chkAdministrador.Checked = true;
                    //chkFacturador.Enabled = true;
                    //chkJefe.Enabled = false;
                    //chkReporteador.Enabled = true;
                    //chkNaturista.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:



                    break;
                case EstadoMantenimiento.Borrar:
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }


        /// <summary>
        /// Metodo que llama al metodo Cambiar estado y le manda el parametro nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripbtnNuevo_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
            cmbUsuarioId.DataSource = GestorUsuarioTable.OptenerId();
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
        /// Metodo que optiene los valores de los objetos y se los asigna a 
        /// un usuario por medio del gesotor y puego por este mismo manda a guardar a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuario = new UsuarioTable();
            try
            {
                if (txtPassword.Text.Trim() != "" && txtConfirmacion.Text.Trim() != "")
                {
                    if (txtPassword.Text.Equals(txtConfirmacion.Text))
                    {
                        string ID = (cmbUsuarioId.SelectedValue.ToString());
                        usuario.codigoUsuario = int.Parse(ID);
                        usuario.usuario = txtUsuario.Text;
                        usuario.contrasena = txtPassword.Text;
                        if (chkAdministrador.Checked)
                        {
                            usuario.perfil = "Administrador";
                        }



                        gestor.AgregarUsuario(usuario);
                        gestor.GuardarUsuario();

                        CambiarEstado(EstadoMantenimiento.Borrar);
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
                this.lstUsuarios.Items.Clear();
                this.lstUsuarios.Items.Add("Este Perfil de Usuario posse accesos a:");
                this.lstUsuarios.Items.Add("A) Sistemas");
                this.lstUsuarios.Items.Add("B) Mantenimientos");
                this.lstUsuarios.Items.Add("C) Procesos");
                this.lstUsuarios.Items.Add("D) Reportes");
                this.lstUsuarios.Items.Add("E) Facturacion");

                chkAdministrador.Enabled = true;

            }
            else
            {
                this.lstUsuarios.Items.Clear();
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
                this.lstUsuarios.Items.Clear();
                this.lstUsuarios.Items.Add("Este Perfil de Usuario posse accesos a:");
                this.lstUsuarios.Items.Add("A) Sistemas");
                this.lstUsuarios.Items.Add("B) Mantenimientos");
                this.lstUsuarios.Items.Add("C) Procesos");
                this.lstUsuarios.Items.Add("D) Reportes");
                this.lstUsuarios.Items.Add("E) Facturacion");
                chkAdministrador.Enabled = true;


            }
            else
            {
                this.lstUsuarios.Items.Clear();


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


                string UsuarioNombre = gridView1.GetFocusedRowCellValue("Usuario").ToString(); ;
                int UsuarioID = Int32.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());

                if (MessageBox.Show("¿Seguro que desea eliminar al Usuario " + UsuarioNombre + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestor.EliminarUsuario(UsuarioID, UsuarioNombre);

                    RefrescarLista();
                }
                e.Handled = true;

            }




        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                ePError.SetError(txtUsuario, "Campo Usuario en Blanco");
                txtUsuario.Focus();
            }
            else
            {
                ePError.Clear();
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                ePError.SetError(txtPassword, "Campo Password en Blanco");
                txtPassword.Focus();
            }
            else
            {
                ePError.Clear();
            }
        }

        private void txtConfirmacion_Validated(object sender, EventArgs e)
        {
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
    }
}
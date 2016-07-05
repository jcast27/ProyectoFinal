﻿using System;
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

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmUsuarios : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        static UsuarioTable usuarioEstatico = null;
        GestorUsuarioTable gestor = null;
        static string nombre = "";
    
        public  frmUsuarios()
        {
            InitializeComponent();
          
        }





        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsuario.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetUsuario.Usuario);
            // TODO: This line of code loads data into the 'sIMEUTNDataSet.Usuario' table. You can move, or remove it, as needed.
            gestor = GestorUsuarioTable.GetInstance();
            usuarioEstatico = new UsuarioTable();
            try
            {

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
        /// Metodo que obtiene el Usuario que esta logueado en la base de datos
        /// </summary>
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

        /// <summary>
        /// Actualiza el datagridview con los usuarios agredados
        /// </summary>
     /*   private void RefrescarLista()
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
        }     */







        /// <summary>
        /// Manda a llamar al metodo Refresca Lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            //RefrescarLista();
       
        }




        /// <summary>
        /// Metodo que permite eliminar un usuario, seleccionandolo en el datagrid y presionando la tecla delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                eliminarUsuario();
                e.Handled = true;
            
            }

        }

        /// <summary>
        /// Metodo que permite seleccionar un Usuario del grid y eliminarlo por medio del boton eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            eliminarUsuario();
        }

        private void eliminarUsuario()
        {
            
                this.UsuarioLogueado();
                string usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString(); ;
                int UsuarioID = Int32.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());
                if (usuario == usuarioLogueado)
                {
                    MessageBox.Show("El usuario: " + usuario + " tiene sesiones abierta, no se puede eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("¿Seguro que desea eliminar al Usuario " + usuario + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gestor.EliminarUsuario(UsuarioID, usuario, usuarioLogueado);
                        MessageBox.Show("El Usuario " + usuario + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmUsuarios_Load(null, null);

                    }

                    
                }
            }




        



        /// <summary>
        /// Metodo que permite extrae el Usuario seleccionado del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCUsuarios_Click(object sender, EventArgs e)
        {

            try
            {
             
                usuarioEstatico.codigoUsuario = int.Parse(gridView1.GetFocusedRowCellValue("CodigoUsuario").ToString());
                usuarioEstatico.nombre = gridView1.GetFocusedRowCellValue("Nombre").ToString();
                usuarioEstatico.apellido1 = gridView1.GetFocusedRowCellValue("Apellido1").ToString();
                usuarioEstatico.apellido2 = gridView1.GetFocusedRowCellValue("Apellido2").ToString();
                usuarioEstatico.usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString();
                usuarioEstatico.perfil = gridView1.GetFocusedRowCellValue("Perfil").ToString();

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
            if (usuarioEstatico != null)
            {
                frmAdUsuario ofrmAdUsuario = new frmAdUsuario(usuarioEstatico);
                ofrmAdUsuario.ShowDialog(this);
                // RefrescarLista();

                frmUsuarios_Load(null,null);
            }
            else
            {
                MessageBox.Show("No hay ningun Usuario seleccionado", "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdUsuario ofrmAdUsuario = new frmAdUsuario();
            ofrmAdUsuario.ShowDialog(this);
            // RefrescarLista();
            frmUsuarios_Load(null, null);

        }
    }
}
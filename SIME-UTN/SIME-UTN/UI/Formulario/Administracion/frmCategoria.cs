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

namespace SIME_UTN.UI.Formulario.Administracion
{
    public partial class frmCategoria : Form
    {
        string usuarioLogueado = "";
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorU = null;
        Item item = null;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sIMEUTNDataSet.Usuario' table. You can move, or remove it, as needed.
            try
            {
                RefrescarLista();
                GestorItem gi = GestorItem.GetInstance();
                List<Item> listaItems = gi.ObtenerItems();
                foreach (Item item in listaItems)
                {
                    clbItems.Items.Add(item);
                }
                clbItems.Items.Insert(0, "Seleccionar Todos");
                
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
            gestorU = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorU.ObtenerUsuarioLogeado();
        }

        /// <summary>
        /// Actualiza el datagridview con los usuarios agredados
        /// </summary>
        private void RefrescarLista()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Items";
            dt.Columns.Add(new DataColumn("IDCategoria"));
            dt.Columns.Add(new DataColumn("Descripcion"));
            dt.Columns.Add(new DataColumn("Items"));
            dt.Columns.Add(new DataColumn("Estado"));

            try
            {
                gestor = GestorCategoria.GetInstance();

                List<Categoria> lista = new List<Categoria>(gestor.ObtenerCategorias());
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["IDCategoria"] = lista[i].idCategoria;
                    dr["Descripcion"] = lista[i].descripcion;
                    dr["Items"] = lista[i].listaItems;
                    dr["Estado"] = lista[i].estado.ToString().Equals("1") ? "Habilitado" : "Deshabilitado";
                    dt.Rows.Add(dr);
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gCCategorias.DataSource = dt;
            
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
                    txtId.Text = "";
                    txtDescripcion.Text = "";
                    txtDescripcion.Enabled = true;
                    this.mBtnNuevo.Enabled = true;
                    this.mBtnAgregar.Enabled = true;
                    this.mBtnModificar.Enabled = false;
                    this.mBtnEliminar.Enabled = false;
                    break;

                case EstadoMantenimiento.Editar:
                    txtDescripcion.Enabled = true;
                    this.mBtnNuevo.Enabled = false;
                    this.mBtnAgregar.Enabled = false;
                    this.mBtnModificar.Enabled = true;
                    this.mBtnEliminar.Enabled = true;
                    break;
                case EstadoMantenimiento.Agregar:
                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = "";
                    txtId.Text = "";
                    this.mBtnNuevo.Enabled = true;
                    this.mBtnAgregar.Enabled = true;
                    this.mBtnModificar.Enabled = false;
                    this.mBtnEliminar.Enabled = false;
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

        /// <summary>
        /// Metodo que cierra la ventana Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que permite eliminar un usuario, seleccionandolo en el datagrid y presionando la tecla delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }



        /// <summary>
        /// Metodo que valida los campos antes de guardar el usuario
        /// </summary>
        public bool ValidarCampos()
        {
            bool r = false;
            if (txtDescripcion.Text.Trim() == "")
            {
                ePError.SetError(txtDescripcion, "Campo Descripción en Blanco");
                txtDescripcion.Focus();
                r = false;
            }
            else
            {
                ePError.Clear();
                r = true;
            }
            return r;
        }


        /// <summary>
        /// Metodo que permite agregar un nuevo Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            /*gestor = GestorItem.GetInstance();
            item = new Item();

            if (ValidarCampos())
            {
                var rdb = gbInformacionPersonal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                item.descripcion = txtDescripcion.Text;
                item.seccion = rdb.Text;
                item.estado = 1;

                if (gestor.ObtenerItemDescripcion(item.descripcion) == null)
                {
                    gestor.AgregarItem(item);
                    gestor.GuardarItem();
                    MessageBox.Show("El Item fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CambiarEstado(EstadoMantenimiento.Agregar);
                    RefrescarLista();
                }
                else
                {
                    MessageBox.Show("Ya existe un nombre con este Item", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }*/
        }



        /// <summary>
        /// Metodo que permite limpiar los campos del formulario de Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }


        /// <summary>
        /// Metodo que permite extrae el Usuario seleccionado del grid y colocar la informacion en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCUsuarios_Click(object sender, EventArgs e)
        {
            /*CambiarEstado(EstadoMantenimiento.Editar);

            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("IDItem").ToString();
                txtDescripcion.Text = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                string seccion = gridView1.GetFocusedRowCellValue("Seccion").ToString();
                
                mBtnEliminar.Caption = gridView1.GetFocusedRowCellValue("Estado").ToString().Equals("Habilitado") ? "Deshabilitar" : "Habilitar";

                CambiarEstado(EstadoMantenimiento.Editar);
            }
            catch (ApplicationException app)
            {
                MessageBox.Show(app.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }



        /// <summary>
        /// Metodo que permite modificar un Usuario ya creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            /*gestor = GestorItem.GetInstance();
            item = new Item();

            if (ValidarCampos())
            {
                var rdb = gbInformacionPersonal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                item.idItem = int.Parse(txtId.Text);
                item.descripcion = txtDescripcion.Text;
                item.seccion = rdb.Text;
                item.estado = mBtnEliminar.Caption.Equals("Habilitar") ? 0 : 1;

                gestor.AgregarItem(item);
                gestor.GuardarItem();
                MessageBox.Show("El Item fue actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarLista();
                CambiarEstado(EstadoMantenimiento.Agregar);
            }
            */
        }


        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {/*
            gestor = GestorItem.GetInstance();
            try
            {
                gestor.EliminarItem(txtId.Text, mBtnEliminar.Caption);
                MessageBox.Show("El Item ha sido " + mBtnEliminar.Caption.Replace("ar","ado").ToLower(), "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mBtnEliminar.Caption = mBtnEliminar.Caption.Equals("Habilitar") ? "Deshabilitar" : "Habilitar";
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void clbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (clbItems.SelectedIndex == 0)
            {
                bool state = clbItems.GetItemChecked(0) ? true : false;

                for (int i = 1; i < clbItems.Items.Count; i++)
                {
                    clbItems.SetItemChecked(i, state);
                }
            }
        }
    }
}
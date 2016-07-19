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
    public partial class frmItem : Form
    {
        string usuarioLogueado = "";
        GestorItem gestor = null;
        GestorUsuarioTable gestorU = null;
        Item item = null;

        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
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
            dt.Columns.Add(new DataColumn("IDItem"));
            dt.Columns.Add(new DataColumn("Descripcion"));
            dt.Columns.Add(new DataColumn("Seccion"));
            dt.Columns.Add(new DataColumn("Estado"));

            try
            {
                gestor = GestorItem.GetInstance();

                List<Item> lista = new List<Item>(gestor.ObtenerItems());
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["IDItem"] = lista[i].idItem;
                    dr["Descripcion"] = lista[i].descripcion;
                    dr["Seccion"] = lista[i].seccion;
                    dr["Estado"] = lista[i].estado.ToString().Equals("1") ? "Habilitado" : "Deshabilitado";
                    dt.Rows.Add(dr);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gCItems.DataSource = dt;

        }

        /// <summary>
        /// Metodo que permite agregar un nuevo Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdItem frm = new frmAdItem();
            frm.ShowDialog(this);
            RefrescarLista();
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
                mBtnEliminar.Enabled = true;
                mBtnModificar.Enabled = true;
                mBtnEliminar.Caption = gridView1.GetFocusedRowCellValue("Estado").ToString().Equals("Habilitado") ? "Deshabilitar" : "Habilitar";
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
        /// Metodo que permite modificar un Usuario ya creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            item = gestor.ObtenerItemId(int.Parse(gridView1.GetFocusedRowCellValue("IDItem").ToString()));

            frmAdItem frm = new frmAdItem(item);
            frm.ShowDialog(this);
            RefrescarLista();
        }


        /// <summary>
        /// Metodo que permite seleccionar un Usuario del grid y eliminarlo por medio del boton eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestor = GestorItem.GetInstance();
            try
            {
                gestor.EliminarItem(gridView1.GetFocusedRowCellValue("IDItem").ToString(), mBtnEliminar.Caption,usuarioLogueado);
                MessageBox.Show("El Item ha sido " + mBtnEliminar.Caption.Replace("ar","ado").ToLower(), "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mBtnEliminar.Caption = mBtnEliminar.Caption.Equals("Habilitar") ? "Deshabilitar" : "Habilitar";
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
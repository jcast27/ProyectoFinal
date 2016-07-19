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
        Categoria categoria = null;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: esta línea de código carga datos en la tabla 'dataSetCategoria.Categoria' Puede moverla o quitarla según sea necesario.
            //this.categoriaTableAdapter.Fill(this.dataSetCategoria.Categoria);
            // TODO: This line of code loads data into the 'sIMEUTNDataSet.Usuario' table. You can move, or remove it, as needed.
            try
            {
                RefrescarLista();
                /*.Fill(this.dataSetRDepartamento.sp_SELECT_Departamento_All);
                UsuarioLogueado();
                gestorDepto = GestorDepartamento.GetInstance();
                deptoEstatico = new Departamento();*/
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

                List<Categoria> lista = new List<Categoria>(gestor.ObtenerCategorias(Pertenece.Formulario.ToString()));
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
        /*

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
                    this.mBtnAgregar.Enabled = true;
                    this.mBtnModificar.Enabled = false;
                    this.mBtnEliminar.Enabled = false;
                    refrescarItems();
                    break;
                case EstadoMantenimiento.Editar:
                    txtDescripcion.Enabled = true;
                    this.mBtnAgregar.Enabled = false;
                    this.mBtnModificar.Enabled = true;
                    this.mBtnEliminar.Enabled = true;
                    break;
                case EstadoMantenimiento.Agregar:
                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = "";
                    txtId.Text = "";
                    this.mBtnAgregar.Enabled = true;
                    this.mBtnModificar.Enabled = false;
                    this.mBtnEliminar.Enabled = false;
                    break;
            }
        }
*/
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
        /// Metodo que permite agregar un nuevo Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdCategoria frm = new frmAdCategoria();
            frm.ShowDialog(this);
            frmCategoria_Load(null, null);            

            /*gestor = GestorCategoria.GetInstance();
            GestorItem gestorItem = GestorItem.GetInstance();
            GestorCategoriaItem gestorCI = GestorCategoriaItem.GetInstance();

            categoria = new Categoria();

            if (ValidarCampos())
            {
                categoria.descripcion = txtDescripcion.Text.Trim();
                categoria.pertenencia = Pertenece.Formulario.ToString();
                categoria.estado = 1;

                List<Item> listaItems = new List<Item>();

                foreach (var item in clbItems.CheckedItems)
                {
                    if (!item.ToString().Equals("Seleccionar Todos"))
                    {
                        listaItems.Add(gestorItem.ObtenerItemDescripcion(item.ToString().Trim()));
                    }
                }

                gestor.AgregarCategoria(categoria);
                int idCategoria = gestor.GuardarCategoria();

                foreach (Item item in listaItems)
                {
                    CategoriaItem CI = new CategoriaItem();
                    CI.idCategoria = idCategoria;
                    CI.idItem = item.idItem;
                    gestorCI.AgregarCategoriaItem(CI);
                    gestorCI.GuardarCategoriaItem();
                }

                MessageBox.Show("La Categoría fue actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarLista();
                CambiarEstado(EstadoMantenimiento.Agregar);
            }*/
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
            categoria = gestor.ObtenerCategoriaId(int.Parse(gridView1.GetFocusedRowCellValue("IDCategoria").ToString()));

            frmAdCategoria frm = new frmAdCategoria(categoria);
            frm.ShowDialog(this);
            frmCategoria_Load(null, null);
        }


        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestor = GestorCategoria.GetInstance();
            try
            {
                gestor.DesactivarCategoria(gridView1.GetFocusedRowCellValue("IDCategoria").ToString(), mBtnEliminar.Caption, usuarioLogueado);
                MessageBox.Show("El Item ha sido " + mBtnEliminar.Caption.Replace("ar", "ado").ToLower(), "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
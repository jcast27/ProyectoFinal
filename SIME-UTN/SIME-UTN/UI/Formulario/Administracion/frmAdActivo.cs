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

namespace SIME_UTN.UI.Formulario.Administracion
{
    public partial class frmAdActivo : DevExpress.XtraEditors.XtraForm
    {
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorUsuario = null;
        Activo activo = null;
        static string usuarioLogueado = "";

        public frmAdActivo()
        {
            InitializeComponent();
            activo = new Activo();
            mBtnModificar.Visible = false;
        }

        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        public frmAdActivo(Activo activop)
        {
            InitializeComponent();
            activo = new Activo();
            activo = activop;
            gCActivo();
            mBtnGuardar.Visible = false;
        }

        private void frmAdActivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFUbicacion.Ubicacion' Puede moverla o quitarla según sea necesario.
            this.ubicacionTableAdapter.Fill(this.dataSetFUbicacion.Ubicacion);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCategoria.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dataSetCategoria.Categoria);
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
        }

        public bool ValidarCampos()
        {
            bool r = false;
            int result = 0;
            DateTime date;

            if (txtNombre.Text.Trim() == "")
            {
                ePError.SetError(txtNombre, "Nombre en blanco");
                txtNombre.Focus();
                r = false;
            }
            else if (DateTime.TryParse(dtpIngreso.Text.Trim(), out date))
            {
                ePError.SetError(dtpIngreso, "Fecha no válida");
                dtpIngreso.Focus();
                r = false;
            }
            else if (cmbCategoria.SelectedIndex == -1)
            {
                ePError.SetError(cmbCategoria, "Categoría no seleccionada");
                cmbCategoria.Focus();
                r = false;
            }
            else if (txtMarca.Text.Trim() == "")
            {
                ePError.SetError(txtMarca, "Marca en blanco");
                txtMarca.Focus();
                r = false;
            }
            else if (txtModelo.Text.Trim() == "")
            {
                ePError.SetError(txtModelo, "Modelo en blanco");
                txtModelo.Focus();
                r = false;
            }
            else if (txtPatrimonio.Text.Trim() == "")
            {
                ePError.SetError(txtPatrimonio, "Patrimonio en blanco");
                txtPatrimonio.Focus();
                r = false;
            }
            else if (txtSerie.Text.Trim() == "")
            {
                ePError.SetError(txtSerie, "N° Serie en blanco");
                txtSerie.Focus();
                r = false;
            }
            else if (!int.TryParse(txtValor.Text.Trim(), out result))
            {
                ePError.SetError(txtValor, "Valor númerico no válido");
                txtValor.Focus();
                r = false;
            }
            else if (cmbUbicacion.SelectedIndex == -1)
            {
                ePError.SetError(cmbUbicacion, "Ubicación no seleccionada");
                cmbUbicacion.Focus();
                r = false;
            }
            else if (txtDescripcion.Text.Trim() == "")
            {
                ePError.SetError(txtDescripcion, "Campo Descripción en blanco");
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

        public void gCActivo()
        {
            try
            {
                txtNombre.Text = activo.descripcion;

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

        private void guardarActivo(string accion)
        {
            if (ValidarCampos())
            {
                /*gestor = GestorCategoria.GetInstance();
                GestorItem gestorItem = GestorItem.GetInstance();
                GestorCategoriaItem gestorCI = GestorCategoriaItem.GetInstance();

                string descripcion = "La Categoría fue agregada correctamente";

                if (accion == "U")
                {
                    categoria.idCategoria = int.Parse(txtId.Text);
                    descripcion = descripcion.Replace("agregada", "actualizada");
                }
                else
                {
                    categoria.estado = 1;
                }

                categoria.descripcion = txtNombre.Text.Trim();
                categoria.pertenencia = Pertenece.Formulario.ToString();

                List<Item> listaItems = new List<Item>();

                foreach (var item in clbItems.CheckedItems)
                {
                    if (!item.ToString().Equals("Seleccionar Todos"))
                    {
                        listaItems.Add(gestorItem.ObtenerItemDescripcion(item.ToString().Trim()));
                    }
                }

                categoria.listaItems = listaItems;

                gestor.AgregarCategoria(categoria);
                int id = gestor.guardarActivo(usuarioLogueado);

                if (id != 0)
                {
                    categoria.idCategoria = id;
                }

                gestorCI.EliminarCategoriaItem(categoria.idCategoria.ToString());
                foreach (Item item in categoria.listaItems)
                {
                    CategoriaItem CI = new CategoriaItem();
                    CI.idCategoria = categoria.idCategoria;
                    CI.idItem = item.idItem;
                    gestorCI.AgregarCategoriaItem(CI);
                    gestorCI.guardarActivoItem();
                }

                MessageBox.Show(descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();*/
            }
        }

        private void mBtnGuardar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarActivo("");
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarActivo("U");
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            foreach (Control control in gbActivo.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }

                if (control is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                }
            }

            mBtnModificar.Visible = false;
            mBtnGuardar.Visible = true;
        }

        private void mBtnSalir_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
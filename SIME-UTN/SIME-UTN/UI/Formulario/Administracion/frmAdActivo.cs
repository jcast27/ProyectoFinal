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
        GestorActivo gestor = null;
        GestorCategoria gestorCategoria = null;
        GestorUbicacion gestorUbicacion = null;
        GestorUsuarioTable gestorUsuario = null;
        Activo activo = null;
        Categoria categoria = null;
        Ubicacion ubicacion = null;
        bool modificar = false;
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
            
            mBtnGuardar.Visible = false;
            modificar = true;
        }

        private void frmAdActivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCategoriaPertenencia.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.FillPertenencia(this.dataSetCategoriaPertenencia.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dataSetFUbicacion.Ubicacion' Puede moverla o quitarla según sea necesario.
            this.ubicacionTableAdapter.Fill(this.dataSetFUbicacion.Ubicacion);
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();

            if (modificar)
            {
                gCActivo();
            }
            else
            {
                cmbCategoria.SelectedIndex = -1;
                cmbUbicacion.SelectedIndex = -1;

            }
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
            else if (dtpIngreso.Text.Trim() == ""/*DateTime.TryParse(dtpIngreso.Text.Trim(), out date)*/)
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
                txtId.Text = activo.idActivo.ToString();
                txtNombre.Text = activo.nombre;
                dtpIngreso.Value = activo.annoIngreso;
                cmbCategoria.SelectedValue = activo.categoria.idCategoria;
                txtMarca.Text = activo.marca;
                txtModelo.Text = activo.modelo;
                txtPatrimonio.Text = activo.patrimonio;
                txtSerie.Text = activo.numeroSerie;
                txtValor.Text = activo.valor.ToString();
                cmbUbicacion.SelectedValue = activo.ubicacion.idUbicacion;
                txtDescripcion.Text = activo.descripcion;

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
            categoria = new Categoria();
            ubicacion = new Ubicacion();

            if (ValidarCampos())
            {
                gestor = GestorActivo.GetInstance();
                categoria = new Categoria();
                ubicacion = new Ubicacion();
                gestorCategoria = GestorCategoria.GetInstance();
                gestorUbicacion = GestorUbicacion.GetInstance();


                string descripcion = "El activo fue agregado correctamente";

                if (accion == "U")
                {
                    activo.idActivo = int.Parse(txtId.Text);
                    descripcion = descripcion.Replace("agregado", "actualizado");
                }
                else
                {
                    activo.estado = 1;
                }

                activo.nombre = txtNombre.Text;
                activo.annoIngreso = dtpIngreso.Value;
                categoria.idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                categoria.descripcion = cmbCategoria.GetItemText(cmbCategoria.Items[cmbCategoria.SelectedIndex]);
                activo.categoria = categoria;
                activo.marca = txtMarca.Text;
                activo.modelo = txtModelo.Text;
                activo.patrimonio = txtPatrimonio.Text;
                activo.numeroSerie = txtSerie.Text;
                activo.valor = double.Parse(txtValor.Text);
                ubicacion.idUbicacion = int.Parse(cmbUbicacion.SelectedValue.ToString());
                ubicacion.nombre = cmbUbicacion.GetItemText(cmbUbicacion.Items[cmbUbicacion.SelectedIndex]);
                activo.ubicacion = ubicacion;
                activo.descripcion = txtDescripcion.Text;

                gestor.AgregarActivo(activo);
                gestor.GuardarActivo(usuarioLogueado);
                MessageBox.Show(descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
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

        private void fillByPertenenciaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaTableAdapter.FillPertenencia(this.dataSetCategoriaPertenencia.Categoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
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
    public partial class frmAdCategoria : DevExpress.XtraEditors.XtraForm
    {
        Categoria unDepto = null;
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorUsuario = null;
        Categoria categoria = null;
        static string usuarioLogueado = "";

        public frmAdCategoria()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
        }

        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        public frmAdCategoria(Categoria categoriap)
        {
            InitializeComponent();
            mBtnGuardar.Visible = false;
            categoria = new Categoria();
            categoria = categoriap;
            gCCategoria();
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Close();
        }

        private void frmAdCategoria_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
            refrescarItems();
        }

        private void refrescarItems()
        {
            clbItems.Items.Clear();
            GestorItem gi = GestorItem.GetInstance();
            List<Item> listaItems = gi.ObtenerItems();
            foreach (Item item in listaItems)
            {
                clbItems.Items.Add(item);
            }
            clbItems.Items.Insert(0, "Seleccionar Todos");
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {
            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombre.Text = "";
                    break;
                case EstadoMantenimiento.Editar:
                    Close();
                    break;
            }
        }

        public bool ValidarCampos()
        {
            bool r = false;
            if (txtNombre.Text.Trim() == "")
            {
                ePError.SetError(txtNombre, "Campo Descripción en Blanco");
                txtNombre.Focus();
                r = false;
            }
            else if (clbItems.CheckedItems == null)
            {
                ePError.SetError(clbItems, "Debe Seleccionar al menos un Item");
                clbItems.Focus();
                r = false;
            }
            else
            {
                ePError.Clear();
                r = true;
            }
            return r;
        }

        public void gCCategoria()
        {
            try
            {
                txtNombre.Text = categoria.descripcion;
                txtId.Text = categoria.idCategoria.ToString();
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

        public void GuardarCambiosCategoria(string accionp)
        {
            gestor = GestorCategoria.GetInstance();
            GestorItem gestorItem = GestorItem.GetInstance();
            GestorCategoriaItem gestorCI = GestorCategoriaItem.GetInstance();

            if (ValidarCampos())
            {
                categoria.idCategoria = int.Parse(txtId.Text);
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
                gestor.GuardarCategoria();

                gestorCI.EliminarCategoriaItem(categoria.idCategoria.ToString());
                foreach (Item item in categoria.listaItems)
                {
                    CategoriaItem CI = new CategoriaItem();
                    CI.idCategoria = categoria.idCategoria;
                    CI.idItem = item.idItem;
                    gestorCI.AgregarCategoriaItem(CI);
                    gestorCI.GuardarCategoriaItem();
                }

                MessageBox.Show("La Categoría fue actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                string accion = "Modificar";
                GuardarCambiosCategoria(accion);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambiosCategoria("");
            }
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            refrescarItems();
        }
    }
}
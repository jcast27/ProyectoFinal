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
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorUsuario = null;
        Categoria categoria = null;
        static string usuarioLogueado = "";

        public frmAdCategoria()
        {
            InitializeComponent();
            refrescarItems();
            categoria = new Categoria();
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
            categoria = new Categoria();
            categoria = categoriap;
            refrescarItems();
            gCCategoria();
            mBtnGuardar.Visible = false;
        }

        private void frmAdCategoria_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
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

                foreach (Item item in categoria.listaItems)
                {
                    for (int i = 0; i < clbItems.Items.Count; i++)
                    {
                        string chkL = clbItems.Items[i].ToString();
                        if (item.descripcion.Equals(chkL))
                            clbItems.SetItemChecked(i, true);
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

        private void guardarCategoria(string accion)
        {
            if (ValidarCampos())
            {
                gestor = GestorCategoria.GetInstance();
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
                int id = gestor.GuardarCategoria(usuarioLogueado);

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
                    gestorCI.GuardarCategoriaItem();
                }

                MessageBox.Show(descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
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

        private void mBtnGuardar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarCategoria("");
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarCategoria("U");
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            mBtnModificar.Visible = false;
            mBtnGuardar.Visible = true;
            refrescarItems();
        }

        private void mBtnSalir_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Close();
        }
    }
}
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
    public partial class frmAdItem : DevExpress.XtraEditors.XtraForm
    {
        GestorItem gestor = null;
        GestorUsuarioTable gestorUsuario = null;
        Item item = null;
        static string usuarioLogueado = "";

        public frmAdItem()
        {
            InitializeComponent();
            item = new Item();
            mBtnModificar.Visible = false;
        }

        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        public frmAdItem(Item itemp)
        {
            InitializeComponent();
            item = new Item();
            item = itemp;
            gCItem();
            mBtnGuardar.Visible = false;
        }

        private void frmAdItem_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
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
            else
            {
                ePError.Clear();
                r = true;
            }
            return r;
        }

        public void gCItem()
        {
            try
            {
                txtNombre.Text = item.descripcion;
                txtId.Text = item.idItem.ToString();

                switch (item.seccion)
                {
                    case "Si/No":
                        rdbSiNo.Checked = true; ;
                        break;
                    case "Bueno/Regular/Malo":
                        rdBMR.Checked = true; ;
                        break;
                    case "Texto Libre":
                        rdTexto.Checked = true; ;
                        break;
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

        private void guardarItem(string accion)
        {
            /*
                item.idItem = int.Parse(txtId.Text);
                item.descripcion = txtDescripcion.Text;
                item.seccion = rdb.Text;
                
            item.estado = mBtnEliminar.Caption.Equals("Habilitar") ? 0 : 1;

                gestor.AgregarItem(item);
                gestor.GuardarItem();
                MessageBox.Show("El Item fue actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarLista();
                CambiarEstado(EstadoMantenimiento.Agregar);
*/
            if (ValidarCampos())
            {
                gestor = GestorItem.GetInstance();

                var rdb = gbItem.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                string descripcion = "El Item fue agregado correctamente";

                if (accion == "U")
                {
                    item.idItem = int.Parse(txtId.Text);
                    descripcion = descripcion.Replace("agregado", "actualizado");
                }
                else
                {
                    item = new Item();
                    item.estado = 1;
                }

                item.descripcion = txtNombre.Text;
                item.seccion = rdb.Text;
                gestor.AgregarItem(item);

                if (accion == "U")
                {
                    gestor.GuardarItem();
                    MessageBox.Show(descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (gestor.ObtenerItemDescripcion(item.descripcion) == null)
                {
                    gestor.GuardarItem();
                    MessageBox.Show(descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un nombre con este Item", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void mBtnGuardar_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarItem("");
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            guardarItem("U");
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            rdbSiNo.Checked = true;
            mBtnModificar.Visible = false;
            mBtnGuardar.Visible = true;
        }

        private void mBtnSalir_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Close();
        }
    }
}
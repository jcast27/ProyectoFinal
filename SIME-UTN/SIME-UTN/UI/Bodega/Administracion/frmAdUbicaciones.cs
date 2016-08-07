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

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmAdUbicaciones : DevExpress.XtraEditors.XtraForm
    {
        GestorUsuarioTable gestorUsuario = null;
        GestorUbicacion gestorUbicacion = null;
        static Ubicacion ubicacionEstatica = null;
        Ubicacion unaUbicacion = null;
        Departamento unDepartamento = null;
        static string usuarioLogueado = "";
        public frmAdUbicaciones()
        {
            InitializeComponent();
            mBtnModificar.Visible = false;
            ubicacionEstatica = null;
        }

        public frmAdUbicaciones(Ubicacion ubicacionEstaticap)
        {
            InitializeComponent();
            ubicacionEstatica = new Ubicacion();
            ubicacionEstatica = ubicacionEstaticap;
            mBtnGuardar.Visible = false;
            mBtnModificar.Visible = true;
            gCUbicaciones();
        }



        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void frmAdUbicaciones_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'dataSetUDepartamento.sp_SELECT_Departamento_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_Departamento_AllTableAdapter.Fill(this.dataSetUDepartamento.sp_SELECT_Departamento_All);
            UsuarioLogueado();

            if (ubicacionEstatica == null)
            {
                cmbDepartamento.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cmbDepartamento.Items.Count; i++)
                {
                    string value = cmbDepartamento.GetItemText(cmbDepartamento.Items[i]);
                    if (value == ubicacionEstatica.Departamento.descripcion)
                    {
                        cmbDepartamento.SelectedIndex = i;
                    }
                }
            }
        }

        public void CambiarEstado(EstadoMantenimiento estado)
        {


            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    cmbDepartamento.SelectedIndex = -1;
                    break;
                case EstadoMantenimiento.Editar:
                    this.Close();
                    break;

            }
        }

        public void gCUbicaciones()
        {

            try
            {
                lblIdUbicacion.Text = ubicacionEstatica.idUbicacion.ToString();
                txtNombre.Text = ubicacionEstatica.nombre;
                txtDescripcion.Text = ubicacionEstatica.otraSennas;

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

        public void GuardarCambios(string accionp)
        {
            gestorUbicacion = new GestorUbicacion();
            unaUbicacion = new Ubicacion();
            unDepartamento = new Departamento();
            try
            {
                unaUbicacion.nombre = txtNombre.Text;
                unaUbicacion.otraSennas = txtDescripcion.Text;
                unDepartamento.idDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                unDepartamento.descripcion = cmbDepartamento.GetItemText(cmbDepartamento.Items[cmbDepartamento.SelectedIndex]);
                unaUbicacion.Departamento = unDepartamento;

                if (accionp == "Modificar")
                {
                    string idUbicacion = lblIdUbicacion.Text;
                    unaUbicacion.idUbicacion = int.Parse(idUbicacion);
                    gestorUbicacion.AgregarUbicacion(unaUbicacion);
                    gestorUbicacion.GuardarUbicacion(unaUbicacion,usuarioLogueado);
                    MessageBox.Show("La ubicación " + unaUbicacion.nombre + " fue modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    unaUbicacion.estado = 1;
                    gestorUbicacion.AgregarUbicacion(unaUbicacion);
                    gestorUbicacion.GuardarUbicacion(unaUbicacion, usuarioLogueado);
                    MessageBox.Show("La ubicación  " + unaUbicacion.nombre + " fue agregada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CambiarEstado(EstadoMantenimiento.Editar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                string accion = "Modificar";
                GuardarCambios(accion);
            }
        }

        private void mBtnGuardar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (ValidarCampos() == false)
            {
                GuardarCambios("");
            }
        }

        public bool ValidarCampos()
        {
            bool error = false;
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Campo Requerido");
                txtNombre.Focus();
                error = true;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                epError.SetError(txtDescripcion, "Campo Requerido");
                txtDescripcion.Focus();
                error = true;
            }
            if(cmbDepartamento.SelectedIndex == -1)
            {
                epError.SetError(cmbDepartamento, "Campo Requerido");
                cmbDepartamento.Focus();
                error = true;
            }
            if (error == false)
            {
                epError.Clear();
            }

            return error;
        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Nuevo);
        }
    }
}
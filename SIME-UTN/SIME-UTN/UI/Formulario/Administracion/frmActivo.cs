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
    public partial class frmActivo : Form
    {
        
        string usuarioLogueado = "";
        GestorActivo gestor = null;
        GestorUsuarioTable gestorU = null;
        static Activo activo = null;

        public frmActivo()
        {
            InitializeComponent();
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
            dt.TableName = "Activos";
            dt.Columns.Add(new DataColumn("IDActivo"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("NumeroSerie"));
            dt.Columns.Add(new DataColumn("Descripcion"));
            dt.Columns.Add(new DataColumn("Categoria"));
            dt.Columns.Add(new DataColumn("Ingreso"));
            dt.Columns.Add(new DataColumn("Valor"));
            dt.Columns.Add(new DataColumn("Ubicacion"));
            dt.Columns.Add(new DataColumn("Marca"));
            dt.Columns.Add(new DataColumn("Modelo"));
            dt.Columns.Add(new DataColumn("Patrimonio"));
            dt.Columns.Add(new DataColumn("Estado"));

            try
            {
                gestor = GestorActivo.GetInstance();

                List<Activo> lista = new List<Activo>(gestor.ObtenerActivos());
                for (int i = 0; i < lista.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["IDActivo"] = lista[i].idActivo;
                    dr["Nombre"] = lista[i].nombre;
                    dr["NumeroSerie"] = lista[i].numeroSerie;
                    dr["Descripcion"] = lista[i].descripcion;
                    dr["Categoria"] = lista[i].categoria.descripcion;
                    dr["Ingreso"] = lista[i].annoIngreso.ToShortDateString();
                    dr["Valor"] = lista[i].valor.ToString();
                    dr["Ubicacion"] = lista[i].ubicacion.nombre;
                    dr["Marca"] = lista[i].marca;
                    dr["Modelo"] = lista[i].modelo;
                    dr["Patrimonio"] = lista[i].patrimonio;
                    dr["Estado"] = lista[i].estado.ToString().Equals("1") ? "Habilitado" : "Deshabilitado";
                    dt.Rows.Add(dr);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gCActivos.DataSource = dt;

        }

        /// <summary>
        /// Metodo que permite agregar un nuevo Usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdActivo frm = new frmAdActivo();
            frm.ShowDialog(this);
            frmActivo_Load(null, null);
        }

        /// <summary>
        /// Metodo que permite extrae el Usuario seleccionado del grid y colocar la Información en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnEliminar.Enabled = false;
                mBtnModificar.Enabled = false;

                activo.idActivo = int.Parse(gridView1.GetFocusedRowCellValue("IDActivo").ToString());
                if (activo.idActivo != 0)
                {
                    mBtnEliminar.Enabled = true;
                    mBtnModificar.Enabled = true;
                    mBtnEliminar.Caption = gridView1.GetFocusedRowCellValue("Estado").ToString().Equals("Habilitado") ? "Deshabilitar" : "Habilitar";
                }
            }
            catch (ApplicationException app)
            {
                MessageBox.Show(app.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que permite modificar un Usuario ya creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Activo unActivo = new Activo();
            unActivo = gestor.ObtenerActivoId(activo.idActivo);

            frmAdActivo frm = new frmAdActivo(unActivo);
            frm.ShowDialog(this);
            frmActivo_Load(null, null);
        }


        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            gestor = GestorActivo.GetInstance();
            try
            {
                gestor.DesactivarActivo(activo.idActivo.ToString(), mBtnEliminar.Caption, usuarioLogueado);
                MessageBox.Show("El activo ha sido " + mBtnEliminar.Caption.Replace("ar", "ado").ToLower(), "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mBtnEliminar.Caption = mBtnEliminar.Caption.Equals("Habilitar") ? "Deshabilitar" : "Habilitar";
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmActivo_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            gestor = GestorActivo.GetInstance();
            activo = new Activo();
            try
            {
                RefrescarLista();
                mBtnEliminar.Enabled = false;
                mBtnModificar.Enabled = false;
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
    }
}
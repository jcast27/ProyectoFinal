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

namespace SIME_UTN.UI.Bodega.Administracion
{
    public partial class frmFuncionarios : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestorUsuario = null;
        GestorFuncionario gestorFuncionario = null;
        Funcionario funcionarioEstatico = null;
        static string nombre = "";
        public frmFuncionarios()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestorUsuario = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorUsuario.ObtenerUsuarioLogeado();
        }

   

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdFuncionario ofrmAdFuncionario = new frmAdFuncionario();
            ofrmAdFuncionario.ShowDialog(this);
            frmFuncionarios_Load(null, null);
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetDepartamento.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dataSetDepartamento.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dataSetFuncionario.Funcionario' Puede moverla o quitarla según sea necesario.
            this.funcionarioTableAdapter.Fill(this.dataSetFuncionario.Funcionario);
            UsuarioLogueado();
            gestorFuncionario = GestorFuncionario.GetInstance();
            funcionarioEstatico = new Funcionario();

        }

        private void gCFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                Departamento unDepto = new Departamento();
                Categoria unaCategoria = new Categoria();
                Ubicacion unaUbicacion = new Ubicacion();
                UnidadMedida unaUnidadMedida = new UnidadMedida();
                System.Data.DataRowView row = null;
                funcionarioEstatico.idFuncionario = int.Parse(gridView1.GetFocusedRowCellValue("IDFuncionario").ToString());
                funcionarioEstatico.nombre = gridView1.GetFocusedRowCellValue("Nombre").ToString();
                funcionarioEstatico.cedula = gridView1.GetFocusedRowCellValue("Cedula").ToString();
                funcionarioEstatico.correo = gridView1.GetFocusedRowCellValue("Correo").ToString();
                funcionarioEstatico.telefono = gridView1.GetFocusedRowCellValue("Telefono").ToString();
                unDepto.idDepartamento = int.Parse(gridView1.GetFocusedRowCellValue("IDDepartamento").ToString());
                row = LookUpDepartamento.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("IDDepartamento").ToString())) as DataRowView;
                unDepto.descripcion = row.Row["Descripcion"].ToString();
                funcionarioEstatico.Departamento = unDepto;
                
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

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdFuncionario ofrmAdFuncionario = new frmAdFuncionario(funcionarioEstatico);
            ofrmAdFuncionario.ShowDialog(this);
            frmFuncionarios_Load(null, null);
        }

        /// <summary>
        /// Invoca al metodo desactivar funcionario, al seleccionar un row del grid y pulsar la tecla Delete del teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarFuncionario();
                e.Handled = true;
            }


        }
        public void DesactivarFuncionario()
        {
            string funcionario = gridView1.GetFocusedRowCellValue("Nombre").ToString(); ;
            int funcionarioId = Int32.Parse(gridView1.GetFocusedRowCellValue("IDFuncionario").ToString());

            if (MessageBox.Show("¿Seguro que desea eliminar al funcionario " + funcionario + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gestorFuncionario.EliminarFuncionario(funcionarioId, funcionario, usuarioLogueado);
                MessageBox.Show("El Funcionario " + funcionario + " fue eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmFuncionarios_Load(null, null);

            }
        }

        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarFuncionario();
        }
    }
}
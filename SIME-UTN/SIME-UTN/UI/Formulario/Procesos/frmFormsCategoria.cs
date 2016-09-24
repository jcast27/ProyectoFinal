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

namespace SIME_UTN.UI.Formulario.Procesos
{
    public partial class frmFormsCategoria : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        static UsuarioTable usuarioEstatico = null;
        GestorUsuarioTable gestor = null;
        static string categoria = "";

        public frmFormsCategoria()
        {
            InitializeComponent();
          
        }

        private void mBtnAbrir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
 
            frmFormulario frm = new frmFormulario(categoria);
            frm.ShowDialog(this);
        }

    


        private void frmFormsCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formulariosCategoria.sp_SELECT_Categoria_Formulario' table. You can move, or remove it, as needed.
            this.sp_SELECT_Categoria_FormularioTableAdapter.Fill(this.formulariosCategoria.sp_SELECT_Categoria_Formulario);

        }

        private void gCFormulario_Click_1(object sender, EventArgs e)
        {
            try
            {
                mBtnAbrir.Enabled = false;
                int idCategoria = 0;

                idCategoria = int.Parse(gridView1.GetFocusedRowCellValue("idcategoria").ToString());
                if (idCategoria != 0)
                {
                    mBtnAbrir.Enabled = true;
                    categoria = gridView1.GetFocusedRowCellValue("descripcion").ToString();

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
    }
}
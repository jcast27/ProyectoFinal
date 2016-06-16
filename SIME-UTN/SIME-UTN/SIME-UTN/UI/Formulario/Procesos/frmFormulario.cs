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
    public partial class frmFormulario : Form
    {
        string usuarioLogueado = "";
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorU = null;
        Categoria categoria = null;
        int cont;

        public frmFormulario(string categoriaP)
        {
            InitializeComponent();
            cont = 0;
            gestor = GestorCategoria.GetInstance();
            categoria = gestor.ObtenerCategoriaDescripcion(categoriaP);
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            try
            {
                List<Item> sino = new List<Item>();
                List<Item> brm = new List<Item>();
                List<Item> textolibre = new List<Item>();

                foreach (Item item in categoria.listaItems)
                {
                    switch (item.seccion)
                    {
                        case "Si/No":
                            sino.Add(item);
                            break;
                        case "Texto Libre":
                            textolibre.Add(item);
                            break;
                        case "Bueno/Regular/Malo":
                            brm.Add(item);
                            break;
                    }
                }

                List<DataGridView> listaGrid = new List<DataGridView>();

                if (sino.Count > 0)
                {
                    dgvSiNo.AutoGenerateColumns = false;
                    dgvSiNo.DataSource = sino;
                    listaGrid.Add(dgvSiNo);
                    //dgvSiNo.Visible = true;
                }

                if (brm.Count > 0)
                {
                    dgvBRM.AutoGenerateColumns = false;
                    dgvBRM.DataSource = brm;
                    listaGrid.Add(dgvBRM);
                    //dgvBRM.Visible = true;
                }

                if (textolibre.Count > 0)
                {
                    dgvTextoLibre.AutoGenerateColumns = false;
                    dgvTextoLibre.DataSource = textolibre;
                    listaGrid.Add(dgvTextoLibre);
                    //dgvTextoLibre.Visible = true;
                }

                cont = listaGrid.Count;

                gbPrincipal.Controls.Clear();

                SplitContainer splitSeccion = new SplitContainer();
                splitSeccion.Dock = DockStyle.Fill;

                gbPrincipal.Controls.Add(splitSeccion);

                switch (cont)
                {
                    case 1:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        splitSeccion.SplitterDistance = panelPrincipal.Width / 2;
                        listaGrid[0].Dock = DockStyle.Fill;
                        break;
                    case 2:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        splitSeccion.Panel2.Controls.Add(listaGrid[1]);
                        splitSeccion.SplitterDistance = splitSeccion.Width / 2;
                        listaGrid[0].Dock = DockStyle.Fill;
                        listaGrid[1].Dock = DockStyle.Fill;
                        break;
                    case 3:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        SplitContainer splitSeccion2 = new SplitContainer();
                        splitSeccion2.Dock = DockStyle.Fill;
                        splitSeccion.Panel2.Controls.Add(splitSeccion2);
                        splitSeccion2.Panel1.Controls.Add(listaGrid[1]);
                        splitSeccion2.Panel2.Controls.Add(listaGrid[2]);
                        splitSeccion.SplitterDistance = splitSeccion.Width / 3;
                        splitSeccion2.SplitterDistance = splitSeccion.Width / 3;
                        listaGrid[0].Dock = DockStyle.Fill;
                        listaGrid[1].Dock = DockStyle.Fill;
                        listaGrid[2].Dock = DockStyle.Fill;
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


        /// <summary>
        /// Metodo que obtiene el Usuario que esta logueado en la base de datos
        /// </summary>
        public void UsuarioLogueado()
        {
            gestorU = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestorU.ObtenerUsuarioLogeado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSiNo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                if (e.ColumnIndex == 2)
                {
                    dgvSiNo.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = false;
                }
                else
                {
                    dgvSiNo.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = false;
                }
            }
        }

        private void dgvBRM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                if (e.ColumnIndex == 2)
                {
                    dgvBRM.Rows[e.RowIndex].Cells[3].Value = false;
                    dgvBRM.Rows[e.RowIndex].Cells[4].Value = false;
                }
                else if (e.ColumnIndex == 3)
                {
                    dgvBRM.Rows[e.RowIndex].Cells[2].Value = false;
                    dgvBRM.Rows[e.RowIndex].Cells[4].Value = false;
                }
                else
                {
                    dgvBRM.Rows[e.RowIndex].Cells[2].Value = false;
                    dgvBRM.Rows[e.RowIndex].Cells[3].Value = false;
                }
            }
        }

        private void frmFormulario_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dgvSiNo_SizeChanged(object sender, EventArgs e)
        {
            dgvSiNo.Columns[1].Width = dgvSiNo.Width - 80;
        }

        private void dgvBRM_SizeChanged(object sender, EventArgs e)
        {
            dgvBRM.Columns[1].Width = dgvBRM.Width - 150;
        }

        private void dgvTextoLibre_SizeChanged(object sender, EventArgs e)
        {
            dgvTextoLibre.Columns[1].Width = dgvTextoLibre.Width - 210;
        }
    }
}
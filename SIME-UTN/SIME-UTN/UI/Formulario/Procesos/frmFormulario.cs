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
using SIME_UTN.BLL;

namespace SIME_UTN.UI.Formulario.Procesos
{
    public partial class frmFormulario : Form
    {
        string usuarioLogueado = "";
        GestorCategoria gestor = null;
        GestorUsuarioTable gestorU = null;
        Categoria categoria = null;
        List<DataGridView> listaGrid = new List<DataGridView>();
        int cont;

        public frmFormulario(string categoriaP)
        {
            InitializeComponent();
            cont = 0;
            gestor = GestorCategoria.GetInstance();
            categoria = gestor.ObtenerCategoriaDescripcion(categoriaP);
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFuncionario.Funcionario' Puede moverla o quitarla según sea necesario.
            this.funcionarioTableAdapter.Fill(this.dataSetFuncionario.Funcionario);
            // TODO: esta línea de código carga datos en la tabla 'dataSetActivo.Activo' Puede moverla o quitarla según sea necesario.
            this.activoTableAdapter.Fill(this.dataSetActivo.Activo);

            cmbFuncionario.SelectedIndex = -1;
            cmbPatrimonio.SelectedIndex = -1;

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
                splitSeccion.Orientation = Orientation.Horizontal;
                splitSeccion.Dock = DockStyle.Fill;

                gbPrincipal.Controls.Add(splitSeccion);

                //List<DataGridView> listaTemp = new List<DataGridView>();

                //foreach (DataGridView grid in listaGrid)
                //{
                //    int totalRowHeight = grid.ColumnHeadersHeight;
                //    foreach (DataGridViewRow row in grid.Rows)
                //        totalRowHeight += row.Height;

                //    grid.Height = totalRowHeight + 10;
                //    listaTemp.Add(grid);
                //}

                //listaGrid = listaTemp;

                switch (cont)
                {
                    case 1:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        splitSeccion.SplitterDistance = panelPrincipal.Height / 2;
                        listaGrid[0].Dock = DockStyle.Fill;
                        break;
                    case 2:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        splitSeccion.Panel2.Controls.Add(listaGrid[1]);
                        splitSeccion.SplitterDistance = splitSeccion.Height / 2;
                        listaGrid[0].Dock = DockStyle.Fill;
                        listaGrid[1].Dock = DockStyle.Fill;
                        break;
                    case 3:
                        splitSeccion.Panel1.Controls.Add(listaGrid[0]);
                        SplitContainer splitSeccion2 = new SplitContainer();
                        splitSeccion2.Orientation = Orientation.Horizontal;
                        splitSeccion2.Dock = DockStyle.Fill;
                        splitSeccion.Panel2.Controls.Add(splitSeccion2);
                        splitSeccion2.Panel1.Controls.Add(listaGrid[1]);
                        splitSeccion2.Panel2.Controls.Add(listaGrid[2]);
                        splitSeccion.SplitterDistance = splitSeccion.Height / 3;
                        splitSeccion2.SplitterDistance = splitSeccion.Height / 3;
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
            if (ValidarCampos())
            {

                GestorActivo ga = new GestorActivo();
                GestorFuncionario gf = new GestorFuncionario();
                GestorFormulario gForm = new GestorFormulario();

                Entities.Formulario form = new Entities.Formulario();
                form.activo = ga.ObtenerActivoId(int.Parse(cmbPatrimonio.SelectedValue.ToString()));
                form.funcionario = gf.ObtenerFuncionarioId(int.Parse(cmbFuncionario.SelectedValue.ToString()));
                form.fecha = DateTime.Parse(txtFecha.Text);
                form.cliente = txtCliente.Text;
                form.observaciones = txtComentario.Text;

                form.idFormulario = gForm.GuardarFormulario();

                foreach (DataGridView dgv in listaGrid)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (dgv.Name == "dgvBRM")
                        {
                            
                        }
                        else if (dgv.Name == "dgvSiNo")
                        {
                            
                        }
                        else if (dgv.Name == "dgvTextoLibre")
                        {
                            
                        }
                    }
                }
            }
        }

        public bool ValidarCampos()
        {
            bool r = false;
            bool brm = false;
            bool sino = false;
            bool texto = false;

           /* List<DataGridView> dgl = new List<DataGridView>();
            try { dgl.Add(((DataGridView)Controls.Find("dgvSiNo", true)[0])); } catch (Exception) { }
            try { dgl.Add(((DataGridView)Controls.Find("dgvBRM", true)[0])); } catch (Exception) { }
            try { dgl.Add(((DataGridView)Controls.Find("dgvTextoLibre", true)[0])); } catch (Exception) { }
            */
            foreach (DataGridView dgv in listaGrid)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (dgv.Name == "dgvBRM")
                    {
                        if ((row.Cells[2].Value == null && row.Cells[3].Value == null && row.Cells[4].Value == null) || ((bool)row.Cells[2].Value == false && (bool)row.Cells[3].Value == false && (bool)row.Cells[4].Value == false))
                        {
                            brm = true;
                        }
                    }
                    else if (dgv.Name == "dgvSiNo")
                    {
                        if ((row.Cells[2].Value == null && row.Cells[3].Value == null) || ((bool)row.Cells[2].Value == false && (bool)row.Cells[3].Value == false))
                        {
                            sino = true;
                        }
                    }
                    else if (dgv.Name == "dgvTextoLibre")
                    {
                        if (row.Cells[2].Value == null)
                        {
                            texto = true;
                        }
                    }
                }
            }

            if (brm)
            {
                ePError.SetError(gbPrincipal, "BRM - Items sin valor");
                r = false;
            }
            else if (sino)
            {
                ePError.SetError(gbPrincipal, "Si No - Items sin valor");
                r = false;
            }
            else if (texto)
            {
                ePError.SetError(gbPrincipal, "Texto Libre - Items sin valor");
                r = false;
            }
            //else if (cmbPatrimonio.SelectedIndex == -1)
            //{
            //    ePError.SetError(cmbPatrimonio, "Activo no seleccionado");
            //    cmbPatrimonio.Focus();
            //    r = false;
            //}
            //else if (cmbFuncionario.SelectedIndex == -1)
            //{
            //    ePError.SetError(cmbFuncionario, "Funcionario no seleccionado");
            //    cmbFuncionario.Focus();
            //    r = false;
            //}
            else
            {
                ePError.Clear();
                r = true;
            }
            return r;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cmbPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatrimonio.SelectedIndex > -1)
            {
                GestorActivo ga = new GestorActivo();

                Activo a = ga.ObtenerActivoId(int.Parse(cmbPatrimonio.SelectedValue.ToString()));

                txtNombre.Text = a.nombre;
                txtMarca.Text = a.marca;
                txtModelo.Text = a.modelo;
                txtSerie.Text = a.numeroSerie;
                txtUbicacion.Text = a.ubicacion.nombre;
            }
        }
    }
}
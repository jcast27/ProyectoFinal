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
    public partial class frmForms : Form
    {
        public frmForms()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            Location = new Point(150, 176);
            Icon = Properties.Resources.Icono;
            // TODO: This line of code loads data into the 'sIMEUTNDataSet.Usuario' table. You can move, or remove it, as needed.
            try
            {
                GestorCategoria gestorC = GestorCategoria.GetInstance();
                int x = 6;
                int y = 30;

                foreach (Categoria cat in gestorC.ObtenerCategorias(Pertenece.Formulario.ToString()))
                {
                    if (cat.estado == 1)
                    {
                        Button btn = new Button();
                        btn.FlatAppearance.BorderColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = new Font("Microsoft Sans Serif", 11.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        btn.Image = global::SIME_UTN.Properties.Resources.form;
                        btn.Name = cat.descripcion; ;
                        btn.Size = new Size(155, 139);
                        btn.Text = cat.descripcion;
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextImageRelation = TextImageRelation.ImageAboveText;
                        btn.UseVisualStyleBackColor = false;
                        btn.Location = new System.Drawing.Point(x, y);
                        btn.Click += Btn_Click;

                        pnForms.Controls.Add(btn);

                        x += 155;
                        if (x > pnForms.Width-100)
                        {
                            x = 6;
                            y += 139;
                        }
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

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmFormulario frm = new frmFormulario(btn.Name);
            frm.ShowDialog(this);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
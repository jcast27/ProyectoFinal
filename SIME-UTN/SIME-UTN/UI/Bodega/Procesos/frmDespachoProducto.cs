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
using SIME_UTN.DTOs;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmDespachoProducto : Form
    {
        string usuarioLogueado = "";
        GestorUsuarioTable gestor = null;
        GestorRegistroBodega gestorBodega = null;
        public frmDespachoProducto()
        {
            InitializeComponent();
            RefrescarLista();
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

        private void frmDespachoProducto_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }

        private void RefrescarLista()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Bodegas";
            dt.Columns.Add(new DataColumn("IDRegistroBodega"));
            dt.Columns.Add(new DataColumn("Nombre"));
            dt.Columns.Add(new DataColumn("Descripcion"));

            try
            {
                gestorBodega = GestorRegistroBodega.GetInstance();

                List<RegistroBodegaTipoBodegaDTO> lista = new List<RegistroBodegaTipoBodegaDTO>(gestorBodega.ObtenertBodegas());
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].tipobodega.Equals("Despacho"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["IDRegistroBodega"] = lista[i].idregistrobodega;
                        dr["Nombre"] = lista[i].nombre;
                        dr["Descripcion"] = lista[i].descripcion;
                        dt.Rows.Add(dr);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gCDespachoP.DataSource = dt;

        }

        private void gCBodegas_Click(object sender, EventArgs e)
        {
            mBtnDespachar.Enabled = true;
        }

        private void mBtnDespachar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdDespacho frm = new frmAdDespacho(int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodega").ToString()));
            frm.ShowDialog(this);
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdRuta.ShowDialog(this) == DialogResult.OK)
            {
                gCDespachoP.ExportToXlsx(sfdRuta.FileName);
            }
        }
    }
}
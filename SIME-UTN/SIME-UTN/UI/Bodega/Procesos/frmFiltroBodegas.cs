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
using SIME_UTN.DTOs;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmFiltroBodegas : DevExpress.XtraEditors.XtraForm
    {
     
        private RegistroBodegaTipoBodegaDTO bodegaSeleccionada;
        GestorRegistroBodega gestorBodega = null;

        public RegistroBodegaTipoBodegaDTO BodegaSeleccionada
        {
            get { return bodegaSeleccionada; }
            set { bodegaSeleccionada = value; }
        }

        public frmFiltroBodegas()
        {
            InitializeComponent();
        }


        private void RefrescaLista()
        {
            try
            {
                gestorBodega = new GestorRegistroBodega();
                List<RegistroBodegaTipoBodegaDTO> lista = gestorBodega.ObtenertBodegas();
                this.gCBodegas.DataSource = null;
                this.gCBodegas.DataSource = lista;



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "Macrobiotica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gCProductos_Click(object sender, EventArgs e)
        {
            try
            {

                bodegaSeleccionada = ((List<RegistroBodegaTipoBodegaDTO>)gridView1.DataSource)[gridView1.FocusedRowHandle] as RegistroBodegaTipoBodegaDTO;
                Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFiltroBodegas_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
            RefrescaLista();
        }
    }
}
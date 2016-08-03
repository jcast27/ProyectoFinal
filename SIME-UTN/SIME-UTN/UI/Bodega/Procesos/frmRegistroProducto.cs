﻿using System;
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

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmRegistroProducto : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        static string nombre = "";
        RegistroProducto unRegProd = null;
        static RegistroProducto registroEstatico = null;
        GestorRegistroProducto gestorRegistro = null;

        public frmRegistroProducto()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }

     

        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdRegistroProducto ofrmAdRegistroProducto = new frmAdRegistroProducto();
            ofrmAdRegistroProducto.ShowDialog(this);
            frmRegistroProducto_Load(null, null);
            
        }

        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRBodegaNombre.sp_SELECT_RegistroBodega_All' table. You can move, or remove it, as needed.
            this.sp_SELECT_RegistroBodega_AllTableAdapter.Fill(this.dataSetRBodegaNombre.sp_SELECT_RegistroBodega_All);
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsuario.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataSetUsuario.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'dataSetRegistroProducto.RegistroProducto' Puede moverla o quitarla según sea necesario.
            this.registroProductoTableAdapter.Fill(this.dataSetRegistroProducto.RegistroProducto);
            //FALTARIA UN DATASET??????????
            // this.sp_SELECT_RegistroProducto_AllTableAdapter.Fill(this.dataSetRMezclas.sp_SELECT_RegistroMezcla_All);
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
            registroEstatico = new RegistroProducto();
        }

        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmAdRegistroProducto ofrmAdRegistroProducto = new frmAdRegistroProducto(registroEstatico);
            ofrmAdRegistroProducto.ShowDialog(this);
            frmRegistroProducto_Load(null, null);
        }

        public void DesactivarRegistroProductos()
        {
            gestorRegistro = new GestorRegistroProducto();
            unRegProd = new RegistroProducto();
            RegistroBodega bodega = new RegistroBodega();
            try
            {
                bodega.idRegistroBodega = int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodega").ToString());
                unRegProd.idIngresoProducto = int.Parse(gridView1.GetFocusedRowCellValue("IDIngresoProducto").ToString());
                unRegProd.descripcion = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                unRegProd.Bodega = bodega;


                if (MessageBox.Show("¿Seguro que desea eliminar el registro " + unRegProd.descripcion + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorRegistro.EliminarRegistroProducto(unRegProd.Bodega.idRegistroBodega,unRegProd.idIngresoProducto, unRegProd.descripcion, usuarioLogueado);
                    
                    MessageBox.Show("El registro " + unRegProd.descripcion + " fue eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRegistroProducto_Load(null, null);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DesactivarRegistroProductos();
                e.Handled = true;
            }
        }

        private void mBtnEliminar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DesactivarRegistroProductos();
        }

        private void gCBodegas_Click(object sender, EventArgs e)
        {
            UsuarioTable user = new UsuarioTable();
            try
            {
                RegistroBodega bodega = new RegistroBodega();
                System.Data.DataRowView row = null;
                mBtnModificar.Enabled = true;
                mBtnEliminar.Enabled = true;
                registroEstatico.idIngresoProducto = int.Parse(gridView1.GetFocusedRowCellValue("IDIngresoProducto").ToString());
                registroEstatico.descripcion = gridView1.GetFocusedRowCellValue("Descripcion").ToString();
                registroEstatico.solicitudAvatar = gridView1.GetFocusedRowCellValue("SolicitudAvatar").ToString();
                registroEstatico.fechaIngreso = gridView1.GetFocusedRowCellValue("FechaIngreso").ToString();
                bodega.idRegistroBodega = int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodega").ToString());
                row = LookUpEditBodega.GetDataSourceRowByKeyValue(int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodega").ToString())) as DataRowView;
                bodega.nombre = row.Row["nombre"].ToString();
                registroEstatico.Bodega = bodega;
               
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
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

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmTrasladosDeProductos : Form
    {
        string usuarioLogueado = "";
        UsuarioTable usuario = null;
        GestorUsuarioTable gestor = null;
        TrasladoProducto traslado = null;
        static TrasladoProducto trasladoEstatico = null;
        GestorTrasladoProducto gestorTraslado = null;
        public frmTrasladosDeProductos()
        {
            InitializeComponent();
          
        }

      
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
        }


        private void mBtnModificar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
           
        }
        private void mBtnAgregar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (mBtnAgregar.Caption == "Agregar")
            {
                frmAdTrasladoProductos ofrmAdTrasladoProducto = new frmAdTrasladoProductos();
                ofrmAdTrasladoProducto.ShowDialog(this);
                frmTrasladosDeProductos_Load(null, null);
            }
            if(mBtnAgregar.Caption== "Modificar")
            {
                frmModTrasladoProductos ofrmModTrasladoProducto = new frmModTrasladoProductos(trasladoEstatico);
                ofrmModTrasladoProducto.ShowDialog(this);
                frmTrasladosDeProductos_Load(null, null);
            }

        }

        private void frmTrasladosDeProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTrasladoProducto.sp_SELECT_TrasladoProducto_All_DTO' table. You can move, or remove it, as needed.
            this.sp_SELECT_TrasladoProducto_All_DTOTableAdapter.Fill(this.dataSetTrasladoProducto.sp_SELECT_TrasladoProducto_All_DTO);
            trasladoEstatico = new TrasladoProducto();
            UsuarioLogueado();
            Icon = Properties.Resources.Icono;
            mBtnAceptar.Enabled = false;
            mBtnDeclinar.Enabled = false;
            mBtnAgregar.Caption = "Agregar";
        }
        /// <summary>
        /// Metodo que permite extrae el traslado seleccionado del grid y colocar la Información en los campos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gCTraslados_Click(object sender, EventArgs e)
        {
            try
            {
              
                RegistroBodega bodegaOrigen = new RegistroBodega();
                RegistroBodega bodegaDestino = new RegistroBodega();
                UsuarioTable unUsuario = new UsuarioTable();
                TipoTraslado tipoTraslado = new TipoTraslado();
                EstadoTraslado estadoTraslado = new EstadoTraslado();
                           
                trasladoEstatico.idTraslado = int.Parse(gridView1.GetFocusedRowCellValue("idtraslado").ToString());
                bodegaOrigen.idRegistroBodega = int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodegaOrigen").ToString());
                bodegaOrigen.nombre = gridView1.GetFocusedRowCellValue("BodegaOrigen").ToString();
                trasladoEstatico.BodegaOrigen = bodegaOrigen;
                bodegaDestino.idRegistroBodega = int.Parse(gridView1.GetFocusedRowCellValue("IDRegistroBodegaDestino").ToString());
                bodegaDestino.nombre = gridView1.GetFocusedRowCellValue("BodegaDestino").ToString();
                trasladoEstatico.BodegaDestino = bodegaDestino;
                unUsuario.codigoUsuario = int.Parse(gridView1.GetFocusedRowCellValue("IDUsuario").ToString());
                unUsuario.usuario = gridView1.GetFocusedRowCellValue("Usuario").ToString();
                trasladoEstatico.Usuario = unUsuario;
                trasladoEstatico.observaciones = gridView1.GetFocusedRowCellValue("Observaciones").ToString();
                trasladoEstatico.fechaTraslado = gridView1.GetFocusedRowCellValue("fechatraslado").ToString();
                tipoTraslado.idTipoTraslado = int.Parse(gridView1.GetFocusedRowCellValue("IDTipoTraslado").ToString());
                tipoTraslado.descripcion = gridView1.GetFocusedRowCellValue("TipoTraslado").ToString();
                trasladoEstatico.TipoTraslado = tipoTraslado;
                estadoTraslado.idEstadoTraslado = int.Parse(gridView1.GetFocusedRowCellValue("IDEstadoTraslado").ToString());
                estadoTraslado.descripcion = gridView1.GetFocusedRowCellValue("EstadoTraslado").ToString();
                trasladoEstatico.EstadoTraslado = estadoTraslado;
                if (trasladoEstatico.EstadoTraslado.idEstadoTraslado == 1)
                {
                    mBtnAgregar.Caption = "Modificar";
                    mBtnAceptar.Enabled = true;
                    mBtnDeclinar.Enabled = true;
                }
                else
                {
                    mBtnAceptar.Enabled = false;
                    mBtnDeclinar.Enabled = false;
                    mBtnAgregar.Caption = "Agregar";
                    MessageBox.Show("No se puede utilizar este traslado debido a que se encuentra: " + trasladoEstatico.EstadoTraslado.descripcion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Metodo que declina un traslado
        /// </summary>
        public void DeclinarTraslados()
        {

            gestorTraslado = new GestorTrasladoProducto();
            try
            {
               

                    if (MessageBox.Show("¿Seguro que desea declinar el traslado # " + trasladoEstatico.idTraslado + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gestorTraslado.DeclinarTraslado(trasladoEstatico, usuarioLogueado);
                        MessageBox.Show("El traslado # " + trasladoEstatico.idTraslado + " fue declinado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTrasladosDeProductos_Load(null, null);
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que acepta un traslado
        /// </summary>
        public void AceptarTraslados()
        {

            gestorTraslado = new GestorTrasladoProducto();
            try
            {


                if (MessageBox.Show("¿Seguro que desea aceptar el traslado # " + trasladoEstatico.idTraslado + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gestorTraslado.AceptarTraslado(trasladoEstatico, usuarioLogueado);
                    MessageBox.Show("El traslado # " + trasladoEstatico.idTraslado + " fue aceptado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrasladosDeProductos_Load(null, null);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "SIME-UTN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Invoca al metodo desactivar un traslado, al seleccionar un row del grid y pulsar el boton Declinar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnDeclinar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            DeclinarTraslados();
        }

        /// <summary>
        /// Invoca al metodo acepta un traslado, al seleccionar un row del grid y pulsar el boton Aceptar del menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnAceptar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AceptarTraslados();
        }
    }
}
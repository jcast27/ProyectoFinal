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
using SIME_UTN.Entities;

namespace SIME_UTN.UI.Bodega.Procesos
{
    public partial class frmAdDespacho : DevExpress.XtraEditors.XtraForm
    {
        GestorUsuarioTable gestor = null;
        GestorBodega gb = new GestorBodega();
        int idBodega = 0;
        string user;

        public frmAdDespacho(int idBodegap)
        {
            InitializeComponent();
            idBodega = idBodegap;
            RefrescarBodega(idBodega);
        }

        private void RefrescarBodega(int idBodega)
        {
            List<PBodega> lista = new List<PBodega>();
            lista = gb.ObtenerProductosPorIdBodega(idBodega);
            gcProducto.DataSource = lista;
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            user = gestor.ObtenerUsuarioLogeado();
        }

        private void frmAdDespachoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetRMezclas.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSetRMezclas.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dataSetFuncionario.Funcionario' Puede moverla o quitarla según sea necesario.
            this.funcionarioTableAdapter.Fill(this.dataSetFuncionario.Funcionario);
            Icon = Properties.Resources.Icono;
            UsuarioLogueado();
            cmbMezcla.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
        }

        private void mBtnSalir_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double cantProd = int.Parse(gridView1.GetFocusedRowCellValue("contenido").ToString());

            double cantDesp = validarCampos(cantProd, 0);

            if (cantDesp > 0)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("Producto.idProducto").ToString());

                List<PBodega> listaProd = (List<PBodega>)gcProducto.DataSource;

                int indexProd = listaProd.FindIndex(a => a.Producto.idProducto == id);

                listaProd[indexProd].contenido -= cantDesp;

                List<PBodega> listaDesp = new List<PBodega>();

                if (gcDespacho.DataSource != null)
                {
                    listaDesp = (List<PBodega>)gcDespacho.DataSource;
                }

                int indexDesp = listaDesp.FindIndex(a => a.Producto.idProducto == id);

                if (indexDesp == -1)
                {
                    PBodega nuevo = new PBodega();
                    nuevo.estado = listaProd[indexProd].estado;
                    nuevo.idBodega = listaProd[indexProd].idBodega;
                    nuevo.Producto = listaProd[indexProd].Producto;
                    nuevo.RegistroBodega = listaProd[indexProd].RegistroBodega;
                    nuevo.UnidadMedida = listaProd[indexProd].UnidadMedida;
                    nuevo.contenido = cantDesp;
                    listaDesp.Add(nuevo);
                }
                else
                {
                    listaDesp[indexDesp].contenido += cantDesp;
                }


                gcProducto.DataSource = null;
                gcDespacho.DataSource = null;

                gcProducto.DataSource = listaProd;
                gcDespacho.DataSource = listaDesp;
            }



        }

        public double validarCampos(double cantProd, double cantDesp)
        {

            double r = cantDesp;

            if (double.TryParse(txtCantidadProd.Text, out cantDesp))
            {
                if (cantDesp > 0)
                {
                    r = int.Parse(txtCantidadProd.Text);
                    ePError.Clear();
                }
                else
                {
                    ePError.SetError(txtCantidadProd, "Cantidad no válida");
                    txtCantidadProd.Focus();
                    r = 0;
                }
            }
            else
            {
                ePError.SetError(txtCantidadProd, "Cantidad no válida");
                txtCantidadProd.Focus();
                r = 0;
            }

            cantProd = cantProd - cantDesp;

            if (cantProd < 0)
            {
                ePError.SetError(txtCantidadProd, "Productos Insuficientes");
                txtCantidadProd.Focus();
                r = 0;
            }

            return r;
        }

        private void txtRemover_Click(object sender, EventArgs e)
        {
            double cantProd = int.Parse(gridView2.GetFocusedRowCellValue("contenido").ToString());

            double cantDevol = validarCampos(cantProd, 0);

            if (cantDevol > 0)
            {
                int id = int.Parse(gridView2.GetFocusedRowCellValue("Producto.idProducto").ToString());

                List<PBodega> listaProd = (List<PBodega>)gcProducto.DataSource;
                List<PBodega> listaDesp = listaDesp = (List<PBodega>)gcDespacho.DataSource;

                int indexProd = listaProd.FindIndex(a => a.Producto.idProducto == id);
                int indexDesp = listaDesp.FindIndex(a => a.Producto.idProducto == id);

                listaProd[indexProd].contenido += cantDevol;

                double prodDesp = listaDesp[indexDesp].contenido - cantDevol;

                if (prodDesp == 0)
                {
                    listaDesp.RemoveAt(indexDesp);
                }
                else
                {
                    listaDesp[indexDesp].contenido -= cantDevol;
                }

                gcProducto.DataSource = null;
                gcDespacho.DataSource = null;

                gcProducto.DataSource = listaProd;
                gcDespacho.DataSource = listaDesp;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                gridView1.ActiveFilterString = "[Producto.nombreProducto] LIKE '%%'";
            }
            else
            {
                gridView1.ActiveFilterString = "[Producto.nombreProducto] LIKE '%" + txtBuscar.Text + "%'";
            }

        }

        private void mBtnNuevo_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            RefrescarBodega(idBodega);
            cmbMezcla.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
            gcDespacho.DataSource = null;
            txtBuscar.Clear();
            txtCantidadProd.Clear();
            txtCantidadMez.Clear();
            txtBuscar.Focus();
        }

        private void mBtnAceptar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (validarRegistro())
            {
                List<PBodega> lista = (List<PBodega>)gcDespacho.DataSource;

                GestorFuncionario gf = GestorFuncionario.GetInstance();
                Funcionario f = gf.ObtenerFuncionarioId(int.Parse(cmbFuncionario.SelectedValue.ToString()));
                UsuarioTable usuario = gestor.ValidarUsuarioPorUsuario(user);
                GestorDespacho gd = GestorDespacho.GetInstance();

                try
                {
                    int idDespacho = gd.GuardarDespacho(idBodega, usuario, txtObservaciones.Text, f);

                    foreach (PBodega pb in lista)
                    {
                        pb.idBodega = idBodega;
                        pb.estado = 1;
                        gd.GuardarDespachoDetalle(idDespacho, pb);
                    }

                    MessageBox.Show("Despacho realizado con éxito", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al despachar el producto\r\nDetalle del error: " + error.Message, "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool validarRegistro()
        {

            bool r = false;

            if (cmbFuncionario.SelectedIndex == -1)
            {
                ePError.SetError(cmbFuncionario, "Seleccione un funcionario");
                cmbFuncionario.Focus();
                r = false;
            }
            else if (gridView2.DataRowCount == 0)
            {
                ePError.SetError(gcDespacho, "No hay productos para despachar");
                gcDespacho.Focus();
                r = false;
            }
            else if (txtObservaciones.Text == "")
            {
                ePError.SetError(txtObservaciones, "Favor ingresar comentarios");
                txtObservaciones.Focus();
                r = false;
            }
            else
            {
                ePError.Clear();
                r = true;
            }

            return r;
        }
    }
}
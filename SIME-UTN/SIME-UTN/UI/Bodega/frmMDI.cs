using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using SIME_UTN.Gestores;
using DevExpress.XtraBars.Docking2010.Views;

namespace SIME_UTN.UI.Bodega
{
    public partial class frmMDI : DevExpress.XtraEditors.XtraForm
    {
        static string tipoDeProceso ="";
        static string usuarioLogueado = "";
        GestorUsuarioTable gestor = null;
        public bool modulo = false;
        public string name = "Bodega";

        public frmMDI()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
           // CrearDocuemtnos();
            this.UsuarioLogueado();
            security();
        }

        public frmMDI(bool estado)
        {
            InitializeComponent();
            this.UsuarioLogueado();
            security();
        }

        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
            usuarioTSMI.Text = "Usuario: " + usuarioLogueado;
        }

        public void security()
        {
            try
            {
                string perfil = gestor.ValidarUsuarioPorUsuario(usuarioLogueado).perfil;

                if (perfil.Equals("Despachador"))
                {
                    mBtnAdministracion.Visible = false;
                }
                else
                {
                    mBtnAdministracion.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document.Caption == "Ventana Usuarios")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmUsuarios();
            if (e.Document.Caption == "Ventana Productos")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmProductos();
            if (e.Document.Caption == "Ventana Funcionarios")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmFuncionarios();
            if (e.Document.Caption == "Ventana Bodegas")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmBodegas();
            if (e.Document.Caption == "Ventana Ubicaciones")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmUbicaciones();
            if (e.Document.Caption == "Ventana Unidad De Medida")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmUnidadesMedida();
            if (e.Document.Caption == "Ventana Departamentos")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmDepartamentos();
            if (e.Document.Caption == "Ventana Mezclas")
                e.Control = new SIME_UTN.UI.Bodega.Administracion.frmMezclas();
            if (e.Document.Caption == "Ventana Registro Producto")
                e.Control = new SIME_UTN.UI.Bodega.Procesos.frmRegistroProducto();
            if (e.Document.Caption == "Ventana Despacho Producto")
                e.Control = new SIME_UTN.UI.Bodega.Procesos.frmDespachoProducto();
            if (e.Document.Caption == "Ventana Traslado Producto")
                e.Control = new SIME_UTN.UI.Bodega.Procesos.frmTrasladosDeProductos();
            if (e.Document.Caption == "Ventana Inventario Mínimo")
                e.Control = new SIME_UTN.UI.Bodega.Inventarios.frmInventarioMinimo();
            if (e.Document.Caption == "Ventana Inventario Máximo")
                e.Control = new SIME_UTN.UI.Bodega.Inventarios.frmInventarioMaximo();
            if (e.Document.Caption == "Ventana Inventario Actual")
                e.Control = new SIME_UTN.UI.Bodega.Inventarios.frmInventarioActual();
            //if (e.Control == null)
            //    e.Control = new System.Windows.Forms.Control();
        }

        private FlyoutAction createCloseAction(Flyout flyout)
        {
            FlyoutAction closeaction = new FlyoutAction() { Caption = "Confirmación", Description = "¿Desea cerrar esta aplicación?" };
            // closeaction.Description = "Desea Cerrar Esta Aplicacion?";
            FlyoutCommand comandoYes = new FlyoutCommand() { Text = "Sí", Result = System.Windows.Forms.DialogResult.Yes };
            FlyoutCommand comandoNO = new FlyoutCommand() { Text = "No", Result = System.Windows.Forms.DialogResult.No };
            closeaction.Commands.Add(comandoYes);
            closeaction.Commands.Add(comandoNO);
            return closeaction;
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlyoutCloseAction.Action = this.createCloseAction(FlyoutCloseAction);
            if (windowsUIView1.ShowFlyoutDialog(FlyoutCloseAction) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


        private void mBtnAdministracion_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CrearDocumentosProceso(false);
            this.CrearDocumentosAdministracion(true);
            tipoDeProceso = "Administracion";
        }

        private void mBtnProcesos_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.CrearDocumentosAdministracion(false);
            CrearDocumentosProceso(true);
            tipoDeProceso = "Procesos";
        }

        private void mBtnInventarios_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.CrearDocumentosAdministracion(false);
            this.CrearDocumentosProceso(false);
            this.CrearDocumentosInventario(true);
            tipoDeProceso = "Inventarios";
        }
        //Se crea un elemento que sera agregado al frame
        public TileItemElement CrearElemento(String nombreElemento,Image imagen)
        {
            Font font = new Font("Tahoma", 15.0f, FontStyle.Underline | FontStyle.Underline);
            TileItemElement elemento = new TileItemElement();
            elemento.Text = nombreElemento;
            elemento.Image = imagen;
            elemento.ImageAlignment = TileItemContentAlignment.TopCenter;
            elemento.ImageScaleMode = TileItemImageScaleMode.Default;
            elemento.TextAlignment = TileItemContentAlignment.BottomCenter;
            elemento.Appearance.Normal.ForeColor = Color.White;
            elemento.Appearance.Normal.BackColor = Color.Transparent;
            elemento.Appearance.Normal.Font = font;
            return elemento;
        }

        //Se crea el frame que contiene el elemento y q sera agregado a un tile
        public TileItemFrame crearFrame(String nombreElemento, Image imagen)
        {
            TileItemFrame frame = new TileItemFrame();
            frame.Appearance.BackColor = Color.Transparent;
            frame.Appearance.BorderColor = Color.Black;
            frame.Elements.Add(this.CrearElemento(nombreElemento, imagen));
            return frame;
        }

        //Se crea un tile que contendra el frame
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile crearTile(Document document, String nombreElemento, String grupo, Image imagen,Boolean estado)
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile();
            tile1.Group = grupo;
            tile1.Document = document;
            tile1.Frames.Add(this.crearFrame(nombreElemento, imagen));
            tile1.Visible = estado;
            return tile1;
        }

        public void CrearDocumentosAdministracion(Boolean estado)
        {
            string nombreElemento = "";
            string grupo = "";
            Image imagen = null;
           
            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();
            //Creating documents
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docUsuarios = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Usuarios" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docProductos = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Productos" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docFuncionarios = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Funcionarios" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docBodegas = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Bodegas" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docUnidadDeMedida = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Unidad De Medida" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docUbicaciones = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Ubicaciones" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docDepartamentos = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Departamentos" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docMezclas = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Mezclas" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {docUsuarios,docProductos,docFuncionarios,docBodegas,docUnidadDeMedida,docUbicaciones,docDepartamentos, docMezclas});
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 120;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;
            //Propiedades para el decumento Usuarios
            grupo = "Group 1";
            imagen = Properties.Resources.usuarios;
            nombreElemento = "Usuarios";
            tileContainer2.Items.Add(this.crearTile(docUsuarios, nombreElemento,grupo,imagen,estado));

            //Propiedades para el decumento Productos
            grupo = "Group 2";
            imagen = Properties.Resources.productos;
            nombreElemento = "Productos";
            tileContainer2.Items.Add(this.crearTile(docProductos, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Funcionarios
            grupo = "Group 3";
            imagen = Properties.Resources.funcionarios;
            nombreElemento = "Funcionarios";
            tileContainer2.Items.Add(this.crearTile(docFuncionarios, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Bodegas
            grupo = "Group 1";
            imagen = Properties.Resources.warehouse;
            nombreElemento = "Bodegas";
            tileContainer2.Items.Add(this.crearTile(docBodegas, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Unidad Medida
            grupo = "Group 2";
            imagen = Properties.Resources.unidadMedida;
            nombreElemento = "Unidad De Medida";
            tileContainer2.Items.Add(this.crearTile(docUnidadDeMedida, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Ubicaciones
            grupo = "Group 3";
            imagen = Properties.Resources.Localizacion;
            nombreElemento = "Ubicaciones";
            tileContainer2.Items.Add(this.crearTile(docUbicaciones, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Departamentos
            grupo = "Group 1";
            imagen = Properties.Resources.Departamento;
            nombreElemento = "Departamentos";
            tileContainer2.Items.Add(this.crearTile(docDepartamentos, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Mezclas
            grupo = "Group 2";
            imagen = Properties.Resources.mezclas;
            nombreElemento = "Mezclas";
            tileContainer2.Items.Add(this.crearTile(docMezclas, nombreElemento, grupo, imagen, estado));


            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }

        public void CrearDocumentosProceso(Boolean estado)
        {
            string nombreElemento = "";
            string grupo = "";
            Image imagen = null;

            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();
            //Creating documents
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Registro Producto" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Despacho Producto" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc3 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Traslado Producto" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { doc1,doc2,doc3});
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 120;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;
            //Propiedades para el decumento Ingreso Productos
            grupo = "Group 1";
            imagen = Properties.Resources.registro;
            nombreElemento = "Registro De Productos";
            tileContainer2.Items.Add(this.crearTile(doc1, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Despacho Productos
            grupo = "Group 2";
            imagen = Properties.Resources.registro;
            nombreElemento = "Despacho De Productos";
            tileContainer2.Items.Add(this.crearTile(doc2, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Traslado Productos
            grupo = "Group 1";
            imagen = Properties.Resources.registro;
            nombreElemento = "Traslado De Productos";
            tileContainer2.Items.Add(this.crearTile(doc3, nombreElemento, grupo, imagen, estado));



            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }


        public void CrearDocumentosInventario(Boolean estado)
        {
            string nombreElemento = "";
            string grupo = "";
            Image imagen = null;

            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();
            //Creating documents
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docMinimo = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Inventario Mínimo" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docMaximo = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Inventario Máximo" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docActual = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Inventario Actual" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { docMinimo, docMaximo, docActual });
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 120;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;
            //Propiedades para el decumento Usuarios
            grupo = "Group 1";
            imagen = Properties.Resources.min;
            nombreElemento = "Inventario Mínimo";
            tileContainer2.Items.Add(this.crearTile(docMinimo, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Productos
            grupo = "Group 2";
            imagen = Properties.Resources.max;
            nombreElemento = "Inventario Máximo";
            tileContainer2.Items.Add(this.crearTile(docMaximo, nombreElemento, grupo, imagen, estado));

            //Propiedades para el decumento Funcionarios
            grupo = "Group 3";
            imagen = Properties.Resources.inven;
            nombreElemento = "Inventario Actual";
            tileContainer2.Items.Add(this.crearTile(docActual, nombreElemento, grupo, imagen, estado));


            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }


        private void windowsUIView1_BackButtonClick(object sender, BackButtonClickEventArgs e)
        {
            if (tipoDeProceso == "Administracion")
            {
                this.CrearDocumentosAdministracion(true);
            }
            if (tipoDeProceso == "Procesos")
            {
                this.CrearDocumentosProceso(true);
            }
            if (tipoDeProceso == "Inventarios")
            {
                this.CrearDocumentosInventario(true);
            }
             
        }

        private void windowsUIView1_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            e.DisposeControl = true;
        }


        private void cambiarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario ofrNuevoUsuario = new frmCambioUsuario(usuarioLogueado);
            ofrNuevoUsuario.ShowDialog(this);
            this.UsuarioLogueado();
            string perfil = gestor.ValidarUsuarioPorUsuario(usuarioLogueado).perfil;

            if (ofrNuevoUsuario.DialogResult == DialogResult.OK)
            {
                if (perfil.Equals("Administrador"))
                {
                    if (tipoDeProceso == "Administracion")
                    {
                        this.CrearDocumentosAdministracion(true);
                    }
                }else
                {
                    this.CrearDocumentosAdministracion(false);
                }
                if (tipoDeProceso == "Procesos")
                {
                    this.CrearDocumentosProceso(true);
                }
                if (tipoDeProceso == "Inventarios")
                {
                    this.CrearDocumentosInventario(true);
                }
            }
            security();
        }

        private void cambiarContrasennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContrasenna ofrmCambioContrasenna = new frmCambioContrasenna(usuarioLogueado);
            ofrmCambioContrasenna.ShowDialog(this);
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }

        private void cambiarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modulo = true;
            FormClosing -= frmMDI_FormClosing;
            Close();
        }
    }
}
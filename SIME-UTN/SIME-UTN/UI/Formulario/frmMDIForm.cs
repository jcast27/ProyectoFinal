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

namespace SIME_UTN.UI.Formulario
{
    public partial class frmMDIForm : DevExpress.XtraEditors.XtraForm
    {
        static string tipoDeProceso ="";
        static string usuarioLogueado = "";
        GestorUsuarioTable gestor = null;
        public frmMDIForm()
        {
           
            Thread tardar = new Thread(new ThreadStart(this.SplashScreen));
            tardar.Start();
            Thread.Sleep(6000); // Tardanza para iniciar aplicacion (6000)
            InitializeComponent();
            tardar.Abort();
            // Handling the QueryControl event that will populate all automatically generated Documents
           // CrearDocuemtnos();
            this.UsuarioLogueado();
           
           
        }
        public frmMDIForm(bool estado)
        {

            InitializeComponent();
            this.UsuarioLogueado();

        }
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            usuarioLogueado = gestor.ObtenerUsuarioLogeado();
            usuarioTSMI.Text = "Usuario: " + usuarioLogueado;
        }



        public void SplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document.Caption == "Ventana Items")
                e.Control = new SIME_UTN.UI.Formulario.Administracion.frmItem();
            if (e.Document.Caption == "Ventana Categorías")
                e.Control = new SIME_UTN.UI.Formulario.Administracion.frmCategoria();

            //if (e.Control == null)
            //    e.Control = new System.Windows.Forms.Control();

            /*switch (e.Document.Caption)
            {
                case "Ventana Usuarios":
                    e.Control = new SIME_UTN.UI.Bodega.Administracion.frmUsuarios();
                    break;
                case "Ventana Productos":
                    e.Control = new SIME_UTN.UI.Bodega.Administracion.frmProductos();
                    break;
                case "Ventana Ingreso Producto":
                    e.Control = new SIME_UTN.UI.Bodega.Procesos.frmRegistroProducto();
                    break;
            }*/

        }

        private FlyoutAction createCloseAction(Flyout flyout)
        {
            FlyoutAction closeaction = new FlyoutAction() { Caption = "Confirmación", Description = "Desea Cerrar Esta Aplicacion?" };
            // closeaction.Description = "Desea Cerrar Esta Aplicacion?";
            FlyoutCommand comandoYes = new FlyoutCommand() { Text = "Si", Result = System.Windows.Forms.DialogResult.Yes };
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

        //Se crea un elemento que sera agregado al frame
        public TileItemElement CrearElemento(String nombreElemento,Image imagen)
        {
            Font font = new Font("Tahoma", 20.0f,FontStyle.Underline| FontStyle.Underline);
            TileItemElement elemento = new TileItemElement();
            elemento.Text = nombreElemento;
            elemento.Image = imagen;
            elemento.ImageScaleMode = TileItemImageScaleMode.Stretch;
            elemento.TextAlignment = TileItemContentAlignment.BottomLeft;
            elemento.Appearance.Normal.ForeColor = Color.Maroon;
            elemento.Appearance.Normal.BackColor = Color.MediumAquamarine;
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
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Items" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Categorías" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { doc1,doc2 });
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 200;

            //Propiedades para el documento Items
            grupo = "Group 1";
            imagen = Properties.Resources.usuarios1;
            nombreElemento = "Items";
            tileContainer2.Items.Add(this.crearTile(doc1,nombreElemento,grupo,imagen,estado));

            //Propiedades para el documento Categorías
            grupo = "Group 2";
            imagen = Properties.Resources.productos1;
            nombreElemento = "Categorías";
            tileContainer2.Items.Add(this.crearTile(doc2, nombreElemento, grupo, imagen, estado));

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
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Ingreso Producto" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { doc1});
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 200;

            //Propiedades para el decumento Ingreso Productos
            grupo = "Group 1";
            imagen = Properties.Resources.registroProducto;
            nombreElemento = "Ingreso De Productos";
            tileContainer2.Items.Add(this.crearTile(doc1, nombreElemento, grupo, imagen, estado));



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
             
        }

        private void windowsUIView1_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            e.DisposeControl = true;
        }


        private void cambiarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario ofrNuevoUsuario = new frmCambioUsuario(usuarioLogueado);
            ofrNuevoUsuario.ShowDialog(this);


            if (ofrNuevoUsuario.DialogResult == DialogResult.OK)
            {
                this.UsuarioLogueado();
                if (tipoDeProceso == "Administracion")
                {
                    this.CrearDocumentosAdministracion(true);
                }
                if (tipoDeProceso == "Procesos")
                {
                    this.CrearDocumentosProceso(true);
                }
            }

        }

        private void cambiarContrasennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContrasenna ofrmCambioContrasenna = new frmCambioContrasenna(usuarioLogueado);
            ofrmCambioContrasenna.ShowDialog(this);
        }
    }
}
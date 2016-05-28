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

namespace SIME_UTN.UI
{
    public partial class frmMDI : DevExpress.XtraEditors.XtraForm
    {
       
        GestorUsuarioTable gestor = null;
        frmUsuarios ofrmUsuarios = new frmUsuarios();
        public frmMDI()
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
        public void UsuarioLogueado()
        {
            gestor = GestorUsuarioTable.GetInstance();
            btnUsuarioLogueado.Text = "Usuario: " + gestor.ObtenerUsuarioLogeado();
        }



        public void SplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document.Caption == "Ventana Usuarios")
                e.Control = new SIME_UTN.UI.frmUsuarios();
            if (e.Document.Caption == "frmProductosDocument")
                e.Control = new SIME_UTN.UI.frmProductos();
            //if (e.Control == null)
            //    e.Control = new System.Windows.Forms.Control();



        }

        private FlyoutAction createCloseAction(Flyout flyout)
        {
            FlyoutAction closeaction = new FlyoutAction() { Caption = "Confirmacion", Description = "Desea Cerrar Esta Aplicacion?" };
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

 
            this.CrearDocuemtoUsuarios();
       
        }

        private void mBtnProcesos_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmUsuariosTile.Visible = false;
            frmProductosTile.Visible = false;
        }

        public void CrearDocuemtoUsuarios()
        {

            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();
            //Creating documents
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Ventana Usuarios" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { doc1 });
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 200;
          
            //Se crea un elemento que sera agregado al frame
            TileItemElement elemento = new TileItemElement();
            elemento.Text = "Usuarios";
            elemento.Image = Image.FromFile("C:\\Projects\\SIME-UTN\\SIME-UTN\\Resources\\usuarios1.jpg");
            elemento.ImageScaleMode = TileItemImageScaleMode.Stretch;

            //Se crea el frame que contiene el elemento y q sera agregado a un tile
            TileItemFrame frame = new TileItemFrame();
            frame.Appearance.BackColor = Color.Transparent;
            frame.Appearance.BorderColor = Color.Black;
            frame.Elements.Add(elemento);

            //Se crea un tile que contendra el frame
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile();
            tile1.Group = "Group 1";
            tile1.Document = doc1;
            tile1.Frames.Add(frame);
            tileContainer2.Items.Add(tile1);
            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;



        }


        private void windowsUIView1_BackButtonClick(object sender, BackButtonClickEventArgs e)
        {
            this.CrearDocuemtoUsuarios();
           
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

          
        }

        private void windowsUIView1_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            e.DisposeControl = true;
        }

     

        private void tileContainer1_Click(object sender, TileClickEventArgs e)
        {
          
        }
    }
}
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
using SIME_UTN.Entities;
using SIME_UTN.UI.Formulario.Procesos;
using SIME_UTN.DAL;
using SIME_UTN.UI.Reportes;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace SIME_UTN.UI.Formulario
{
    public partial class frmMDIForm : DevExpress.XtraEditors.XtraForm
    {
        static string tipoDeProceso = "";
        static string usuarioLogueado = "";
        GestorUsuarioTable gestor = null;
        public bool modulo = false;
        public string name = "Formulario";

        public frmMDIForm()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            // CrearDocuemtnos();
            this.UsuarioLogueado();
            security();
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

        public void security()
        {

            try
            {
                string perfil = gestor.ValidarUsuarioPorUsuario(usuarioLogueado).perfil;

                if (perfil.Equals("Despachador"))
                {
                    mBtnAdministracion.Visible = false;
                }
            }
            catch (Exception)
            { }
        }


        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document.Caption == "Ventana Items")
                e.Control = new Administracion.frmItem();
            else if (e.Document.Caption == "Ventana Categorías")
                e.Control = new Administracion.frmCategoria();
            else if (e.Document.Caption == "Ventana Usuarios")
                e.Control = new Bodega.Administracion.frmUsuarios();
            else if (e.Document.Caption == "Ventana Ubicaciones")
                e.Control = new Bodega.Administracion.frmUbicaciones();
            else if (e.Document.Caption == "Ventana Activos")
                e.Control = new Administracion.frmActivo();
            else if (e.Document.Caption == "Ventana Departamentos")
                e.Control = new Bodega.Administracion.frmDepartamentos();
            else if (e.Document.Caption == "Ventana Formularios")
                e.Control = new Formulario.Procesos.frmForms();
            else if (e.Document.Caption == "Ventana Empresa")
                e.Control = new Formulario.Administracion.frmEmpresa();

            if (e.Document.Caption == "Reporte Activos")
                e.Control = new SIME_UTN.UI.Reportes.frmReporte("btnActivo", usuarioLogueado, 0);
            if (e.Document.Caption == "Reporte Formularios")
                e.Control = new SIME_UTN.UI.Reportes.frmReporte("btnFormulario", usuarioLogueado, 0);
            if (e.Document.Caption == "Reporte Formularios Por Fecha")
                e.Control = new SIME_UTN.UI.Reportes.frmReporte("btnFormularioFecha", usuarioLogueado, 0);
            if (e.Document.Caption == "Reporte Utilizacion de Items")
                e.Control = new SIME_UTN.UI.Reportes.frmReporte("btnItem", usuarioLogueado, 0);

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
            CrearDocumentosFormulario(false);
            this.CrearDocumentosAdministracion(true);
            tipoDeProceso = "Administracion";
        }

        private void mBtnProcesos_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.CrearDocumentosAdministracion(false);
            this.CrearDocumentosReportes(false);
            this.CrearDocumentosFormulario(true);
            //CrearDocumentosFormulario(true);
            //tipoDeProceso = "Formularios";
            //frmForms frm = new frmForms();
            //frm.ShowDialog(this);
        }

        //Se crea un elemento que sera agregado al frame
        public TileItemElement CrearElemento(String nombreElemento, Image imagen)
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
        public Tile crearTile(Document document, String nombreElemento, String grupo, Image imagen, Boolean estado)
        {
            Tile tile1 = new Tile();
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
            Document doc0 = new Document { Caption = "Ventana Usuarios" };
            Document doc1 = new Document { Caption = "Ventana Items" };
            Document doc2 = new Document { Caption = "Ventana Categorías" };
            Document doc3 = new Document { Caption = "Ventana Ubicaciones" };
            Document doc4 = new Document { Caption = "Ventana Departamentos" };
            Document doc5 = new Document { Caption = "Ventana Activos" };
            Document doc6 = new Document { Caption = "Ventana Empresa" };
            this.windowsUIView1.Documents.AddRange(new Document[] { doc0, doc1, doc2, doc3, doc4, doc5, doc6 });
            //Creating and populating content container
            TileContainer tileContainer2 = new TileContainer();
            tileContainer2.Properties.ItemSize = 120;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;

            grupo = "Group 0";
            imagen = Properties.Resources.usuarios;
            nombreElemento = "Usuarios";
            tileContainer2.Items.Add(this.crearTile(doc0, nombreElemento, grupo, imagen, estado));

            grupo = "Group 1";
            imagen = Properties.Resources.item;
            nombreElemento = "Items";
            tileContainer2.Items.Add(this.crearTile(doc1, nombreElemento, grupo, imagen, estado));

            grupo = "Group 2";
            imagen = Properties.Resources.categories;
            nombreElemento = "Categorías";
            tileContainer2.Items.Add(this.crearTile(doc2, nombreElemento, grupo, imagen, estado));

            grupo = "Group 0";
            imagen = Properties.Resources.Localizacion;
            nombreElemento = "Ubicaciones";
            tileContainer2.Items.Add(this.crearTile(doc3, nombreElemento, grupo, imagen, estado));

            grupo = "Group 1";
            imagen = Properties.Resources.Departamento;
            nombreElemento = "Departamentos";
            tileContainer2.Items.Add(this.crearTile(doc4, nombreElemento, grupo, imagen, estado));

            grupo = "Group 2";
            imagen = Properties.Resources.inven;
            nombreElemento = "Activos";
            tileContainer2.Items.Add(this.crearTile(doc5, nombreElemento, grupo, imagen, estado));

            grupo = "Group 0";
            imagen = Properties.Resources.agency;
            nombreElemento = "Empresas";
            tileContainer2.Items.Add(this.crearTile(doc6, nombreElemento, grupo, imagen, estado));

            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }

        public void CrearDocumentosFormulario(Boolean estado)
        {
            string nombreElemento = "";
            string grupo = "";
            Image imagen = null;
            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();

            Document doc1 = new Document { Caption = "Ventana Formularios" };
            this.windowsUIView1.Documents.AddRange(new Document[] { doc1 });

            //Creating and populating content container
            TileContainer tileContainer2 = new TileContainer();
            tileContainer2.Properties.ItemSize = 120;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;

            grupo = "Group 1";
            imagen = Properties.Resources.form;
            nombreElemento = "Formularios";
            tileContainer2.Items.Add(this.crearTile(doc1, nombreElemento, grupo, imagen, estado));

            windowsUIView1.ContentContainers.Add(tileContainer2);
            this.windowsUIView1.ActivateContainer(tileContainer2);
            this.windowsUIView1.EndUpdate();
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;

        }

        public void CrearDocumentosReportes(Boolean estado)
        {
            string nombreElemento = "";
            string grupo = "";
            Image imagen = null;

            this.windowsUIView1.BeginUpdate();
            this.windowsUIView1.Controller.CloseAll();
            this.windowsUIView1.Documents.Clear();
            //Creating documents
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docRptActivos = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Reporte Activos" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docRptFormularios = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Reporte Formularios" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docFormulariosPorFecha = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Reporte Formularios Por Fecha" };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docUtilizaciondeItems = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document { Caption = "Reporte Utilizacion de Items" };
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] { docRptActivos, docRptFormularios, docFormulariosPorFecha, docUtilizaciondeItems });
            //Creating and populating content container
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer();
            tileContainer2.Properties.ItemSize = 140;
            tileContainer2.Properties.Orientation = Orientation.Horizontal;
            //Propiedades para el decumento Reporte Bodega
            grupo = "Group 1";
            imagen = Properties.Resources.Reporte;
            nombreElemento = "RPT. Activos";
            tileContainer2.Items.Add(this.crearTile(docRptActivos, nombreElemento, grupo, imagen, estado));
            //Propiedades para el decumento Reporte Bodega Especifica
            grupo = "Group 2";
            imagen = Properties.Resources.Reporte;
            nombreElemento = "RPT. Formularios";
            tileContainer2.Items.Add(this.crearTile(docRptFormularios, nombreElemento, grupo, imagen, estado));
            //Propiedades para el decumento Reporte Traslados
            grupo = "Group 3";
            imagen = Properties.Resources.Reporte;
            nombreElemento = "RPT. Fromularios Por Fecha";
            tileContainer2.Items.Add(this.crearTile(docFormulariosPorFecha, nombreElemento, grupo, imagen, estado));

            grupo = "Group 1";
            imagen = Properties.Resources.Reporte;
            nombreElemento = "RPT. Utilizacion de Items";
            tileContainer2.Items.Add(this.crearTile(docUtilizaciondeItems, nombreElemento, grupo, imagen, estado));


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
            if (tipoDeProceso == "Formularios")
            {
                this.CrearDocumentosFormulario(true);
            }

        }

        private void windowsUIView1_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            e.DisposeControl = true;
        }


        private void cambiarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCambioUsuario ofrNuevoUsuario = new frmCambioUsuario(usuarioLogueado);
                ofrNuevoUsuario.ShowDialog(this);
                string perfil = gestor.ValidarUsuarioPorUsuario(usuarioLogueado).perfil;

                if (ofrNuevoUsuario.DialogResult == DialogResult.OK)
                {
                    this.UsuarioLogueado();
                    if (perfil.Equals("Administrador"))
                    {
                        if (tipoDeProceso == "Administracion")
                        {
                            this.CrearDocumentosAdministracion(true);
                        }
                    }
                    else
                    {
                        this.CrearDocumentosAdministracion(false);
                    }
                    if (tipoDeProceso == "Administracion")
                    {
                        this.CrearDocumentosAdministracion(true);
                    }
                    if (tipoDeProceso == "Formularios")
                    {
                        this.CrearDocumentosFormulario(true);
                    }
                }
                security();
            }
            catch (Exception)
            { }

        }

        private void cambiarContrasennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContrasenna ofrmCambioContrasenna = new frmCambioContrasenna(usuarioLogueado);
            ofrmCambioContrasenna.ShowDialog(this);
        }

        private void cambiarModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modulo = true;
            FormClosing -= frmMDI_FormClosing;
            Close();
        }

        private void frmMDIForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.Icono;
        }

        private void restaurarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pass = Interaction.InputBox("Ingresar contraseña de Seguridad\nRecuerde pausar cual acción en las demás terminales del sistema", "Seguridad");
            restoreDB rDB = new restoreDB();

            if (rDB.validarPass(pass))
            {
                try
                {
                    Thread tardar = new Thread(new ThreadStart(SplashScreen));
                    tardar.Start();
                    rDB.Restore();
                    //Thread.Sleep(2000); // Tardanza para iniciar aplicacion (6000)
                    tardar.Abort();
                    MessageBox.Show("Base de Datos restaurada correctamente", "Restauración");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error: \n" + error.Message, "Restauración");
                }
            }
        }

        static void SplashScreen()
        {
            Application.Run(new frmSplashRestaurar());
        }

        private void mBtnReportes_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            CrearDocumentosFormulario(false);
            CrearDocumentosAdministracion(false);
            CrearDocumentosReportes(true);

        }




        private void mBtnAcercaDe_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AcercaDe about = new AcercaDe();
            about.ShowDialog(this);
        }

        private void mBtnAyuda_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Ayuda ofrmAyuda = new Ayuda();
            ofrmAyuda.ShowDialog(this);
        }

        //public void CrearDocumentosReportes(Boolean estado)
        //{
        //    string nombreElemento = "";
        //    string grupo = "";
        //    Image imagen = null;

        //    this.windowsUIView1.BeginUpdate();
        //    this.windowsUIView1.Controller.CloseAll();
        //    this.windowsUIView1.Documents.Clear();
        //    //Creating documents
        //    Document doc0 = new Document { Caption = "Reporte Activos" };
        //    this.windowsUIView1.Documents.AddRange(new Document[] { doc0 });
        //    //Creating and populating content container
        //    TileContainer tileContainer2 = new TileContainer();
        //    tileContainer2.Properties.ItemSize = 120;
        //    tileContainer2.Properties.Orientation = Orientation.Horizontal;

        //    grupo = "Group 0";
        //    imagen = Properties.Resources.usuarios;
        //    nombreElemento = "Activos";
        //    tileContainer2.Items.Add(this.crearTile(doc0, nombreElemento, grupo, imagen, estado));

        //    windowsUIView1.ContentContainers.Add(tileContainer2);
        //    this.windowsUIView1.ActivateContainer(tileContainer2);
        //    this.windowsUIView1.EndUpdate();
        //    this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
        //}
    }
}
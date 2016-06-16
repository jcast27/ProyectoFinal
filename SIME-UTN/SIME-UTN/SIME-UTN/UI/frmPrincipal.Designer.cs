namespace SIME_UTN.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.rCMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.rPAdmistracion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.nativeMdiView1 = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(this.components);
            this.frmUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.frmUsuariosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.dManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.wUIVIEW = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.FlyoutCloseAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wUIVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).BeginInit();
            this.SuspendLayout();
            // 
            // rCMenu
            // 
            this.rCMenu.ExpandCollapseItem.Id = 0;
            this.rCMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rCMenu.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.bBtnUsuarios,
            this.bBtnProductos,
            this.skinRibbonGalleryBarItem2});
            this.rCMenu.Location = new System.Drawing.Point(0, 0);
            this.rCMenu.MaxItemId = 8;
            this.rCMenu.Name = "rCMenu";
            this.rCMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPAdmistracion,
            this.ribbonPage2,
            this.ribbonPage1});
            this.rCMenu.Size = new System.Drawing.Size(631, 141);
            this.rCMenu.StatusBar = this.ribbonStatusBar1;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "Themes";
            this.skinRibbonGalleryBarItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("skinRibbonGalleryBarItem1.Glyph")));
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "usuarios";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bBtnUsuarios
            // 
            this.bBtnUsuarios.Caption = "Usuarios";
            this.bBtnUsuarios.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnUsuarios.Glyph")));
            this.bBtnUsuarios.Id = 5;
            this.bBtnUsuarios.Name = "bBtnUsuarios";
            this.bBtnUsuarios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bBtnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUsuarios_ItemClick);
            // 
            // bBtnProductos
            // 
            this.bBtnProductos.Caption = "Productos";
            this.bBtnProductos.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnProductos.Glyph")));
            this.bBtnProductos.Id = 6;
            this.bBtnProductos.Name = "bBtnProductos";
            this.bBtnProductos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "Themes";
            this.skinRibbonGalleryBarItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("skinRibbonGalleryBarItem2.Glyph")));
            this.skinRibbonGalleryBarItem2.Id = 7;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // rPAdmistracion
            // 
            this.rPAdmistracion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rPAdmistracion.Name = "rPAdmistracion";
            this.rPAdmistracion.Text = "Administracion";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnUsuarios);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnProductos);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Procesos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 391);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.rCMenu;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(631, 27);
            // 
            // frmUsuariosDocument
            // 
            this.frmUsuariosDocument.Caption = "frmUsuarios";
            this.frmUsuariosDocument.ControlName = "frmUsuarios";
            this.frmUsuariosDocument.ControlTypeName = "SIME_UTN.UI.frmUsuarios";
            // 
            // tileContainer1
            // 
            this.tileContainer1.Name = "tileContainer1";
            // 
            // frmUsuariosTile
            // 
            this.frmUsuariosTile.Document = this.frmUsuariosDocument;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.Text = "element1";
            this.frmUsuariosTile.Elements.Add(tileItemElement1);
            this.frmUsuariosTile.Name = "frmUsuariosTile";
            // 
            // dManager
            // 
            this.dManager.MdiParent = this;
            this.dManager.MenuManager = this.rCMenu;
            this.dManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.dManager.View = this.wUIVIEW;
            this.dManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.wUIVIEW});
            // 
            // wUIVIEW
            // 
            this.wUIVIEW.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.FlyoutCloseAction});
            this.wUIVIEW.BackButtonClick += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BackButtonClickEventHandler(this.wUIVIEW_BackButtonClick);
            // 
            // FlyoutCloseAction
            // 
            this.FlyoutCloseAction.Name = "FlyoutCloseAction";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(631, 418);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.rCMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Bodega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wUIVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl rCMenu;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bBtnUsuarios;
        private DevExpress.XtraBars.BarButtonItem bBtnProductos;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPAdmistracion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView nativeMdiView1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmUsuariosTile;
        private DevExpress.XtraBars.Docking2010.DocumentManager dManager;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView wUIVIEW;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout FlyoutCloseAction;
    }
}
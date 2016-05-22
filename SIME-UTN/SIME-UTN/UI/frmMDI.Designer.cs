namespace SIME_UTN.UI
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
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
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.frmUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.frmProductosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.frmUsuariosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.frmProductosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.FlyoutCloseAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
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
            this.rCMenu.Size = new System.Drawing.Size(635, 141);
            this.rCMenu.Click += new System.EventHandler(this.rCMenu_Click);
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
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.rCMenu;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1,
            this.FlyoutCloseAction});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.frmUsuariosDocument,
            this.frmProductosDocument});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.frmUsuariosTile,
            this.frmProductosTile});
            this.windowsUIView1.BackButtonClick += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BackButtonClickEventHandler(this.windowsUIView1_BackButtonClick);
            // 
            // frmUsuariosDocument
            // 
            this.frmUsuariosDocument.Caption = "Ventana Usuarios";
            this.frmUsuariosDocument.ControlName = "frmUsuarios";
            this.frmUsuariosDocument.ControlTypeName = "SIME_UTN.UI.frmUsuarios";
            // 
            // frmProductosDocument
            // 
            this.frmProductosDocument.Caption = "frmProductos";
            this.frmProductosDocument.ControlName = "frmProductos";
            this.frmProductosDocument.ControlTypeName = "SIME_UTN.UI.frmProductos";
            // 
            // frmUsuariosTile
            // 
            this.frmUsuariosTile.Document = this.frmUsuariosDocument;
            tileItemFrame1.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame1.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame1.Appearance.ForeColor = System.Drawing.Color.Black;
            tileItemFrame1.Appearance.Options.UseBackColor = true;
            tileItemFrame1.Appearance.Options.UseBorderColor = true;
            tileItemFrame1.Appearance.Options.UseForeColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "element1";
            tileItemFrame1.Elements.Add(tileItemElement1);
            tileItemFrame1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame1.Image")));
            this.frmUsuariosTile.Frames.Add(tileItemFrame1);
            this.tileContainer1.SetID(this.frmUsuariosTile, 2);
            this.frmUsuariosTile.Name = "frmUsuariosTile";
            // 
            // frmProductosTile
            // 
            this.frmProductosTile.Document = this.frmProductosDocument;
            tileItemFrame2.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame2.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame2.Appearance.Options.UseBackColor = true;
            tileItemFrame2.Appearance.Options.UseBorderColor = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "element1";
            tileItemFrame2.Elements.Add(tileItemElement2);
            tileItemFrame2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame2.Image")));
            this.frmProductosTile.Frames.Add(tileItemFrame2);
            this.tileContainer1.SetID(this.frmProductosTile, 1);
            this.frmProductosTile.Name = "frmProductosTile";
            // 
            // tileContainer1
            // 
            this.tileContainer1.Caption = "";
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.frmUsuariosTile,
            this.frmProductosTile});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // FlyoutCloseAction
            // 
            this.FlyoutCloseAction.Name = "FlyoutCloseAction";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.rCMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "frmMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
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
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPAdmistracion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmProductosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmUsuariosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmProductosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout FlyoutCloseAction;
    }
}
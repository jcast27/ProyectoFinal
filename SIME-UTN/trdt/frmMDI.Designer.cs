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
            DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.rCMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnAdministracion = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnProcesos = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bBtnInventarios = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnReportes = new DevExpress.XtraBars.BarButtonItem();
            this.bSItemUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.rPAdmistracion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.frmUsuariosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.frmUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.frmProductosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.frmProductosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.FlyoutCloseAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).BeginInit();
            this.SuspendLayout();
            // 
            // rCMenu
            // 
            this.rCMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rCMenu.ExpandCollapseItem.Id = 0;
            this.rCMenu.ForeColor = System.Drawing.Color.White;
            this.rCMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rCMenu.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.bBtnAdministracion,
            this.bBtnProcesos,
            this.skinRibbonGalleryBarItem2,
            this.bBtnInventarios,
            this.bBtnReportes,
            this.bSItemUsuario});
            this.rCMenu.Location = new System.Drawing.Point(0, 0);
            this.rCMenu.MaxItemId = 3;
            this.rCMenu.Name = "rCMenu";
            this.rCMenu.PageHeaderItemLinks.Add(this.bSItemUsuario);
            this.rCMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPAdmistracion});
            this.rCMenu.Size = new System.Drawing.Size(635, 151);
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
            // bBtnAdministracion
            // 
            this.bBtnAdministracion.Caption = "Administracion";
            this.bBtnAdministracion.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnAdministracion.Glyph")));
            this.bBtnAdministracion.Id = 5;
            this.bBtnAdministracion.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnAdministracion.ItemAppearance.Hovered.Options.UseFont = true;
            this.bBtnAdministracion.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnAdministracion.ItemAppearance.Normal.Options.UseFont = true;
            this.bBtnAdministracion.Name = "bBtnAdministracion";
            this.bBtnAdministracion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bBtnAdministracion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnAdministracion_ItemClick);
            // 
            // bBtnProcesos
            // 
            this.bBtnProcesos.Caption = "Procesos";
            this.bBtnProcesos.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnProcesos.Glyph")));
            this.bBtnProcesos.Id = 6;
            this.bBtnProcesos.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnProcesos.ItemAppearance.Hovered.Options.UseFont = true;
            this.bBtnProcesos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnProcesos.ItemAppearance.Normal.Options.UseFont = true;
            this.bBtnProcesos.Name = "bBtnProcesos";
            this.bBtnProcesos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bBtnProcesos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnProcesos_ItemClick);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "Themes";
            this.skinRibbonGalleryBarItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("skinRibbonGalleryBarItem2.Glyph")));
            this.skinRibbonGalleryBarItem2.Id = 7;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // bBtnInventarios
            // 
            this.bBtnInventarios.Caption = "Inventarios";
            this.bBtnInventarios.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnInventarios.Glyph")));
            this.bBtnInventarios.Id = 8;
            this.bBtnInventarios.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnInventarios.ItemAppearance.Hovered.Options.UseFont = true;
            this.bBtnInventarios.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnInventarios.ItemAppearance.Normal.Options.UseFont = true;
            this.bBtnInventarios.Name = "bBtnInventarios";
            this.bBtnInventarios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bBtnReportes
            // 
            this.bBtnReportes.Caption = "Reportes";
            this.bBtnReportes.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnReportes.Glyph")));
            this.bBtnReportes.Id = 9;
            this.bBtnReportes.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnReportes.ItemAppearance.Hovered.Options.UseFont = true;
            this.bBtnReportes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBtnReportes.ItemAppearance.Normal.Options.UseFont = true;
            this.bBtnReportes.Name = "bBtnReportes";
            this.bBtnReportes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bSItemUsuario
            // 
            this.bSItemUsuario.Caption = "Usuario";
            this.bSItemUsuario.Glyph = ((System.Drawing.Image)(resources.GetObject("bSItemUsuario.Glyph")));
            this.bSItemUsuario.Id = 2;
            this.bSItemUsuario.Name = "bSItemUsuario";
            this.bSItemUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rPAdmistracion
            // 
            this.rPAdmistracion.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPAdmistracion.Appearance.Options.UseFont = true;
            this.rPAdmistracion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rPAdmistracion.ImageAlign = DevExpress.Utils.HorzAlignment.Far;
            this.rPAdmistracion.Name = "rPAdmistracion";
            this.rPAdmistracion.Text = "SIME-UTN";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnAdministracion);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnProcesos);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnInventarios);
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnReportes);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
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
            // tileContainer1
            // 
            this.tileContainer1.Caption = "";
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.frmUsuariosTile,
            this.frmProductosTile});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // frmUsuariosTile
            // 
            this.frmUsuariosTile.Document = this.frmUsuariosDocument;
            tileItemFrame3.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame3.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame3.Appearance.ForeColor = System.Drawing.Color.Black;
            tileItemFrame3.Appearance.Options.UseBackColor = true;
            tileItemFrame3.Appearance.Options.UseBorderColor = true;
            tileItemFrame3.Appearance.Options.UseForeColor = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement3.Text = "element1";
            tileItemFrame3.Elements.Add(tileItemElement3);
            tileItemFrame3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame3.Image")));
            this.frmUsuariosTile.Frames.Add(tileItemFrame3);
            this.frmUsuariosTile.Group = "TileGroup1";
            this.tileContainer1.SetID(this.frmUsuariosTile, 2);
            this.frmUsuariosTile.Name = "frmUsuariosTile";
            this.frmUsuariosTile.Visible = false;
            // 
            // frmUsuariosDocument
            // 
            this.frmUsuariosDocument.Caption = "Ventana Usuarios";
            this.frmUsuariosDocument.ControlName = "frmUsuarios";
            this.frmUsuariosDocument.ControlTypeName = "SIME_UTN.UI.frmUsuarios";
            // 
            // frmProductosTile
            // 
            this.frmProductosTile.Document = this.frmProductosDocument;
            tileItemFrame1.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame1.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame1.Appearance.Options.UseBackColor = true;
            tileItemFrame1.Appearance.Options.UseBorderColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "element1";
            tileItemFrame1.Elements.Add(tileItemElement1);
            tileItemFrame1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame1.Image")));
            this.frmProductosTile.Frames.Add(tileItemFrame1);
            this.tileContainer1.SetID(this.frmProductosTile, 1);
            this.frmProductosTile.Name = "frmProductosTile";
            this.frmProductosTile.Visible = false;
            // 
            // frmProductosDocument
            // 
            this.frmProductosDocument.Caption = "frmProductos";
            this.frmProductosDocument.ControlName = "frmProductos";
            this.frmProductosDocument.ControlTypeName = "SIME_UTN.UI.frmProductos";
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
            this.Name = "frmMDI";
            this.Text = "frmMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rCMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rCMenu;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bBtnAdministracion;
        private DevExpress.XtraBars.BarButtonItem bBtnProcesos;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPAdmistracion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmProductosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmUsuariosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmProductosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout FlyoutCloseAction;
        private DevExpress.XtraBars.BarButtonItem bBtnInventarios;
        private DevExpress.XtraBars.BarButtonItem bBtnReportes;
        private DevExpress.XtraBars.BarStaticItem bSItemUsuario;
    }
}
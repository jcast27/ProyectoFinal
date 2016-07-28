﻿namespace SIME_UTN.UI.Bodega
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavPane2 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAdministracion = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnProcesos = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnInventarios = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnReportes = new DevExpress.XtraBars.Navigation.NavButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.FlyoutCloseAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.frmUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.frmProductosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.frmUsuariosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.frmProductosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContrasennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resturarDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // tileNavPane2
            // 
            this.tileNavPane2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane2.BackgroundImage")));
            this.tileNavPane2.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane2.Buttons.Add(this.mBtnAdministracion);
            this.tileNavPane2.Buttons.Add(this.mBtnProcesos);
            this.tileNavPane2.Buttons.Add(this.mBtnInventarios);
            this.tileNavPane2.Buttons.Add(this.mBtnReportes);
            // 
            // tileNavCategory2
            // 
            this.tileNavPane2.DefaultCategory.Name = "tileNavCategory2";
            this.tileNavPane2.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane2.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane2.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane2.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane2.Location = new System.Drawing.Point(0, 61);
            this.tileNavPane2.Name = "tileNavPane2";
            this.tileNavPane2.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane2.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane2.Size = new System.Drawing.Size(918, 93);
            this.tileNavPane2.TabIndex = 3;
            this.tileNavPane2.Text = "tileNavPane2";
            // 
            // mBtnAdministracion
            // 
            this.mBtnAdministracion.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAdministracion.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAdministracion.Appearance.Options.UseFont = true;
            this.mBtnAdministracion.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAdministracion.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mBtnAdministracion.AppearanceHovered.Options.UseFont = true;
            this.mBtnAdministracion.AppearanceHovered.Options.UseForeColor = true;
            this.mBtnAdministracion.Caption = "Administración";
            this.mBtnAdministracion.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAdministracion.Glyph")));
            this.mBtnAdministracion.Name = "mBtnAdministracion";
            this.mBtnAdministracion.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAdministracion_ElementClick);
            // 
            // mBtnProcesos
            // 
            this.mBtnProcesos.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnProcesos.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnProcesos.Appearance.Options.UseFont = true;
            this.mBtnProcesos.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnProcesos.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mBtnProcesos.AppearanceHovered.Options.UseFont = true;
            this.mBtnProcesos.AppearanceHovered.Options.UseForeColor = true;
            this.mBtnProcesos.Caption = "Procesos";
            this.mBtnProcesos.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnProcesos.Glyph")));
            this.mBtnProcesos.Name = "mBtnProcesos";
            this.mBtnProcesos.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnProcesos_ElementClick);
            // 
            // mBtnInventarios
            // 
            this.mBtnInventarios.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnInventarios.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnInventarios.Appearance.Options.UseFont = true;
            this.mBtnInventarios.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnInventarios.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mBtnInventarios.AppearanceHovered.Options.UseFont = true;
            this.mBtnInventarios.AppearanceHovered.Options.UseForeColor = true;
            this.mBtnInventarios.Caption = "Inventarios";
            this.mBtnInventarios.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnInventarios.Glyph")));
            this.mBtnInventarios.Name = "mBtnInventarios";
            this.mBtnInventarios.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnInventarios_ElementClick);
            // 
            // mBtnReportes
            // 
            this.mBtnReportes.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnReportes.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnReportes.Appearance.Options.UseFont = true;
            this.mBtnReportes.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnReportes.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mBtnReportes.AppearanceHovered.Options.UseFont = true;
            this.mBtnReportes.AppearanceHovered.Options.UseForeColor = true;
            this.mBtnReportes.Caption = "Reportes";
            this.mBtnReportes.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnReportes.Glyph")));
            this.mBtnReportes.Name = "mBtnReportes";
            this.mBtnReportes.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnReportes_ElementClick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(918, 154);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.FlyoutCloseAction});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.frmUsuariosDocument,
            this.frmProductosDocument});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.frmUsuariosTile,
            this.frmProductosTile});
            this.windowsUIView1.BackButtonClick += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BackButtonClickEventHandler(this.windowsUIView1_BackButtonClick);
            this.windowsUIView1.ControlReleasing += new DevExpress.XtraBars.Docking2010.Views.ControlReleasingEventHandler(this.windowsUIView1_ControlReleasing);
            // 
            // FlyoutCloseAction
            // 
            this.FlyoutCloseAction.Name = "FlyoutCloseAction";
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
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.Text = "element1";
            this.frmUsuariosTile.Elements.Add(tileItemElement1);
            tileItemFrame1.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame1.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame1.Appearance.Options.UseBackColor = true;
            tileItemFrame1.Appearance.Options.UseBorderColor = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "element1";
            tileItemFrame1.Elements.Add(tileItemElement2);
            tileItemFrame1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame1.Image")));
            this.frmUsuariosTile.Frames.Add(tileItemFrame1);
            this.frmUsuariosTile.Group = "TileGroup2";
            this.frmUsuariosTile.Name = "frmUsuariosTile";
            this.frmUsuariosTile.Visible = false;
            // 
            // frmProductosTile
            // 
            this.frmProductosTile.Document = this.frmProductosDocument;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement3.Text = "element1";
            this.frmProductosTile.Elements.Add(tileItemElement3);
            tileItemFrame2.Appearance.BackColor = System.Drawing.Color.Transparent;
            tileItemFrame2.Appearance.BorderColor = System.Drawing.Color.Black;
            tileItemFrame2.Appearance.Options.UseBackColor = true;
            tileItemFrame2.Appearance.Options.UseBorderColor = true;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement4.Text = "element1";
            tileItemFrame2.Elements.Add(tileItemElement4);
            tileItemFrame2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame2.Image")));
            this.frmProductosTile.Frames.Add(tileItemFrame2);
            this.frmProductosTile.Name = "frmProductosTile";
            this.frmProductosTile.Visible = false;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.BackColor = System.Drawing.Color.DimGray;
            this.lblNombreProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreProyecto.Location = new System.Drawing.Point(7, 15);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(710, 24);
            this.lblNombreProyecto.TabIndex = 9;
            this.lblNombreProyecto.Text = "SISTEMA DE INVENTARIOS Y MANTENIMIENTO DE EQUIPOS SIME-UTN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(734, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioTSMI
            // 
            this.usuarioTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarSessionToolStripMenuItem,
            this.cambiarContrasennaToolStripMenuItem,
            this.cambiarModuloToolStripMenuItem,
            this.resturarDBToolStripMenuItem,
            this.ayudaStripMenuItem,
            this.acercaDeStripMenuItem});
            this.usuarioTSMI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTSMI.Image = ((System.Drawing.Image)(resources.GetObject("usuarioTSMI.Image")));
            this.usuarioTSMI.Name = "usuarioTSMI";
            this.usuarioTSMI.Size = new System.Drawing.Size(44, 36);
            // 
            // cambiarSessionToolStripMenuItem
            // 
            this.cambiarSessionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cambiarSessionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarSessionToolStripMenuItem.Name = "cambiarSessionToolStripMenuItem";
            this.cambiarSessionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cambiarSessionToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarSessionToolStripMenuItem.Click += new System.EventHandler(this.cambiarSessionToolStripMenuItem_Click);
            // 
            // cambiarContrasennaToolStripMenuItem
            // 
            this.cambiarContrasennaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cambiarContrasennaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarContrasennaToolStripMenuItem.Name = "cambiarContrasennaToolStripMenuItem";
            this.cambiarContrasennaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cambiarContrasennaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContrasennaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContrasennaToolStripMenuItem_Click);
            // 
            // cambiarModuloToolStripMenuItem
            // 
            this.cambiarModuloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cambiarModuloToolStripMenuItem.Name = "cambiarModuloToolStripMenuItem";
            this.cambiarModuloToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cambiarModuloToolStripMenuItem.Text = "Cambiar Módulo";
            this.cambiarModuloToolStripMenuItem.Click += new System.EventHandler(this.cambiarModuloToolStripMenuItem_Click);
            // 
            // resturarDBToolStripMenuItem
            // 
            this.resturarDBToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resturarDBToolStripMenuItem.Name = "resturarDBToolStripMenuItem";
            this.resturarDBToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.resturarDBToolStripMenuItem.Text = "Resturar Base de Datos";
            this.resturarDBToolStripMenuItem.Click += new System.EventHandler(this.resturarDBToolStripMenuItem_Click);
            // 
            // ayudaStripMenuItem
            // 
            this.ayudaStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ayudaStripMenuItem.Name = "ayudaStripMenuItem";
            this.ayudaStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ayudaStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeStripMenuItem
            // 
            this.acercaDeStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.acercaDeStripMenuItem.Name = "acercaDeStripMenuItem";
            this.acercaDeStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.acercaDeStripMenuItem.Text = "Acerca De";
            this.acercaDeStripMenuItem.Click += new System.EventHandler(this.acercaDeStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(918, 548);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.tileNavPane2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitter1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Bodega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutCloseAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmUsuariosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmProductosTile)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAdministracion;
        private DevExpress.XtraBars.Navigation.NavButton mBtnProcesos;
        private DevExpress.XtraBars.Navigation.NavButton mBtnInventarios;
        private DevExpress.XtraBars.Navigation.NavButton mBtnReportes;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document frmProductosDocument;
        private System.Windows.Forms.Label lblNombreProyecto;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmUsuariosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile frmProductosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout FlyoutCloseAction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioTSMI;
        private System.Windows.Forms.ToolStripMenuItem cambiarSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContrasennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resturarDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeStripMenuItem;
    }
}
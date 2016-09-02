﻿namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.gCUsuarios = new DevExpress.XtraGrid.GridControl();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsuario = new SIME_UTN.DataSets.DataSetUsuario();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbGridViewUsuario = new System.Windows.Forms.GroupBox();
            this.usuarioTableAdapter = new SIME_UTN.DataSets.DataSetUsuarioTableAdapters.UsuarioTableAdapter();
            this.cmMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gCUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewUsuario.SuspendLayout();
            this.cmMenuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCUsuarios
            // 
            this.gCUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gCUsuarios.BackgroundImage")));
            this.gCUsuarios.ContextMenuStrip = this.cmMenuGrid;
            this.gCUsuarios.DataSource = this.usuarioBindingSource;
            this.gCUsuarios.Location = new System.Drawing.Point(6, 54);
            this.gCUsuarios.MainView = this.gridView1;
            this.gCUsuarios.Name = "gCUsuarios";
            this.gCUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UsuarioItemLookUpEdit1});
            this.gCUsuarios.Size = new System.Drawing.Size(995, 424);
            this.gCUsuarios.TabIndex = 0;
            this.gCUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCUsuarios.Click += new System.EventHandler(this.gCUsuarios_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dataSetUsuario;
            // 
            // dataSetUsuario
            // 
            this.dataSetUsuario.DataSetName = "DataSetUsuario";
            this.dataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoUsuario,
            this.colNombre,
            this.colPrimerApellido,
            this.colSegundoApellido,
            this.colUsuario,
            this.colPerfil});
            this.gridView1.GridControl = this.gCUsuarios;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colCodigoUsuario
            // 
            this.colCodigoUsuario.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCodigoUsuario.AppearanceCell.Options.UseFont = true;
            this.colCodigoUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCodigoUsuario.AppearanceHeader.Options.UseFont = true;
            this.colCodigoUsuario.FieldName = "CodigoUsuario";
            this.colCodigoUsuario.Name = "colCodigoUsuario";
            this.colCodigoUsuario.OptionsColumn.AllowEdit = false;
            // 
            // colNombre
            // 
            this.colNombre.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colNombre.AppearanceCell.Options.UseFont = true;
            this.colNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNombre.AppearanceHeader.Options.UseFont = true;
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colPrimerApellido
            // 
            this.colPrimerApellido.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPrimerApellido.AppearanceCell.Options.UseFont = true;
            this.colPrimerApellido.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPrimerApellido.AppearanceHeader.Options.UseFont = true;
            this.colPrimerApellido.Caption = "P. Apellido";
            this.colPrimerApellido.FieldName = "Apellido1";
            this.colPrimerApellido.Name = "colPrimerApellido";
            this.colPrimerApellido.Visible = true;
            this.colPrimerApellido.VisibleIndex = 1;
            // 
            // colSegundoApellido
            // 
            this.colSegundoApellido.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSegundoApellido.AppearanceCell.Options.UseFont = true;
            this.colSegundoApellido.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSegundoApellido.AppearanceHeader.Options.UseFont = true;
            this.colSegundoApellido.Caption = "S. Apellido";
            this.colSegundoApellido.FieldName = "Apellido2";
            this.colSegundoApellido.Name = "colSegundoApellido";
            this.colSegundoApellido.Visible = true;
            this.colSegundoApellido.VisibleIndex = 2;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colUsuario.AppearanceCell.Options.UseFont = true;
            this.colUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colUsuario.AppearanceHeader.Options.UseFont = true;
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 3;
            // 
            // colPerfil
            // 
            this.colPerfil.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colPerfil.AppearanceCell.Options.UseFont = true;
            this.colPerfil.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPerfil.AppearanceHeader.Options.UseFont = true;
            this.colPerfil.FieldName = "Perfil";
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colPerfil.Visible = true;
            this.colPerfil.VisibleIndex = 4;
            // 
            // UsuarioItemLookUpEdit1
            // 
            this.UsuarioItemLookUpEdit1.AutoHeight = false;
            this.UsuarioItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsuarioItemLookUpEdit1.Name = "UsuarioItemLookUpEdit1";
            this.UsuarioItemLookUpEdit1.NullText = "";
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnAgregar);
            this.tileNavPane1.Buttons.Add(this.mBtnModificar);
            this.tileNavPane1.Buttons.Add(this.mBtnEliminar);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Location = new System.Drawing.Point(144, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1162, 45);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "Nuevo";
            // 
            // mBtnAgregar
            // 
            this.mBtnAgregar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAgregar.Appearance.Options.UseFont = true;
            this.mBtnAgregar.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAgregar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAgregar.Caption = "Agregar";
            this.mBtnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAgregar.Glyph")));
            this.mBtnAgregar.Name = "mBtnAgregar";
            this.mBtnAgregar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAgregar_ElementClick);
            // 
            // mBtnModificar
            // 
            this.mBtnModificar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnModificar.Appearance.Options.UseFont = true;
            this.mBtnModificar.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnModificar.AppearanceHovered.Options.UseFont = true;
            this.mBtnModificar.Caption = "Modificar";
            this.mBtnModificar.Enabled = false;
            this.mBtnModificar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnModificar.Glyph")));
            this.mBtnModificar.Name = "mBtnModificar";
            this.mBtnModificar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnModificar_ElementClick);
            // 
            // mBtnEliminar
            // 
            this.mBtnEliminar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnEliminar.Appearance.Options.UseFont = true;
            this.mBtnEliminar.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnEliminar.AppearanceHovered.Options.UseFont = true;
            this.mBtnEliminar.Caption = "Eliminar";
            this.mBtnEliminar.Enabled = false;
            this.mBtnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnEliminar.Glyph")));
            this.mBtnEliminar.Name = "mBtnEliminar";
            this.mBtnEliminar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnEliminar_ElementClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 568);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1159, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 527);
            this.panel2.TabIndex = 31;
            // 
            // gbGridViewUsuario
            // 
            this.gbGridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewUsuario.Controls.Add(this.gCUsuarios);
            this.gbGridViewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewUsuario.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewUsuario.Name = "gbGridViewUsuario";
            this.gbGridViewUsuario.Size = new System.Drawing.Size(1001, 484);
            this.gbGridViewUsuario.TabIndex = 33;
            this.gbGridViewUsuario.TabStop = false;
            this.gbGridViewUsuario.Text = "Seleccionar Usuario";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cmMenuGrid
            // 
            this.cmMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.cmMenuGrid.Name = "cmMenuGrid";
            this.cmMenuGrid.Size = new System.Drawing.Size(156, 48);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // sfdRuta
            // 
            this.sfdRuta.Filter = "Archivos Excel | *.xlsx";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1307, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewUsuario.ResumeLayout(false);
            this.cmMenuGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gCUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPerfil;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UsuarioItemLookUpEdit1;
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colSegundoApellido;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private System.Windows.Forms.GroupBox gbGridViewUsuario;
        private SIME_UTN.DataSets.DataSetUsuario dataSetUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private SIME_UTN.DataSets.DataSetUsuarioTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
    }
}
﻿namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            this.gCDepartamentos = new DevExpress.XtraGrid.GridControl();
            this.cmMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spSELECTDepartamentoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRDepartamento = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetRDepartamento();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coliddepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbGridViewSelecBodegas = new System.Windows.Forms.GroupBox();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.sp_SELECT_Departamento_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetRDepartamentoTableAdapters.sp_SELECT_Departamento_AllTableAdapter();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gCDepartamentos)).BeginInit();
            this.cmMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTDepartamentoAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewSelecBodegas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCDepartamentos
            // 
            this.gCDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCDepartamentos.ContextMenuStrip = this.cmMenuGrid;
            this.gCDepartamentos.DataSource = this.spSELECTDepartamentoAllBindingSource;
            this.gCDepartamentos.Location = new System.Drawing.Point(6, 39);
            this.gCDepartamentos.MainView = this.gridView1;
            this.gCDepartamentos.Name = "gCDepartamentos";
            this.gCDepartamentos.Size = new System.Drawing.Size(1033, 479);
            this.gCDepartamentos.TabIndex = 0;
            this.gCDepartamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCDepartamentos.Click += new System.EventHandler(this.gCDepartamentos_Click);
            // 
            // cmMenuGrid
            // 
            this.cmMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.cmMenuGrid.Name = "cmMenuGrid";
            this.cmMenuGrid.Size = new System.Drawing.Size(156, 26);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // spSELECTDepartamentoAllBindingSource
            // 
            this.spSELECTDepartamentoAllBindingSource.DataMember = "sp_SELECT_Departamento_All";
            this.spSELECTDepartamentoAllBindingSource.DataSource = this.dataSetRDepartamento;
            // 
            // dataSetRDepartamento
            // 
            this.dataSetRDepartamento.DataSetName = "DataSetRDepartamento";
            this.dataSetRDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coliddepartamento,
            this.coldescripcion,
            this.colestado});
            this.gridView1.GridControl = this.gCDepartamentos;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coliddepartamento, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // coliddepartamento
            // 
            this.coliddepartamento.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coliddepartamento.AppearanceCell.Options.UseFont = true;
            this.coliddepartamento.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coliddepartamento.AppearanceHeader.Options.UseFont = true;
            this.coliddepartamento.Caption = "ID Departamento";
            this.coliddepartamento.FieldName = "iddepartamento";
            this.coliddepartamento.Name = "coliddepartamento";
            this.coliddepartamento.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.coliddepartamento.Visible = true;
            this.coliddepartamento.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.coldescripcion.AppearanceCell.Options.UseFont = true;
            this.coldescripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldescripcion.AppearanceHeader.Options.UseFont = true;
            this.coldescripcion.Caption = "Departamento";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
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
            this.tileNavPane1.Size = new System.Drawing.Size(1200, 45);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "Nuevo";
            // 
            // mBtnAgregar
            // 
            this.mBtnAgregar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAgregar.Appearance.Options.UseFont = true;
            this.mBtnAgregar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAgregar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAgregar.Caption = "Agregar";
            this.mBtnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAgregar.Glyph")));
            this.mBtnAgregar.Name = "mBtnAgregar";
            this.mBtnAgregar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAgregar_ElementClick);
            // 
            // mBtnModificar
            // 
            this.mBtnModificar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnModificar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnModificar.Appearance.Options.UseFont = true;
            this.mBtnModificar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.mBtnEliminar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnEliminar.Appearance.Options.UseFont = true;
            this.mBtnEliminar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Size = new System.Drawing.Size(147, 688);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1197, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 647);
            this.panel2.TabIndex = 31;
            // 
            // gbGridViewSelecBodegas
            // 
            this.gbGridViewSelecBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewSelecBodegas.Controls.Add(this.gCDepartamentos);
            this.gbGridViewSelecBodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewSelecBodegas.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewSelecBodegas.Name = "gbGridViewSelecBodegas";
            this.gbGridViewSelecBodegas.Size = new System.Drawing.Size(1039, 518);
            this.gbGridViewSelecBodegas.TabIndex = 33;
            this.gbGridViewSelecBodegas.TabStop = false;
            this.gbGridViewSelecBodegas.Text = "Registro Departamentos";
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = null;
            this.navButton1.Enabled = false;
            this.navButton1.Name = "navButton1";
            // 
            // sp_SELECT_Departamento_AllTableAdapter
            // 
            this.sp_SELECT_Departamento_AllTableAdapter.ClearBeforeFill = true;
            // 
            // sfdRuta
            // 
            this.sfdRuta.Filter = "Archivos Excel | *.xlsx";
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewSelecBodegas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Departamentos";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCDepartamentos)).EndInit();
            this.cmMenuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTDepartamentoAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewSelecBodegas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gCDepartamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.GroupBox gbGridViewSelecBodegas;

        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DataSets.Bodega.Admistracion.DataSetRDepartamento dataSetRDepartamento;
        private System.Windows.Forms.BindingSource spSELECTDepartamentoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetRDepartamentoTableAdapters.sp_SELECT_Departamento_AllTableAdapter sp_SELECT_Departamento_AllTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coliddepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private System.Windows.Forms.ContextMenuStrip cmMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
    }
}
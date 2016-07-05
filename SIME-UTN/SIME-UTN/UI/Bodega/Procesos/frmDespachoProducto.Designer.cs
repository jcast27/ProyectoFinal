namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmDespachoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespachoProducto));
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.gCBodegas = new DevExpress.XtraGrid.GridControl();
            this.spSELECTRegistroBodegaByTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBodegaDespacho = new SIME_UTN.DataSets.Bodega.DataSetBodegaDespacho();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidregistrobodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpTipoBodega = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSetTBodega = new SIME_UTN.DataSets.Bodega.DataSetTBodega();
            this.sp_SELECT_RegistroBodega_By_TypeTableAdapter = new SIME_UTN.DataSets.Bodega.DataSetBodegaDespachoTableAdapters.sp_SELECT_RegistroBodega_By_TypeTableAdapter();
            this.dataSetTipoBodegaDespacho = new SIME_UTN.DataSets.Bodega.DataSetTipoBodegaDespacho();
            this.spSELECTTipoBodegaAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SELECT_TipoBodega_AllTableAdapter = new SIME_UTN.DataSets.Bodega.DataSetTipoBodegaDespachoTableAdapters.sp_SELECT_TipoBodega_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaByTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBodegaDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTipoBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoBodegaDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tileNavPane1.TabIndex = 29;
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
            // 
            // mBtnEliminar
            // 
            this.mBtnEliminar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnEliminar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnEliminar.Appearance.Options.UseFont = true;
            this.mBtnEliminar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnEliminar.AppearanceHovered.Options.UseFont = true;
            this.mBtnEliminar.Caption = "Eliminar";
            this.mBtnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnEliminar.Glyph")));
            this.mBtnEliminar.Name = "mBtnEliminar";
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
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = null;
            this.navButton1.Enabled = false;
            this.navButton1.Name = "navButton1";
            // 
            // gbGridViewRegistroProductos
            // 
            this.gbGridViewRegistroProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewRegistroProductos.Controls.Add(this.gCBodegas);
            this.gbGridViewRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewRegistroProductos.Name = "gbGridViewRegistroProductos";
            this.gbGridViewRegistroProductos.Size = new System.Drawing.Size(1039, 522);
            this.gbGridViewRegistroProductos.TabIndex = 34;
            this.gbGridViewRegistroProductos.TabStop = false;
            this.gbGridViewRegistroProductos.Text = "Bodega - Despacho de Productos";
            // 
            // gCBodegas
            // 
            this.gCBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCBodegas.DataSource = this.spSELECTRegistroBodegaByTypeBindingSource;
            this.gCBodegas.Location = new System.Drawing.Point(3, 55);
            this.gCBodegas.MainView = this.gridView1;
            this.gCBodegas.Name = "gCBodegas";
            this.gCBodegas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpTipoBodega});
            this.gCBodegas.Size = new System.Drawing.Size(1030, 464);
            this.gCBodegas.TabIndex = 0;
            this.gCBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spSELECTRegistroBodegaByTypeBindingSource
            // 
            this.spSELECTRegistroBodegaByTypeBindingSource.DataMember = "sp_SELECT_RegistroBodega_By_Type";
            this.spSELECTRegistroBodegaByTypeBindingSource.DataSource = this.dataSetBodegaDespacho;
            // 
            // dataSetBodegaDespacho
            // 
            this.dataSetBodegaDespacho.DataSetName = "DataSetBodegaDespacho";
            this.dataSetBodegaDespacho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidregistrobodega,
            this.colnombre,
            this.coldescripcion,
            this.coltipo,
            this.colestado});
            this.gridView1.GridControl = this.gCBodegas;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            // 
            // colidregistrobodega
            // 
            this.colidregistrobodega.FieldName = "idregistrobodega";
            this.colidregistrobodega.Name = "colidregistrobodega";
            // 
            // colnombre
            // 
            this.colnombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colnombre.AppearanceHeader.Options.UseFont = true;
            this.colnombre.Caption = "Nombre de la Bodega";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coldescripcion.AppearanceHeader.Options.UseFont = true;
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // coltipo
            // 
            this.coltipo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltipo.AppearanceHeader.Options.UseFont = true;
            this.coltipo.Caption = "Tipo de Bodega";
            this.coltipo.ColumnEdit = this.LookUpTipoBodega;
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 2;
            // 
            // LookUpTipoBodega
            // 
            this.LookUpTipoBodega.AutoHeight = false;
            this.LookUpTipoBodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpTipoBodega.DataSource = this.spSELECTTipoBodegaAllBindingSource;
            this.LookUpTipoBodega.DisplayMember = "descripcion";
            this.LookUpTipoBodega.Name = "LookUpTipoBodega";
            this.LookUpTipoBodega.ValueMember = "idtipobodega";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // dataSetTBodega
            // 
            this.dataSetTBodega.DataSetName = "DataSetTBodega";
            this.dataSetTBodega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SELECT_RegistroBodega_By_TypeTableAdapter
            // 
            this.sp_SELECT_RegistroBodega_By_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetTipoBodegaDespacho
            // 
            this.dataSetTipoBodegaDespacho.DataSetName = "DataSetTipoBodegaDespacho";
            this.dataSetTipoBodegaDespacho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSELECTTipoBodegaAllBindingSource
            // 
            this.spSELECTTipoBodegaAllBindingSource.DataMember = "sp_SELECT_TipoBodega_All";
            this.spSELECTTipoBodegaAllBindingSource.DataSource = this.dataSetTipoBodegaDespacho;
            // 
            // sp_SELECT_TipoBodega_AllTableAdapter
            // 
            this.sp_SELECT_TipoBodega_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmDespachoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDespachoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Despacho de Productos";
            this.Load += new System.EventHandler(this.frmDespachoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaByTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBodegaDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTipoBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoBodegaDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;

        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private DevExpress.XtraGrid.GridControl gCBodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSets.Bodega.DataSetBodegaDespacho dataSetBodegaDespacho;
        private System.Windows.Forms.BindingSource spSELECTRegistroBodegaByTypeBindingSource;
        private DataSets.Bodega.DataSetBodegaDespachoTableAdapters.sp_SELECT_RegistroBodega_By_TypeTableAdapter sp_SELECT_RegistroBodega_By_TypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidregistrobodega;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpTipoBodega;
        private DataSets.Bodega.DataSetTBodega dataSetTBodega;
        private DataSets.Bodega.DataSetTipoBodegaDespacho dataSetTipoBodegaDespacho;
        private System.Windows.Forms.BindingSource spSELECTTipoBodegaAllBindingSource;
        private DataSets.Bodega.DataSetTipoBodegaDespachoTableAdapters.sp_SELECT_TipoBodega_AllTableAdapter sp_SELECT_TipoBodega_AllTableAdapter;
    }
}
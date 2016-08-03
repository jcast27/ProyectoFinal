namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroProducto));
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
            this.registroProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRegistroProducto = new SIME_UTN.DataSets.Bodega.Procesos.DataSetRegistroProducto();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDIngresoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsuario = new SIME_UTN.DataSets.DataSetUsuario();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolicitudAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDRegistroBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditBodega = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spSELECTRegistroBodegaAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRBodegaNombre = new SIME_UTN.DataSets.Bodega.Procesos.DataSetRBodegaNombre();
            this.registroProductoTableAdapter = new SIME_UTN.DataSets.Bodega.Procesos.DataSetRegistroProductoTableAdapters.RegistroProductoTableAdapter();
            this.usuarioTableAdapter = new SIME_UTN.DataSets.DataSetUsuarioTableAdapters.UsuarioTableAdapter();
            this.sp_SELECT_RegistroBodega_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Procesos.DataSetRBodegaNombreTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRegistroProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRBodegaNombre)).BeginInit();
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
            this.gbGridViewRegistroProductos.Text = "Registro De Producto";
            // 
            // gCBodegas
            // 
            this.gCBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCBodegas.DataSource = this.registroProductoBindingSource;
            this.gCBodegas.Location = new System.Drawing.Point(3, 55);
            this.gCBodegas.MainView = this.gridView1;
            this.gCBodegas.Name = "gCBodegas";
            this.gCBodegas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpUsuario,
            this.LookUpEditBodega});
            this.gCBodegas.Size = new System.Drawing.Size(1030, 464);
            this.gCBodegas.TabIndex = 0;
            this.gCBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCBodegas.Click += new System.EventHandler(this.gCBodegas_Click);
            // 
            // registroProductoBindingSource
            // 
            this.registroProductoBindingSource.DataMember = "RegistroProducto";
            this.registroProductoBindingSource.DataSource = this.dataSetRegistroProducto;
            // 
            // dataSetRegistroProducto
            // 
            this.dataSetRegistroProducto.DataSetName = "DataSetRegistroProducto";
            this.dataSetRegistroProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDIngresoProducto,
            this.colIDUsuario,
            this.colDescripcion,
            this.colSolicitudAvatar,
            this.colFechaIngreso,
            this.colIDRegistroBodega});
            this.gridView1.GridControl = this.gCBodegas;
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
            // colIDIngresoProducto
            // 
            this.colIDIngresoProducto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colIDIngresoProducto.AppearanceCell.Options.UseFont = true;
            this.colIDIngresoProducto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDIngresoProducto.AppearanceHeader.Options.UseFont = true;
            this.colIDIngresoProducto.FieldName = "IDIngresoProducto";
            this.colIDIngresoProducto.Name = "colIDIngresoProducto";
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colIDUsuario.AppearanceCell.Options.UseFont = true;
            this.colIDUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colIDUsuario.AppearanceHeader.Options.UseFont = true;
            this.colIDUsuario.ColumnEdit = this.LookUpUsuario;
            this.colIDUsuario.FieldName = "IDUsuario";
            this.colIDUsuario.Name = "colIDUsuario";
            // 
            // LookUpUsuario
            // 
            this.LookUpUsuario.AutoHeight = false;
            this.LookUpUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpUsuario.DataSource = this.usuarioBindingSource;
            this.LookUpUsuario.DisplayMember = "Nombre";
            this.LookUpUsuario.Name = "LookUpUsuario";
            this.LookUpUsuario.ValueMember = "CodigoUsuario";
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
            // colDescripcion
            // 
            this.colDescripcion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDescripcion.AppearanceCell.Options.UseFont = true;
            this.colDescripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDescripcion.AppearanceHeader.Options.UseFont = true;
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colSolicitudAvatar
            // 
            this.colSolicitudAvatar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSolicitudAvatar.AppearanceCell.Options.UseFont = true;
            this.colSolicitudAvatar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSolicitudAvatar.AppearanceHeader.Options.UseFont = true;
            this.colSolicitudAvatar.FieldName = "SolicitudAvatar";
            this.colSolicitudAvatar.Name = "colSolicitudAvatar";
            this.colSolicitudAvatar.Visible = true;
            this.colSolicitudAvatar.VisibleIndex = 0;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colFechaIngreso.AppearanceCell.Options.UseFont = true;
            this.colFechaIngreso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colFechaIngreso.AppearanceHeader.Options.UseFont = true;
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 2;
            // 
            // colIDRegistroBodega
            // 
            this.colIDRegistroBodega.ColumnEdit = this.LookUpEditBodega;
            this.colIDRegistroBodega.FieldName = "IDRegistroBodega";
            this.colIDRegistroBodega.Name = "colIDRegistroBodega";
            this.colIDRegistroBodega.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // LookUpEditBodega
            // 
            this.LookUpEditBodega.AutoHeight = false;
            this.LookUpEditBodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditBodega.DataSource = this.spSELECTRegistroBodegaAllBindingSource;
            this.LookUpEditBodega.DisplayMember = "nombre";
            this.LookUpEditBodega.Name = "LookUpEditBodega";
            this.LookUpEditBodega.ValueMember = "idregistrobodega";
            // 
            // spSELECTRegistroBodegaAllBindingSource
            // 
            this.spSELECTRegistroBodegaAllBindingSource.DataMember = "sp_SELECT_RegistroBodega_All";
            this.spSELECTRegistroBodegaAllBindingSource.DataSource = this.dataSetRBodegaNombre;
            // 
            // dataSetRBodegaNombre
            // 
            this.dataSetRBodegaNombre.DataSetName = "DataSetRBodegaNombre";
            this.dataSetRBodegaNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroProductoTableAdapter
            // 
            this.registroProductoTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SELECT_RegistroBodega_AllTableAdapter
            // 
            this.sp_SELECT_RegistroBodega_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegistroProducto
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
            this.Name = "frmRegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Registro de Productos";
            this.Load += new System.EventHandler(this.frmRegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRegistroProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRBodegaNombre)).EndInit();
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
        private SIME_UTN.DataSets.Bodega.Procesos.DataSetRegistroProducto dataSetRegistroProducto;
        private System.Windows.Forms.BindingSource registroProductoBindingSource;
        private SIME_UTN.DataSets.Bodega.Procesos.DataSetRegistroProductoTableAdapters.RegistroProductoTableAdapter registroProductoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDIngresoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSolicitudAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUsuario;
        private DataSets.DataSetUsuario dataSetUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSets.DataSetUsuarioTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDRegistroBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditBodega;
        private DataSets.Bodega.Procesos.DataSetRBodegaNombre dataSetRBodegaNombre;
        private System.Windows.Forms.BindingSource spSELECTRegistroBodegaAllBindingSource;
        private DataSets.Bodega.Procesos.DataSetRBodegaNombreTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter sp_SELECT_RegistroBodega_AllTableAdapter;
    }
}
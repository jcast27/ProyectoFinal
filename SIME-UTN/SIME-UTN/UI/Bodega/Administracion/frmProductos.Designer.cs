namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.cmMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProducto = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProducto();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategorias = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetCategorias();
            this.colIDUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spSELECTUnidadMedidaProductoAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidadMedida = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedida();
            this.colCantidadMinima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPresupuestaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContenido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUbicacion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spSELECTUnidadMedidaProductoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbGridViewUsuario = new System.Windows.Forms.GroupBox();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.productoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductoTableAdapters.ProductoTableAdapter();
            this.categoriaTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetCategoriasTableAdapters.CategoriaTableAdapter();
            this.sp_SELECT_Ubicacion_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUbicacionTableAdapters.sp_SELECT_Ubicacion_AllTableAdapter();
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter();
            this.sfdRuta = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            this.cmMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCProductos
            // 
            this.gCProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCProductos.ContextMenuStrip = this.cmMenuGrid;
            this.gCProductos.DataSource = this.productoBindingSource;
            this.gCProductos.Location = new System.Drawing.Point(6, 42);
            this.gCProductos.MainView = this.gridView1;
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpCategoria,
            this.LookUpUnidadMedida,
            this.LookUpUbicacion});
            this.gCProductos.Size = new System.Drawing.Size(974, 468);
            this.gCProductos.TabIndex = 0;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCProductos.Click += new System.EventHandler(this.gCProductos_Click);
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
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dataSetProducto;
            // 
            // dataSetProducto
            // 
            this.dataSetProducto.DataSetName = "DataSetProducto";
            this.dataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 4;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.colCodigoAvatar,
            this.colNombre,
            this.colDescripcion,
            this.colIDCategoria,
            this.colIDUnidadMedida,
            this.colCantidadMinima,
            this.colCantidadMaxima,
            this.colCuentaPresupuestaria,
            this.colEstado,
            this.colContenido});
            this.gridView1.GridControl = this.gCProductos;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.RowHeight = 2;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            // 
            // colCodigoAvatar
            // 
            this.colCodigoAvatar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCodigoAvatar.AppearanceCell.Options.UseFont = true;
            this.colCodigoAvatar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigoAvatar.AppearanceHeader.Options.UseFont = true;
            this.colCodigoAvatar.Caption = "Código Avatar";
            this.colCodigoAvatar.FieldName = "CodigoAvatar";
            this.colCodigoAvatar.Name = "colCodigoAvatar";
            this.colCodigoAvatar.Visible = true;
            this.colCodigoAvatar.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colNombre.AppearanceCell.Options.UseFont = true;
            this.colNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colNombre.AppearanceHeader.Options.UseFont = true;
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 185;
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
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 185;
            // 
            // colIDCategoria
            // 
            this.colIDCategoria.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colIDCategoria.AppearanceCell.Options.UseFont = true;
            this.colIDCategoria.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colIDCategoria.AppearanceHeader.Options.UseFont = true;
            this.colIDCategoria.Caption = "Categoría";
            this.colIDCategoria.ColumnEdit = this.LookUpCategoria;
            this.colIDCategoria.FieldName = "IDCategoria";
            this.colIDCategoria.Name = "colIDCategoria";
            this.colIDCategoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colIDCategoria.Visible = true;
            this.colIDCategoria.VisibleIndex = 3;
            this.colIDCategoria.Width = 185;
            // 
            // LookUpCategoria
            // 
            this.LookUpCategoria.AutoHeight = false;
            this.LookUpCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpCategoria.DataSource = this.categoriaBindingSource;
            this.LookUpCategoria.DisplayMember = "Descripcion";
            this.LookUpCategoria.Name = "LookUpCategoria";
            this.LookUpCategoria.NullText = "";
            this.LookUpCategoria.ValueMember = "IDCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSetCategorias;
            // 
            // dataSetCategorias
            // 
            this.dataSetCategorias.DataSetName = "DataSetCategorias";
            this.dataSetCategorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colIDUnidadMedida
            // 
            this.colIDUnidadMedida.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDUnidadMedida.AppearanceCell.Options.UseFont = true;
            this.colIDUnidadMedida.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colIDUnidadMedida.AppearanceHeader.Options.UseFont = true;
            this.colIDUnidadMedida.Caption = "Unidad Medida";
            this.colIDUnidadMedida.ColumnEdit = this.LookUpUnidadMedida;
            this.colIDUnidadMedida.FieldName = "IDUnidadMedida";
            this.colIDUnidadMedida.Name = "colIDUnidadMedida";
            this.colIDUnidadMedida.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colIDUnidadMedida.Visible = true;
            this.colIDUnidadMedida.VisibleIndex = 4;
            this.colIDUnidadMedida.Width = 194;
            // 
            // LookUpUnidadMedida
            // 
            this.LookUpUnidadMedida.AutoHeight = false;
            this.LookUpUnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpUnidadMedida.DataSource = this.spSELECTUnidadMedidaProductoAllBindingSource1;
            this.LookUpUnidadMedida.DisplayMember = "descripcion";
            this.LookUpUnidadMedida.Name = "LookUpUnidadMedida";
            this.LookUpUnidadMedida.ValueMember = "idunidadmedida";
            // 
            // spSELECTUnidadMedidaProductoAllBindingSource1
            // 
            this.spSELECTUnidadMedidaProductoAllBindingSource1.DataMember = "sp_SELECT_UnidadMedidaProducto_All";
            this.spSELECTUnidadMedidaProductoAllBindingSource1.DataSource = this.dataSetUnidadMedida;
            // 
            // dataSetUnidadMedida
            // 
            this.dataSetUnidadMedida.DataSetName = "DataSetUnidadMedida";
            this.dataSetUnidadMedida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCantidadMinima
            // 
            this.colCantidadMinima.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCantidadMinima.AppearanceCell.Options.UseFont = true;
            this.colCantidadMinima.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCantidadMinima.AppearanceHeader.Options.UseFont = true;
            this.colCantidadMinima.FieldName = "CantidadMinima";
            this.colCantidadMinima.Name = "colCantidadMinima";
            // 
            // colCantidadMaxima
            // 
            this.colCantidadMaxima.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCantidadMaxima.AppearanceCell.Options.UseFont = true;
            this.colCantidadMaxima.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCantidadMaxima.AppearanceHeader.Options.UseFont = true;
            this.colCantidadMaxima.FieldName = "CantidadMaxima";
            this.colCantidadMaxima.Name = "colCantidadMaxima";
            // 
            // colCuentaPresupuestaria
            // 
            this.colCuentaPresupuestaria.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCuentaPresupuestaria.AppearanceCell.Options.UseFont = true;
            this.colCuentaPresupuestaria.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCuentaPresupuestaria.AppearanceHeader.Options.UseFont = true;
            this.colCuentaPresupuestaria.Caption = "C. Presupuestaria";
            this.colCuentaPresupuestaria.FieldName = "CuentaPresupuestaria";
            this.colCuentaPresupuestaria.Name = "colCuentaPresupuestaria";
            this.colCuentaPresupuestaria.Visible = true;
            this.colCuentaPresupuestaria.VisibleIndex = 5;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colContenido
            // 
            this.colContenido.FieldName = "Contenido";
            this.colContenido.Name = "colContenido";
            // 
            // LookUpUbicacion
            // 
            this.LookUpUbicacion.AutoHeight = false;
            this.LookUpUbicacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpUbicacion.DisplayMember = "nombre";
            this.LookUpUbicacion.Name = "LookUpUbicacion";
            this.LookUpUbicacion.ValueMember = "idubicacion";
            // 
            // spSELECTUnidadMedidaProductoAllBindingSource
            // 
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataMember = "sp_SELECT_UnidadMedidaProducto_All";
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataSource = this.dataSetUnidadMedida;
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
            this.tileNavPane1.Size = new System.Drawing.Size(1147, 45);
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
            this.panel2.Location = new System.Drawing.Point(1144, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 647);
            this.panel2.TabIndex = 31;
            // 
            // gbGridViewUsuario
            // 
            this.gbGridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewUsuario.Controls.Add(this.gCProductos);
            this.gbGridViewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewUsuario.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewUsuario.Name = "gbGridViewUsuario";
            this.gbGridViewUsuario.Size = new System.Drawing.Size(986, 516);
            this.gbGridViewUsuario.TabIndex = 33;
            this.gbGridViewUsuario.TabStop = false;
            this.gbGridViewUsuario.Text = "Seleccionar Producto";
            // 
            // navButton1
            // 
            this.navButton1.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton1.Caption = null;
            this.navButton1.Enabled = false;
            this.navButton1.Name = "navButton1";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SELECT_Ubicacion_AllTableAdapter
            // 
            this.sp_SELECT_Ubicacion_AllTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SELECT_UnidadMedidaProducto_AllTableAdapter
            // 
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter.ClearBeforeFill = true;
            // 
            // sfdRuta
            // 
            this.sfdRuta.Filter = "Archivos Excel | *.xlsx";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1292, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            this.cmMenuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpCategoria;
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.GroupBox gbGridViewUsuario;

        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUnidadMedida;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetProducto dataSetProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductoTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DataSets.Bodega.Admistracion.DataSetCategorias dataSetCategorias;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataSets.Bodega.Admistracion.DataSetCategoriasTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource dataSetUnidadMedidaBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUbicacion;
        private DataSets.Bodega.Admistracion.DataSetUbicacionTableAdapters.sp_SELECT_Ubicacion_AllTableAdapter sp_SELECT_Ubicacion_AllTableAdapter;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource spSELECTUnidadMedidaProductoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter sp_SELECT_UnidadMedidaProducto_AllTableAdapter;
        private System.Windows.Forms.BindingSource spSELECTUnidadMedidaProductoAllBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadMinima;
        private DevExpress.XtraGrid.Columns.GridColumn colContenido;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPresupuestaria;
        private System.Windows.Forms.ContextMenuStrip cmMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRuta;
    }
}
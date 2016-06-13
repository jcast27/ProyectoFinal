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
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new SIME_UTN.DataSets.Bodega.DataSetProductos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategorias = new SIME_UTN.DataSets.Bodega.DataSetCategorias();
            this.colUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unidadMedidaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidadMedida = new SIME_UTN.DataSets.Bodega.DataSetUnidadMedida();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigoAvatar = new System.Windows.Forms.Label();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.txtCodigoAvatar = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtLocalizacion = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.gbGridViewUsuario = new System.Windows.Forms.GroupBox();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.categoriaTableAdapter = new SIME_UTN.DataSets.Bodega.DataSetCategoriasTableAdapters.CategoriaTableAdapter();
            this.unidadMedidaProductoTableAdapter = new SIME_UTN.DataSets.Bodega.DataSetUnidadMedidaTableAdapters.UnidadMedidaProductoTableAdapter();
            this.productoTableAdapter = new SIME_UTN.DataSets.Bodega.DataSetProductosTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbInformacionPersonal.SuspendLayout();
            this.gbGridViewUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocalizacion.Location = new System.Drawing.Point(15, 316);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(95, 18);
            this.lblLocalizacion.TabIndex = 13;
            this.lblLocalizacion.Text = "Localizacion:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(189, 62);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(114, 22);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.Text = "Cloro";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoria.Location = new System.Drawing.Point(15, 254);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 62);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(154, 18);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // gCProductos
            // 
            this.gCProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gCProductos.DataSource = this.productoBindingSource;
            this.gCProductos.Location = new System.Drawing.Point(6, 106);
            this.gCProductos.MainView = this.gridView1;
            this.gCProductos.MaximumSize = new System.Drawing.Size(787, 232);
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpCategoria,
            this.LookUpUnidadMedida});
            this.gCProductos.Size = new System.Drawing.Size(656, 232);
            this.gCProductos.TabIndex = 19;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCProductos.Click += new System.EventHandler(this.gCUsuarios_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dataSetProductos;
            // 
            // dataSetProductos
            // 
            this.dataSetProductos.DataSetName = "DataSetProductos";
            this.dataSetProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.colCodigoAvatar,
            this.colNombre,
            this.colDescripcion,
            this.colIDCategoria,
            this.colUbicacion,
            this.colIDUnidadMedida,
            this.colEstado});
            this.gridView1.GridControl = this.gCProductos;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            // 
            // colCodigoAvatar
            // 
            this.colCodigoAvatar.FieldName = "CodigoAvatar";
            this.colCodigoAvatar.Name = "colCodigoAvatar";
            this.colCodigoAvatar.Visible = true;
            this.colCodigoAvatar.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colIDCategoria
            // 
            this.colIDCategoria.Caption = "Categoria";
            this.colIDCategoria.ColumnEdit = this.LookUpCategoria;
            this.colIDCategoria.FieldName = "IDCategoria";
            this.colIDCategoria.Name = "colIDCategoria";
            this.colIDCategoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colIDCategoria.Visible = true;
            this.colIDCategoria.VisibleIndex = 3;
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
            // colUbicacion
            // 
            this.colUbicacion.FieldName = "Ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.Visible = true;
            this.colUbicacion.VisibleIndex = 4;
            // 
            // colIDUnidadMedida
            // 
            this.colIDUnidadMedida.Caption = "Unidad Medida";
            this.colIDUnidadMedida.ColumnEdit = this.LookUpUnidadMedida;
            this.colIDUnidadMedida.FieldName = "IDUnidadMedida";
            this.colIDUnidadMedida.Name = "colIDUnidadMedida";
            this.colIDUnidadMedida.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colIDUnidadMedida.Visible = true;
            this.colIDUnidadMedida.VisibleIndex = 5;
            // 
            // LookUpUnidadMedida
            // 
            this.LookUpUnidadMedida.AutoHeight = false;
            this.LookUpUnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpUnidadMedida.DataSource = this.unidadMedidaProductoBindingSource;
            this.LookUpUnidadMedida.DisplayMember = "Descripcion";
            this.LookUpUnidadMedida.Name = "LookUpUnidadMedida";
            this.LookUpUnidadMedida.ValueMember = "IDUnidadMedida";
            // 
            // unidadMedidaProductoBindingSource
            // 
            this.unidadMedidaProductoBindingSource.DataMember = "UnidadMedidaProducto";
            this.unidadMedidaProductoBindingSource.DataSource = this.dataSetUnidadMedida;
            // 
            // dataSetUnidadMedida
            // 
            this.dataSetUnidadMedida.DataSetName = "DataSetUnidadMedida";
            this.dataSetUnidadMedida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodigoAvatar
            // 
            this.lblCodigoAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoAvatar.AutoSize = true;
            this.lblCodigoAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAvatar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoAvatar.Location = new System.Drawing.Point(15, 181);
            this.lblCodigoAvatar.Name = "lblCodigoAvatar";
            this.lblCodigoAvatar.Size = new System.Drawing.Size(105, 18);
            this.lblCodigoAvatar.TabIndex = 23;
            this.lblCodigoAvatar.Text = "Codigo Avatar:";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnNuevo);
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
            // mBtnNuevo
            // 
            this.mBtnNuevo.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnNuevo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnNuevo.Appearance.Options.UseFont = true;
            this.mBtnNuevo.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnNuevo.AppearanceHovered.Options.UseFont = true;
            this.mBtnNuevo.Caption = "Nuevo";
            this.mBtnNuevo.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnNuevo.Glyph")));
            this.mBtnNuevo.Name = "mBtnNuevo";
            this.mBtnNuevo.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnNuevo_ElementClick);
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
            // 
            // txtCodigoAvatar
            // 
            this.txtCodigoAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAvatar.Location = new System.Drawing.Point(189, 183);
            this.txtCodigoAvatar.Name = "txtCodigoAvatar";
            this.txtCodigoAvatar.Size = new System.Drawing.Size(114, 22);
            this.txtCodigoAvatar.TabIndex = 28;
            this.txtCodigoAvatar.Text = "A234";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(189, 125);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(114, 22);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.Text = "Limpieza";
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
            // gbInformacionPersonal
            // 
            this.gbInformacionPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionPersonal.Controls.Add(this.cmbUnidadMedida);
            this.gbInformacionPersonal.Controls.Add(this.lblUnidadMedida);
            this.gbInformacionPersonal.Controls.Add(this.cmbCategoria);
            this.gbInformacionPersonal.Controls.Add(this.txtLocalizacion);
            this.gbInformacionPersonal.Controls.Add(this.lblCodigoUsuario);
            this.gbInformacionPersonal.Controls.Add(this.lblDescripcion);
            this.gbInformacionPersonal.Controls.Add(this.txtCodigoAvatar);
            this.gbInformacionPersonal.Controls.Add(this.txtNombreProducto);
            this.gbInformacionPersonal.Controls.Add(this.lblCodigoAvatar);
            this.gbInformacionPersonal.Controls.Add(this.lblNombreProducto);
            this.gbInformacionPersonal.Controls.Add(this.lblLocalizacion);
            this.gbInformacionPersonal.Controls.Add(this.lblCategoria);
            this.gbInformacionPersonal.Controls.Add(this.txtDescripcion);
            this.gbInformacionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionPersonal.Location = new System.Drawing.Point(167, 64);
            this.gbInformacionPersonal.Name = "gbInformacionPersonal";
            this.gbInformacionPersonal.Size = new System.Drawing.Size(350, 456);
            this.gbInformacionPersonal.TabIndex = 32;
            this.gbInformacionPersonal.TabStop = false;
            this.gbInformacionPersonal.Text = "Informacion del Producto";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidadMedida.DataSource = this.unidadMedidaProductoBindingSource;
            this.cmbUnidadMedida.DisplayMember = "Descripcion";
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(189, 366);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(114, 24);
            this.cmbUnidadMedida.TabIndex = 33;
            this.cmbUnidadMedida.ValueMember = "IDUnidadMedida";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnidadMedida.Location = new System.Drawing.Point(15, 372);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(130, 18);
            this.lblUnidadMedida.TabIndex = 32;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(189, 254);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(114, 24);
            this.cmbCategoria.TabIndex = 31;
            this.cmbCategoria.ValueMember = "IDCategoria";
            // 
            // txtLocalizacion
            // 
            this.txtLocalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacion.Location = new System.Drawing.Point(189, 312);
            this.txtLocalizacion.Name = "txtLocalizacion";
            this.txtLocalizacion.Size = new System.Drawing.Size(114, 22);
            this.txtLocalizacion.TabIndex = 30;
            this.txtLocalizacion.Text = "Modulo1";
            // 
            // lblCodigoUsuario
            // 
            this.lblCodigoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoUsuario.AutoSize = true;
            this.lblCodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoUsuario.Location = new System.Drawing.Point(14, 25);
            this.lblCodigoUsuario.Name = "lblCodigoUsuario";
            this.lblCodigoUsuario.Size = new System.Drawing.Size(0, 18);
            this.lblCodigoUsuario.TabIndex = 29;
            this.lblCodigoUsuario.Visible = false;
            // 
            // gbGridViewUsuario
            // 
            this.gbGridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewUsuario.Controls.Add(this.gCProductos);
            this.gbGridViewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewUsuario.Location = new System.Drawing.Point(523, 64);
            this.gbGridViewUsuario.Name = "gbGridViewUsuario";
            this.gbGridViewUsuario.Size = new System.Drawing.Size(668, 456);
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
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // unidadMedidaProductoTableAdapter
            // 
            this.unidadMedidaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbInformacionPersonal);
            this.Controls.Add(this.gbGridViewUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbInformacionPersonal.ResumeLayout(false);
            this.gbInformacionPersonal.PerformLayout();
            this.gbGridViewUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblLocalizacion;
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpCategoria;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Label lblCodigoAvatar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoAvatar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbInformacionPersonal;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.GroupBox gbGridViewUsuario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.TextBox txtLocalizacion;
        private System.Windows.Forms.ComboBox cmbCategoria;

        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private SIME_UTN.DataSets.Bodega.DataSetCategorias dataSetCategorias;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private SIME_UTN.DataSets.Bodega.DataSetCategoriasTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private SIME_UTN.DataSets.Bodega.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource unidadMedidaProductoBindingSource;
        private SIME_UTN.DataSets.Bodega.DataSetUnidadMedidaTableAdapters.UnidadMedidaProductoTableAdapter unidadMedidaProductoTableAdapter;
        private SIME_UTN.DataSets.Bodega.DataSetProductos dataSetProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private SIME_UTN.DataSets.Bodega.DataSetProductosTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUnidadMedida;
    }
}
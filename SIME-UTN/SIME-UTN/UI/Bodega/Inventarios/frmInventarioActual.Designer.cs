namespace SIME_UTN.UI.Bodega.Inventarios
{
    partial class frmInventarioActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioActual));
            this.inventarioProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInventario = new SIME_UTN.DataSetInventario();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductos();
            this.unidadMedidaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidadMedida = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedida();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.inventarioProductoTableAdapter = new SIME_UTN.DataSetInventarioTableAdapters.InventarioProductoTableAdapter();
            this.dataSetProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductosTableAdapters.ProductoTableAdapter();
            this.unidadMedidaProductoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.UnidadMedidaProductoTableAdapter();
            this.gbInvActual = new System.Windows.Forms.GroupBox();
            this.gInvActual = new DevExpress.XtraGrid.GridControl();
            this.gCInventarioActual = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDInventarioProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpProducto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane2 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).BeginInit();
            this.gbInvActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gInvActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCInventarioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioProductoBindingSource
            // 
            this.inventarioProductoBindingSource.DataMember = "InventarioProducto";
            this.inventarioProductoBindingSource.DataSource = this.dataSetInventario;
            // 
            // dataSetInventario
            // 
            this.dataSetInventario.DataSetName = "DataSetInventario";
            this.dataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tileNavPane1
            // 
            this.tileNavPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
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
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(500, 40);
            this.tileNavPane1.TabIndex = 0;
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
            // inventarioProductoTableAdapter
            // 
            this.inventarioProductoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetProductosBindingSource
            // 
            this.dataSetProductosBindingSource.DataSource = this.dataSetProductos;
            this.dataSetProductosBindingSource.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // unidadMedidaProductoTableAdapter
            // 
            this.unidadMedidaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // gbInvActual
            // 
            this.gbInvActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvActual.Controls.Add(this.gInvActual);
            this.gbInvActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvActual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbInvActual.Location = new System.Drawing.Point(152, 64);
            this.gbInvActual.Name = "gbInvActual";
            this.gbInvActual.Size = new System.Drawing.Size(1039, 516);
            this.gbInvActual.TabIndex = 33;
            this.gbInvActual.TabStop = false;
            this.gbInvActual.Text = "Inventario Actual";
            // 
            // gInvActual
            // 
            this.gInvActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gInvActual.DataSource = this.inventarioProductoBindingSource;
            this.gInvActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gInvActual.Location = new System.Drawing.Point(6, 42);
            this.gInvActual.MainView = this.gCInventarioActual;
            this.gInvActual.Name = "gInvActual";
            this.gInvActual.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpProducto,
            this.LookUpUnidadMedida});
            this.gInvActual.Size = new System.Drawing.Size(1027, 468);
            this.gInvActual.TabIndex = 19;
            this.gInvActual.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gCInventarioActual});
            // 
            // gCInventarioActual
            // 
            this.gCInventarioActual.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDInventarioProducto,
            this.colCodigoAvatar,
            this.colIDProducto,
            this.colDescripcion,
            this.colIDUnidadMedida,
            this.colStockActual,
            this.colStockMinimo,
            this.colStockMaximo,
            this.colEstado});
            this.gCInventarioActual.GridControl = this.gInvActual;
            this.gCInventarioActual.Name = "gCInventarioActual";
            // 
            // colIDInventarioProducto
            // 
            this.colIDInventarioProducto.FieldName = "IDInventarioProducto";
            this.colIDInventarioProducto.Name = "colIDInventarioProducto";
            // 
            // colCodigoAvatar
            // 
            this.colCodigoAvatar.Caption = "Código Avatar";
            this.colCodigoAvatar.FieldName = "CodigoAvatar";
            this.colCodigoAvatar.Name = "colCodigoAvatar";
            this.colCodigoAvatar.Visible = true;
            this.colCodigoAvatar.VisibleIndex = 0;
            // 
            // colIDProducto
            // 
            this.colIDProducto.Caption = "Producto";
            this.colIDProducto.ColumnEdit = this.LookUpProducto;
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.Visible = true;
            this.colIDProducto.VisibleIndex = 1;
            // 
            // LookUpProducto
            // 
            this.LookUpProducto.AutoHeight = false;
            this.LookUpProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpProducto.DataSource = this.productoBindingSource;
            this.LookUpProducto.DisplayMember = "Nombre";
            this.LookUpProducto.Name = "LookUpProducto";
            this.LookUpProducto.ValueMember = "IDProducto";
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colIDUnidadMedida
            // 
            this.colIDUnidadMedida.Caption = "Unidad Medida";
            this.colIDUnidadMedida.ColumnEdit = this.LookUpUnidadMedida;
            this.colIDUnidadMedida.FieldName = "IDUnidadMedida";
            this.colIDUnidadMedida.Name = "colIDUnidadMedida";
            this.colIDUnidadMedida.Visible = true;
            this.colIDUnidadMedida.VisibleIndex = 3;
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
            // colStockActual
            // 
            this.colStockActual.Caption = "Existencia Actual";
            this.colStockActual.FieldName = "StockActual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.Visible = true;
            this.colStockActual.VisibleIndex = 4;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.FieldName = "StockMinimo";
            this.colStockMinimo.Name = "colStockMinimo";
            // 
            // colStockMaximo
            // 
            this.colStockMaximo.FieldName = "StockMaximo";
            this.colStockMaximo.Name = "colStockMaximo";
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
            // tileNavPane2
            // 
            this.tileNavPane2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane2.BackgroundImage")));
            this.tileNavPane2.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane2.Buttons.Add(this.navButton2);
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
            this.tileNavPane2.Location = new System.Drawing.Point(144, 0);
            this.tileNavPane2.Name = "tileNavPane2";
            this.tileNavPane2.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane2.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane2.Size = new System.Drawing.Size(1200, 45);
            this.tileNavPane2.TabIndex = 29;
            this.tileNavPane2.Text = "tileNavPane2";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
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
            // frmInventarioActual
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tileNavPane2);
            this.Controls.Add(this.gbInvActual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioActual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Actual";
            this.Load += new System.EventHandler(this.frmInventarioActual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductosBindingSource)).EndInit();
            this.gbInvActual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gInvActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCInventarioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private DataSetInventario dataSetInventario;
        private System.Windows.Forms.BindingSource inventarioProductoBindingSource;
        private DataSetInventarioTableAdapters.InventarioProductoTableAdapter inventarioProductoTableAdapter;
        private System.Windows.Forms.BindingSource dataSetProductosBindingSource;
        private DataSets.Bodega.Admistracion.DataSetProductos dataSetProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetProductosTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource unidadMedidaProductoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.UnidadMedidaProductoTableAdapter unidadMedidaProductoTableAdapter;
        private System.Windows.Forms.GroupBox gbInvActual;
        private DevExpress.XtraGrid.GridControl gInvActual;
        private DevExpress.XtraGrid.Views.Grid.GridView gCInventarioActual;
        private DevExpress.XtraGrid.Columns.GridColumn colIDInventarioProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colStockActual;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMinimo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMaximo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane2;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private System.Windows.Forms.Panel panel2;
    }
}
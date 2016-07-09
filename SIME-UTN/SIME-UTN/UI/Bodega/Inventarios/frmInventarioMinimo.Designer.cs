namespace SIME_UTN.UI.Bodega.Inventarios
{
    partial class frmInventarioMinimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioMinimo));
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbInvMin = new System.Windows.Forms.GroupBox();
            this.gcInvMin = new DevExpress.XtraGrid.GridControl();
            this.inventarioProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInventario = new SIME_UTN.DataSetInventario();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDInventarioProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpProducto = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProductos = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductos();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockMaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inventarioProductoTableAdapter = new SIME_UTN.DataSetInventarioTableAdapters.InventarioProductoTableAdapter();
            this.productoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetProductosTableAdapters.ProductoTableAdapter();
            this.dataSetUnidadMedida = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedida();
            this.spSELECTUnidadMedidaProductoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbInvMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).BeginInit();
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
            this.tileNavPane1.Buttons.Add(this.navButton2);
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
            this.tileNavPane1.Text = "tileNavPane1";
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
            // gbInvMin
            // 
            this.gbInvMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvMin.Controls.Add(this.gcInvMin);
            this.gbInvMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvMin.Location = new System.Drawing.Point(152, 64);
            this.gbInvMin.Name = "gbInvMin";
            this.gbInvMin.Size = new System.Drawing.Size(1039, 516);
            this.gbInvMin.TabIndex = 33;
            this.gbInvMin.TabStop = false;
            this.gbInvMin.Text = "Inventario Mínimo";
            // 
            // gcInvMin
            // 
            this.gcInvMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcInvMin.DataSource = this.inventarioProductoBindingSource;
            this.gcInvMin.Location = new System.Drawing.Point(6, 42);
            this.gcInvMin.MainView = this.gridView1;
            this.gcInvMin.Name = "gcInvMin";
            this.gcInvMin.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpProducto,
            this.LookUpUnidadMedida});
            this.gcInvMin.Size = new System.Drawing.Size(1027, 468);
            this.gcInvMin.TabIndex = 19;
            this.gcInvMin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDInventarioProducto,
            this.colCodigoAvatar,
            this.colIDProducto,
            this.colDescripcion,
            this.colIDUnidadMedida,
            this.colStockActual,
            this.colStockMinimo,
            this.colStockMaximo,
            this.colEstado});
            this.gridView1.GridControl = this.gcInvMin;
            this.gridView1.Name = "gridView1";
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
            this.LookUpUnidadMedida.DataSource = this.spSELECTUnidadMedidaProductoAllBindingSource;
            this.LookUpUnidadMedida.DisplayMember = "descripcion";
            this.LookUpUnidadMedida.Name = "LookUpUnidadMedida";
            this.LookUpUnidadMedida.ValueMember = "idunidadmedida";
            // 
            // colStockActual
            // 
            this.colStockActual.FieldName = "StockActual";
            this.colStockActual.Name = "colStockActual";
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.Caption = "Existencia Mínima";
            this.colStockMinimo.FieldName = "StockMinimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.Visible = true;
            this.colStockMinimo.VisibleIndex = 4;
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
            // inventarioProductoTableAdapter
            // 
            this.inventarioProductoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetUnidadMedida
            // 
            this.dataSetUnidadMedida.DataSetName = "DataSetUnidadMedida";
            this.dataSetUnidadMedida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSELECTUnidadMedidaProductoAllBindingSource
            // 
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataMember = "sp_SELECT_UnidadMedidaProducto_All";
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataSource = this.dataSetUnidadMedida;
            // 
            // sp_SELECT_UnidadMedidaProducto_AllTableAdapter
            // 
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventarioMinimo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.gbInvMin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tileNavPane1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioMinimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Mínimo";
            this.Load += new System.EventHandler(this.frmInventarioMinimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbInvMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.GroupBox gbInvMin;
        private DevExpress.XtraGrid.GridControl gcInvMin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DataSetInventario dataSetInventario;
        private System.Windows.Forms.BindingSource inventarioProductoBindingSource;
        private DataSetInventarioTableAdapters.InventarioProductoTableAdapter inventarioProductoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDInventarioProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colStockActual;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMinimo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMaximo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpProducto;
        private DataSets.Bodega.Admistracion.DataSetProductos dataSetProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetProductosTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUnidadMedida;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource spSELECTUnidadMedidaProductoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter sp_SELECT_UnidadMedidaProducto_AllTableAdapter;
    }
}
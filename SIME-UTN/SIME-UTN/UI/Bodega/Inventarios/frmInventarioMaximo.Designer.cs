namespace SIME_UTN.UI.Bodega.Inventarios
{
    partial class frmInventarioMaximo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioMaximo));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbInvMax = new System.Windows.Forms.GroupBox();
            this.gCInvMax = new DevExpress.XtraGrid.GridControl();
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
            this.unidadMedidaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.gbInvMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCInvMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tileNavPane1.Location = new System.Drawing.Point(123, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1221, 45);
            this.tileNavPane1.TabIndex = 29;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 688);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1218, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 647);
            this.panel2.TabIndex = 31;
            // 
            // gbInvMax
            // 
            this.gbInvMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvMax.Controls.Add(this.gCInvMax);
            this.gbInvMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInvMax.Location = new System.Drawing.Point(130, 64);
            this.gbInvMax.Name = "gbInvMax";
            this.gbInvMax.Size = new System.Drawing.Size(1083, 516);
            this.gbInvMax.TabIndex = 33;
            this.gbInvMax.TabStop = false;
            this.gbInvMax.Text = "Inventario Máximo";
            // 
            // gCInvMax
            // 
            this.gCInvMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCInvMax.DataSource = this.inventarioProductoBindingSource;
            this.gCInvMax.Location = new System.Drawing.Point(5, 42);
            this.gCInvMax.MainView = this.gridView1;
            this.gCInvMax.Name = "gCInvMax";
            this.gCInvMax.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpProducto,
            this.LookUpUnidadMedida});
            this.gCInvMax.Size = new System.Drawing.Size(1072, 468);
            this.gCInvMax.TabIndex = 19;
            this.gCInvMax.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gCInvMax;
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
            this.colStockMinimo.FieldName = "StockMinimo";
            this.colStockMinimo.Name = "colStockMinimo";
            // 
            // colStockMaximo
            // 
            this.colStockMaximo.Caption = "Existencia Máxima";
            this.colStockMaximo.FieldName = "StockMaximo";
            this.colStockMaximo.Name = "colStockMaximo";
            this.colStockMaximo.Visible = true;
            this.colStockMaximo.VisibleIndex = 4;
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
            // frmInventarioMaximo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.gbInvMax);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tileNavPane1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioMaximo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Máximo";
            this.Load += new System.EventHandler(this.frmInventarioMaximo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbInvMax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCInvMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInvMax;
        private DevExpress.XtraGrid.GridControl gCInvMax;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.BindingSource unidadMedidaProductoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource spSELECTUnidadMedidaProductoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter sp_SELECT_UnidadMedidaProducto_AllTableAdapter;
    }
}
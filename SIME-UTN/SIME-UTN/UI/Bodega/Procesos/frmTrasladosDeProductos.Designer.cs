namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmTrasladosDeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrasladosDeProductos));
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAceptar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnDeclinar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewTrasladoProductos = new System.Windows.Forms.GroupBox();
            this.gCTraslados = new DevExpress.XtraGrid.GridControl();
            this.spSELECTTrasladoProductoAllDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTrasladoProducto = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTrasladoProducto();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidtraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDRegistroBodegaOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodegaOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDRegistroBodegaDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodegaDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechatraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDTipoTraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoTraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEstadoTraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoTraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_SELECT_TrasladoProducto_All_DTOTableAdapter = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTrasladoProductoTableAdapters.sp_SELECT_TrasladoProducto_All_DTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewTrasladoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCTraslados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTrasladoProductoAllDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrasladoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tileNavPane1.Buttons.Add(this.mBtnAceptar);
            this.tileNavPane1.Buttons.Add(this.mBtnDeclinar);
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
            // mBtnAceptar
            // 
            this.mBtnAceptar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAceptar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAceptar.Appearance.Options.UseFont = true;
            this.mBtnAceptar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAceptar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAceptar.Caption = "Aceptar";
            this.mBtnAceptar.Enabled = false;
            this.mBtnAceptar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAceptar.Glyph")));
            this.mBtnAceptar.Name = "mBtnAceptar";
            // 
            // mBtnDeclinar
            // 
            this.mBtnDeclinar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnDeclinar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnDeclinar.Appearance.Options.UseFont = true;
            this.mBtnDeclinar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnDeclinar.AppearanceHovered.Options.UseFont = true;
            this.mBtnDeclinar.Caption = "Declinar";
            this.mBtnDeclinar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnDeclinar.Glyph")));
            this.mBtnDeclinar.Name = "mBtnDeclinar";
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
            // gbGridViewTrasladoProductos
            // 
            this.gbGridViewTrasladoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewTrasladoProductos.Controls.Add(this.gCTraslados);
            this.gbGridViewTrasladoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewTrasladoProductos.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewTrasladoProductos.Name = "gbGridViewTrasladoProductos";
            this.gbGridViewTrasladoProductos.Size = new System.Drawing.Size(1039, 522);
            this.gbGridViewTrasladoProductos.TabIndex = 34;
            this.gbGridViewTrasladoProductos.TabStop = false;
            this.gbGridViewTrasladoProductos.Text = "Detalle Traslados";
            // 
            // gCTraslados
            // 
            this.gCTraslados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCTraslados.DataSource = this.spSELECTTrasladoProductoAllDTOBindingSource;
            this.gCTraslados.Location = new System.Drawing.Point(3, 55);
            this.gCTraslados.MainView = this.gridView1;
            this.gCTraslados.Name = "gCTraslados";
            this.gCTraslados.Size = new System.Drawing.Size(1030, 464);
            this.gCTraslados.TabIndex = 0;
            this.gCTraslados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCTraslados.Click += new System.EventHandler(this.gCTraslados_Click);
            // 
            // spSELECTTrasladoProductoAllDTOBindingSource
            // 
            this.spSELECTTrasladoProductoAllDTOBindingSource.DataMember = "sp_SELECT_TrasladoProducto_All_DTO";
            this.spSELECTTrasladoProductoAllDTOBindingSource.DataSource = this.dataSetTrasladoProducto;
            // 
            // dataSetTrasladoProducto
            // 
            this.dataSetTrasladoProducto.DataSetName = "DataSetTrasladoProducto";
            this.dataSetTrasladoProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidtraslado,
            this.colIDRegistroBodegaOrigen,
            this.colBodegaOrigen,
            this.colIDRegistroBodegaDestino,
            this.colBodegaDestino,
            this.colIDUsuario,
            this.colUsuario,
            this.colObservaciones,
            this.colfechatraslado,
            this.colIDTipoTraslado,
            this.colTipoTraslado,
            this.colIDEstadoTraslado,
            this.colEstadoTraslado,
            this.colEstado});
            this.gridView1.GridControl = this.gCTraslados;
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
            // colidtraslado
            // 
            this.colidtraslado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colidtraslado.AppearanceCell.Options.UseFont = true;
            this.colidtraslado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colidtraslado.AppearanceHeader.Options.UseFont = true;
            this.colidtraslado.Caption = "Traslado #";
            this.colidtraslado.FieldName = "idtraslado";
            this.colidtraslado.Name = "colidtraslado";
            this.colidtraslado.Visible = true;
            this.colidtraslado.VisibleIndex = 0;
            // 
            // colIDRegistroBodegaOrigen
            // 
            this.colIDRegistroBodegaOrigen.FieldName = "IDRegistroBodegaOrigen";
            this.colIDRegistroBodegaOrigen.Name = "colIDRegistroBodegaOrigen";
            // 
            // colBodegaOrigen
            // 
            this.colBodegaOrigen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBodegaOrigen.AppearanceCell.Options.UseFont = true;
            this.colBodegaOrigen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colBodegaOrigen.AppearanceHeader.Options.UseFont = true;
            this.colBodegaOrigen.Caption = "Bodega Origen";
            this.colBodegaOrigen.FieldName = "BodegaOrigen";
            this.colBodegaOrigen.Name = "colBodegaOrigen";
            this.colBodegaOrigen.Visible = true;
            this.colBodegaOrigen.VisibleIndex = 1;
            // 
            // colIDRegistroBodegaDestino
            // 
            this.colIDRegistroBodegaDestino.FieldName = "IDRegistroBodegaDestino";
            this.colIDRegistroBodegaDestino.Name = "colIDRegistroBodegaDestino";
            // 
            // colBodegaDestino
            // 
            this.colBodegaDestino.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colBodegaDestino.AppearanceCell.Options.UseFont = true;
            this.colBodegaDestino.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colBodegaDestino.AppearanceHeader.Options.UseFont = true;
            this.colBodegaDestino.Caption = "Bodega Destino";
            this.colBodegaDestino.FieldName = "BodegaDestino";
            this.colBodegaDestino.Name = "colBodegaDestino";
            this.colBodegaDestino.Visible = true;
            this.colBodegaDestino.VisibleIndex = 2;
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.FieldName = "IDUsuario";
            this.colIDUsuario.Name = "colIDUsuario";
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            // 
            // colfechatraslado
            // 
            this.colfechatraslado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colfechatraslado.AppearanceCell.Options.UseFont = true;
            this.colfechatraslado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colfechatraslado.AppearanceHeader.Options.UseFont = true;
            this.colfechatraslado.Caption = "Fecha del Traslado";
            this.colfechatraslado.FieldName = "fechatraslado";
            this.colfechatraslado.Name = "colfechatraslado";
            this.colfechatraslado.Visible = true;
            this.colfechatraslado.VisibleIndex = 3;
            // 
            // colIDTipoTraslado
            // 
            this.colIDTipoTraslado.FieldName = "IDTipoTraslado";
            this.colIDTipoTraslado.Name = "colIDTipoTraslado";
            // 
            // colTipoTraslado
            // 
            this.colTipoTraslado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTipoTraslado.AppearanceCell.Options.UseFont = true;
            this.colTipoTraslado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTipoTraslado.AppearanceHeader.Options.UseFont = true;
            this.colTipoTraslado.Caption = "Tipo de Traslado";
            this.colTipoTraslado.FieldName = "TipoTraslado";
            this.colTipoTraslado.Name = "colTipoTraslado";
            this.colTipoTraslado.Visible = true;
            this.colTipoTraslado.VisibleIndex = 4;
            // 
            // colIDEstadoTraslado
            // 
            this.colIDEstadoTraslado.FieldName = "IDEstadoTraslado";
            this.colIDEstadoTraslado.Name = "colIDEstadoTraslado";
            // 
            // colEstadoTraslado
            // 
            this.colEstadoTraslado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEstadoTraslado.AppearanceCell.Options.UseFont = true;
            this.colEstadoTraslado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEstadoTraslado.AppearanceHeader.Options.UseFont = true;
            this.colEstadoTraslado.Caption = "Estado del Traslado";
            this.colEstadoTraslado.FieldName = "EstadoTraslado";
            this.colEstadoTraslado.Name = "colEstadoTraslado";
            this.colEstadoTraslado.Visible = true;
            this.colEstadoTraslado.VisibleIndex = 5;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // sp_SELECT_TrasladoProducto_All_DTOTableAdapter
            // 
            this.sp_SELECT_TrasladoProducto_All_DTOTableAdapter.ClearBeforeFill = true;
            // 
            // frmTrasladosDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1345, 680);
            this.Controls.Add(this.gbGridViewTrasladoProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrasladosDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Traslado de Productos";
            this.Load += new System.EventHandler(this.frmTrasladosDeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewTrasladoProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCTraslados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTrasladoProductoAllDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrasladoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAceptar;

        private DevExpress.XtraBars.Navigation.NavButton mBtnDeclinar;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private System.Windows.Forms.GroupBox gbGridViewTrasladoProductos;
        private DevExpress.XtraGrid.GridControl gCTraslados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSets.Bodega.Procesos.DataSetTrasladoProducto dataSetTrasladoProducto;
        private System.Windows.Forms.BindingSource spSELECTTrasladoProductoAllDTOBindingSource;
        private DataSets.Bodega.Procesos.DataSetTrasladoProductoTableAdapters.sp_SELECT_TrasladoProducto_All_DTOTableAdapter sp_SELECT_TrasladoProducto_All_DTOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidtraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colIDRegistroBodegaOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colBodegaOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colIDRegistroBodegaDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colBodegaDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colfechatraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colIDTipoTraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoTraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEstadoTraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoTraslado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}
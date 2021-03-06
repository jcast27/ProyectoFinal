﻿namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmModTrasladoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModTrasladoProductos));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.txtFechaTraslado = new System.Windows.Forms.TextBox();
            this.cmbBodegaDestino = new System.Windows.Forms.ComboBox();
            this.spSELECTRegistroBodegaAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTPRegistroBodegaD = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTPRegistroBodegaD();
            this.cmbBodegaOrigen = new System.Windows.Forms.ComboBox();
            this.spSELECTRegistroBodegaAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTPRegistroBodega = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTPRegistroBodega();
            this.lblIDBodegaDestino = new System.Windows.Forms.Label();
            this.lblIDBodegaOrigen = new System.Windows.Forms.Label();
            this.lblBodegaDestino = new System.Windows.Forms.Label();
            this.cmbTipoTraslado = new System.Windows.Forms.ComboBox();
            this.tipoTrasladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTipoTrasladoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTipoTraslado = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTipoTraslado();
            this.txtNumeroTraslado = new System.Windows.Forms.TextBox();
            this.lblNumeroTraslado = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblTipoTraslado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaTraslado = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaCodigoAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipoTrasladoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTipoTrasladoTableAdapters.TipoTrasladoTableAdapter();
            this.sp_SELECT_RegistroBodega_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTPRegistroBodegaTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter();
            this.sp_SELECT_RegistroBodega_AllTableAdapter1 = new SIME_UTN.DataSets.Bodega.Procesos.DataSetTPRegistroBodegaDTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTPRegistroBodegaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTPRegistroBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTrasladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoTrasladoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoTraslado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnModificar);
            this.tileNavPane1.Buttons.Add(this.mBtnSalir);
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
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(853, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // mBtnModificar
            // 
            this.mBtnModificar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnModificar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnModificar.Appearance.Options.UseFont = true;
            this.mBtnModificar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnModificar.AppearanceHovered.Options.UseFont = true;
            this.mBtnModificar.Caption = "Modificar";
            this.mBtnModificar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnModificar.Glyph")));
            this.mBtnModificar.Name = "mBtnModificar";
            this.mBtnModificar.Visible = false;
            this.mBtnModificar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnModificar_ElementClick);
            // 
            // mBtnSalir
            // 
            this.mBtnSalir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnSalir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnSalir.Appearance.Options.UseFont = true;
            this.mBtnSalir.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnSalir.AppearanceHovered.Options.UseFont = true;
            this.mBtnSalir.Caption = "Cancelar";
            this.mBtnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnSalir.Glyph")));
            this.mBtnSalir.Name = "mBtnSalir";
            this.mBtnSalir.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnSalir_ElementClick);
            // 
            // gbGridViewFuncionario
            // 
            this.gbGridViewFuncionario.Controls.Add(this.txtFechaTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.cmbBodegaDestino);
            this.gbGridViewFuncionario.Controls.Add(this.cmbBodegaOrigen);
            this.gbGridViewFuncionario.Controls.Add(this.lblIDBodegaDestino);
            this.gbGridViewFuncionario.Controls.Add(this.lblIDBodegaOrigen);
            this.gbGridViewFuncionario.Controls.Add(this.lblBodegaDestino);
            this.gbGridViewFuncionario.Controls.Add(this.cmbTipoTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.txtNumeroTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.lblNumeroTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.txtObservaciones);
            this.gbGridViewFuncionario.Controls.Add(this.lblTipoTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.lblUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.lblBodega);
            this.gbGridViewFuncionario.Controls.Add(this.txtUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblObservaciones);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(12, 46);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(832, 195);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Traslado de Producto";
            // 
            // txtFechaTraslado
            // 
            this.txtFechaTraslado.Enabled = false;
            this.txtFechaTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaTraslado.Location = new System.Drawing.Point(210, 122);
            this.txtFechaTraslado.Name = "txtFechaTraslado";
            this.txtFechaTraslado.Size = new System.Drawing.Size(176, 22);
            this.txtFechaTraslado.TabIndex = 4;
            // 
            // cmbBodegaDestino
            // 
            this.cmbBodegaDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBodegaDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBodegaDestino.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTRegistroBodegaAllBindingSource1, "idregistrobodega", true));
            this.cmbBodegaDestino.DataSource = this.spSELECTRegistroBodegaAllBindingSource1;
            this.cmbBodegaDestino.DisplayMember = "nombre";
            this.cmbBodegaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodegaDestino.FormattingEnabled = true;
            this.cmbBodegaDestino.Location = new System.Drawing.Point(210, 82);
            this.cmbBodegaDestino.Name = "cmbBodegaDestino";
            this.cmbBodegaDestino.Size = new System.Drawing.Size(176, 24);
            this.cmbBodegaDestino.TabIndex = 2;
            this.cmbBodegaDestino.ValueMember = "idregistrobodega";
            // 
            // spSELECTRegistroBodegaAllBindingSource1
            // 
            this.spSELECTRegistroBodegaAllBindingSource1.DataMember = "sp_SELECT_RegistroBodega_All";
            this.spSELECTRegistroBodegaAllBindingSource1.DataSource = this.dataSetTPRegistroBodegaD;
            // 
            // dataSetTPRegistroBodegaD
            // 
            this.dataSetTPRegistroBodegaD.DataSetName = "DataSetTPRegistroBodegaD";
            this.dataSetTPRegistroBodegaD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBodegaOrigen
            // 
            this.cmbBodegaOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTRegistroBodegaAllBindingSource, "idregistrobodega", true));
            this.cmbBodegaOrigen.DataSource = this.spSELECTRegistroBodegaAllBindingSource;
            this.cmbBodegaOrigen.DisplayMember = "nombre";
            this.cmbBodegaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodegaOrigen.FormattingEnabled = true;
            this.cmbBodegaOrigen.Location = new System.Drawing.Point(571, 41);
            this.cmbBodegaOrigen.Name = "cmbBodegaOrigen";
            this.cmbBodegaOrigen.Size = new System.Drawing.Size(176, 24);
            this.cmbBodegaOrigen.TabIndex = 1;
            this.cmbBodegaOrigen.ValueMember = "idregistrobodega";
            // 
            // spSELECTRegistroBodegaAllBindingSource
            // 
            this.spSELECTRegistroBodegaAllBindingSource.DataMember = "sp_SELECT_RegistroBodega_All";
            this.spSELECTRegistroBodegaAllBindingSource.DataSource = this.dataSetTPRegistroBodega;
            // 
            // dataSetTPRegistroBodega
            // 
            this.dataSetTPRegistroBodega.DataSetName = "DataSetTPRegistroBodega";
            this.dataSetTPRegistroBodega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIDBodegaDestino
            // 
            this.lblIDBodegaDestino.AutoSize = true;
            this.lblIDBodegaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBodegaDestino.ForeColor = System.Drawing.Color.White;
            this.lblIDBodegaDestino.Location = new System.Drawing.Point(898, 67);
            this.lblIDBodegaDestino.Name = "lblIDBodegaDestino";
            this.lblIDBodegaDestino.Size = new System.Drawing.Size(0, 18);
            this.lblIDBodegaDestino.TabIndex = 66;
            this.lblIDBodegaDestino.Visible = false;
            // 
            // lblIDBodegaOrigen
            // 
            this.lblIDBodegaOrigen.AutoSize = true;
            this.lblIDBodegaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBodegaOrigen.ForeColor = System.Drawing.Color.White;
            this.lblIDBodegaOrigen.Location = new System.Drawing.Point(580, 69);
            this.lblIDBodegaOrigen.Name = "lblIDBodegaOrigen";
            this.lblIDBodegaOrigen.Size = new System.Drawing.Size(0, 18);
            this.lblIDBodegaOrigen.TabIndex = 65;
            this.lblIDBodegaOrigen.Visible = false;
            // 
            // lblBodegaDestino
            // 
            this.lblBodegaDestino.AutoSize = true;
            this.lblBodegaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodegaDestino.ForeColor = System.Drawing.Color.White;
            this.lblBodegaDestino.Location = new System.Drawing.Point(54, 86);
            this.lblBodegaDestino.Name = "lblBodegaDestino";
            this.lblBodegaDestino.Size = new System.Drawing.Size(118, 18);
            this.lblBodegaDestino.TabIndex = 53;
            this.lblBodegaDestino.Text = "Bodega Destino:";
            // 
            // cmbTipoTraslado
            // 
            this.cmbTipoTraslado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoTraslado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoTraslado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoTrasladoBindingSource, "IDTipoTraslado", true));
            this.cmbTipoTraslado.DataSource = this.tipoTrasladoBindingSource;
            this.cmbTipoTraslado.DisplayMember = "Descripcion";
            this.cmbTipoTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTraslado.FormattingEnabled = true;
            this.cmbTipoTraslado.Location = new System.Drawing.Point(571, 117);
            this.cmbTipoTraslado.Name = "cmbTipoTraslado";
            this.cmbTipoTraslado.Size = new System.Drawing.Size(176, 24);
            this.cmbTipoTraslado.TabIndex = 5;
            this.cmbTipoTraslado.ValueMember = "IDTipoTraslado";
            // 
            // tipoTrasladoBindingSource
            // 
            this.tipoTrasladoBindingSource.DataMember = "TipoTraslado";
            this.tipoTrasladoBindingSource.DataSource = this.dataSetTipoTrasladoBindingSource;
            // 
            // dataSetTipoTrasladoBindingSource
            // 
            this.dataSetTipoTrasladoBindingSource.DataSource = this.dataSetTipoTraslado;
            this.dataSetTipoTrasladoBindingSource.Position = 0;
            // 
            // dataSetTipoTraslado
            // 
            this.dataSetTipoTraslado.DataSetName = "DataSetTipoTraslado";
            this.dataSetTipoTraslado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumeroTraslado
            // 
            this.txtNumeroTraslado.Enabled = false;
            this.txtNumeroTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTraslado.Location = new System.Drawing.Point(210, 46);
            this.txtNumeroTraslado.Name = "txtNumeroTraslado";
            this.txtNumeroTraslado.Size = new System.Drawing.Size(176, 22);
            this.txtNumeroTraslado.TabIndex = 0;
            // 
            // lblNumeroTraslado
            // 
            this.lblNumeroTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroTraslado.AutoSize = true;
            this.lblNumeroTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTraslado.ForeColor = System.Drawing.Color.White;
            this.lblNumeroTraslado.Location = new System.Drawing.Point(54, 47);
            this.lblNumeroTraslado.Name = "lblNumeroTraslado";
            this.lblNumeroTraslado.Size = new System.Drawing.Size(99, 18);
            this.lblNumeroTraslado.TabIndex = 47;
            this.lblNumeroTraslado.Text = "Nro.Traslado:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(210, 159);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(537, 22);
            this.txtObservaciones.TabIndex = 6;
            // 
            // lblTipoTraslado
            // 
            this.lblTipoTraslado.AutoSize = true;
            this.lblTipoTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTraslado.ForeColor = System.Drawing.Color.White;
            this.lblTipoTraslado.Location = new System.Drawing.Point(444, 123);
            this.lblTipoTraslado.Name = "lblTipoTraslado";
            this.lblTipoTraslado.Size = new System.Drawing.Size(123, 18);
            this.lblTipoTraslado.TabIndex = 39;
            this.lblTipoTraslado.Text = "Tipo de Traslado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(444, 86);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblFechaTraslado
            // 
            this.lblFechaTraslado.AutoSize = true;
            this.lblFechaTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTraslado.ForeColor = System.Drawing.Color.White;
            this.lblFechaTraslado.Location = new System.Drawing.Point(54, 126);
            this.lblFechaTraslado.Name = "lblFechaTraslado";
            this.lblFechaTraslado.Size = new System.Drawing.Size(115, 18);
            this.lblFechaTraslado.TabIndex = 23;
            this.lblFechaTraslado.Text = "Fecha Traslado:";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.White;
            this.lblBodega.Location = new System.Drawing.Point(444, 47);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(111, 18);
            this.lblBodega.TabIndex = 1;
            this.lblBodega.Text = "Bodega Origen:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(571, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 22);
            this.txtUsuario.TabIndex = 3;
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
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.White;
            this.lblObservaciones.Location = new System.Drawing.Point(54, 159);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(112, 18);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gCProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 204);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Productos";
            // 
            // gCProductos
            // 
            this.gCProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCProductos.Location = new System.Drawing.Point(9, 40);
            this.gCProductos.MainView = this.gridView2;
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.Size = new System.Drawing.Size(820, 158);
            this.gCProductos.TabIndex = 0;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnaID,
            this.columnaCodigoAvatar,
            this.columnaProducto,
            this.columnaUnidades,
            this.columnaUnidadMedida});
            this.gridView2.GridControl = this.gCProductos;
            this.gridView2.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 900;
            // 
            // columnaID
            // 
            this.columnaID.Caption = "gridColumn1";
            this.columnaID.FieldName = "Producto.idProducto";
            this.columnaID.Name = "columnaID";
            // 
            // columnaCodigoAvatar
            // 
            this.columnaCodigoAvatar.Caption = "Codigo Avatar";
            this.columnaCodigoAvatar.FieldName = "codigoAvatar";
            this.columnaCodigoAvatar.Name = "columnaCodigoAvatar";
            this.columnaCodigoAvatar.Visible = true;
            this.columnaCodigoAvatar.VisibleIndex = 0;
            // 
            // columnaProducto
            // 
            this.columnaProducto.Caption = "Producto";
            this.columnaProducto.FieldName = "nombreProducto";
            this.columnaProducto.Name = "columnaProducto";
            this.columnaProducto.Visible = true;
            this.columnaProducto.VisibleIndex = 1;
            // 
            // columnaUnidades
            // 
            this.columnaUnidades.Caption = "Unidades";
            this.columnaUnidades.FieldName = "unidades";
            this.columnaUnidades.Name = "columnaUnidades";
            this.columnaUnidades.Visible = true;
            this.columnaUnidades.VisibleIndex = 2;
            // 
            // columnaUnidadMedida
            // 
            this.columnaUnidadMedida.Caption = "Unidad de Medida";
            this.columnaUnidadMedida.FieldName = "nombreUnidadMedida";
            this.columnaUnidadMedida.Name = "columnaUnidadMedida";
            this.columnaUnidadMedida.Visible = true;
            this.columnaUnidadMedida.VisibleIndex = 3;
            // 
            // tipoTrasladoTableAdapter
            // 
            this.tipoTrasladoTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SELECT_RegistroBodega_AllTableAdapter
            // 
            this.sp_SELECT_RegistroBodega_AllTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SELECT_RegistroBodega_AllTableAdapter1
            // 
            this.sp_SELECT_RegistroBodega_AllTableAdapter1.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmModTrasladoProductos
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(869, 520);
            this.MinimumSize = new System.Drawing.Size(869, 520);
            this.Name = "frmModTrasladoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traslado De Producto";
            this.Load += new System.EventHandler(this.frmAdTrasladoProductos_Load);
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTPRegistroBodegaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTPRegistroBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTrasladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoTrasladoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoTraslado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblTipoTraslado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaTraslado;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtNumeroTraslado;
        private System.Windows.Forms.Label lblNumeroTraslado;
        private System.Windows.Forms.ComboBox cmbTipoTraslado;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label lblBodegaDestino;
        private System.Windows.Forms.BindingSource dataSetTipoTrasladoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetTipoTraslado dataSetTipoTraslado;
        private System.Windows.Forms.BindingSource tipoTrasladoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetTipoTrasladoTableAdapters.TipoTrasladoTableAdapter tipoTrasladoTableAdapter;
        private System.Windows.Forms.Label lblIDBodegaDestino;
        private System.Windows.Forms.Label lblIDBodegaOrigen;
        private System.Windows.Forms.ComboBox cmbBodegaDestino;
        private System.Windows.Forms.ComboBox cmbBodegaOrigen;
        private DataSets.Bodega.Procesos.DataSetTPRegistroBodega dataSetTPRegistroBodega;
        private System.Windows.Forms.BindingSource spSELECTRegistroBodegaAllBindingSource;
        private DataSets.Bodega.Procesos.DataSetTPRegistroBodegaTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter sp_SELECT_RegistroBodega_AllTableAdapter;
        private DataSets.Bodega.Procesos.DataSetTPRegistroBodegaD dataSetTPRegistroBodegaD;
        private System.Windows.Forms.BindingSource spSELECTRegistroBodegaAllBindingSource1;
        private DataSets.Bodega.Procesos.DataSetTPRegistroBodegaDTableAdapters.sp_SELECT_RegistroBodega_AllTableAdapter sp_SELECT_RegistroBodega_AllTableAdapter1;
        private System.Windows.Forms.TextBox txtFechaTraslado;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private DevExpress.XtraGrid.Columns.GridColumn columnaID;
        private DevExpress.XtraGrid.Columns.GridColumn columnaProducto;
        private DevExpress.XtraGrid.Columns.GridColumn columnaUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn columnaUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn columnaCodigoAvatar;
    }
}
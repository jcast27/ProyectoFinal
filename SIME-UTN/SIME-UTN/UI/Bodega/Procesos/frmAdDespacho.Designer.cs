namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmAdDespacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdDespacho));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAceptar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.nudCantidadMez = new System.Windows.Forms.NumericUpDown();
            this.lblComponentes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMezcla = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRMezclasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRMezclas = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetRMezclas();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.gcDespacho = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnaCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFuncionario = new SIME_UTN.DataSets.Formulario.DataSetFuncionario();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.txtRemover = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gcProducto = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContenido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionarioTableAdapter = new SIME_UTN.DataSets.Formulario.DataSetFuncionarioTableAdapters.FuncionarioTableAdapter();
            this.productoTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetRMezclasTableAdapters.ProductoTableAdapter();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRMezclasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRMezclas)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnNuevo);
            this.tileNavPane1.Buttons.Add(this.mBtnAceptar);
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
            this.tileNavPane1.Size = new System.Drawing.Size(806, 40);
            this.tileNavPane1.TabIndex = 35;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // mBtnNuevo
            // 
            this.mBtnNuevo.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnNuevo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnNuevo.Appearance.Options.UseFont = true;
            this.mBtnNuevo.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnNuevo.AppearanceHovered.Options.UseFont = true;
            this.mBtnNuevo.Caption = "Nuevo";
            this.mBtnNuevo.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnNuevo.Glyph")));
            this.mBtnNuevo.Name = "mBtnNuevo";
            this.mBtnNuevo.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnNuevo_ElementClick);
            // 
            // mBtnAceptar
            // 
            this.mBtnAceptar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAceptar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnAceptar.Appearance.Options.UseFont = true;
            this.mBtnAceptar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnAceptar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAceptar.Caption = "Registrar";
            this.mBtnAceptar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAceptar.Glyph")));
            this.mBtnAceptar.Name = "mBtnAceptar";
            this.mBtnAceptar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAceptar_ElementClick);
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
            this.gbGridViewFuncionario.Controls.Add(this.nudCantidadMez);
            this.gbGridViewFuncionario.Controls.Add(this.lblComponentes);
            this.gbGridViewFuncionario.Controls.Add(this.label6);
            this.gbGridViewFuncionario.Controls.Add(this.btnGenerar);
            this.gbGridViewFuncionario.Controls.Add(this.label4);
            this.gbGridViewFuncionario.Controls.Add(this.cmbMezcla);
            this.gbGridViewFuncionario.Controls.Add(this.label2);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoUsuario);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(9, 499);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(785, 68);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Mezclas";
            // 
            // nudCantidadMez
            // 
            this.nudCantidadMez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudCantidadMez.Location = new System.Drawing.Point(415, 32);
            this.nudCantidadMez.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadMez.Name = "nudCantidadMez";
            this.nudCantidadMez.Size = new System.Drawing.Size(104, 24);
            this.nudCantidadMez.TabIndex = 37;
            // 
            // lblComponentes
            // 
            this.lblComponentes.AutoSize = true;
            this.lblComponentes.BackColor = System.Drawing.Color.White;
            this.lblComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblComponentes.ForeColor = System.Drawing.Color.Black;
            this.lblComponentes.Location = new System.Drawing.Point(321, 33);
            this.lblComponentes.Name = "lblComponentes";
            this.lblComponentes.Size = new System.Drawing.Size(16, 18);
            this.lblComponentes.TabIndex = 36;
            this.lblComponentes.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(211, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Componentes:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnGenerar.ForeColor = System.Drawing.Color.Black;
            this.btnGenerar.Location = new System.Drawing.Point(525, 30);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(85, 26);
            this.btnGenerar.TabIndex = 34;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(343, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cantidad:";
            // 
            // cmbMezcla
            // 
            this.cmbMezcla.DataSource = this.productoBindingSource;
            this.cmbMezcla.DisplayMember = "nombre";
            this.cmbMezcla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMezcla.FormattingEnabled = true;
            this.cmbMezcla.Location = new System.Drawing.Point(84, 32);
            this.cmbMezcla.Name = "cmbMezcla";
            this.cmbMezcla.Size = new System.Drawing.Size(121, 24);
            this.cmbMezcla.TabIndex = 31;
            this.cmbMezcla.ValueMember = "idregistromezcla";
            this.cmbMezcla.SelectedIndexChanged += new System.EventHandler(this.cmbMezcla_SelectedIndexChanged);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dataSetRMezclasBindingSource;
            // 
            // dataSetRMezclasBindingSource
            // 
            this.dataSetRMezclasBindingSource.DataSource = this.dataSetRMezclas;
            this.dataSetRMezclasBindingSource.Position = 0;
            // 
            // dataSetRMezclas
            // 
            this.dataSetRMezclas.DataSetName = "DataSetRMezclas";
            this.dataSetRMezclas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mezcla:";
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
            // gbGridViewRegistroProductos
            // 
            this.gbGridViewRegistroProductos.Controls.Add(this.label5);
            this.gbGridViewRegistroProductos.Controls.Add(this.txtObservaciones);
            this.gbGridViewRegistroProductos.Controls.Add(this.gcDespacho);
            this.gbGridViewRegistroProductos.Controls.Add(this.cmbFuncionario);
            this.gbGridViewRegistroProductos.Controls.Add(this.label3);
            this.gbGridViewRegistroProductos.Controls.Add(this.txtCantidadProd);
            this.gbGridViewRegistroProductos.Controls.Add(this.txtRemover);
            this.gbGridViewRegistroProductos.Controls.Add(this.btnAgregar);
            this.gbGridViewRegistroProductos.Controls.Add(this.gcProducto);
            this.gbGridViewRegistroProductos.Controls.Add(this.txtBuscar);
            this.gbGridViewRegistroProductos.Controls.Add(this.label1);
            this.gbGridViewRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewRegistroProductos.ForeColor = System.Drawing.Color.White;
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(9, 46);
            this.gbGridViewRegistroProductos.Name = "gbGridViewRegistroProductos";
            this.gbGridViewRegistroProductos.Size = new System.Drawing.Size(785, 454);
            this.gbGridViewRegistroProductos.TabIndex = 37;
            this.gbGridViewRegistroProductos.TabStop = false;
            this.gbGridViewRegistroProductos.Text = "Despacho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(18, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtObservaciones.Location = new System.Drawing.Point(21, 389);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(743, 48);
            this.txtObservaciones.TabIndex = 11;
            // 
            // gcDespacho
            // 
            this.gcDespacho.Location = new System.Drawing.Point(441, 69);
            this.gcDespacho.MainView = this.gridView2;
            this.gcDespacho.Name = "gcDespacho";
            this.gcDespacho.Size = new System.Drawing.Size(323, 288);
            this.gcDespacho.TabIndex = 10;
            this.gcDespacho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnaID,
            this.columnaProducto,
            this.columnaCantidad});
            this.gridView2.GridControl = this.gcDespacho;
            this.gridView2.Name = "gridView2";
            // 
            // columnaID
            // 
            this.columnaID.Caption = "ID";
            this.columnaID.FieldName = "Producto.idProducto";
            this.columnaID.Name = "columnaID";
            this.columnaID.OptionsColumn.AllowEdit = false;
            // 
            // columnaProducto
            // 
            this.columnaProducto.Caption = "Producto";
            this.columnaProducto.FieldName = "Producto.nombreProducto";
            this.columnaProducto.Name = "columnaProducto";
            this.columnaProducto.OptionsColumn.AllowEdit = false;
            this.columnaProducto.Visible = true;
            this.columnaProducto.VisibleIndex = 0;
            this.columnaProducto.Width = 101;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.Caption = "Unidades";
            this.columnaCantidad.FieldName = "unidades";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.OptionsColumn.AllowEdit = false;
            this.columnaCantidad.Visible = true;
            this.columnaCantidad.VisibleIndex = 1;
            this.columnaCantidad.Width = 101;
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DataSource = this.funcionarioBindingSource;
            this.cmbFuncionario.DisplayMember = "Nombre";
            this.cmbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(593, 33);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(171, 24);
            this.cmbFuncionario.TabIndex = 9;
            this.cmbFuncionario.ValueMember = "IDFuncionario";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.dataSetFuncionarioBindingSource;
            // 
            // dataSetFuncionarioBindingSource
            // 
            this.dataSetFuncionarioBindingSource.DataSource = this.dataSetFuncionario;
            this.dataSetFuncionarioBindingSource.Position = 0;
            // 
            // dataSetFuncionario
            // 
            this.dataSetFuncionario.DataSetName = "DataSetFuncionario";
            this.dataSetFuncionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(497, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Funcionario:";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCantidadProd.Location = new System.Drawing.Point(370, 188);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(50, 24);
            this.txtCantidadProd.TabIndex = 6;
            this.txtCantidadProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadProd_KeyUp);
            // 
            // txtRemover
            // 
            this.txtRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRemover.ForeColor = System.Drawing.Color.Black;
            this.txtRemover.Location = new System.Drawing.Point(370, 218);
            this.txtRemover.Name = "txtRemover";
            this.txtRemover.Size = new System.Drawing.Size(50, 28);
            this.txtRemover.TabIndex = 4;
            this.txtRemover.Text = "<";
            this.txtRemover.UseVisualStyleBackColor = true;
            this.txtRemover.Click += new System.EventHandler(this.txtRemover_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(370, 153);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gcProducto
            // 
            this.gcProducto.Location = new System.Drawing.Point(21, 69);
            this.gcProducto.MainView = this.gridView1;
            this.gcProducto.Name = "gcProducto";
            this.gcProducto.Size = new System.Drawing.Size(323, 288);
            this.gcProducto.TabIndex = 2;
            this.gcProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProducto,
            this.colContenido});
            this.gridView1.GridControl = this.gcProducto;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "Producto.idProducto";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Producto.nombreProducto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            this.colProducto.Width = 101;
            // 
            // colContenido
            // 
            this.colContenido.Caption = "Unidades";
            this.colContenido.FieldName = "unidades";
            this.colContenido.Name = "colContenido";
            this.colContenido.OptionsColumn.AllowEdit = false;
            this.colContenido.Visible = true;
            this.colContenido.VisibleIndex = 1;
            this.colContenido.Width = 101;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBuscar.Location = new System.Drawing.Point(99, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(147, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda:";
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // frmAdDespacho
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 579);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "frmAdDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despacho De Producto";
            this.Load += new System.EventHandler(this.frmAdDespachoProductos_Load);
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRMezclasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRMezclas)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            this.gbGridViewRegistroProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAceptar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Button txtRemover;
        private System.Windows.Forms.Button btnAgregar;
        private DevExpress.XtraGrid.GridControl gcProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMezcla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dataSetFuncionarioBindingSource;
        private DataSets.Formulario.DataSetFuncionario dataSetFuncionario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DataSets.Formulario.DataSetFuncionarioTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colContenido;
        private DevExpress.XtraGrid.GridControl gcDespacho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn columnaID;
        private DevExpress.XtraGrid.Columns.GridColumn columnaProducto;
        private DevExpress.XtraGrid.Columns.GridColumn columnaCantidad;
        private System.Windows.Forms.BindingSource dataSetRMezclasBindingSource;
        private DataSets.Bodega.Admistracion.DataSetRMezclas dataSetRMezclas;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataSets.Bodega.Admistracion.DataSetRMezclasTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblComponentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown nudCantidadMez;
    }
}
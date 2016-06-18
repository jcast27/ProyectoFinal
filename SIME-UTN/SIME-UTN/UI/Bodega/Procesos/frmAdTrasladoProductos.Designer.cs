namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmAdTrasladoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdTrasladoProductos));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAceptar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtECodigoProducto = new DevExpress.XtraEditors.ButtonEdit();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbBodegaDestino = new System.Windows.Forms.ComboBox();
            this.lblBodegaDestino = new System.Windows.Forms.Label();
            this.cmbBodegaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbTipoTraslado = new System.Windows.Forms.ComboBox();
            this.txtNumeroDespacho = new System.Windows.Forms.TextBox();
            this.lblNumeroTraslado = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipoTraslado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dateFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaTraslado = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.gCBodega = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnNuevo);
            this.tileNavPane1.Buttons.Add(this.mBtnAgregar);
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
            this.tileNavPane1.Size = new System.Drawing.Size(1136, 40);
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
            // 
            // mBtnAgregar
            // 
            this.mBtnAgregar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnAgregar.Appearance.Options.UseFont = true;
            this.mBtnAgregar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnAgregar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAgregar.Caption = "Agregar";
            this.mBtnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAgregar.Glyph")));
            this.mBtnAgregar.Name = "mBtnAgregar";
            this.mBtnAgregar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAgregar_ElementClick);
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
            // 
            // gbGridViewFuncionario
            // 
            this.gbGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbGridViewFuncionario.Controls.Add(this.txtCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigo);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombreProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtECodigoProducto);
            this.gbGridViewFuncionario.Controls.Add(this.lblProducto);
            this.gbGridViewFuncionario.Controls.Add(this.cmbBodegaDestino);
            this.gbGridViewFuncionario.Controls.Add(this.lblBodegaDestino);
            this.gbGridViewFuncionario.Controls.Add(this.cmbBodegaOrigen);
            this.gbGridViewFuncionario.Controls.Add(this.cmbTipoTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.txtNumeroDespacho);
            this.gbGridViewFuncionario.Controls.Add(this.lblNumeroTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.txtDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.lblTipoTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.lblUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.dateFechaIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaTraslado);
            this.gbGridViewFuncionario.Controls.Add(this.lblBodega);
            this.gbGridViewFuncionario.Controls.Add(this.txtUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblObservaciones);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(12, 57);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(1124, 293);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Traslado de Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(911, 253);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 22);
            this.txtCantidad.TabIndex = 60;
            this.txtCantidad.Text = "42";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(775, 257);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 18);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(414, 254);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 58;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(209, 250);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(176, 22);
            this.txtNombreProducto.TabIndex = 57;
            // 
            // txtECodigoProducto
            // 
            this.txtECodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtECodigoProducto.Location = new System.Drawing.Point(570, 255);
            this.txtECodigoProducto.Name = "txtECodigoProducto";
            this.txtECodigoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtECodigoProducto.Size = new System.Drawing.Size(167, 20);
            this.txtECodigoProducto.TabIndex = 56;
            this.txtECodigoProducto.Click += new System.EventHandler(this.txtECodigoProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(24, 251);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(154, 18);
            this.lblProducto.TabIndex = 55;
            this.lblProducto.Text = "Nombre del Producto:";
            // 
            // cmbBodegaDestino
            // 
            this.cmbBodegaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBodegaDestino.DisplayMember = "Descripcion";
            this.cmbBodegaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodegaDestino.FormattingEnabled = true;
            this.cmbBodegaDestino.Location = new System.Drawing.Point(911, 63);
            this.cmbBodegaDestino.Name = "cmbBodegaDestino";
            this.cmbBodegaDestino.Size = new System.Drawing.Size(167, 24);
            this.cmbBodegaDestino.TabIndex = 54;
            this.cmbBodegaDestino.ValueMember = "IDCategoria";
            // 
            // lblBodegaDestino
            // 
            this.lblBodegaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodegaDestino.AutoSize = true;
            this.lblBodegaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodegaDestino.ForeColor = System.Drawing.Color.White;
            this.lblBodegaDestino.Location = new System.Drawing.Point(775, 67);
            this.lblBodegaDestino.Name = "lblBodegaDestino";
            this.lblBodegaDestino.Size = new System.Drawing.Size(118, 18);
            this.lblBodegaDestino.TabIndex = 53;
            this.lblBodegaDestino.Text = "Bodega Destino:";
            // 
            // cmbBodegaOrigen
            // 
            this.cmbBodegaOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBodegaOrigen.DisplayMember = "Descripcion";
            this.cmbBodegaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodegaOrigen.FormattingEnabled = true;
            this.cmbBodegaOrigen.Location = new System.Drawing.Point(570, 61);
            this.cmbBodegaOrigen.Name = "cmbBodegaOrigen";
            this.cmbBodegaOrigen.Size = new System.Drawing.Size(167, 24);
            this.cmbBodegaOrigen.TabIndex = 52;
            this.cmbBodegaOrigen.ValueMember = "IDCategoria";
            // 
            // cmbTipoTraslado
            // 
            this.cmbTipoTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoTraslado.DisplayMember = "Descripcion";
            this.cmbTipoTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoTraslado.FormattingEnabled = true;
            this.cmbTipoTraslado.Location = new System.Drawing.Point(911, 128);
            this.cmbTipoTraslado.Name = "cmbTipoTraslado";
            this.cmbTipoTraslado.Size = new System.Drawing.Size(167, 24);
            this.cmbTipoTraslado.TabIndex = 49;
            this.cmbTipoTraslado.ValueMember = "IDCategoria";
            // 
            // txtNumeroDespacho
            // 
            this.txtNumeroDespacho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNumeroDespacho.Enabled = false;
            this.txtNumeroDespacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDespacho.Location = new System.Drawing.Point(209, 63);
            this.txtNumeroDespacho.Name = "txtNumeroDespacho";
            this.txtNumeroDespacho.Size = new System.Drawing.Size(176, 22);
            this.txtNumeroDespacho.TabIndex = 48;
            this.txtNumeroDespacho.Text = "12212313";
            // 
            // lblNumeroTraslado
            // 
            this.lblNumeroTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroTraslado.AutoSize = true;
            this.lblNumeroTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTraslado.ForeColor = System.Drawing.Color.White;
            this.lblNumeroTraslado.Location = new System.Drawing.Point(24, 67);
            this.lblNumeroTraslado.Name = "lblNumeroTraslado";
            this.lblNumeroTraslado.Size = new System.Drawing.Size(99, 18);
            this.lblNumeroTraslado.TabIndex = 47;
            this.lblNumeroTraslado.Text = "Nro.Traslado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(209, 188);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(869, 22);
            this.txtDescripcion.TabIndex = 42;
            // 
            // lblTipoTraslado
            // 
            this.lblTipoTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoTraslado.AutoSize = true;
            this.lblTipoTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTraslado.ForeColor = System.Drawing.Color.White;
            this.lblTipoTraslado.Location = new System.Drawing.Point(775, 134);
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
            this.lblUsuario.Location = new System.Drawing.Point(24, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateFechaIngreso.EditValue = null;
            this.dateFechaIngreso.Location = new System.Drawing.Point(570, 130);
            this.dateFechaIngreso.MaximumSize = new System.Drawing.Size(200, 22);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaIngreso.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateFechaIngreso.Properties.DisplayFormat.FormatString = "";
            this.dateFechaIngreso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFechaIngreso.Properties.EditFormat.FormatString = "";
            this.dateFechaIngreso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFechaIngreso.Properties.Mask.EditMask = "";
            this.dateFechaIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateFechaIngreso.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateFechaIngreso.Size = new System.Drawing.Size(167, 20);
            this.dateFechaIngreso.TabIndex = 34;
            // 
            // lblFechaTraslado
            // 
            this.lblFechaTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaTraslado.AutoSize = true;
            this.lblFechaTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTraslado.ForeColor = System.Drawing.Color.White;
            this.lblFechaTraslado.Location = new System.Drawing.Point(414, 133);
            this.lblFechaTraslado.Name = "lblFechaTraslado";
            this.lblFechaTraslado.Size = new System.Drawing.Size(115, 18);
            this.lblFechaTraslado.TabIndex = 23;
            this.lblFechaTraslado.Text = "Fecha Traslado:";
            // 
            // lblBodega
            // 
            this.lblBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.White;
            this.lblBodega.Location = new System.Drawing.Point(414, 67);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(111, 18);
            this.lblBodega.TabIndex = 1;
            this.lblBodega.Text = "Bodega Origen:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(209, 133);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 22);
            this.txtUsuario.TabIndex = 27;
            this.txtUsuario.Text = "jcastro";
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
            this.lblObservaciones.Location = new System.Drawing.Point(24, 188);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(112, 18);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // gbGridViewRegistroProductos
            // 
            this.gbGridViewRegistroProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewRegistroProductos.Controls.Add(this.gCBodega);
            this.gbGridViewRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewRegistroProductos.ForeColor = System.Drawing.Color.White;
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(1, 377);
            this.gbGridViewRegistroProductos.Name = "gbGridViewRegistroProductos";
            this.gbGridViewRegistroProductos.Size = new System.Drawing.Size(552, 255);
            this.gbGridViewRegistroProductos.TabIndex = 37;
            this.gbGridViewRegistroProductos.TabStop = false;
            this.gbGridViewRegistroProductos.Text = "Detalle De Bodega Origen";
            // 
            // gCBodega
            // 
            this.gCBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCBodega.Location = new System.Drawing.Point(6, 46);
            this.gCBodega.MainView = this.gridView1;
            this.gCBodega.Name = "gCBodega";
            this.gCBodega.Size = new System.Drawing.Size(534, 209);
            this.gCBodega.TabIndex = 0;
            this.gCBodega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gCBodega;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gCProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(559, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 255);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Productos";
            // 
            // gCProductos
            // 
            this.gCProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCProductos.Location = new System.Drawing.Point(6, 46);
            this.gCProductos.MainView = this.gridView2;
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.Size = new System.Drawing.Size(534, 209);
            this.gCProductos.TabIndex = 0;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
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
            // frmAdTrasladoProductos
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(1152, 675);
            this.Name = "frmAdTrasladoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traslado De Producto";
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAceptar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTipoTraslado;
        private System.Windows.Forms.Label lblUsuario;
        private DevExpress.XtraEditors.DateEdit dateFechaIngreso;
        private System.Windows.Forms.Label lblFechaTraslado;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtNumeroDespacho;
        private System.Windows.Forms.Label lblNumeroTraslado;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private DevExpress.XtraGrid.GridControl gCBodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.ComboBox cmbTipoTraslado;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox cmbBodegaDestino;
        private System.Windows.Forms.Label lblBodegaDestino;
        private System.Windows.Forms.ComboBox cmbBodegaOrigen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private DevExpress.XtraEditors.ButtonEdit txtECodigoProducto;
        private System.Windows.Forms.Label lblProducto;
    }
}
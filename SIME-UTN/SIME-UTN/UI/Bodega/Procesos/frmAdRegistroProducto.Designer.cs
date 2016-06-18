namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmAdRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdRegistroProducto));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAceptar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.txtNumeroIngreso = new System.Windows.Forms.TextBox();
            this.lblNumeroIngreso = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadXEmpaque = new System.Windows.Forms.TextBox();
            this.txtECodigoProducto = new DevExpress.XtraEditors.ButtonEdit();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dateFechaCaducidad = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.lblCantidadXEmpaque = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dateFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblSolicitudAvatar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtSolicitudAvatar = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.gCRegistroProducto = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCRegistroProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gbGridViewFuncionario.Controls.Add(this.txtNumeroIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblNumeroIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigo);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombreProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtCantidadXEmpaque);
            this.gbGridViewFuncionario.Controls.Add(this.txtECodigoProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.txtCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.dateFechaCaducidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaCaducidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblCantidadXEmpaque);
            this.gbGridViewFuncionario.Controls.Add(this.lblCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.dateFechaIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblSolicitudAvatar);
            this.gbGridViewFuncionario.Controls.Add(this.txtUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.txtSolicitudAvatar);
            this.gbGridViewFuncionario.Controls.Add(this.lblProducto);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(12, 57);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(1124, 293);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Regristro de Producto";
            // 
            // txtNumeroIngreso
            // 
            this.txtNumeroIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNumeroIngreso.Enabled = false;
            this.txtNumeroIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIngreso.Location = new System.Drawing.Point(209, 63);
            this.txtNumeroIngreso.Name = "txtNumeroIngreso";
            this.txtNumeroIngreso.Size = new System.Drawing.Size(176, 22);
            this.txtNumeroIngreso.TabIndex = 48;
            this.txtNumeroIngreso.Text = "12212313";
            // 
            // lblNumeroIngreso
            // 
            this.lblNumeroIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroIngreso.AutoSize = true;
            this.lblNumeroIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIngreso.ForeColor = System.Drawing.Color.White;
            this.lblNumeroIngreso.Location = new System.Drawing.Point(24, 67);
            this.lblNumeroIngreso.Name = "lblNumeroIngreso";
            this.lblNumeroIngreso.Size = new System.Drawing.Size(90, 18);
            this.lblNumeroIngreso.TabIndex = 47;
            this.lblNumeroIngreso.Text = "Nro.Ingreso:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(827, 260);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(618, 256);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(167, 22);
            this.txtNombreProducto.TabIndex = 45;
            // 
            // txtCantidadXEmpaque
            // 
            this.txtCantidadXEmpaque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCantidadXEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadXEmpaque.Location = new System.Drawing.Point(209, 253);
            this.txtCantidadXEmpaque.Name = "txtCantidadXEmpaque";
            this.txtCantidadXEmpaque.Size = new System.Drawing.Size(176, 22);
            this.txtCantidadXEmpaque.TabIndex = 43;
            // 
            // txtECodigoProducto
            // 
            this.txtECodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtECodigoProducto.Location = new System.Drawing.Point(911, 261);
            this.txtECodigoProducto.Name = "txtECodigoProducto";
            this.txtECodigoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtECodigoProducto.Size = new System.Drawing.Size(138, 20);
            this.txtECodigoProducto.TabIndex = 44;
            this.txtECodigoProducto.Click += new System.EventHandler(this.txtECodigoProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(209, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(840, 22);
            this.txtDescripcion.TabIndex = 42;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(911, 187);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 22);
            this.txtCantidad.TabIndex = 41;
            // 
            // dateFechaCaducidad
            // 
            this.dateFechaCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateFechaCaducidad.EditValue = null;
            this.dateFechaCaducidad.Location = new System.Drawing.Point(618, 184);
            this.dateFechaCaducidad.MaximumSize = new System.Drawing.Size(200, 22);
            this.dateFechaCaducidad.Name = "dateFechaCaducidad";
            this.dateFechaCaducidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCaducidad.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCaducidad.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateFechaCaducidad.Properties.DisplayFormat.FormatString = "";
            this.dateFechaCaducidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFechaCaducidad.Properties.EditFormat.FormatString = "";
            this.dateFechaCaducidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFechaCaducidad.Properties.Mask.EditMask = "";
            this.dateFechaCaducidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateFechaCaducidad.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateFechaCaducidad.Size = new System.Drawing.Size(167, 20);
            this.dateFechaCaducidad.TabIndex = 40;
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.ForeColor = System.Drawing.Color.White;
            this.lblFechaCaducidad.Location = new System.Drawing.Point(414, 183);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(150, 18);
            this.lblFechaCaducidad.TabIndex = 39;
            this.lblFechaCaducidad.Text = "Fecha De Caducidad:";
            // 
            // lblCantidadXEmpaque
            // 
            this.lblCantidadXEmpaque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadXEmpaque.AutoSize = true;
            this.lblCantidadXEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadXEmpaque.ForeColor = System.Drawing.Color.White;
            this.lblCantidadXEmpaque.Location = new System.Drawing.Point(24, 257);
            this.lblCantidadXEmpaque.Name = "lblCantidadXEmpaque";
            this.lblCantidadXEmpaque.Size = new System.Drawing.Size(165, 18);
            this.lblCantidadXEmpaque.TabIndex = 37;
            this.lblCantidadXEmpaque.Text = "Cantidad Por Empaque:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(827, 187);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 18);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(827, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateFechaIngreso.EditValue = null;
            this.dateFechaIngreso.Location = new System.Drawing.Point(209, 179);
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
            this.dateFechaIngreso.Size = new System.Drawing.Size(176, 20);
            this.dateFechaIngreso.TabIndex = 34;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(24, 181);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(115, 18);
            this.lblFechaIngreso.TabIndex = 23;
            this.lblFechaIngreso.Text = "Fecha Recibido:";
            // 
            // lblSolicitudAvatar
            // 
            this.lblSolicitudAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolicitudAvatar.AutoSize = true;
            this.lblSolicitudAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudAvatar.ForeColor = System.Drawing.Color.White;
            this.lblSolicitudAvatar.Location = new System.Drawing.Point(414, 67);
            this.lblSolicitudAvatar.Name = "lblSolicitudAvatar";
            this.lblSolicitudAvatar.Size = new System.Drawing.Size(191, 18);
            this.lblSolicitudAvatar.TabIndex = 1;
            this.lblSolicitudAvatar.Text = "Solicitud de Compra Avatar:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(911, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 22);
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
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 127);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtSolicitudAvatar
            // 
            this.txtSolicitudAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSolicitudAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitudAvatar.Location = new System.Drawing.Point(618, 63);
            this.txtSolicitudAvatar.Name = "txtSolicitudAvatar";
            this.txtSolicitudAvatar.Size = new System.Drawing.Size(167, 22);
            this.txtSolicitudAvatar.TabIndex = 3;
            this.txtSolicitudAvatar.Text = "AD234";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(414, 257);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(154, 18);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Nombre del Producto:";
            // 
            // gbGridViewRegistroProductos
            // 
            this.gbGridViewRegistroProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewRegistroProductos.Controls.Add(this.gCRegistroProducto);
            this.gbGridViewRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewRegistroProductos.ForeColor = System.Drawing.Color.White;
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(1, 377);
            this.gbGridViewRegistroProductos.Name = "gbGridViewRegistroProductos";
            this.gbGridViewRegistroProductos.Size = new System.Drawing.Size(1135, 255);
            this.gbGridViewRegistroProductos.TabIndex = 37;
            this.gbGridViewRegistroProductos.TabStop = false;
            this.gbGridViewRegistroProductos.Text = "Detalle de Productos";
            // 
            // gCRegistroProducto
            // 
            this.gCRegistroProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCRegistroProducto.Location = new System.Drawing.Point(6, 46);
            this.gCRegistroProducto.MainView = this.gridView1;
            this.gCRegistroProducto.Name = "gCRegistroProducto";
            this.gCRegistroProducto.Size = new System.Drawing.Size(1117, 209);
            this.gCRegistroProducto.TabIndex = 0;
            this.gCRegistroProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gCRegistroProducto;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            // 
            // frmAdRegistroProducto
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 636);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(1152, 675);
            this.Name = "frmAdRegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regristro De Producto";
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaIngreso.Properties)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCRegistroProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAceptar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidadXEmpaque;
        private DevExpress.XtraEditors.ButtonEdit txtECodigoProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private DevExpress.XtraEditors.DateEdit dateFechaCaducidad;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.Label lblCantidadXEmpaque;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUsuario;
        private DevExpress.XtraEditors.DateEdit dateFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblSolicitudAvatar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtSolicitudAvatar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNumeroIngreso;
        private System.Windows.Forms.Label lblNumeroIngreso;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private DevExpress.XtraGrid.GridControl gCRegistroProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
    }
}
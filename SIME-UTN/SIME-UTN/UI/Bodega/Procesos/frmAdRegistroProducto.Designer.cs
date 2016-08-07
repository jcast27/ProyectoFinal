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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdRegistroProducto));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnAceptar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.txtFechaRecibido = new System.Windows.Forms.TextBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.spSELECTRegistroBodegaLessVirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBodegas = new SIME_UTN.DataSets.Bodega.Procesos.DataSetBodegas();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.dateFechaCaducidad = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadXEmpaque = new System.Windows.Forms.TextBox();
            this.txtECodigoProducto = new DevExpress.XtraEditors.ButtonEdit();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantidadXEmpaque = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblSolicitudAvatar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIdRegProd = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtSolicitudAvatar = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.gCRegistroProducto = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sp_SELECT_RegistroBodega_LessVirtualTableAdapter = new SIME_UTN.DataSets.Bodega.Procesos.DataSetBodegasTableAdapters.sp_SELECT_RegistroBodega_LessVirtualTableAdapter();
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaLessVirtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).BeginInit();
            this.gbGridViewRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCRegistroProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnNuevo);
            this.tileNavPane1.Buttons.Add(this.mBtnAgregar);
            this.tileNavPane1.Buttons.Add(this.mBtnModificar);
            this.tileNavPane1.Buttons.Add(this.mBtnAceptar);
            this.tileNavPane1.Buttons.Add(this.mBtnEliminar);
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
            this.mBtnNuevo.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnNuevo_ElementClick);
            // 
            // mBtnAgregar
            // 
            this.mBtnAgregar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnAgregar.Appearance.Options.UseFont = true;
            this.mBtnAgregar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnAgregar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAgregar.Caption = "Agregar Registro";
            this.mBtnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAgregar.Glyph")));
            this.mBtnAgregar.Name = "mBtnAgregar";
            this.mBtnAgregar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAgregar_ElementClick);
            // 
            // mBtnModificar
            // 
            this.mBtnModificar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnModificar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnModificar.Appearance.Options.UseFont = true;
            this.mBtnModificar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnModificar.AppearanceHovered.Options.UseFont = true;
            this.mBtnModificar.Caption = "Modificar Registro";
            this.mBtnModificar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnModificar.Glyph")));
            this.mBtnModificar.Name = "mBtnModificar";
            this.mBtnModificar.Visible = false;
            this.mBtnModificar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnModificar_ElementClick);
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
            // mBtnEliminar
            // 
            this.mBtnEliminar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnEliminar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnEliminar.Appearance.Options.UseFont = true;
            this.mBtnEliminar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnEliminar.AppearanceHovered.Options.UseFont = true;
            this.mBtnEliminar.Caption = "Eliminar Registro";
            this.mBtnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnEliminar.Glyph")));
            this.mBtnEliminar.Name = "mBtnEliminar";
            this.mBtnEliminar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnEliminar_ElementClick);
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
            this.gbGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbGridViewFuncionario.Controls.Add(this.txtFechaRecibido);
            this.gbGridViewFuncionario.Controls.Add(this.cmbBodega);
            this.gbGridViewFuncionario.Controls.Add(this.txtCosto);
            this.gbGridViewFuncionario.Controls.Add(this.dateFechaCaducidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaCaducidad);
            this.gbGridViewFuncionario.Controls.Add(this.label1);
            this.gbGridViewFuncionario.Controls.Add(this.txtUnidadMedida);
            this.gbGridViewFuncionario.Controls.Add(this.lblUnidadMedida);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigo);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombreProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtCantidadXEmpaque);
            this.gbGridViewFuncionario.Controls.Add(this.txtECodigoProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.lblCantidadXEmpaque);
            this.gbGridViewFuncionario.Controls.Add(this.lblBodega);
            this.gbGridViewFuncionario.Controls.Add(this.lblUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblFechaIngreso);
            this.gbGridViewFuncionario.Controls.Add(this.lblSolicitudAvatar);
            this.gbGridViewFuncionario.Controls.Add(this.txtUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblIdRegProd);
            this.gbGridViewFuncionario.Controls.Add(this.lblDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.txtSolicitudAvatar);
            this.gbGridViewFuncionario.Controls.Add(this.lblProducto);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(12, 57);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(1112, 162);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Registro de Producto";
            // 
            // txtFechaRecibido
            // 
            this.txtFechaRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFechaRecibido.Enabled = false;
            this.txtFechaRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRecibido.Location = new System.Drawing.Point(962, 73);
            this.txtFechaRecibido.Name = "txtFechaRecibido";
            this.txtFechaRecibido.Size = new System.Drawing.Size(138, 22);
            this.txtFechaRecibido.TabIndex = 54;
            // 
            // cmbBodega
            // 
            this.cmbBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBodega.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTRegistroBodegaLessVirtualBindingSource, "idregistrobodega", true));
            this.cmbBodega.DataSource = this.spSELECTRegistroBodegaLessVirtualBindingSource;
            this.cmbBodega.DisplayMember = "nombre";
            this.cmbBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(226, 46);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(153, 24);
            this.cmbBodega.TabIndex = 0;
            this.cmbBodega.ValueMember = "idregistrobodega";
            // 
            // spSELECTRegistroBodegaLessVirtualBindingSource
            // 
            this.spSELECTRegistroBodegaLessVirtualBindingSource.DataMember = "sp_SELECT_RegistroBodega_LessVirtual";
            this.spSELECTRegistroBodegaLessVirtualBindingSource.DataSource = this.dataSetBodegas;
            // 
            // dataSetBodegas
            // 
            this.dataSetBodegas.DataSetName = "DataSetBodegas";
            this.dataSetBodegas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(596, 130);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(153, 22);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // dateFechaCaducidad
            // 
            this.dateFechaCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateFechaCaducidad.EditValue = null;
            this.dateFechaCaducidad.Location = new System.Drawing.Point(962, 129);
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
            this.dateFechaCaducidad.Size = new System.Drawing.Size(138, 20);
            this.dateFechaCaducidad.TabIndex = 6;
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidad.ForeColor = System.Drawing.Color.White;
            this.lblFechaCaducidad.Location = new System.Drawing.Point(785, 128);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(147, 18);
            this.lblFechaCaducidad.TabIndex = 39;
            this.lblFechaCaducidad.Text = "Fecha de Caducidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Costo por Empaque:";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadMedida.Location = new System.Drawing.Point(962, 101);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(138, 22);
            this.txtUnidadMedida.TabIndex = 50;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.ForeColor = System.Drawing.Color.White;
            this.lblUnidadMedida.Location = new System.Drawing.Point(785, 104);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(130, 18);
            this.lblUnidadMedida.TabIndex = 49;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(29, 103);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(125, 18);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Código Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(596, 102);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(153, 22);
            this.txtNombreProducto.TabIndex = 45;
            // 
            // txtCantidadXEmpaque
            // 
            this.txtCantidadXEmpaque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCantidadXEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadXEmpaque.Location = new System.Drawing.Point(226, 130);
            this.txtCantidadXEmpaque.Name = "txtCantidadXEmpaque";
            this.txtCantidadXEmpaque.Size = new System.Drawing.Size(153, 22);
            this.txtCantidadXEmpaque.TabIndex = 4;
            this.txtCantidadXEmpaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadXEmpaque_KeyPress);
            // 
            // txtECodigoProducto
            // 
            this.txtECodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtECodigoProducto.Location = new System.Drawing.Point(226, 104);
            this.txtECodigoProducto.Name = "txtECodigoProducto";
            this.txtECodigoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtECodigoProducto.Size = new System.Drawing.Size(153, 20);
            this.txtECodigoProducto.TabIndex = 3;
            this.txtECodigoProducto.Click += new System.EventHandler(this.txtECodigoProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(596, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(504, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblCantidadXEmpaque
            // 
            this.lblCantidadXEmpaque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadXEmpaque.AutoSize = true;
            this.lblCantidadXEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadXEmpaque.ForeColor = System.Drawing.Color.White;
            this.lblCantidadXEmpaque.Location = new System.Drawing.Point(29, 131);
            this.lblCantidadXEmpaque.Name = "lblCantidadXEmpaque";
            this.lblCantidadXEmpaque.Size = new System.Drawing.Size(163, 18);
            this.lblCantidadXEmpaque.TabIndex = 37;
            this.lblCantidadXEmpaque.Text = "Cantidad por Empaque:";
            // 
            // lblBodega
            // 
            this.lblBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.White;
            this.lblBodega.Location = new System.Drawing.Point(29, 47);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(63, 18);
            this.lblBodega.TabIndex = 35;
            this.lblBodega.Text = "Bodega:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(425, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(785, 74);
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
            this.lblSolicitudAvatar.Location = new System.Drawing.Point(29, 77);
            this.lblSolicitudAvatar.Name = "lblSolicitudAvatar";
            this.lblSolicitudAvatar.Size = new System.Drawing.Size(191, 18);
            this.lblSolicitudAvatar.TabIndex = 1;
            this.lblSolicitudAvatar.Text = "Solicitud de Compra Avatar:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(596, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblIdRegProd
            // 
            this.lblIdRegProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdRegProd.AutoSize = true;
            this.lblIdRegProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRegProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIdRegProd.Location = new System.Drawing.Point(14, 25);
            this.lblIdRegProd.Name = "lblIdRegProd";
            this.lblIdRegProd.Size = new System.Drawing.Size(0, 18);
            this.lblIdRegProd.TabIndex = 29;
            this.lblIdRegProd.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(425, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtSolicitudAvatar
            // 
            this.txtSolicitudAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSolicitudAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitudAvatar.Location = new System.Drawing.Point(226, 76);
            this.txtSolicitudAvatar.Name = "txtSolicitudAvatar";
            this.txtSolicitudAvatar.Size = new System.Drawing.Size(153, 22);
            this.txtSolicitudAvatar.TabIndex = 2;
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
            this.lblProducto.Location = new System.Drawing.Point(425, 102);
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
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(12, 225);
            this.gbGridViewRegistroProductos.Name = "gbGridViewRegistroProductos";
            this.gbGridViewRegistroProductos.Size = new System.Drawing.Size(1112, 255);
            this.gbGridViewRegistroProductos.TabIndex = 37;
            this.gbGridViewRegistroProductos.TabStop = false;
            this.gbGridViewRegistroProductos.Text = "Detalle de Productos";
            // 
            // gCRegistroProducto
            // 
            this.gCRegistroProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCRegistroProducto.Location = new System.Drawing.Point(6, 30);
            this.gCRegistroProducto.MainView = this.gridView1;
            this.gCRegistroProducto.Name = "gCRegistroProducto";
            this.gCRegistroProducto.Size = new System.Drawing.Size(1094, 209);
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
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // sp_SELECT_RegistroBodega_LessVirtualTableAdapter
            // 
            this.sp_SELECT_RegistroBodega_LessVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdRegistroProducto
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 492);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(1152, 531);
            this.MinimumSize = new System.Drawing.Size(1152, 531);
            this.Name = "frmAdRegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Producto";
            this.Load += new System.EventHandler(this.frmAdRegistroProducto_Load);
            this.Click += new System.EventHandler(this.gCRegistroProducto_Click);
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTRegistroBodegaLessVirtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaducidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCRegistroProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dateFechaCaducidad;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.Label lblCantidadXEmpaque;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblSolicitudAvatar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIdRegProd;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtSolicitudAvatar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private DevExpress.XtraGrid.GridControl gCRegistroProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtUnidadMedida;
       // private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCosto;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private System.Windows.Forms.ComboBox cmbBodega;
        private DataSets.Bodega.Procesos.DataSetBodegas dataSetBodegas;
        private System.Windows.Forms.BindingSource spSELECTRegistroBodegaLessVirtualBindingSource;
        private DataSets.Bodega.Procesos.DataSetBodegasTableAdapters.sp_SELECT_RegistroBodega_LessVirtualTableAdapter sp_SELECT_RegistroBodega_LessVirtualTableAdapter;
        private System.Windows.Forms.TextBox txtFechaRecibido;
    }
}
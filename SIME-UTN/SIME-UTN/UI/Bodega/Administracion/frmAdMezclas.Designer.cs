namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmAdMezclas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdMezclas));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAgregar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnGuardar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnEliminar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMezclaCategoria = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetMezclaCategoria();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIdMezcla = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtECodigoProducto = new DevExpress.XtraEditors.ButtonEdit();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbGridViewRegistroProductos = new System.Windows.Forms.GroupBox();
            this.gCRegistroProducto = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriaTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetMezclaCategoriaTableAdapters.CategoriaTableAdapter();
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMezclaCategoria)).BeginInit();
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
            this.tileNavPane1.Buttons.Add(this.mBtnAgregar);
            this.tileNavPane1.Buttons.Add(this.mBtnModificar);
            this.tileNavPane1.Buttons.Add(this.mBtnGuardar);
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
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // mBtnAgregar
            // 
            this.mBtnAgregar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnAgregar.Appearance.Options.UseFont = true;
            this.mBtnAgregar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnAgregar.AppearanceHovered.Options.UseFont = true;
            this.mBtnAgregar.Caption = "Agregar Producto";
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
            this.mBtnModificar.Caption = "Modificar";
            this.mBtnModificar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnModificar.Glyph")));
            this.mBtnModificar.Name = "mBtnModificar";
            this.mBtnModificar.Visible = false;
            this.mBtnModificar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnModificar_ElementClick);
            // 
            // mBtnGuardar
            // 
            this.mBtnGuardar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnGuardar.Appearance.Options.UseFont = true;
            this.mBtnGuardar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnGuardar.AppearanceHovered.Options.UseFont = true;
            this.mBtnGuardar.Caption = "Guardar";
            this.mBtnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnGuardar.Glyph")));
            this.mBtnGuardar.Name = "mBtnGuardar";
            this.mBtnGuardar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnGuardar_ElementClick);
            // 
            // mBtnEliminar
            // 
            this.mBtnEliminar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnEliminar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnEliminar.Appearance.Options.UseFont = true;
            this.mBtnEliminar.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mBtnEliminar.AppearanceHovered.Options.UseFont = true;
            this.mBtnEliminar.Caption = "Eliminar Producto";
            this.mBtnEliminar.Enabled = false;
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
            this.gbGridViewFuncionario.Controls.Add(this.cmbCategoria);
            this.gbGridViewFuncionario.Controls.Add(this.lblCategoria);
            this.gbGridViewFuncionario.Controls.Add(this.lblIdMezcla);
            this.gbGridViewFuncionario.Controls.Add(this.txtUnidadMedida);
            this.gbGridViewFuncionario.Controls.Add(this.lblUnidadMedida);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigo);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombreProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombre);
            this.gbGridViewFuncionario.Controls.Add(this.txtECodigoProducto);
            this.gbGridViewFuncionario.Controls.Add(this.txtDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.txtCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblNombre);
            this.gbGridViewFuncionario.Controls.Add(this.lblCantidad);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoUsuario);
            this.gbGridViewFuncionario.Controls.Add(this.lblDescripcion);
            this.gbGridViewFuncionario.Controls.Add(this.lblProducto);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(12, 57);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(1112, 147);
            this.gbGridViewFuncionario.TabIndex = 36;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Registro de Mezclas";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "IDCategoria", true));
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(203, 77);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(167, 24);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.ValueMember = "IDCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSetMezclaCategoria;
            // 
            // dataSetMezclaCategoria
            // 
            this.dataSetMezclaCategoria.DataSetName = "DataSetMezclaCategoria";
            this.dataSetMezclaCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(24, 83);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 52;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblIdMezcla
            // 
            this.lblIdMezcla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdMezcla.AutoSize = true;
            this.lblIdMezcla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMezcla.ForeColor = System.Drawing.Color.White;
            this.lblIdMezcla.Location = new System.Drawing.Point(195, 50);
            this.lblIdMezcla.Name = "lblIdMezcla";
            this.lblIdMezcla.Size = new System.Drawing.Size(0, 18);
            this.lblIdMezcla.TabIndex = 51;
            this.lblIdMezcla.Visible = false;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadMedida.Location = new System.Drawing.Point(904, 77);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(157, 22);
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
            this.lblUnidadMedida.Location = new System.Drawing.Point(750, 78);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(99, 18);
            this.lblUnidadMedida.TabIndex = 49;
            this.lblUnidadMedida.Text = "Presentación:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(416, 49);
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
            this.txtNombreProducto.Location = new System.Drawing.Point(904, 45);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(157, 22);
            this.txtNombreProducto.TabIndex = 45;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(203, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtECodigoProducto
            // 
            this.txtECodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtECodigoProducto.Location = new System.Drawing.Point(547, 47);
            this.txtECodigoProducto.Name = "txtECodigoProducto";
            this.txtECodigoProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtECodigoProducto.Size = new System.Drawing.Size(167, 20);
            this.txtECodigoProducto.TabIndex = 3;
            this.txtECodigoProducto.Click += new System.EventHandler(this.txtECodigoProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(203, 107);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(167, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(547, 77);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 22);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(24, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(153, 18);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre de la Mezcla:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(416, 81);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 18);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad:";
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
            this.lblDescripcion.Location = new System.Drawing.Point(24, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Múltiplos de:";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(750, 46);
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
            this.gbGridViewRegistroProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.gbGridViewRegistroProductos.ForeColor = System.Drawing.Color.White;
            this.gbGridViewRegistroProductos.Location = new System.Drawing.Point(12, 210);
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
            this.gCRegistroProducto.Size = new System.Drawing.Size(1100, 209);
            this.gCRegistroProducto.TabIndex = 0;
            this.gCRegistroProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCRegistroProducto.Click += new System.EventHandler(this.gCRegistroProducto_Click);
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
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdMezclas
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 480);
            this.Controls.Add(this.gbGridViewRegistroProductos);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(1152, 519);
            this.MinimumSize = new System.Drawing.Size(1152, 519);
            this.Name = "frmAdMezclas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Mezclas";
            this.Load += new System.EventHandler(this.frmAdRegistroProducto_Load);
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMezclaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtECodigoProducto.Properties)).EndInit();
            this.gbGridViewRegistroProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCRegistroProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnGuardar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private DevExpress.XtraEditors.ButtonEdit txtECodigoProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox gbGridViewRegistroProductos;
        private DevExpress.XtraGrid.GridControl gCRegistroProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAgregar;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label lblIdMezcla;
        private DevExpress.XtraBars.Navigation.NavButton mBtnEliminar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private DataSets.Bodega.Admistracion.DataSetMezclaCategoria dataSetMezclaCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataSets.Bodega.Admistracion.DataSetMezclaCategoriaTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
    }
}
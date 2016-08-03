namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmAdProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdProducto));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnGuardar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtCantMaxima = new System.Windows.Forms.TextBox();
            this.txtCantMinima = new System.Windows.Forms.TextBox();
            this.lblCantMax = new System.Windows.Forms.Label();
            this.lblCantMin = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.spSELECTUnidadMedidaProductoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidadMedida = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedida();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategorias = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetCategorias();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoAvatar = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoAvatar = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.categoriaTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetCategoriasTableAdapters.CategoriaTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.gbInformaciónPersonal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.gbInformaciónPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnNuevo);
            this.tileNavPane1.Buttons.Add(this.mBtnGuardar);
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
            this.tileNavPane1.Size = new System.Drawing.Size(1087, 40);
            this.tileNavPane1.TabIndex = 0;
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
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(517, 75);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(178, 22);
            this.txtContenido.TabIndex = 4;
            this.txtContenido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContenido_KeyPress);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(379, 76);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(99, 18);
            this.lblContenido.TabIndex = 39;
            this.lblContenido.Text = "Presentación:";
            // 
            // txtCantMaxima
            // 
            this.txtCantMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMaxima.Location = new System.Drawing.Point(517, 103);
            this.txtCantMaxima.Name = "txtCantMaxima";
            this.txtCantMaxima.Size = new System.Drawing.Size(178, 22);
            this.txtCantMaxima.TabIndex = 7;
            this.txtCantMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMaxima_KeyPress);
            // 
            // txtCantMinima
            // 
            this.txtCantMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMinima.Location = new System.Drawing.Point(174, 105);
            this.txtCantMinima.Name = "txtCantMinima";
            this.txtCantMinima.Size = new System.Drawing.Size(187, 22);
            this.txtCantMinima.TabIndex = 6;
            this.txtCantMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMinima_KeyPress);
            // 
            // lblCantMax
            // 
            this.lblCantMax.AutoSize = true;
            this.lblCantMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMax.Location = new System.Drawing.Point(379, 104);
            this.lblCantMax.Name = "lblCantMax";
            this.lblCantMax.Size = new System.Drawing.Size(126, 18);
            this.lblCantMax.TabIndex = 36;
            this.lblCantMax.Text = "Cantidad Máxima:";
            // 
            // lblCantMin
            // 
            this.lblCantMin.AutoSize = true;
            this.lblCantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMin.Location = new System.Drawing.Point(14, 104);
            this.lblCantMin.Name = "lblCantMin";
            this.lblCantMin.Size = new System.Drawing.Size(122, 18);
            this.lblCantMin.TabIndex = 35;
            this.lblCantMin.Text = "Cantidad Mínima:";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidadMedida.DataSource = this.spSELECTUnidadMedidaProductoAllBindingSource;
            this.cmbUnidadMedida.DisplayMember = "Descripcion";
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(853, 75);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(172, 24);
            this.cmbUnidadMedida.TabIndex = 5;
            this.cmbUnidadMedida.ValueMember = "IDUnidadMedida";
            // 
            // spSELECTUnidadMedidaProductoAllBindingSource
            // 
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataMember = "sp_SELECT_UnidadMedidaProducto_All";
            this.spSELECTUnidadMedidaProductoAllBindingSource.DataSource = this.dataSetUnidadMedida;
            // 
            // dataSetUnidadMedida
            // 
            this.dataSetUnidadMedida.DataSetName = "DataSetUnidadMedida";
            this.dataSetUnidadMedida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.ForeColor = System.Drawing.Color.White;
            this.lblUnidadMedida.Location = new System.Drawing.Point(717, 76);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(130, 18);
            this.lblUnidadMedida.TabIndex = 32;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource, "IDCategoria", true));
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(174, 75);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(187, 24);
            this.cmbCategoria.TabIndex = 3;
            this.cmbCategoria.ValueMember = "IDCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSetCategorias;
            // 
            // dataSetCategorias
            // 
            this.dataSetCategorias.DataSetName = "DataSetCategorias";
            this.dataSetCategorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(379, 51);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCodigoAvatar
            // 
            this.txtCodigoAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAvatar.Location = new System.Drawing.Point(853, 47);
            this.txtCodigoAvatar.Name = "txtCodigoAvatar";
            this.txtCodigoAvatar.Size = new System.Drawing.Size(172, 22);
            this.txtCodigoAvatar.TabIndex = 2;
            this.txtCodigoAvatar.Text = "A234";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(174, 47);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(187, 22);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.Text = "Cloro";
            // 
            // lblCodigoAvatar
            // 
            this.lblCodigoAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoAvatar.AutoSize = true;
            this.lblCodigoAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAvatar.ForeColor = System.Drawing.Color.White;
            this.lblCodigoAvatar.Location = new System.Drawing.Point(717, 48);
            this.lblCodigoAvatar.Name = "lblCodigoAvatar";
            this.lblCodigoAvatar.Size = new System.Drawing.Size(105, 18);
            this.lblCodigoAvatar.TabIndex = 23;
            this.lblCodigoAvatar.Text = "Código Avatar:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 48);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(154, 18);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(14, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(517, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 22);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Limpieza";
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // sp_SELECT_UnidadMedidaProducto_AllTableAdapter
            // 
            this.sp_SELECT_UnidadMedidaProducto_AllTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoProducto.Location = new System.Drawing.Point(14, 25);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(0, 18);
            this.lblCodigoProducto.TabIndex = 29;
            this.lblCodigoProducto.Visible = false;
            // 
            // gbInformaciónPersonal
            // 
            this.gbInformaciónPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformaciónPersonal.Controls.Add(this.txtContenido);
            this.gbInformaciónPersonal.Controls.Add(this.lblContenido);
            this.gbInformaciónPersonal.Controls.Add(this.txtCantMaxima);
            this.gbInformaciónPersonal.Controls.Add(this.txtCantMinima);
            this.gbInformaciónPersonal.Controls.Add(this.lblCantMax);
            this.gbInformaciónPersonal.Controls.Add(this.lblCantMin);
            this.gbInformaciónPersonal.Controls.Add(this.cmbUnidadMedida);
            this.gbInformaciónPersonal.Controls.Add(this.lblUnidadMedida);
            this.gbInformaciónPersonal.Controls.Add(this.cmbCategoria);
            this.gbInformaciónPersonal.Controls.Add(this.lblCodigoProducto);
            this.gbInformaciónPersonal.Controls.Add(this.lblDescripcion);
            this.gbInformaciónPersonal.Controls.Add(this.txtCodigoAvatar);
            this.gbInformaciónPersonal.Controls.Add(this.txtNombreProducto);
            this.gbInformaciónPersonal.Controls.Add(this.lblCodigoAvatar);
            this.gbInformaciónPersonal.Controls.Add(this.lblNombreProducto);
            this.gbInformaciónPersonal.Controls.Add(this.lblCategoria);
            this.gbInformaciónPersonal.Controls.Add(this.txtDescripcion);
            this.gbInformaciónPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformaciónPersonal.ForeColor = System.Drawing.Color.White;
            this.gbInformaciónPersonal.Location = new System.Drawing.Point(12, 46);
            this.gbInformaciónPersonal.Name = "gbInformaciónPersonal";
            this.gbInformaciónPersonal.Size = new System.Drawing.Size(1063, 154);
            this.gbInformaciónPersonal.TabIndex = 0;
            this.gbInformaciónPersonal.TabStop = false;
            this.gbInformaciónPersonal.Text = "Información del Producto";
            // 
            // frmAdProducto
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 214);
            this.Controls.Add(this.gbInformaciónPersonal);
            this.Controls.Add(this.tileNavPane1);
            this.MaximumSize = new System.Drawing.Size(1103, 252);
            this.MinimumSize = new System.Drawing.Size(1103, 252);
            this.Name = "frmAdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmAdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUnidadMedidaProductoAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.gbInformaciónPersonal.ResumeLayout(false);
            this.gbInformaciónPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private DevExpress.XtraBars.Navigation.NavButton mBtnGuardar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoAvatar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCodigoAvatar;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DataSets.Bodega.Admistracion.DataSetCategorias dataSetCategorias;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataSets.Bodega.Admistracion.DataSetCategoriasTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedida dataSetUnidadMedida;
        private System.Windows.Forms.BindingSource spSELECTUnidadMedidaProductoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUnidadMedidaTableAdapters.sp_SELECT_UnidadMedidaProducto_AllTableAdapter sp_SELECT_UnidadMedidaProducto_AllTableAdapter;
        private System.Windows.Forms.TextBox txtCantMaxima;
        private System.Windows.Forms.TextBox txtCantMinima;
        private System.Windows.Forms.Label lblCantMax;
        private System.Windows.Forms.Label lblCantMin;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.GroupBox gbInformaciónPersonal;
        private System.Windows.Forms.Label lblCodigoProducto;
    }
}
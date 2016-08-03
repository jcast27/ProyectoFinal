namespace SIME_UTN.UI.Formulario.Administracion
{
    partial class frmAdActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdActivo));
            this.gbActivo = new System.Windows.Forms.GroupBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFUbicacion = new SIME_UTN.DataSets.Formulario.DataSetFUbicacion();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategoria = new SIME_UTN.DataSets.Formulario.DataSetCategoria();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTBodega = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodega();
            this.tipoBodegaTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodegaTableAdapters.TipoBodegaTableAdapter();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnGuardar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.categoriaTableAdapter = new SIME_UTN.DataSets.Formulario.DataSetCategoriaTableAdapters.CategoriaTableAdapter();
            this.ubicacionTableAdapter = new SIME_UTN.DataSets.Formulario.DataSetFUbicacionTableAdapters.UbicacionTableAdapter();
            this.gbActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActivo
            // 
            this.gbActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbActivo.Controls.Add(this.dtpIngreso);
            this.gbActivo.Controls.Add(this.cmbUbicacion);
            this.gbActivo.Controls.Add(this.cmbCategoria);
            this.gbActivo.Controls.Add(this.txtPatrimonio);
            this.gbActivo.Controls.Add(this.label10);
            this.gbActivo.Controls.Add(this.txtDescripcion);
            this.gbActivo.Controls.Add(this.label9);
            this.gbActivo.Controls.Add(this.txtValor);
            this.gbActivo.Controls.Add(this.label8);
            this.gbActivo.Controls.Add(this.label7);
            this.gbActivo.Controls.Add(this.txtModelo);
            this.gbActivo.Controls.Add(this.label6);
            this.gbActivo.Controls.Add(this.txtMarca);
            this.gbActivo.Controls.Add(this.label5);
            this.gbActivo.Controls.Add(this.label4);
            this.gbActivo.Controls.Add(this.label3);
            this.gbActivo.Controls.Add(this.txtSerie);
            this.gbActivo.Controls.Add(this.label2);
            this.gbActivo.Controls.Add(this.txtId);
            this.gbActivo.Controls.Add(this.lblId);
            this.gbActivo.Controls.Add(this.txtNombre);
            this.gbActivo.Controls.Add(this.label1);
            this.gbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActivo.ForeColor = System.Drawing.Color.White;
            this.gbActivo.Location = new System.Drawing.Point(6, 46);
            this.gbActivo.MaximumSize = new System.Drawing.Size(611, 413);
            this.gbActivo.Name = "gbActivo";
            this.gbActivo.Size = new System.Drawing.Size(543, 221);
            this.gbActivo.TabIndex = 33;
            this.gbActivo.TabStop = false;
            this.gbActivo.Text = "Registro Activo";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(97, 94);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(163, 22);
            this.dtpIngreso.TabIndex = 2;
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUbicacion.DataSource = this.ubicacionBindingSource;
            this.cmbUbicacion.DisplayMember = "Nombre";
            this.cmbUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(364, 122);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(163, 24);
            this.cmbUbicacion.TabIndex = 9;
            this.cmbUbicacion.ValueMember = "IDUbicacion";
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataMember = "Ubicacion";
            this.ubicacionBindingSource.DataSource = this.dataSetFUbicacion;
            // 
            // dataSetFUbicacion
            // 
            this.dataSetFUbicacion.DataSetName = "DataSetFUbicacion";
            this.dataSetFUbicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(97, 122);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(163, 24);
            this.cmbCategoria.TabIndex = 3;
            this.cmbCategoria.ValueMember = "IDCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSetCategoria;
            // 
            // dataSetCategoria
            // 
            this.dataSetCategoria.DataSetName = "DataSetCategoria";
            this.dataSetCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatrimonio.Location = new System.Drawing.Point(364, 39);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(163, 22);
            this.txtPatrimonio.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(274, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Patrimonio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(364, 152);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 50);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(274, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Descripción:";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(364, 94);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(163, 22);
            this.txtValor.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(274, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(14, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Categoría:";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(97, 180);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(163, 22);
            this.txtModelo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(97, 152);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(163, 22);
            this.txtMarca.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(274, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ubicación:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ingreso:";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(364, 67);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(163, 22);
            this.txtSerie.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(274, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "N° Serie:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtId.Location = new System.Drawing.Point(97, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(163, 22);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(14, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 18);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Id:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(97, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre:";
            // 
            // tipoBodegaBindingSource
            // 
            this.tipoBodegaBindingSource.DataMember = "TipoBodega";
            this.tipoBodegaBindingSource.DataSource = this.dataSetTBodega;
            // 
            // dataSetTBodega
            // 
            this.dataSetTBodega.DataSetName = "DataSetTBodega";
            this.dataSetTBodega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBodegaTableAdapter
            // 
            this.tipoBodegaTableAdapter.ClearBeforeFill = true;
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
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
            this.tileNavPane1.Size = new System.Drawing.Size(561, 40);
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
            this.mBtnNuevo.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnNuevo_ElementClick);
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
            this.mBtnGuardar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnGuardar_ElementClick_1);
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
            this.mBtnSalir.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnSalir_ElementClick_1);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // ubicacionTableAdapter
            // 
            this.ubicacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdActivo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 279);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbActivo);
            this.MaximumSize = new System.Drawing.Size(577, 317);
            this.MinimumSize = new System.Drawing.Size(577, 317);
            this.Name = "frmAdActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.frmAdActivo_Load);
            this.gbActivo.ResumeLayout(false);
            this.gbActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActivo;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodega dataSetTBodega;
        private System.Windows.Forms.BindingSource tipoBodegaBindingSource;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodegaTableAdapters.TipoBodegaTableAdapter tipoBodegaTableAdapter;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnGuardar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private DataSets.Formulario.DataSetCategoria dataSetCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DataSets.Formulario.DataSetCategoriaTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private DataSets.Formulario.DataSetFUbicacion dataSetFUbicacion;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private DataSets.Formulario.DataSetFUbicacionTableAdapters.UbicacionTableAdapter ubicacionTableAdapter;
    }
}
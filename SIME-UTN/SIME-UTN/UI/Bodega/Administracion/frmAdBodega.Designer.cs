namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmAdBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdBodega));
            this.gbGridViewBodega = new System.Windows.Forms.GroupBox();
            this.chkedEstado = new DevExpress.XtraEditors.CheckEdit();
            this.cmbTipoBodega = new System.Windows.Forms.ComboBox();
            this.spSELECTTipoBodegaAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTipoBodegaCMB = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTipoBodegaCMB();
            this.spSELECTTipoBodegaAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodigoBodega = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tipoBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTBodega = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodega();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnGuardar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.tipoBodegaTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodegaTableAdapters.TipoBodegaTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sp_SELECT_TipoBodega_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetTipoBodegaCMBTableAdapters.sp_SELECT_TipoBodega_AllTableAdapter();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.dataSetUbicacion = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUbicacion();
            this.spSELECTUbicacionAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SELECT_Ubicacion_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetUbicacionTableAdapters.sp_SELECT_Ubicacion_AllTableAdapter();
            this.gbGridViewBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkedEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoBodegaCMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUbicacionAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGridViewBodega
            // 
            this.gbGridViewBodega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbGridViewBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbGridViewBodega.Controls.Add(this.cmbUbicacion);
            this.gbGridViewBodega.Controls.Add(this.lblLocalizacion);
            this.gbGridViewBodega.Controls.Add(this.chkedEstado);
            this.gbGridViewBodega.Controls.Add(this.cmbTipoBodega);
            this.gbGridViewBodega.Controls.Add(this.lblCodigoBodega);
            this.gbGridViewBodega.Controls.Add(this.lblDescripcion);
            this.gbGridViewBodega.Controls.Add(this.txtBodega);
            this.gbGridViewBodega.Controls.Add(this.lblTipo);
            this.gbGridViewBodega.Controls.Add(this.lblBodega);
            this.gbGridViewBodega.Controls.Add(this.txtDescripcion);
            this.gbGridViewBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewBodega.ForeColor = System.Drawing.Color.White;
            this.gbGridViewBodega.Location = new System.Drawing.Point(6, 63);
            this.gbGridViewBodega.MaximumSize = new System.Drawing.Size(611, 413);
            this.gbGridViewBodega.Name = "gbGridViewBodega";
            this.gbGridViewBodega.Size = new System.Drawing.Size(550, 312);
            this.gbGridViewBodega.TabIndex = 33;
            this.gbGridViewBodega.TabStop = false;
            this.gbGridViewBodega.Text = "Registro Bodega";
            // 
            // chkedEstado
            // 
            this.chkedEstado.EditValue = true;
            this.chkedEstado.Enabled = false;
            this.chkedEstado.Location = new System.Drawing.Point(414, 231);
            this.chkedEstado.Name = "chkedEstado";
            this.chkedEstado.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chkedEstado.Properties.Appearance.Options.UseFont = true;
            this.chkedEstado.Properties.Caption = "Activo";
            this.chkedEstado.Size = new System.Drawing.Size(75, 22);
            this.chkedEstado.TabIndex = 33;
            // 
            // cmbTipoBodega
            // 
            this.cmbTipoBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoBodega.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTTipoBodegaAllBindingSource1, "idtipobodega", true));
            this.cmbTipoBodega.DataSource = this.spSELECTTipoBodegaAllBindingSource;
            this.cmbTipoBodega.DisplayMember = "descripcion";
            this.cmbTipoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoBodega.FormattingEnabled = true;
            this.cmbTipoBodega.Location = new System.Drawing.Point(199, 227);
            this.cmbTipoBodega.Name = "cmbTipoBodega";
            this.cmbTipoBodega.Size = new System.Drawing.Size(78, 24);
            this.cmbTipoBodega.TabIndex = 32;
            this.cmbTipoBodega.ValueMember = "idtipobodega";
            // 
            // spSELECTTipoBodegaAllBindingSource1
            // 
            this.spSELECTTipoBodegaAllBindingSource1.DataMember = "sp_SELECT_TipoBodega_All";
            this.spSELECTTipoBodegaAllBindingSource1.DataSource = this.dataSetTipoBodegaCMB;
            // 
            // dataSetTipoBodegaCMB
            // 
            this.dataSetTipoBodegaCMB.DataSetName = "DataSetTipoBodegaCMB";
            this.dataSetTipoBodegaCMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSELECTTipoBodegaAllBindingSource
            // 
            this.spSELECTTipoBodegaAllBindingSource.DataMember = "sp_SELECT_TipoBodega_All";
            this.spSELECTTipoBodegaAllBindingSource.DataSource = this.dataSetTipoBodegaCMB;
            // 
            // lblCodigoBodega
            // 
            this.lblCodigoBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoBodega.AutoSize = true;
            this.lblCodigoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBodega.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoBodega.Location = new System.Drawing.Point(14, 25);
            this.lblCodigoBodega.Name = "lblCodigoBodega";
            this.lblCodigoBodega.Size = new System.Drawing.Size(0, 18);
            this.lblCodigoBodega.TabIndex = 29;
            this.lblCodigoBodega.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 131);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtBodega
            // 
            this.txtBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega.Location = new System.Drawing.Point(199, 74);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(290, 22);
            this.txtBodega.TabIndex = 3;
            this.txtBodega.Text = "A";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(25, 233);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 18);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblBodega
            // 
            this.lblBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.Color.White;
            this.lblBodega.Location = new System.Drawing.Point(25, 78);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(63, 18);
            this.lblBodega.TabIndex = 1;
            this.lblBodega.Text = "Bodega:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(199, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(290, 22);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.Text = "Para productos fisicos";
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
            this.tileNavPane1.Size = new System.Drawing.Size(562, 40);
            this.tileNavPane1.TabIndex = 34;
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
            // tipoBodegaTableAdapter
            // 
            this.tipoBodegaTableAdapter.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // sp_SELECT_TipoBodega_AllTableAdapter
            // 
            this.sp_SELECT_TipoBodega_AllTableAdapter.ClearBeforeFill = true;
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTUbicacionAllBindingSource, "idubicacion", true));
            this.cmbUbicacion.DataSource = this.spSELECTUbicacionAllBindingSource;
            this.cmbUbicacion.DisplayMember = "nombre";
            this.cmbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Location = new System.Drawing.Point(199, 182);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(290, 24);
            this.cmbUbicacion.TabIndex = 36;
            this.cmbUbicacion.ValueMember = "idubicacion";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.ForeColor = System.Drawing.Color.White;
            this.lblLocalizacion.Location = new System.Drawing.Point(22, 183);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(95, 18);
            this.lblLocalizacion.TabIndex = 35;
            this.lblLocalizacion.Text = "Localización:";
            // 
            // dataSetUbicacion
            // 
            this.dataSetUbicacion.DataSetName = "DataSetUbicacion";
            this.dataSetUbicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSELECTUbicacionAllBindingSource
            // 
            this.spSELECTUbicacionAllBindingSource.DataMember = "sp_SELECT_Ubicacion_All";
            this.spSELECTUbicacionAllBindingSource.DataSource = this.dataSetUbicacion;
            // 
            // sp_SELECT_Ubicacion_AllTableAdapter
            // 
            this.sp_SELECT_Ubicacion_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdBodega
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 377);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewBodega);
            this.MaximumSize = new System.Drawing.Size(578, 416);
            this.Name = "frmAdBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.frmAdBodega_Load);
            this.gbGridViewBodega.ResumeLayout(false);
            this.gbGridViewBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkedEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTipoBodegaCMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTTipoBodegaAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTUbicacionAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridViewBodega;
        private System.Windows.Forms.Label lblCodigoBodega;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private DevExpress.XtraBars.Navigation.NavButton mBtnGuardar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private System.Windows.Forms.ComboBox cmbTipoBodega;
        private DevExpress.XtraEditors.CheckEdit chkedEstado;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodega dataSetTBodega;
        private System.Windows.Forms.BindingSource tipoBodegaBindingSource;
        private SIME_UTN.DataSets.Bodega.Admistracion.DataSetTBodegaTableAdapters.TipoBodegaTableAdapter tipoBodegaTableAdapter;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private DataSets.Bodega.Admistracion.DataSetTipoBodegaCMB dataSetTipoBodegaCMB;
        private System.Windows.Forms.BindingSource spSELECTTipoBodegaAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetTipoBodegaCMBTableAdapters.sp_SELECT_TipoBodega_AllTableAdapter sp_SELECT_TipoBodega_AllTableAdapter;
        private System.Windows.Forms.BindingSource spSELECTTipoBodegaAllBindingSource1;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.Label lblLocalizacion;
        private DataSets.Bodega.Admistracion.DataSetUbicacion dataSetUbicacion;
        private System.Windows.Forms.BindingSource spSELECTUbicacionAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetUbicacionTableAdapters.sp_SELECT_Ubicacion_AllTableAdapter sp_SELECT_Ubicacion_AllTableAdapter;
    }
}
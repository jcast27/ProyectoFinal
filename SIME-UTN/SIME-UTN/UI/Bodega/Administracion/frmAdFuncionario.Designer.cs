namespace SIME_UTN.UI.Bodega.Administracion
{
    partial class frmAdFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdFuncionario));
            this.gbGridViewFuncionario = new System.Windows.Forms.GroupBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.spSELECTDepartamentoAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDepartamento = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetDepartamento();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreFuncionario = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnNuevo = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnGuardar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnModificar = new DevExpress.XtraBars.Navigation.NavButton();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sp_SELECT_Departamento_AllTableAdapter = new SIME_UTN.DataSets.Bodega.Admistracion.DataSetDepartamentoTableAdapters.sp_SELECT_Departamento_AllTableAdapter();
            this.gbGridViewFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTDepartamentoAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGridViewFuncionario
            // 
            this.gbGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbGridViewFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.gbGridViewFuncionario.Controls.Add(this.cmbDepartamento);
            this.gbGridViewFuncionario.Controls.Add(this.txtCorreo);
            this.gbGridViewFuncionario.Controls.Add(this.lblCodigoFuncionario);
            this.gbGridViewFuncionario.Controls.Add(this.lblCedula);
            this.gbGridViewFuncionario.Controls.Add(this.txtTelefono);
            this.gbGridViewFuncionario.Controls.Add(this.txtNombreFuncionario);
            this.gbGridViewFuncionario.Controls.Add(this.lblTelefono);
            this.gbGridViewFuncionario.Controls.Add(this.lblNombreFuncionario);
            this.gbGridViewFuncionario.Controls.Add(this.lblDepartamento);
            this.gbGridViewFuncionario.Controls.Add(this.lblCorreo);
            this.gbGridViewFuncionario.Controls.Add(this.txtCedula);
            this.gbGridViewFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbGridViewFuncionario.Location = new System.Drawing.Point(6, 46);
            this.gbGridViewFuncionario.MaximumSize = new System.Drawing.Size(611, 413);
            this.gbGridViewFuncionario.Name = "gbGridViewFuncionario";
            this.gbGridViewFuncionario.Size = new System.Drawing.Size(611, 212);
            this.gbGridViewFuncionario.TabIndex = 0;
            this.gbGridViewFuncionario.TabStop = false;
            this.gbGridViewFuncionario.Text = "Información del Funcionario";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spSELECTDepartamentoAllBindingSource, "iddepartamento", true));
            this.cmbDepartamento.DataSource = this.spSELECTDepartamentoAllBindingSource;
            this.cmbDepartamento.DisplayMember = "descripcion";
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(205, 165);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(375, 24);
            this.cmbDepartamento.TabIndex = 4;
            this.cmbDepartamento.ValueMember = "IDDepartamento";
            // 
            // spSELECTDepartamentoAllBindingSource
            // 
            this.spSELECTDepartamentoAllBindingSource.DataMember = "sp_SELECT_Departamento_All";
            this.spSELECTDepartamentoAllBindingSource.DataSource = this.dataSetDepartamento;
            // 
            // dataSetDepartamento
            // 
            this.dataSetDepartamento.DataSetName = "DataSetDepartamento";
            this.dataSetDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(205, 137);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(375, 22);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(14, 25);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(0, 18);
            this.lblCodigoFuncionario.TabIndex = 29;
            this.lblCodigoFuncionario.Visible = false;
            // 
            // lblCedula
            // 
            this.lblCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(28, 85);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(58, 18);
            this.lblCedula.TabIndex = 22;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(205, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(375, 22);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtNombreFuncionario
            // 
            this.txtNombreFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFuncionario.Location = new System.Drawing.Point(205, 53);
            this.txtNombreFuncionario.Name = "txtNombreFuncionario";
            this.txtNombreFuncionario.Size = new System.Drawing.Size(375, 22);
            this.txtNombreFuncionario.TabIndex = 0;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(28, 113);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 18);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblNombreFuncionario
            // 
            this.lblNombreFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreFuncionario.AutoSize = true;
            this.lblNombreFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNombreFuncionario.Location = new System.Drawing.Point(28, 57);
            this.lblNombreFuncionario.Name = "lblNombreFuncionario";
            this.lblNombreFuncionario.Size = new System.Drawing.Size(171, 18);
            this.lblNombreFuncionario.TabIndex = 1;
            this.lblNombreFuncionario.Text = "Nombre del Funcionario:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(28, 171);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(106, 18);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(28, 141);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 18);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(205, 81);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(375, 22);
            this.txtCedula.TabIndex = 1;
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
            this.tileNavPane1.Size = new System.Drawing.Size(629, 40);
            this.tileNavPane1.TabIndex = 1;
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
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // sp_SELECT_Departamento_AllTableAdapter
            // 
            this.sp_SELECT_Departamento_AllTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdFuncionario
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 277);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewFuncionario);
            this.Name = "frmAdFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.frmAdFuncionario_Load);
            this.gbGridViewFuncionario.ResumeLayout(false);
            this.gbGridViewFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTDepartamentoAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridViewFuncionario;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreFuncionario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreFuncionario;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCedula;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
        private DevExpress.XtraBars.Navigation.NavButton mBtnNuevo;
        private DevExpress.XtraBars.Navigation.NavButton mBtnGuardar;
        private DevExpress.XtraBars.Navigation.NavButton mBtnModificar;
        private System.Windows.Forms.ErrorProvider epError;
        private DataSets.Bodega.Admistracion.DataSetDepartamento dataSetDepartamento;
        private System.Windows.Forms.BindingSource spSELECTDepartamentoAllBindingSource;
        private DataSets.Bodega.Admistracion.DataSetDepartamentoTableAdapters.sp_SELECT_Departamento_AllTableAdapter sp_SELECT_Departamento_AllTableAdapter;
    }
}
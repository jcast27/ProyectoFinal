namespace SIME_UTN.UI
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.cmbUsuarioId = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gCUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimerApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSegundoApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkDespachador = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.rControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bBtnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.overlayControl1 = new OverlayControl.OverlayControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rControl)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarioId
            // 
            this.cmbUsuarioId.FormattingEnabled = true;
            this.cmbUsuarioId.Location = new System.Drawing.Point(803, 107);
            this.cmbUsuarioId.Name = "cmbUsuarioId";
            this.cmbUsuarioId.Size = new System.Drawing.Size(17, 21);
            this.cmbUsuarioId.TabIndex = 17;
            this.cmbUsuarioId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 88);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(198, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Usuario";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtConfirmacion.Location = new System.Drawing.Point(559, 297);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.PasswordChar = '*';
            this.txtConfirmacion.Size = new System.Drawing.Size(248, 20);
            this.txtConfirmacion.TabIndex = 14;
            this.txtConfirmacion.Text = "123";
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfirmacion.Location = new System.Drawing.Point(441, 296);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(101, 18);
            this.lblConfirmacion.TabIndex = 13;
            this.lblConfirmacion.Text = "Confirmacion:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.chkAdministrador.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdministrador.Location = new System.Drawing.Point(25, 188);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(118, 22);
            this.chkAdministrador.TabIndex = 6;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = false;
            this.chkAdministrador.CheckedChanged += new System.EventHandler(this.chkAdministrador_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassword.Location = new System.Drawing.Point(559, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Location = new System.Drawing.Point(163, 234);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "jose";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(441, 234);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(22, 235);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // gCUsuarios
            // 
            this.gCUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gCUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gCUsuarios.BackgroundImage")));
            this.gCUsuarios.Location = new System.Drawing.Point(25, 444);
            this.gCUsuarios.MainView = this.gridView1;
            this.gCUsuarios.Name = "gCUsuarios";
            this.gCUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UsuarioItemLookUpEdit1});
            this.gCUsuarios.Size = new System.Drawing.Size(752, 212);
            this.gCUsuarios.TabIndex = 19;
            this.gCUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoUsuario,
            this.colUsuario,
            this.colNombre,
            this.colPrimerApellido,
            this.colSegundoApellido,
            this.colPerfil});
            this.gridView1.GridControl = this.gCUsuarios;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.FormCaptionFormat = "{Name} {Modification";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colCodigoUsuario
            // 
            this.colCodigoUsuario.FieldName = "CodigoUsuario";
            this.colCodigoUsuario.Name = "colCodigoUsuario";
            this.colCodigoUsuario.OptionsColumn.AllowEdit = false;
            this.colCodigoUsuario.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigoUsuario.Visible = true;
            this.colCodigoUsuario.VisibleIndex = 0;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colPrimerApellido
            // 
            this.colPrimerApellido.Caption = "P. Apellido";
            this.colPrimerApellido.FieldName = "PrimerApellido";
            this.colPrimerApellido.Name = "colPrimerApellido";
            this.colPrimerApellido.Visible = true;
            this.colPrimerApellido.VisibleIndex = 3;
            // 
            // colSegundoApellido
            // 
            this.colSegundoApellido.Caption = "S. Apellido";
            this.colSegundoApellido.FieldName = "SegundoApellido";
            this.colSegundoApellido.Name = "colSegundoApellido";
            this.colSegundoApellido.Visible = true;
            this.colSegundoApellido.VisibleIndex = 4;
            // 
            // colPerfil
            // 
            this.colPerfil.FieldName = "Perfil";
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colPerfil.Visible = true;
            this.colPerfil.VisibleIndex = 5;
            // 
            // UsuarioItemLookUpEdit1
            // 
            this.UsuarioItemLookUpEdit1.AutoHeight = false;
            this.UsuarioItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsuarioItemLookUpEdit1.Name = "UsuarioItemLookUpEdit1";
            this.UsuarioItemLookUpEdit1.NullText = "";
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // chkDespachador
            // 
            this.chkDespachador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chkDespachador.AutoSize = true;
            this.chkDespachador.BackColor = System.Drawing.Color.Transparent;
            this.chkDespachador.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkDespachador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDespachador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDespachador.Location = new System.Drawing.Point(163, 188);
            this.chkDespachador.Name = "chkDespachador";
            this.chkDespachador.Size = new System.Drawing.Size(116, 22);
            this.chkDespachador.TabIndex = 20;
            this.chkDespachador.Text = "Despachador";
            this.chkDespachador.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(441, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApellido1.Location = new System.Drawing.Point(23, 296);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(111, 18);
            this.lblApellido1.TabIndex = 22;
            this.lblApellido1.Text = "Primer Apellido:";
            // 
            // lblApellido2
            // 
            this.lblApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApellido2.Location = new System.Drawing.Point(23, 354);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(126, 18);
            this.lblApellido2.TabIndex = 23;
            this.lblApellido2.Text = "Segundo Apellido:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(559, 355);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtUsuario.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtApellido2);
            this.panel2.Controls.Add(this.txtApellido1);
            this.panel2.Controls.Add(this.lblApellido2);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.gCUsuarios);
            this.panel2.Controls.Add(this.txtConfirmacion);
            this.panel2.Controls.Add(this.chkDespachador);
            this.panel2.Controls.Add(this.lblConfirmacion);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.chkAdministrador);
            this.panel2.Controls.Add(this.lblApellido1);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.cmbUsuarioId);
            this.panel2.Controls.Add(this.rControl);
            this.panel2.Location = new System.Drawing.Point(25, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 674);
            this.panel2.TabIndex = 29;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido2.Location = new System.Drawing.Point(163, 355);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(248, 20);
            this.txtApellido2.TabIndex = 28;
            this.txtApellido2.Text = "morera";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido1.Location = new System.Drawing.Point(163, 297);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(248, 20);
            this.txtApellido1.TabIndex = 27;
            this.txtApellido1.Text = "castro";
            // 
            // rControl
            // 
            this.rControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rControl.Dock = System.Windows.Forms.DockStyle.None;
            this.rControl.ExpandCollapseItem.Id = 0;
            this.rControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rControl.ExpandCollapseItem,
            this.bBtnAgregar});
            this.rControl.Location = new System.Drawing.Point(0, 14);
            this.rControl.MaxItemId = 1;
            this.rControl.Name = "rControl";
            this.rControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.rControl.Size = new System.Drawing.Size(820, 128);
            this.rControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // bBtnAgregar
            // 
            this.bBtnAgregar.Caption = "Agregar";
            this.bBtnAgregar.Glyph = ((System.Drawing.Image)(resources.GetObject("bBtnAgregar.Glyph")));
            this.bBtnAgregar.Id = 1;
            this.bBtnAgregar.Name = "bBtnAgregar";
            this.bBtnAgregar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bBtnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnAgregar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnAgregar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // overlayControl1
            // 
            this.overlayControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.overlayControl1.Location = new System.Drawing.Point(12, 2);
            this.overlayControl1.Name = "overlayControl1";
            this.overlayControl1.Size = new System.Drawing.Size(847, 769);
            this.overlayControl1.TabIndex = 30;
            this.overlayControl1.Text = "overlayControl1";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(871, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.overlayControl1);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.ComboBox cmbUsuarioId;
        private DevExpress.XtraGrid.GridControl gCUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPerfil;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UsuarioItemLookUpEdit1;
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDespachador;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Ribbon.RibbonControl rControl;
        private DevExpress.XtraBars.BarButtonItem bBtnAgregar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimerApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colSegundoApellido;
        private OverlayControl.OverlayControl overlayControl1;
    }
}
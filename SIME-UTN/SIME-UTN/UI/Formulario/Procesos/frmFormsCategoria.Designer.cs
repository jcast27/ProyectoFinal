namespace SIME_UTN.UI.Formulario.Procesos
{
    partial class frmFormsCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormsCategoria));
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnAbrir = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbGridViewUsuario = new System.Windows.Forms.GroupBox();
            this.gCFormulario = new DevExpress.XtraGrid.GridControl();
            this.spSELECTCategoriaFormularioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formulariosCategoria = new SIME_UTN.DataSets.Formulario.FormulariosCategoria();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpertenencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sp_SELECT_Categoria_FormularioTableAdapter = new SIME_UTN.DataSets.Formulario.FormulariosCategoriaTableAdapters.sp_SELECT_Categoria_FormularioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.gbGridViewUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTCategoriaFormularioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulariosCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.mBtnAbrir);
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
            this.tileNavPane1.Location = new System.Drawing.Point(144, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1162, 45);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "Nuevo";
            // 
            // mBtnAbrir
            // 
            this.mBtnAbrir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnAbrir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAbrir.Appearance.Options.UseFont = true;
            this.mBtnAbrir.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnAbrir.AppearanceHovered.Options.UseFont = true;
            this.mBtnAbrir.Caption = "Abrir";
            this.mBtnAbrir.Enabled = false;
            this.mBtnAbrir.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnAbrir.Glyph")));
            this.mBtnAbrir.Name = "mBtnAbrir";
            this.mBtnAbrir.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnAbrir_ElementClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 568);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(1159, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 527);
            this.panel2.TabIndex = 31;
            // 
            // gbGridViewUsuario
            // 
            this.gbGridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridViewUsuario.Controls.Add(this.gCFormulario);
            this.gbGridViewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGridViewUsuario.Location = new System.Drawing.Point(152, 64);
            this.gbGridViewUsuario.Name = "gbGridViewUsuario";
            this.gbGridViewUsuario.Size = new System.Drawing.Size(1001, 484);
            this.gbGridViewUsuario.TabIndex = 33;
            this.gbGridViewUsuario.TabStop = false;
            this.gbGridViewUsuario.Text = "Seleccionar Formulario";
            // 
            // gCFormulario
            // 
            this.gCFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCFormulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gCFormulario.BackgroundImage")));
            this.gCFormulario.DataSource = this.spSELECTCategoriaFormularioBindingSource;
            this.gCFormulario.Location = new System.Drawing.Point(3, 30);
            this.gCFormulario.MainView = this.gridView1;
            this.gCFormulario.Name = "gCFormulario";
            this.gCFormulario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UsuarioItemLookUpEdit1});
            this.gCFormulario.Size = new System.Drawing.Size(995, 424);
            this.gCFormulario.TabIndex = 1;
            this.gCFormulario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCFormulario.Click += new System.EventHandler(this.gCFormulario_Click_1);
            // 
            // spSELECTCategoriaFormularioBindingSource
            // 
            this.spSELECTCategoriaFormularioBindingSource.DataMember = "sp_SELECT_Categoria_Formulario";
            this.spSELECTCategoriaFormularioBindingSource.DataSource = this.formulariosCategoria;
            // 
            // formulariosCategoria
            // 
            this.formulariosCategoria.DataSetName = "FormulariosCategoria";
            this.formulariosCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidcategoria,
            this.coldescripcion,
            this.colpertenencia,
            this.colestado});
            this.gridView1.GridControl = this.gCFormulario;
            this.gridView1.GroupPanelText = "Arrastre un encabezado de columna aquí para agrupar por esa columna";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Perfil", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colidcategoria
            // 
            this.colidcategoria.FieldName = "idcategoria";
            this.colidcategoria.Name = "colidcategoria";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colpertenencia
            // 
            this.colpertenencia.FieldName = "pertenencia";
            this.colpertenencia.Name = "colpertenencia";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // UsuarioItemLookUpEdit1
            // 
            this.UsuarioItemLookUpEdit1.AutoHeight = false;
            this.UsuarioItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsuarioItemLookUpEdit1.Name = "UsuarioItemLookUpEdit1";
            this.UsuarioItemLookUpEdit1.NullText = "";
            // 
            // sp_SELECT_Categoria_FormularioTableAdapter
            // 
            this.sp_SELECT_Categoria_FormularioTableAdapter.ClearBeforeFill = true;
            // 
            // frmFormsCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1307, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gbGridViewUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormsCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Usuarios";
            this.Load += new System.EventHandler(this.frmFormsCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.gbGridViewUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSELECTCategoriaFormularioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulariosCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ePError;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnAbrir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbGridViewUsuario;
        private DevExpress.XtraGrid.GridControl gCFormulario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UsuarioItemLookUpEdit1;
        private DataSets.Formulario.FormulariosCategoria formulariosCategoria;
        private System.Windows.Forms.BindingSource spSELECTCategoriaFormularioBindingSource;
        private DataSets.Formulario.FormulariosCategoriaTableAdapters.sp_SELECT_Categoria_FormularioTableAdapter sp_SELECT_Categoria_FormularioTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpertenencia;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}
namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmFiltroProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroProductos));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.mBtnSalir = new DevExpress.XtraBars.Navigation.NavButton();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtNombreProducto);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCliente.Location = new System.Drawing.Point(12, 82);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(638, 71);
            this.gbCliente.TabIndex = 20;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Digite el nombre del Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(19, 28);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(593, 26);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gCProductos);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 285);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // gCProductos
            // 
            this.gCProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCProductos.Location = new System.Drawing.Point(3, 19);
            this.gCProductos.MainView = this.gridView1;
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.Size = new System.Drawing.Size(691, 263);
            this.gCProductos.TabIndex = 0;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCProductos.Click += new System.EventHandler(this.gCProductos_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gCProductos;
            this.gridView1.Name = "gridView1";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileNavPane1.BackgroundImage")));
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
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
            this.tileNavPane1.Size = new System.Drawing.Size(731, 40);
            this.tileNavPane1.TabIndex = 22;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // mBtnSalir
            // 
            this.mBtnSalir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.mBtnSalir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.mBtnSalir.Appearance.Options.UseFont = true;
            this.mBtnSalir.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBtnSalir.AppearanceHovered.Options.UseFont = true;
            this.mBtnSalir.Caption = "Salir";
            this.mBtnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("mBtnSalir.Glyph")));
            this.mBtnSalir.Name = "mBtnSalir";
            this.mBtnSalir.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.mBtnSalir_ElementClick);
            // 
            // frmFiltroProductos
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 505);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFiltroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmFiltroProductos_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton mBtnSalir;
    }
}
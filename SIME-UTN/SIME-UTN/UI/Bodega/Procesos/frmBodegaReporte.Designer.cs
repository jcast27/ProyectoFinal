namespace SIME_UTN.UI.Bodega.Procesos
{
    partial class frmBodegaReporte
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
            this.ePError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnForms = new System.Windows.Forms.Panel();
            this.btnTrasladoUser = new System.Windows.Forms.Button();
            this.btnTrasladoFecha = new System.Windows.Forms.Button();
            this.btnTraslado = new System.Windows.Forms.Button();
            this.btnBodegaN = new System.Windows.Forms.Button();
            this.btnBodega = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).BeginInit();
            this.pnForms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ePError
            // 
            this.ePError.ContainerControl = this;
            // 
            // pnForms
            // 
            this.pnForms.AutoScroll = true;
            this.pnForms.Controls.Add(this.btnTrasladoUser);
            this.pnForms.Controls.Add(this.btnTrasladoFecha);
            this.pnForms.Controls.Add(this.btnTraslado);
            this.pnForms.Controls.Add(this.btnBodegaN);
            this.pnForms.Controls.Add(this.btnBodega);
            this.pnForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForms.Location = new System.Drawing.Point(0, 36);
            this.pnForms.Name = "pnForms";
            this.pnForms.Size = new System.Drawing.Size(889, 524);
            this.pnForms.TabIndex = 0;
            // 
            // btnTrasladoUser
            // 
            this.btnTrasladoUser.BackColor = System.Drawing.Color.Transparent;
            this.btnTrasladoUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrasladoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasladoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnTrasladoUser.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnTrasladoUser.Location = new System.Drawing.Point(656, 15);
            this.btnTrasladoUser.Name = "btnTrasladoUser";
            this.btnTrasladoUser.Size = new System.Drawing.Size(155, 139);
            this.btnTrasladoUser.TabIndex = 4;
            this.btnTrasladoUser.Text = "Traslados por Usuario";
            this.btnTrasladoUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasladoUser.UseVisualStyleBackColor = false;
            this.btnTrasladoUser.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnTrasladoFecha
            // 
            this.btnTrasladoFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnTrasladoFecha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrasladoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasladoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnTrasladoFecha.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnTrasladoFecha.Location = new System.Drawing.Point(495, 15);
            this.btnTrasladoFecha.Name = "btnTrasladoFecha";
            this.btnTrasladoFecha.Size = new System.Drawing.Size(155, 139);
            this.btnTrasladoFecha.TabIndex = 3;
            this.btnTrasladoFecha.Text = "Traslados por Fecha";
            this.btnTrasladoFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasladoFecha.UseVisualStyleBackColor = false;
            this.btnTrasladoFecha.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnTraslado
            // 
            this.btnTraslado.BackColor = System.Drawing.Color.Transparent;
            this.btnTraslado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraslado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnTraslado.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnTraslado.Location = new System.Drawing.Point(334, 15);
            this.btnTraslado.Name = "btnTraslado";
            this.btnTraslado.Size = new System.Drawing.Size(155, 139);
            this.btnTraslado.TabIndex = 2;
            this.btnTraslado.Text = "Traslados";
            this.btnTraslado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTraslado.UseVisualStyleBackColor = false;
            this.btnTraslado.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnBodegaN
            // 
            this.btnBodegaN.BackColor = System.Drawing.Color.Transparent;
            this.btnBodegaN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBodegaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodegaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnBodegaN.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnBodegaN.Location = new System.Drawing.Point(173, 15);
            this.btnBodegaN.Name = "btnBodegaN";
            this.btnBodegaN.Size = new System.Drawing.Size(155, 139);
            this.btnBodegaN.TabIndex = 1;
            this.btnBodegaN.Text = "Bodega Específica";
            this.btnBodegaN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBodegaN.UseVisualStyleBackColor = false;
            this.btnBodegaN.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.BackColor = System.Drawing.Color.Transparent;
            this.btnBodega.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnBodega.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnBodega.Location = new System.Drawing.Point(12, 15);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(155, 139);
            this.btnBodega.TabIndex = 0;
            this.btnBodega.Text = "Bodegas";
            this.btnBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBodega.UseVisualStyleBackColor = false;
            this.btnBodega.Click += new System.EventHandler(this.Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.atrasToolStripMenuItem.Text = "Atrás";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // frmBodegaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(889, 560);
            this.Controls.Add(this.pnForms);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBodegaReporte";
            this.Text = "Ventana Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePError)).EndInit();
            this.pnForms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ePError;
        private System.Windows.Forms.Panel pnForms;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.Button btnBodegaN;
        private System.Windows.Forms.Button btnTraslado;
        private System.Windows.Forms.Button btnTrasladoFecha;
        private System.Windows.Forms.Button btnTrasladoUser;
    }
}
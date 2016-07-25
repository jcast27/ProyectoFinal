namespace SIME_UTN.UI.Reportes
{
    partial class frmFormReporte
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
            this.ePError = new System.Windows.Forms.ErrorProvider();
            this.pnForms = new System.Windows.Forms.Panel();
            this.btnFormularioFecha = new System.Windows.Forms.Button();
            this.btnFormulario = new System.Windows.Forms.Button();
            this.btnActivo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnItem = new System.Windows.Forms.Button();
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
            this.pnForms.Controls.Add(this.btnItem);
            this.pnForms.Controls.Add(this.btnFormularioFecha);
            this.pnForms.Controls.Add(this.btnFormulario);
            this.pnForms.Controls.Add(this.btnActivo);
            this.pnForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForms.Location = new System.Drawing.Point(0, 36);
            this.pnForms.Name = "pnForms";
            this.pnForms.Size = new System.Drawing.Size(789, 524);
            this.pnForms.TabIndex = 0;
            // 
            // btnFormularioFecha
            // 
            this.btnFormularioFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnFormularioFecha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormularioFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormularioFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnFormularioFecha.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnFormularioFecha.Location = new System.Drawing.Point(334, 15);
            this.btnFormularioFecha.Name = "btnFormularioFecha";
            this.btnFormularioFecha.Size = new System.Drawing.Size(155, 139);
            this.btnFormularioFecha.TabIndex = 2;
            this.btnFormularioFecha.Text = "Formularios por Fecha";
            this.btnFormularioFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFormularioFecha.UseVisualStyleBackColor = false;
            this.btnFormularioFecha.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnFormulario
            // 
            this.btnFormulario.BackColor = System.Drawing.Color.Transparent;
            this.btnFormulario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnFormulario.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnFormulario.Location = new System.Drawing.Point(173, 15);
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Size = new System.Drawing.Size(155, 139);
            this.btnFormulario.TabIndex = 1;
            this.btnFormulario.Text = "Formularios";
            this.btnFormulario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFormulario.UseVisualStyleBackColor = false;
            this.btnFormulario.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnActivo
            // 
            this.btnActivo.BackColor = System.Drawing.Color.Transparent;
            this.btnActivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnActivo.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnActivo.Location = new System.Drawing.Point(12, 15);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(155, 139);
            this.btnActivo.TabIndex = 0;
            this.btnActivo.Text = "Activos";
            this.btnActivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActivo.UseVisualStyleBackColor = false;
            this.btnActivo.Click += new System.EventHandler(this.Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 36);
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
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.Transparent;
            this.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.btnItem.Image = global::SIME_UTN.Properties.Resources.Reporte;
            this.btnItem.Location = new System.Drawing.Point(495, 15);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(155, 139);
            this.btnItem.TabIndex = 3;
            this.btnItem.Text = "Utilización de Items";
            this.btnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.Btn_Click);
            // 
            // frmFormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(789, 560);
            this.Controls.Add(this.pnForms);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Items";
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
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.Button btnFormularioFecha;
        private System.Windows.Forms.Button btnItem;
    }
}
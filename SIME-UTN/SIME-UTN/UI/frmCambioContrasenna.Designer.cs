namespace SIME_UTN.UI
{
    partial class frmCambioContrasenna
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContrasennaAntigua = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblContrasennaNueva = new System.Windows.Forms.Label();
            this.txtContrasennaNueva = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenna = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.txtContrasennaAntigua = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SIME_UTN.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblContrasennaAntigua
            // 
            this.lblContrasennaAntigua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasennaAntigua.AutoSize = true;
            this.lblContrasennaAntigua.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasennaAntigua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasennaAntigua.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContrasennaAntigua.Location = new System.Drawing.Point(321, 181);
            this.lblContrasennaAntigua.Name = "lblContrasennaAntigua";
            this.lblContrasennaAntigua.Size = new System.Drawing.Size(160, 18);
            this.lblContrasennaAntigua.TabIndex = 47;
            this.lblContrasennaAntigua.Text = "Contraseña Antigua:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(321, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 18);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.Image = global::SIME_UTN.Properties.Resources.Forward_32x32;
            this.btnIngresar.Location = new System.Drawing.Point(597, 310);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(44, 36);
            this.btnIngresar.TabIndex = 49;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblContrasennaNueva
            // 
            this.lblContrasennaNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasennaNueva.AutoSize = true;
            this.lblContrasennaNueva.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasennaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasennaNueva.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContrasennaNueva.Location = new System.Drawing.Point(321, 239);
            this.lblContrasennaNueva.Name = "lblContrasennaNueva";
            this.lblContrasennaNueva.Size = new System.Drawing.Size(152, 18);
            this.lblContrasennaNueva.TabIndex = 51;
            this.lblContrasennaNueva.Text = "Contraseña Nueva:";
            // 
            // txtContrasennaNueva
            // 
            this.txtContrasennaNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasennaNueva.Location = new System.Drawing.Point(325, 260);
            this.txtContrasennaNueva.Multiline = true;
            this.txtContrasennaNueva.Name = "txtContrasennaNueva";
            this.txtContrasennaNueva.PasswordChar = '*';
            this.txtContrasennaNueva.Size = new System.Drawing.Size(257, 25);
            this.txtContrasennaNueva.TabIndex = 50;
            // 
            // lblConfirmarContrasenna
            // 
            this.lblConfirmarContrasenna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmarContrasenna.AutoSize = true;
            this.lblConfirmarContrasenna.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasenna.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmarContrasenna.Location = new System.Drawing.Point(322, 298);
            this.lblConfirmarContrasenna.Name = "lblConfirmarContrasenna";
            this.lblConfirmarContrasenna.Size = new System.Drawing.Size(180, 18);
            this.lblConfirmarContrasenna.TabIndex = 53;
            this.lblConfirmarContrasenna.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContrasenna
            // 
            this.txtConfirmarContrasenna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarContrasenna.Location = new System.Drawing.Point(324, 319);
            this.txtConfirmarContrasenna.Multiline = true;
            this.txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            this.txtConfirmarContrasenna.PasswordChar = '*';
            this.txtConfirmarContrasenna.Size = new System.Drawing.Size(257, 25);
            this.txtConfirmarContrasenna.TabIndex = 52;
            // 
            // txtContrasennaAntigua
            // 
            this.txtContrasennaAntigua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasennaAntigua.Location = new System.Drawing.Point(325, 202);
            this.txtContrasennaAntigua.Multiline = true;
            this.txtContrasennaAntigua.Name = "txtContrasennaAntigua";
            this.txtContrasennaAntigua.PasswordChar = '*';
            this.txtContrasennaAntigua.Size = new System.Drawing.Size(257, 25);
            this.txtContrasennaAntigua.TabIndex = 54;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(324, 145);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(257, 25);
            this.txtUsuario.TabIndex = 55;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(322, 90);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 25);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Cambiar Contraseña";
            // 
            // frmCambioContrasenna
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 457);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasennaAntigua);
            this.Controls.Add(this.lblConfirmarContrasenna);
            this.Controls.Add(this.txtConfirmarContrasenna);
            this.Controls.Add(this.lblContrasennaNueva);
            this.Controls.Add(this.txtContrasennaNueva);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblContrasennaAntigua);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCambioContrasenna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio De Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContrasennaAntigua;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblConfirmarContrasenna;
        private System.Windows.Forms.TextBox txtConfirmarContrasenna;
        private System.Windows.Forms.Label lblContrasennaNueva;
        private System.Windows.Forms.TextBox txtContrasennaNueva;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasennaAntigua;
        private System.Windows.Forms.Label lblTitulo;
    }
}
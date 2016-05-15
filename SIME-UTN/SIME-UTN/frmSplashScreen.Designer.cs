namespace SIME_UTN
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pBSplashScreen = new System.Windows.Forms.ProgressBar();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.pbUTN = new System.Windows.Forms.PictureBox();
            this.overlyControl21 = new SIME_UTN.OverlyControl2();
            ((System.ComponentModel.ISupportInitialize)(this.pbUTN)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 45;
            this.timer.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // pBSplashScreen
            // 
            this.pBSplashScreen.Location = new System.Drawing.Point(91, 253);
            this.pBSplashScreen.Name = "pBSplashScreen";
            this.pBSplashScreen.Size = new System.Drawing.Size(276, 23);
            this.pBSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBSplashScreen.TabIndex = 0;
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(130, 298);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(154, 31);
            this.lblNombreProyecto.TabIndex = 2;
            this.lblNombreProyecto.Text = "SIME-UTN";
            // 
            // pbUTN
            // 
            this.pbUTN.Image = ((System.Drawing.Image)(resources.GetObject("pbUTN.Image")));
            this.pbUTN.Location = new System.Drawing.Point(107, 36);
            this.pbUTN.Name = "pbUTN";
            this.pbUTN.Size = new System.Drawing.Size(245, 189);
            this.pbUTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUTN.TabIndex = 0;
            this.pbUTN.TabStop = false;
            this.pbUTN.Click += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // overlyControl21
            // 
            this.overlyControl21.Location = new System.Drawing.Point(4, 12);
            this.overlyControl21.Name = "overlyControl21";
            this.overlyControl21.Size = new System.Drawing.Size(473, 331);
            this.overlyControl21.TabIndex = 3;
            this.overlyControl21.Text = "overlyControl21";
            // 
            // frmSplashScreen
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 349);
            this.Controls.Add(this.overlyControl21);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.pBSplashScreen);
            this.Controls.Add(this.pbUTN);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbUTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar pBSplashScreen;
        private System.Windows.Forms.PictureBox pbUTN;
        private System.Windows.Forms.Label lblNombreProyecto;
        private OverlyControl2 overlyControl21;
    }
}
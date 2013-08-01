namespace grafLoader
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_caricamento_programma = new System.Windows.Forms.Label();
            this.lbl_versione_programma = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbl_caricamento_programma
            // 
            this.lbl_caricamento_programma.Location = new System.Drawing.Point(0, 64);
            this.lbl_caricamento_programma.Name = "lbl_caricamento_programma";
            this.lbl_caricamento_programma.Size = new System.Drawing.Size(453, 17);
            this.lbl_caricamento_programma.TabIndex = 2;
            this.lbl_caricamento_programma.Text = "Caricamento del programma: ";
            this.lbl_caricamento_programma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_versione_programma
            // 
            this.lbl_versione_programma.Location = new System.Drawing.Point(0, 81);
            this.lbl_versione_programma.Name = "lbl_versione_programma";
            this.lbl_versione_programma.Size = new System.Drawing.Size(453, 17);
            this.lbl_versione_programma.TabIndex = 4;
            this.lbl_versione_programma.Text = "versione";
            this.lbl_versione_programma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_log
            // 
            this.lbl_log.Location = new System.Drawing.Point(0, 107);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(453, 17);
            this.lbl_log.TabIndex = 5;
            this.lbl_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 61);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::grafLoader.Properties.Resources.FileMove;
            this.pictureBox1.Location = new System.Drawing.Point(90, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(453, 206);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_versione_programma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_caricamento_programma);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiornamento in corso...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_caricamento_programma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_versione_programma;
        private System.Windows.Forms.Label lbl_log;
    }
}


namespace P06InneKontrolki
{
    partial class Form1
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
            this.btnPrzesunKosz = new System.Windows.Forms.Button();
            this.pcKosz = new System.Windows.Forms.PictureBox();
            this.timerSekunda = new System.Windows.Forms.Timer(this.components);
            this.cbHistoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcKosz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrzesunKosz
            // 
            this.btnPrzesunKosz.Location = new System.Drawing.Point(12, 12);
            this.btnPrzesunKosz.Name = "btnPrzesunKosz";
            this.btnPrzesunKosz.Size = new System.Drawing.Size(85, 61);
            this.btnPrzesunKosz.TabIndex = 0;
            this.btnPrzesunKosz.Text = "Start/Stop";
            this.btnPrzesunKosz.UseVisualStyleBackColor = true;
            this.btnPrzesunKosz.Click += new System.EventHandler(this.btnPrzesunKosz_Click);
            // 
            // pcKosz
            // 
            this.pcKosz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcKosz.Image = global::P06InneKontrolki.Properties.Resources._2891491;
            this.pcKosz.Location = new System.Drawing.Point(12, 94);
            this.pcKosz.Name = "pcKosz";
            this.pcKosz.Size = new System.Drawing.Size(85, 85);
            this.pcKosz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcKosz.TabIndex = 1;
            this.pcKosz.TabStop = false;
            this.pcKosz.Click += new System.EventHandler(this.pcKosz_Click);
            this.pcKosz.MouseEnter += new System.EventHandler(this.pcKosz_MouseEnter);
            this.pcKosz.MouseLeave += new System.EventHandler(this.pcKosz_MouseLeave);
            this.pcKosz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcKosz_MouseMove);
            // 
            // timerSekunda
            // 
            this.timerSekunda.Interval = 1000;
            this.timerSekunda.Tick += new System.EventHandler(this.timerSekunda_Tick);
            // 
            // cbHistoria
            // 
            this.cbHistoria.FormattingEnabled = true;
            this.cbHistoria.Items.AddRange(new object[] {
            "Raz",
            "Dwa",
            "Trzy"});
            this.cbHistoria.Location = new System.Drawing.Point(217, 94);
            this.cbHistoria.Name = "cbHistoria";
            this.cbHistoria.Size = new System.Drawing.Size(197, 21);
            this.cbHistoria.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHistoria);
            this.Controls.Add(this.pcKosz);
            this.Controls.Add(this.btnPrzesunKosz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcKosz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrzesunKosz;
        private System.Windows.Forms.PictureBox pcKosz;
        private System.Windows.Forms.Timer timerSekunda;
        private System.Windows.Forms.ComboBox cbHistoria;
    }
}


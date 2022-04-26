namespace P07ZadaniePogoda
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
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pcObrazek = new System.Windows.Forms.PictureBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.rbCelcujesz = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFarenheit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 35);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(185, 21);
            this.cbMiasta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz miasto";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 34);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(41, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pcObrazek
            // 
            this.pcObrazek.Location = new System.Drawing.Point(102, 90);
            this.pcObrazek.Name = "pcObrazek";
            this.pcObrazek.Size = new System.Drawing.Size(49, 35);
            this.pcObrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcObrazek.TabIndex = 3;
            this.pcObrazek.TabStop = false;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatura.Location = new System.Drawing.Point(12, 59);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 29);
            this.lblTemperatura.TabIndex = 4;
            // 
            // rbCelcujesz
            // 
            this.rbCelcujesz.AutoSize = true;
            this.rbCelcujesz.Checked = true;
            this.rbCelcujesz.Location = new System.Drawing.Point(168, 62);
            this.rbCelcujesz.Name = "rbCelcujesz";
            this.rbCelcujesz.Size = new System.Drawing.Size(70, 17);
            this.rbCelcujesz.TabIndex = 5;
            this.rbCelcujesz.TabStop = true;
            this.rbCelcujesz.Text = "Celcujesz";
            this.rbCelcujesz.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(168, 85);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 6;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFarenheit
            // 
            this.rbFarenheit.AutoSize = true;
            this.rbFarenheit.Location = new System.Drawing.Point(168, 108);
            this.rbFarenheit.Name = "rbFarenheit";
            this.rbFarenheit.Size = new System.Drawing.Size(69, 17);
            this.rbFarenheit.TabIndex = 7;
            this.rbFarenheit.TabStop = true;
            this.rbFarenheit.Text = "Farenheit";
            this.rbFarenheit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 132);
            this.Controls.Add(this.rbFarenheit);
            this.Controls.Add(this.rbKelvin);
            this.Controls.Add(this.rbCelcujesz);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.pcObrazek);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pcObrazek;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.RadioButton rbCelcujesz;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFarenheit;
    }
}


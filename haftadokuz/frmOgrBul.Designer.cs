namespace haftadokuz
{
    partial class frmOgrBul
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
            this.grbogrencibul = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblnumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.grbogrencibul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbogrencibul
            // 
            this.grbogrencibul.Controls.Add(this.btnAra);
            this.grbogrencibul.Controls.Add(this.txtNumara);
            this.grbogrencibul.Controls.Add(this.lblnumara);
            this.grbogrencibul.Location = new System.Drawing.Point(12, 12);
            this.grbogrencibul.Name = "grbogrencibul";
            this.grbogrencibul.Size = new System.Drawing.Size(243, 253);
            this.grbogrencibul.TabIndex = 0;
            this.grbogrencibul.TabStop = false;
            this.grbogrencibul.Text = "Ögrenci Bulma Ekranı";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(38, 54);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(122, 13);
            this.lblnumara.TabIndex = 0;
            this.lblnumara.Text = "Öğrenci Numarası Giriniz";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(51, 78);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(88, 20);
            this.txtNumara.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(56, 111);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 32);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 277);
            this.Controls.Add(this.grbogrencibul);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.grbogrencibul.ResumeLayout(false);
            this.grbogrencibul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbogrencibul;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblnumara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
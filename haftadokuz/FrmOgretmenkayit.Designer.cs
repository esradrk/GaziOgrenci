namespace haftadokuz
{
    partial class FrmOgretmenkayit
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
            this.ogretmenkayıt = new System.Windows.Forms.GroupBox();
            this.txtogrtc = new System.Windows.Forms.TextBox();
            this.txtogrsoyad = new System.Windows.Forms.TextBox();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblogrsoyad = new System.Windows.Forms.Label();
            this.lblograd = new System.Windows.Forms.Label();
            this.ogrkaydet = new System.Windows.Forms.Button();
            this.ogretmenkayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogretmenkayıt
            // 
            this.ogretmenkayıt.Controls.Add(this.txtogrtc);
            this.ogretmenkayıt.Controls.Add(this.txtogrsoyad);
            this.ogretmenkayıt.Controls.Add(this.txtograd);
            this.ogretmenkayıt.Controls.Add(this.lbltc);
            this.ogretmenkayıt.Controls.Add(this.lblogrsoyad);
            this.ogretmenkayıt.Controls.Add(this.lblograd);
            this.ogretmenkayıt.Location = new System.Drawing.Point(27, 28);
            this.ogretmenkayıt.Name = "ogretmenkayıt";
            this.ogretmenkayıt.Size = new System.Drawing.Size(304, 227);
            this.ogretmenkayıt.TabIndex = 0;
            this.ogretmenkayıt.TabStop = false;
            this.ogretmenkayıt.Text = "Öğretmen Kayıt";
            // 
            // txtogrtc
            // 
            this.txtogrtc.Location = new System.Drawing.Point(71, 163);
            this.txtogrtc.Name = "txtogrtc";
            this.txtogrtc.Size = new System.Drawing.Size(127, 20);
            this.txtogrtc.TabIndex = 5;
            // 
            // txtogrsoyad
            // 
            this.txtogrsoyad.Location = new System.Drawing.Point(71, 100);
            this.txtogrsoyad.Name = "txtogrsoyad";
            this.txtogrsoyad.Size = new System.Drawing.Size(127, 20);
            this.txtogrsoyad.TabIndex = 4;
            // 
            // txtograd
            // 
            this.txtograd.Location = new System.Drawing.Point(71, 46);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(127, 20);
            this.txtograd.TabIndex = 3;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(11, 163);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(21, 13);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "TC";
            // 
            // lblogrsoyad
            // 
            this.lblogrsoyad.AutoSize = true;
            this.lblogrsoyad.Location = new System.Drawing.Point(10, 100);
            this.lblogrsoyad.Name = "lblogrsoyad";
            this.lblogrsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblogrsoyad.TabIndex = 1;
            this.lblogrsoyad.Text = "Soyad";
            // 
            // lblograd
            // 
            this.lblograd.AutoSize = true;
            this.lblograd.Location = new System.Drawing.Point(11, 46);
            this.lblograd.Name = "lblograd";
            this.lblograd.Size = new System.Drawing.Size(20, 13);
            this.lblograd.TabIndex = 0;
            this.lblograd.Text = "Ad";
            // 
            // ogrkaydet
            // 
            this.ogrkaydet.Location = new System.Drawing.Point(73, 272);
            this.ogrkaydet.Name = "ogrkaydet";
            this.ogrkaydet.Size = new System.Drawing.Size(84, 37);
            this.ogrkaydet.TabIndex = 6;
            this.ogrkaydet.Text = "EKLE";
            this.ogrkaydet.UseVisualStyleBackColor = true;
            this.ogrkaydet.Click += new System.EventHandler(this.ogrkaydet_Click);
            // 
            // FrmOgretmenkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 321);
            this.Controls.Add(this.ogrkaydet);
            this.Controls.Add(this.ogretmenkayıt);
            this.Name = "FrmOgretmenkayit";
            this.Text = "FrmOgretmenkayit";
            this.ogretmenkayıt.ResumeLayout(false);
            this.ogretmenkayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogretmenkayıt;
        private System.Windows.Forms.TextBox txtogrtc;
        private System.Windows.Forms.TextBox txtogrsoyad;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblogrsoyad;
        private System.Windows.Forms.Label lblograd;
        private System.Windows.Forms.Button ogrkaydet;
    }
}
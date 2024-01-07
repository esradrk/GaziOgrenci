namespace haftadokuz
{
    partial class frmOgnKayit
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
            this.grpogrenci = new System.Windows.Forms.GroupBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.grpogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpogrenci
            // 
            this.grpogrenci.Controls.Add(this.txtno);
            this.grpogrenci.Controls.Add(this.txtsoyad);
            this.grpogrenci.Controls.Add(this.txtad);
            this.grpogrenci.Controls.Add(this.lblno);
            this.grpogrenci.Controls.Add(this.lblsoyad);
            this.grpogrenci.Controls.Add(this.lblad);
            this.grpogrenci.Location = new System.Drawing.Point(47, 27);
            this.grpogrenci.Name = "grpogrenci";
            this.grpogrenci.Size = new System.Drawing.Size(220, 150);
            this.grpogrenci.TabIndex = 0;
            this.grpogrenci.TabStop = false;
            this.grpogrenci.Text = "Öğrenci Bilgileri";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(82, 113);
            this.txtno.MaxLength = 15;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(82, 62);
            this.txtsoyad.MaxLength = 30;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(82, 23);
            this.txtad.MaxLength = 20;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 3;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(11, 116);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(44, 13);
            this.lblno.TabIndex = 2;
            this.lblno.Text = "Numara";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(11, 65);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(11, 23);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(20, 13);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Ad";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(102, 183);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(104, 36);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(273, 36);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(61, 39);
            this.btnbul.TabIndex = 7;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // btnsil
            // 
            this.btnsil.Enabled = false;
            this.btnsil.Location = new System.Drawing.Point(273, 85);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(61, 36);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Enabled = false;
            this.btnguncelle.Location = new System.Drawing.Point(274, 132);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(76, 45);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "GUNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // frmOgnKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 283);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.grpogrenci);
            this.Name = "frmOgnKayit";
            this.Text = "Öğrenci Kayıt İşlemleri";
            this.grpogrenci.ResumeLayout(false);
            this.grpogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpogrenci;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        public System.Windows.Forms.TextBox txtno;
        public System.Windows.Forms.TextBox txtsoyad;
        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.Button btnkaydet;
        public System.Windows.Forms.Button btnbul;
        public System.Windows.Forms.Button btnsil;
        public System.Windows.Forms.Button btnguncelle;
    }
}


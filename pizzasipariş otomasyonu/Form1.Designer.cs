namespace pizzasipariş_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsiptam = new System.Windows.Forms.Button();
            this.lblpizsec = new System.Windows.Forms.Label();
            this.lbladet = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Label();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.lblmussec = new System.Windows.Forms.Label();
            this.lvSiparis = new System.Windows.Forms.ListView();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.Siparişler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(224, 151);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(162, 26);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(235, 422);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(135, 38);
            this.btnMusteriKaydet.TabIndex = 1;
            this.btnMusteriKaydet.Text = "Müşteri Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(224, 322);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(224, 265);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(162, 26);
            this.txtAdres.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(224, 208);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(162, 26);
            this.txtTelefon.TabIndex = 4;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(125, 151);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(93, 20);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "AD SOYAD";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(142, 329);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "EMAİL";
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Location = new System.Drawing.Point(138, 272);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(66, 20);
            this.lbladres.TabIndex = 7;
            this.lbladres.Text = "ADRES";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(130, 209);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(82, 20);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "TELEFON";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::pizzasipariş_otomasyonu.Properties.Resources.pizza;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 174);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnsiptam
            // 
            this.btnsiptam.BackColor = System.Drawing.Color.Red;
            this.btnsiptam.ForeColor = System.Drawing.Color.White;
            this.btnsiptam.Location = new System.Drawing.Point(1328, 329);
            this.btnsiptam.Name = "btnsiptam";
            this.btnsiptam.Size = new System.Drawing.Size(153, 39);
            this.btnsiptam.TabIndex = 19;
            this.btnsiptam.Text = "Siparişi tamamla";
            this.btnsiptam.UseVisualStyleBackColor = false;
            this.btnsiptam.Click += new System.EventHandler(this.btnsiptam_Click);
            // 
            // lblpizsec
            // 
            this.lblpizsec.AutoSize = true;
            this.lblpizsec.Location = new System.Drawing.Point(857, 221);
            this.lblpizsec.Name = "lblpizsec";
            this.lblpizsec.Size = new System.Drawing.Size(115, 20);
            this.lblpizsec.TabIndex = 18;
            this.lblpizsec.Text = "PİZZA SEÇİMİ";
            // 
            // lbladet
            // 
            this.lbladet.AutoSize = true;
            this.lbladet.Location = new System.Drawing.Point(888, 268);
            this.lbladet.Name = "lbladet";
            this.lbladet.Size = new System.Drawing.Size(52, 20);
            this.lbladet.TabIndex = 17;
            this.lbladet.Text = "ADET";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.AutoSize = true;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(1311, 163);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(192, 20);
            this.btnSiparisTamamla.TabIndex = 16;
            this.btnSiparisTamamla.Text = "Eklenen Siparişleri Göster";
            // 
            // cmbPizza
            // 
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(1013, 221);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(154, 28);
            this.cmbPizza.TabIndex = 15;
            // 
            // lblmussec
            // 
            this.lblmussec.AutoSize = true;
            this.lblmussec.Location = new System.Drawing.Point(843, 171);
            this.lblmussec.Name = "lblmussec";
            this.lblmussec.Size = new System.Drawing.Size(142, 20);
            this.lblmussec.TabIndex = 14;
            this.lblmussec.Text = "MÜŞTERİ SEÇİMİ";
            // 
            // lvSiparis
            // 
            this.lvSiparis.HideSelection = false;
            this.lvSiparis.Location = new System.Drawing.Point(1303, 191);
            this.lvSiparis.Name = "lvSiparis";
            this.lvSiparis.Size = new System.Drawing.Size(200, 97);
            this.lvSiparis.TabIndex = 13;
            this.lvSiparis.UseCompatibleStateImageBehavior = false;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.Red;
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.Location = new System.Drawing.Point(1029, 329);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(110, 39);
            this.btnSiparisEkle.TabIndex = 12;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(1013, 268);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(154, 26);
            this.nudAdet.TabIndex = 11;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(1013, 167);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(154, 28);
            this.cmbMusteri.TabIndex = 10;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(1013, 465);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 62;
            this.dgvSiparisler.RowTemplate.Height = 28;
            this.dgvSiparisler.Size = new System.Drawing.Size(548, 148);
            this.dgvSiparisler.TabIndex = 20;
            // 
            // Siparişler
            // 
            this.Siparişler.AutoSize = true;
            this.Siparişler.Location = new System.Drawing.Point(1025, 442);
            this.Siparişler.Name = "Siparişler";
            this.Siparişler.Size = new System.Drawing.Size(74, 20);
            this.Siparişler.TabIndex = 21;
            this.Siparişler.Text = "Siparişler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1827, 852);
            this.Controls.Add(this.Siparişler);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.btnsiptam);
            this.Controls.Add(this.lblpizsec);
            this.Controls.Add(this.lbladet);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.lblmussec);
            this.Controls.Add(this.lvSiparis);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnMusteriKaydet);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "Form1";
            this.Text = "pizza sipariş sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsiptam;
        private System.Windows.Forms.Label lblpizsec;
        private System.Windows.Forms.Label lbladet;
        private System.Windows.Forms.Label btnSiparisTamamla;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label lblmussec;
        private System.Windows.Forms.ListView lvSiparis;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label Siparişler;
    }
}


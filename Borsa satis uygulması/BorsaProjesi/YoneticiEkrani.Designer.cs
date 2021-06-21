namespace BorsaProjesi
{
    partial class YoneticiEkrani
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
            this.Kullanicilar = new System.Windows.Forms.ListBox();
            this.btnBakiyeOnay = new System.Windows.Forms.Button();
            this.urunTalebi = new System.Windows.Forms.ListBox();
            this.labelBakiyetalep = new System.Windows.Forms.Label();
            this.lbltalep = new System.Windows.Forms.Label();
            this.labeluruntalepleri = new System.Windows.Forms.Label();
            this.btnTalep = new System.Windows.Forms.Button();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.btnDovizGuncelle = new System.Windows.Forms.Button();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Kullanicilar
            // 
            this.Kullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanicilar.ForeColor = System.Drawing.Color.Maroon;
            this.Kullanicilar.FormattingEnabled = true;
            this.Kullanicilar.ItemHeight = 20;
            this.Kullanicilar.Location = new System.Drawing.Point(13, 58);
            this.Kullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanicilar.Name = "Kullanicilar";
            this.Kullanicilar.Size = new System.Drawing.Size(413, 224);
            this.Kullanicilar.TabIndex = 0;
            this.Kullanicilar.SelectedIndexChanged += new System.EventHandler(this.listKullanicilar_SelectedIndexChanged);
            // 
            // btnBakiyeOnay
            // 
            this.btnBakiyeOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiyeOnay.ForeColor = System.Drawing.Color.Maroon;
            this.btnBakiyeOnay.Location = new System.Drawing.Point(234, 324);
            this.btnBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnBakiyeOnay.Name = "btnBakiyeOnay";
            this.btnBakiyeOnay.Size = new System.Drawing.Size(192, 37);
            this.btnBakiyeOnay.TabIndex = 1;
            this.btnBakiyeOnay.Text = "Bakiyeyi Onayla";
            this.btnBakiyeOnay.UseVisualStyleBackColor = true;
            this.btnBakiyeOnay.Click += new System.EventHandler(this.btnBakiyeOnay_Click);
            // 
            // urunTalebi
            // 
            this.urunTalebi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunTalebi.ForeColor = System.Drawing.Color.DarkRed;
            this.urunTalebi.FormattingEnabled = true;
            this.urunTalebi.ItemHeight = 20;
            this.urunTalebi.Location = new System.Drawing.Point(513, 58);
            this.urunTalebi.Margin = new System.Windows.Forms.Padding(4);
            this.urunTalebi.Name = "urunTalebi";
            this.urunTalebi.Size = new System.Drawing.Size(655, 224);
            this.urunTalebi.TabIndex = 0;
            // 
            // labelBakiyetalep
            // 
            this.labelBakiyetalep.AutoSize = true;
            this.labelBakiyetalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBakiyetalep.ForeColor = System.Drawing.Color.Maroon;
            this.labelBakiyetalep.Location = new System.Drawing.Point(-3, 330);
            this.labelBakiyetalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBakiyetalep.Name = "labelBakiyetalep";
            this.labelBakiyetalep.Size = new System.Drawing.Size(156, 20);
            this.labelBakiyetalep.TabIndex = 2;
            this.labelBakiyetalep.Text = "Talep edileb bakiye:";
            // 
            // lbltalep
            // 
            this.lbltalep.AutoSize = true;
            this.lbltalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltalep.ForeColor = System.Drawing.Color.Maroon;
            this.lbltalep.Location = new System.Drawing.Point(175, 332);
            this.lbltalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltalep.Name = "lbltalep";
            this.lbltalep.Size = new System.Drawing.Size(38, 20);
            this.lbltalep.TabIndex = 2;
            this.lbltalep.Text = "0TL";
            this.lbltalep.Click += new System.EventHandler(this.lbltalep_Click);
            // 
            // labeluruntalepleri
            // 
            this.labeluruntalepleri.AutoSize = true;
            this.labeluruntalepleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeluruntalepleri.ForeColor = System.Drawing.Color.Black;
            this.labeluruntalepleri.Location = new System.Drawing.Point(508, 19);
            this.labeluruntalepleri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluruntalepleri.Name = "labeluruntalepleri";
            this.labeluruntalepleri.Size = new System.Drawing.Size(250, 29);
            this.labeluruntalepleri.TabIndex = 2;
            this.labeluruntalepleri.Text = "Talep edilen ürünler";
            // 
            // btnTalep
            // 
            this.btnTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalep.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTalep.Location = new System.Drawing.Point(503, 322);
            this.btnTalep.Margin = new System.Windows.Forms.Padding(4);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(401, 39);
            this.btnTalep.TabIndex = 1;
            this.btnTalep.Text = "Talepleri Onayla";
            this.btnTalep.UseVisualStyleBackColor = true;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanicilar.ForeColor = System.Drawing.Color.Black;
            this.lblKullanicilar.Location = new System.Drawing.Point(13, 19);
            this.lblKullanicilar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(217, 32);
            this.lblKullanicilar.TabIndex = 2;
            this.lblKullanicilar.Text = "Kullacı bilgileri";
            // 
            // btnIslemler
            // 
            this.btnIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIslemler.Location = new System.Drawing.Point(942, 320);
            this.btnIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(192, 41);
            this.btnIslemler.TabIndex = 1;
            this.btnIslemler.Text = "İşlemler";
            this.btnIslemler.UseVisualStyleBackColor = true;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // btnDovizGuncelle
            // 
            this.btnDovizGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDovizGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btnDovizGuncelle.Location = new System.Drawing.Point(13, 448);
            this.btnDovizGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDovizGuncelle.Name = "btnDovizGuncelle";
            this.btnDovizGuncelle.Size = new System.Drawing.Size(257, 34);
            this.btnDovizGuncelle.TabIndex = 1;
            this.btnDovizGuncelle.Text = " Döviz Tarihini Güncelle";
            this.btnDovizGuncelle.UseVisualStyleBackColor = true;
            this.btnDovizGuncelle.Click += new System.EventHandler(this.btnDovizGuncelle_Click);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeTarih.Location = new System.Drawing.Point(13, 404);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(257, 27);
            this.dateTimeTarih.TabIndex = 3;
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1183, 529);
            this.Controls.Add(this.dateTimeTarih);
            this.Controls.Add(this.lbltalep);
            this.Controls.Add(this.labeluruntalepleri);
            this.Controls.Add(this.lblKullanicilar);
            this.Controls.Add(this.labelBakiyetalep);
            this.Controls.Add(this.btnDovizGuncelle);
            this.Controls.Add(this.btnTalep);
            this.Controls.Add(this.btnIslemler);
            this.Controls.Add(this.btnBakiyeOnay);
            this.Controls.Add(this.urunTalebi);
            this.Controls.Add(this.Kullanicilar);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiEkrani_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Kullanicilar;
        private System.Windows.Forms.Button btnBakiyeOnay;
        private System.Windows.Forms.ListBox urunTalebi;
        private System.Windows.Forms.Label labelBakiyetalep;
        private System.Windows.Forms.Label lbltalep;
        private System.Windows.Forms.Label labeluruntalepleri;
        private System.Windows.Forms.Button btnTalep;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.Button btnDovizGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
    }
}
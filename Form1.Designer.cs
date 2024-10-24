namespace EBA_Kargo_Takip
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxTakipNo;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonTakip;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelEmailPlaceholder;
        private System.Windows.Forms.Label labelSifrePlaceholder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTakipNo = new System.Windows.Forms.TextBox();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonTakip = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelEmailPlaceholder = new System.Windows.Forms.Label();
            this.labelSifrePlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Panel header
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.Controls.Add(this.labelHeader);

            // labelHeader
            this.labelHeader.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Text = "Kargo EBA Yönetim Paneli";
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Textbox Email
            this.textBoxEmail.Location = new System.Drawing.Point(100, 120);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 30);
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F);

            // labelEmailPlaceholder
            this.labelEmailPlaceholder.Text = "E-posta adresinizi girin";
            this.labelEmailPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.labelEmailPlaceholder.Location = new System.Drawing.Point(100, 100);
            this.labelEmailPlaceholder.AutoSize = true;

            // Textbox Sifre
            this.textBoxSifre.Location = new System.Drawing.Point(100, 170);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(300, 30);
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 12F);

            // labelSifrePlaceholder
            this.labelSifrePlaceholder.Text = "Şifrenizi girin";
            this.labelSifrePlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.labelSifrePlaceholder.Location = new System.Drawing.Point(100, 150);
            this.labelSifrePlaceholder.AutoSize = true;

            // TextBox Ad
            this.textBoxAd.Location = new System.Drawing.Point(100, 220);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(300, 30);
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI", 12F);

            // TextBox Soyad
            this.textBoxSoyad.Location = new System.Drawing.Point(100, 270);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(300, 30);
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI", 12F);

            // TextBox Takip No
            this.textBoxTakipNo.Location = new System.Drawing.Point(100, 320);
            this.textBoxTakipNo.Name = "textBoxTakipNo";
            this.textBoxTakipNo.Size = new System.Drawing.Size(300, 30);
            this.textBoxTakipNo.Font = new System.Drawing.Font("Segoe UI", 12F);

            // Button Kayıt Ol
            this.buttonKayitOl.Location = new System.Drawing.Point(100, 400);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(100, 40);
            this.buttonKayitOl.Text = "Kayıt Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonKayitOl.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonKayitOl.ForeColor = System.Drawing.Color.White;

            // Button Giriş Yap
            this.buttonGirisYap.Location = new System.Drawing.Point(210, 400);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(100, 40);
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonGirisYap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonGirisYap.ForeColor = System.Drawing.Color.White;

            // Button Takip
            this.buttonTakip.Location = new System.Drawing.Point(320, 400);
            this.buttonTakip.Name = "buttonTakip";
            this.buttonTakip.Size = new System.Drawing.Size(100, 40);
            this.buttonTakip.Text = "Kargo Takip";
            this.buttonTakip.UseVisualStyleBackColor = true;
            this.buttonTakip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonTakip.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonTakip.ForeColor = System.Drawing.Color.White;

            // Button Güncelle
            this.buttonGuncelle.Location = new System.Drawing.Point(430, 400);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(100, 40);
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonGuncelle.BackColor = System.Drawing.Color.DimGray;
            this.buttonGuncelle.ForeColor = System.Drawing.Color.White;

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmailPlaceholder);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.labelSifrePlaceholder);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxTakipNo);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.buttonTakip);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Kargo Takip Yönetim Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

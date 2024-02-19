
namespace SSISYonetim
{
    partial class frmYeniSSISEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKurumNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalismaSekli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHaftaninGunleri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAyinGunleri = new System.Windows.Forms.TextBox();
            this.txtTekrarlamaSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaslamaSaati = new System.Windows.Forms.TextBox();
            this.txtOncelik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYilinOzelGunleri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYilinGunleri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAyinOzelGunleri = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKayitKullanıci = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKontroller = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTekrarlamaDakika = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSSISAdi = new System.Windows.Forms.CheckBox();
            this.dtDuzenlemeZamani = new System.Windows.Forms.DateTimePicker();
            this.chkGuncelle = new System.Windows.Forms.CheckBox();
            this.dtKayitZamani = new System.Windows.Forms.DateTimePicker();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSSISListeGetir = new System.Windows.Forms.Button();
            this.btnSSISEkle = new System.Windows.Forms.Button();
            this.lblDuzenleyenKullanici = new System.Windows.Forms.Label();
            this.txtRaporAdi = new System.Windows.Forms.TextBox();
            this.txtDuzenleyenKullanici = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblDuzenlemeZamani = new System.Windows.Forms.Label();
            this.txtKullanilanDosya = new System.Windows.Forms.TextBox();
            this.txtKullanilanTablolar = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtKullanilanDB = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSSIS = new System.Windows.Forms.DataGridView();
            this.epHataDedektoru = new System.Windows.Forms.ErrorProvider(this.components);
            this.menusag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menusSecilenKaydiSifirla = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).BeginInit();
            this.menusag.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(80, 6);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(80, 23);
            this.txtDurum.TabIndex = 1;
            this.txtDurum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDurum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kurum No";
            // 
            // txtKurumNo
            // 
            this.txtKurumNo.Location = new System.Drawing.Point(80, 35);
            this.txtKurumNo.Name = "txtKurumNo";
            this.txtKurumNo.Size = new System.Drawing.Size(80, 23);
            this.txtKurumNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(80, 23);
            this.txtAd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çalışma\r\nŞekli";
            // 
            // txtCalismaSekli
            // 
            this.txtCalismaSekli.Location = new System.Drawing.Point(80, 98);
            this.txtCalismaSekli.Name = "txtCalismaSekli";
            this.txtCalismaSekli.Size = new System.Drawing.Size(80, 23);
            this.txtCalismaSekli.TabIndex = 7;
            this.txtCalismaSekli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalismaSekli_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Haftanın \r\nGünleri";
            // 
            // txtHaftaninGunleri
            // 
            this.txtHaftaninGunleri.Location = new System.Drawing.Point(80, 137);
            this.txtHaftaninGunleri.Name = "txtHaftaninGunleri";
            this.txtHaftaninGunleri.Size = new System.Drawing.Size(80, 23);
            this.txtHaftaninGunleri.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ayın \r\nGünleri";
            // 
            // txtAyinGunleri
            // 
            this.txtAyinGunleri.Location = new System.Drawing.Point(80, 171);
            this.txtAyinGunleri.Name = "txtAyinGunleri";
            this.txtAyinGunleri.Size = new System.Drawing.Size(80, 23);
            this.txtAyinGunleri.TabIndex = 10;
            this.txtAyinGunleri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyinGunleri_KeyPress);
            // 
            // txtTekrarlamaSayisi
            // 
            this.txtTekrarlamaSayisi.Location = new System.Drawing.Point(80, 395);
            this.txtTekrarlamaSayisi.Name = "txtTekrarlamaSayisi";
            this.txtTekrarlamaSayisi.Size = new System.Drawing.Size(80, 23);
            this.txtTekrarlamaSayisi.TabIndex = 22;
            this.txtTekrarlamaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTekrarlamaSayisi_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tekrarlama\r\nSayısı";
            // 
            // txtBaslamaSaati
            // 
            this.txtBaslamaSaati.Location = new System.Drawing.Point(80, 354);
            this.txtBaslamaSaati.Name = "txtBaslamaSaati";
            this.txtBaslamaSaati.Size = new System.Drawing.Size(80, 23);
            this.txtBaslamaSaati.TabIndex = 20;
            // 
            // txtOncelik
            // 
            this.txtOncelik.Location = new System.Drawing.Point(80, 318);
            this.txtOncelik.Name = "txtOncelik";
            this.txtOncelik.Size = new System.Drawing.Size(80, 23);
            this.txtOncelik.TabIndex = 19;
            this.txtOncelik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOncelik_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Başlama\r\nSaati";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Öncelik";
            // 
            // txtYilinOzelGunleri
            // 
            this.txtYilinOzelGunleri.Location = new System.Drawing.Point(80, 277);
            this.txtYilinOzelGunleri.Name = "txtYilinOzelGunleri";
            this.txtYilinOzelGunleri.Size = new System.Drawing.Size(80, 23);
            this.txtYilinOzelGunleri.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "Yılın Özel\r\nGünleri";
            // 
            // txtYilinGunleri
            // 
            this.txtYilinGunleri.Location = new System.Drawing.Point(80, 245);
            this.txtYilinGunleri.Name = "txtYilinGunleri";
            this.txtYilinGunleri.Size = new System.Drawing.Size(80, 23);
            this.txtYilinGunleri.TabIndex = 14;
            this.txtYilinGunleri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYilinGunleri_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "Yılın\r\nGünleri";
            // 
            // txtAyinOzelGunleri
            // 
            this.txtAyinOzelGunleri.Location = new System.Drawing.Point(80, 211);
            this.txtAyinOzelGunleri.Name = "txtAyinOzelGunleri";
            this.txtAyinOzelGunleri.Size = new System.Drawing.Size(80, 23);
            this.txtAyinOzelGunleri.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 30);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ayın Özel\r\nGünleri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 30);
            this.label13.TabIndex = 33;
            this.label13.Text = "Kayıt\r\nZamanı";
            // 
            // txtKayitKullanıci
            // 
            this.txtKayitKullanıci.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKayitKullanıci.Location = new System.Drawing.Point(80, 530);
            this.txtKayitKullanıci.Name = "txtKayitKullanıci";
            this.txtKayitKullanıci.PlaceholderText = "isim.soyisim";
            this.txtKayitKullanıci.Size = new System.Drawing.Size(80, 23);
            this.txtKayitKullanıci.TabIndex = 32;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(80, 494);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(80, 23);
            this.txtAciklama.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 30);
            this.label14.TabIndex = 29;
            this.label14.Text = "Kayıt\r\nKullanıcı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Açıklama";
            // 
            // txtKontroller
            // 
            this.txtKontroller.Location = new System.Drawing.Point(80, 464);
            this.txtKontroller.Name = "txtKontroller";
            this.txtKontroller.Size = new System.Drawing.Size(80, 23);
            this.txtKontroller.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 472);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Kontroller";
            // 
            // txtTekrarlamaDakika
            // 
            this.txtTekrarlamaDakika.Location = new System.Drawing.Point(80, 428);
            this.txtTekrarlamaDakika.Name = "txtTekrarlamaDakika";
            this.txtTekrarlamaDakika.Size = new System.Drawing.Size(80, 23);
            this.txtTekrarlamaDakika.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 428);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 30);
            this.label18.TabIndex = 23;
            this.label18.Text = "Tekrarlama\r\nDakika";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSSISAdi);
            this.panel1.Controls.Add(this.dtDuzenlemeZamani);
            this.panel1.Controls.Add(this.chkGuncelle);
            this.panel1.Controls.Add(this.dtKayitZamani);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnSSISListeGetir);
            this.panel1.Controls.Add(this.btnSSISEkle);
            this.panel1.Controls.Add(this.lblDuzenleyenKullanici);
            this.panel1.Controls.Add(this.txtRaporAdi);
            this.panel1.Controls.Add(this.txtDuzenleyenKullanici);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.lblDuzenlemeZamani);
            this.panel1.Controls.Add(this.txtKullanilanDosya);
            this.panel1.Controls.Add(this.txtKullanilanTablolar);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtKullanilanDB);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDurum);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKayitKullanıci);
            this.panel1.Controls.Add(this.txtKurumNo);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtKontroller);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtCalismaSekli);
            this.panel1.Controls.Add(this.txtHaftaninGunleri);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTekrarlamaDakika);
            this.panel1.Controls.Add(this.txtAyinGunleri);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtTekrarlamaSayisi);
            this.panel1.Controls.Add(this.txtAyinOzelGunleri);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBaslamaSaati);
            this.panel1.Controls.Add(this.txtYilinGunleri);
            this.panel1.Controls.Add(this.txtOncelik);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtYilinOzelGunleri);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 625);
            this.panel1.TabIndex = 35;
            // 
            // chkSSISAdi
            // 
            this.chkSSISAdi.AutoSize = true;
            this.chkSSISAdi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSSISAdi.Location = new System.Drawing.Point(240, 185);
            this.chkSSISAdi.Name = "chkSSISAdi";
            this.chkSSISAdi.Size = new System.Drawing.Size(89, 19);
            this.chkSSISAdi.TabIndex = 53;
            this.chkSSISAdi.Text = "SSIS Adı Ara";
            this.chkSSISAdi.UseVisualStyleBackColor = true;
            // 
            // dtDuzenlemeZamani
            // 
            this.dtDuzenlemeZamani.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtDuzenlemeZamani.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDuzenlemeZamani.Location = new System.Drawing.Point(246, 472);
            this.dtDuzenlemeZamani.MinDate = new System.DateTime(1987, 7, 12, 0, 0, 0, 0);
            this.dtDuzenlemeZamani.Name = "dtDuzenlemeZamani";
            this.dtDuzenlemeZamani.ShowUpDown = true;
            this.dtDuzenlemeZamani.Size = new System.Drawing.Size(110, 23);
            this.dtDuzenlemeZamani.TabIndex = 52;
            this.dtDuzenlemeZamani.Visible = false;
            // 
            // chkGuncelle
            // 
            this.chkGuncelle.AutoSize = true;
            this.chkGuncelle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGuncelle.Location = new System.Drawing.Point(205, 326);
            this.chkGuncelle.Name = "chkGuncelle";
            this.chkGuncelle.Size = new System.Drawing.Size(124, 19);
            this.chkGuncelle.TabIndex = 51;
            this.chkGuncelle.Text = "SSIS Güncelle Aktif";
            this.chkGuncelle.UseVisualStyleBackColor = true;
            this.chkGuncelle.Visible = false;
            this.chkGuncelle.CheckedChanged += new System.EventHandler(this.chkGuncelle_CheckedChanged);
            // 
            // dtKayitZamani
            // 
            this.dtKayitZamani.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtKayitZamani.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKayitZamani.Location = new System.Drawing.Point(249, 12);
            this.dtKayitZamani.MinDate = new System.DateTime(1987, 7, 12, 0, 0, 0, 0);
            this.dtKayitZamani.Name = "dtKayitZamani";
            this.dtKayitZamani.ShowUpDown = true;
            this.dtKayitZamani.Size = new System.Drawing.Size(110, 23);
            this.dtKayitZamani.TabIndex = 34;
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(264, 286);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(205, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 49;
            this.label17.Text = "Satır Sayı : ";
            // 
            // btnSSISListeGetir
            // 
            this.btnSSISListeGetir.Location = new System.Drawing.Point(201, 221);
            this.btnSSISListeGetir.Name = "btnSSISListeGetir";
            this.btnSSISListeGetir.Size = new System.Drawing.Size(128, 47);
            this.btnSSISListeGetir.TabIndex = 48;
            this.btnSSISListeGetir.Text = "Liste Getir";
            this.btnSSISListeGetir.UseVisualStyleBackColor = true;
            this.btnSSISListeGetir.Click += new System.EventHandler(this.btnSSISListeGetir_Click);
            // 
            // btnSSISEkle
            // 
            this.btnSSISEkle.Location = new System.Drawing.Point(201, 356);
            this.btnSSISEkle.Name = "btnSSISEkle";
            this.btnSSISEkle.Size = new System.Drawing.Size(128, 39);
            this.btnSSISEkle.TabIndex = 47;
            this.btnSSISEkle.Text = "SSIS Ekle";
            this.btnSSISEkle.UseVisualStyleBackColor = true;
            this.btnSSISEkle.Click += new System.EventHandler(this.btnSSISEkle_Click);
            // 
            // lblDuzenleyenKullanici
            // 
            this.lblDuzenleyenKullanici.AutoSize = true;
            this.lblDuzenleyenKullanici.Location = new System.Drawing.Point(181, 421);
            this.lblDuzenleyenKullanici.Name = "lblDuzenleyenKullanici";
            this.lblDuzenleyenKullanici.Size = new System.Drawing.Size(68, 30);
            this.lblDuzenleyenKullanici.TabIndex = 35;
            this.lblDuzenleyenKullanici.Text = "Düzenleyen\r\nKullanıcı";
            this.lblDuzenleyenKullanici.Visible = false;
            // 
            // txtRaporAdi
            // 
            this.txtRaporAdi.Location = new System.Drawing.Point(249, 580);
            this.txtRaporAdi.Name = "txtRaporAdi";
            this.txtRaporAdi.Size = new System.Drawing.Size(80, 23);
            this.txtRaporAdi.TabIndex = 46;
            this.txtRaporAdi.Visible = false;
            // 
            // txtDuzenleyenKullanici
            // 
            this.txtDuzenleyenKullanici.Location = new System.Drawing.Point(249, 425);
            this.txtDuzenleyenKullanici.Name = "txtDuzenleyenKullanici";
            this.txtDuzenleyenKullanici.Size = new System.Drawing.Size(80, 23);
            this.txtDuzenleyenKullanici.TabIndex = 36;
            this.txtDuzenleyenKullanici.Text = "0";
            this.txtDuzenleyenKullanici.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(181, 580);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 30);
            this.label22.TabIndex = 45;
            this.label22.Text = "Rapor\r\nAdı";
            this.label22.Visible = false;
            // 
            // lblDuzenlemeZamani
            // 
            this.lblDuzenlemeZamani.AutoSize = true;
            this.lblDuzenlemeZamani.Location = new System.Drawing.Point(181, 465);
            this.lblDuzenlemeZamani.Name = "lblDuzenlemeZamani";
            this.lblDuzenlemeZamani.Size = new System.Drawing.Size(66, 30);
            this.lblDuzenlemeZamani.TabIndex = 37;
            this.lblDuzenlemeZamani.Text = "Düzenleme\r\nZamanı";
            this.lblDuzenlemeZamani.Visible = false;
            // 
            // txtKullanilanDosya
            // 
            this.txtKullanilanDosya.Location = new System.Drawing.Point(249, 124);
            this.txtKullanilanDosya.Name = "txtKullanilanDosya";
            this.txtKullanilanDosya.Size = new System.Drawing.Size(80, 23);
            this.txtKullanilanDosya.TabIndex = 44;
            this.txtKullanilanDosya.Text = "0";
            // 
            // txtKullanilanTablolar
            // 
            this.txtKullanilanTablolar.Location = new System.Drawing.Point(249, 82);
            this.txtKullanilanTablolar.Name = "txtKullanilanTablolar";
            this.txtKullanilanTablolar.Size = new System.Drawing.Size(80, 23);
            this.txtKullanilanTablolar.TabIndex = 43;
            this.txtKullanilanTablolar.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(181, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 30);
            this.label24.TabIndex = 39;
            this.label24.Text = "Kullanılan\r\nDB";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(181, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 30);
            this.label25.TabIndex = 41;
            this.label25.Text = "Kullanılan\r\nDosya";
            // 
            // txtKullanilanDB
            // 
            this.txtKullanilanDB.Location = new System.Drawing.Point(249, 43);
            this.txtKullanilanDB.Name = "txtKullanilanDB";
            this.txtKullanilanDB.Size = new System.Drawing.Size(80, 23);
            this.txtKullanilanDB.TabIndex = 40;
            this.txtKullanilanDB.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(181, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 30);
            this.label26.TabIndex = 42;
            this.label26.Text = "Kullanılan\r\nTablolar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSSIS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(359, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 625);
            this.panel2.TabIndex = 36;
            // 
            // dgvSSIS
            // 
            this.dgvSSIS.AllowUserToAddRows = false;
            this.dgvSSIS.AllowUserToDeleteRows = false;
            this.dgvSSIS.AllowUserToOrderColumns = true;
            this.dgvSSIS.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSSIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSSIS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSSIS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSSIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSSIS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSSIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSSIS.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSSIS.Location = new System.Drawing.Point(0, 0);
            this.dgvSSIS.Name = "dgvSSIS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSSIS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSSIS.RowTemplate.Height = 25;
            this.dgvSSIS.Size = new System.Drawing.Size(713, 625);
            this.dgvSSIS.TabIndex = 15;
            this.dgvSSIS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSSIS_CellDoubleClick);
            this.dgvSSIS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSSIS_MouseUp);
            // 
            // epHataDedektoru
            // 
            this.epHataDedektoru.ContainerControl = this;
            this.epHataDedektoru.RightToLeftChanged += new System.EventHandler(this.btnSSISEkle_Click);
            // 
            // menusag
            // 
            this.menusag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusSecilenKaydiSifirla});
            this.menusag.Name = "menusag";
            this.menusag.Size = new System.Drawing.Size(176, 26);
            // 
            // menusSecilenKaydiSifirla
            // 
            this.menusSecilenKaydiSifirla.Name = "menusSecilenKaydiSifirla";
            this.menusSecilenKaydiSifirla.Size = new System.Drawing.Size(175, 22);
            this.menusSecilenKaydiSifirla.Text = "Seçilen Kaydı Sıfırla";
            this.menusSecilenKaydiSifirla.Click += new System.EventHandler(this.menusSecilenKaydiSifirla_Click);
            // 
            // frmYeniSSISEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmYeniSSISEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Yeni SSIS Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGunlukKontrol_FormClosed);
            this.Load += new System.EventHandler(this.frmYeniSSISEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHataDedektoru)).EndInit();
            this.menusag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKurumNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalismaSekli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHaftaninGunleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAyinGunleri;
        private System.Windows.Forms.TextBox txtTekrarlamaSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBaslamaSaati;
        private System.Windows.Forms.TextBox txtOncelik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYilinOzelGunleri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYilinGunleri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAyinOzelGunleri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKayitKullanıci;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKontroller;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTekrarlamaDakika;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDuzenleyenKullanici;
        private System.Windows.Forms.TextBox txtRaporAdi;
        private System.Windows.Forms.TextBox txtDuzenleyenKullanici;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblDuzenlemeZamani;
        private System.Windows.Forms.TextBox txtKullanilanDosya;
        private System.Windows.Forms.TextBox txtKullanilanTablolar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtKullanilanDB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSSISEkle;
        private System.Windows.Forms.Button btnSSISListeGetir;
        private System.Windows.Forms.DataGridView dgvSSIS;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtKayitZamani;
        private System.Windows.Forms.ErrorProvider epHataDedektoru;
        private System.Windows.Forms.CheckBox chkGuncelle;
        private System.Windows.Forms.DateTimePicker dtDuzenlemeZamani;
        private System.Windows.Forms.ContextMenuStrip menusag;
        private System.Windows.Forms.ToolStripMenuItem menusSecilenKaydiSifirla;
        private System.Windows.Forms.CheckBox chkSSISAdi;
    }
}
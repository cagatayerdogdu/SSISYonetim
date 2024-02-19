
namespace SSISYonetim
{
    partial class frmGunlukKontrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbxCalismayanlar = new System.Windows.Forms.ListBox();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMfDosyaKontrol = new System.Windows.Forms.Button();
            this.btnSeciliKontrol = new System.Windows.Forms.Button();
            this.btnCalistiUpdate = new System.Windows.Forms.Button();
            this.btnCalismadi = new System.Windows.Forms.Button();
            this.btnHepsiniTemizle = new System.Windows.Forms.Button();
            this.btnHepsiniSec = new System.Windows.Forms.Button();
            this.btnTetikle = new System.Windows.Forms.Button();
            this.btnGunlukETLListele = new System.Windows.Forms.Button();
            this.dgvGunlukEtl = new System.Windows.Forms.DataGridView();
            this.Sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SureDakika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalismaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalismayanListeTemizle = new System.Windows.Forms.Button();
            this.btnCalismayanListeSecimKaldir = new System.Windows.Forms.Button();
            this.txtnSonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSSISListeleGunluk = new System.Windows.Forms.Button();
            this.chkSSISAdi = new System.Windows.Forms.CheckBox();
            this.txtSSISAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukEtl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Çalışmayan SSIS Listesi";
            // 
            // lstbxCalismayanlar
            // 
            this.lstbxCalismayanlar.FormattingEnabled = true;
            this.lstbxCalismayanlar.ItemHeight = 15;
            this.lstbxCalismayanlar.Location = new System.Drawing.Point(0, 492);
            this.lstbxCalismayanlar.Name = "lstbxCalismayanlar";
            this.lstbxCalismayanlar.Size = new System.Drawing.Size(176, 154);
            this.lstbxCalismayanlar.TabIndex = 25;
            this.lstbxCalismayanlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstbxCalismayanlar_KeyDown);
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(94, 10);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Satır Sayısı : ";
            // 
            // btnMfDosyaKontrol
            // 
            this.btnMfDosyaKontrol.Location = new System.Drawing.Point(7, 217);
            this.btnMfDosyaKontrol.Name = "btnMfDosyaKontrol";
            this.btnMfDosyaKontrol.Size = new System.Drawing.Size(133, 52);
            this.btnMfDosyaKontrol.TabIndex = 22;
            this.btnMfDosyaKontrol.Text = "Seçili ETL MF Dosyasını Kontrol Et";
            this.btnMfDosyaKontrol.UseVisualStyleBackColor = true;
            this.btnMfDosyaKontrol.Click += new System.EventHandler(this.btnMfDosyaKontrol_Click);
            // 
            // btnSeciliKontrol
            // 
            this.btnSeciliKontrol.Location = new System.Drawing.Point(7, 159);
            this.btnSeciliKontrol.Name = "btnSeciliKontrol";
            this.btnSeciliKontrol.Size = new System.Drawing.Size(133, 52);
            this.btnSeciliKontrol.TabIndex = 21;
            this.btnSeciliKontrol.Text = "Seçili ETL Tablodan Kontrol Et";
            this.btnSeciliKontrol.UseVisualStyleBackColor = true;
            this.btnSeciliKontrol.Click += new System.EventHandler(this.btnSeciliKontrol_Click);
            // 
            // btnCalistiUpdate
            // 
            this.btnCalistiUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnCalistiUpdate.Location = new System.Drawing.Point(7, 343);
            this.btnCalistiUpdate.Name = "btnCalistiUpdate";
            this.btnCalistiUpdate.Size = new System.Drawing.Size(133, 52);
            this.btnCalistiUpdate.TabIndex = 20;
            this.btnCalistiUpdate.Text = "Seçilileri Çalıştı olarak Update et";
            this.btnCalistiUpdate.UseVisualStyleBackColor = true;
            this.btnCalistiUpdate.Click += new System.EventHandler(this.btnCalistiUpdate_Click);
            // 
            // btnCalismadi
            // 
            this.btnCalismadi.ForeColor = System.Drawing.Color.Red;
            this.btnCalismadi.Location = new System.Drawing.Point(7, 285);
            this.btnCalismadi.Name = "btnCalismadi";
            this.btnCalismadi.Size = new System.Drawing.Size(133, 52);
            this.btnCalismadi.TabIndex = 19;
            this.btnCalismadi.Text = "Seçilileri Çalışmadı olarak Update et";
            this.btnCalismadi.UseVisualStyleBackColor = true;
            this.btnCalismadi.Click += new System.EventHandler(this.btnCalismadi_Click);
            // 
            // btnHepsiniTemizle
            // 
            this.btnHepsiniTemizle.Location = new System.Drawing.Point(7, 118);
            this.btnHepsiniTemizle.Name = "btnHepsiniTemizle";
            this.btnHepsiniTemizle.Size = new System.Drawing.Size(104, 23);
            this.btnHepsiniTemizle.TabIndex = 18;
            this.btnHepsiniTemizle.Text = "Hepsini Temizle";
            this.btnHepsiniTemizle.UseVisualStyleBackColor = true;
            this.btnHepsiniTemizle.Click += new System.EventHandler(this.btnHepsiniTemizle_Click);
            // 
            // btnHepsiniSec
            // 
            this.btnHepsiniSec.Location = new System.Drawing.Point(7, 89);
            this.btnHepsiniSec.Name = "btnHepsiniSec";
            this.btnHepsiniSec.Size = new System.Drawing.Size(104, 23);
            this.btnHepsiniSec.TabIndex = 17;
            this.btnHepsiniSec.Text = "Hepsini Seç";
            this.btnHepsiniSec.UseVisualStyleBackColor = true;
            this.btnHepsiniSec.Click += new System.EventHandler(this.btnHepsiniSec_Click);
            // 
            // btnTetikle
            // 
            this.btnTetikle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTetikle.ForeColor = System.Drawing.Color.Coral;
            this.btnTetikle.Location = new System.Drawing.Point(7, 401);
            this.btnTetikle.Name = "btnTetikle";
            this.btnTetikle.Size = new System.Drawing.Size(132, 48);
            this.btnTetikle.TabIndex = 16;
            this.btnTetikle.Text = "Seçilileri Tetikle";
            this.btnTetikle.UseVisualStyleBackColor = true;
            this.btnTetikle.Click += new System.EventHandler(this.btnTetikle_Click);
            // 
            // btnGunlukETLListele
            // 
            this.btnGunlukETLListele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGunlukETLListele.ForeColor = System.Drawing.Color.Blue;
            this.btnGunlukETLListele.Location = new System.Drawing.Point(7, 31);
            this.btnGunlukETLListele.Name = "btnGunlukETLListele";
            this.btnGunlukETLListele.Size = new System.Drawing.Size(133, 52);
            this.btnGunlukETLListele.TabIndex = 15;
            this.btnGunlukETLListele.Text = "ETL Listele";
            this.btnGunlukETLListele.UseVisualStyleBackColor = true;
            this.btnGunlukETLListele.Click += new System.EventHandler(this.btnGunlukETLListele_Click);
            // 
            // dgvGunlukEtl
            // 
            this.dgvGunlukEtl.AllowUserToAddRows = false;
            this.dgvGunlukEtl.AllowUserToDeleteRows = false;
            this.dgvGunlukEtl.AllowUserToOrderColumns = true;
            this.dgvGunlukEtl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGunlukEtl.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvGunlukEtl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGunlukEtl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGunlukEtl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGunlukEtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunlukEtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sec,
            this.ID,
            this.Gun,
            this.KayitNo,
            this.Ad,
            this.Saat,
            this.BaslamaTarihi,
            this.BaslamaSaat,
            this.BitisSaat,
            this.Sonuc,
            this.SureDakika,
            this.Aciklama,
            this.BitisTarihi,
            this.CalismaSayisi});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGunlukEtl.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGunlukEtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGunlukEtl.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvGunlukEtl.Location = new System.Drawing.Point(0, 0);
            this.dgvGunlukEtl.Name = "dgvGunlukEtl";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGunlukEtl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGunlukEtl.RowHeadersWidth = 52;
            this.dgvGunlukEtl.RowTemplate.Height = 25;
            this.dgvGunlukEtl.Size = new System.Drawing.Size(998, 661);
            this.dgvGunlukEtl.TabIndex = 14;
            this.dgvGunlukEtl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGunlukEtl_CellContentClick);
            this.dgvGunlukEtl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGunlukEtl_CellValueChanged);
            // 
            // Sec
            // 
            this.Sec.DataPropertyName = "Sec";
            this.Sec.FillWeight = 40F;
            this.Sec.HeaderText = "Seç";
            this.Sec.Name = "Sec";
            this.Sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Gun
            // 
            this.Gun.DataPropertyName = "Gun";
            this.Gun.FillWeight = 70F;
            this.Gun.HeaderText = "Gün";
            this.Gun.Name = "Gun";
            // 
            // KayitNo
            // 
            this.KayitNo.DataPropertyName = "KayitNo";
            this.KayitNo.FillWeight = 50F;
            this.KayitNo.HeaderText = "Kayıt No";
            this.KayitNo.Name = "KayitNo";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.FillWeight = 200F;
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.FillWeight = 50F;
            this.Saat.HeaderText = "Saat";
            this.Saat.Name = "Saat";
            // 
            // BaslamaTarihi
            // 
            this.BaslamaTarihi.DataPropertyName = "BaslamaTarihi";
            this.BaslamaTarihi.FillWeight = 70F;
            this.BaslamaTarihi.HeaderText = "Başlama Tarihi";
            this.BaslamaTarihi.Name = "BaslamaTarihi";
            // 
            // BaslamaSaat
            // 
            this.BaslamaSaat.DataPropertyName = "BaslamaSaat";
            this.BaslamaSaat.FillWeight = 70F;
            this.BaslamaSaat.HeaderText = "Başlama Saat";
            this.BaslamaSaat.Name = "BaslamaSaat";
            // 
            // BitisSaat
            // 
            this.BitisSaat.DataPropertyName = "BitisSaat";
            this.BitisSaat.FillWeight = 70F;
            this.BitisSaat.HeaderText = "Bitiş Saat";
            this.BitisSaat.Name = "BitisSaat";
            // 
            // Sonuc
            // 
            this.Sonuc.DataPropertyName = "Sonuc";
            this.Sonuc.FillWeight = 50F;
            this.Sonuc.HeaderText = "Sonuç";
            this.Sonuc.Name = "Sonuc";
            // 
            // SureDakika
            // 
            this.SureDakika.DataPropertyName = "SureDakika";
            this.SureDakika.FillWeight = 50F;
            this.SureDakika.HeaderText = "Dünkü Süre Dakika";
            this.SureDakika.Name = "SureDakika";
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.FillWeight = 230F;
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.DataPropertyName = "BitisTarihi";
            this.BitisTarihi.FillWeight = 70F;
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            // 
            // CalismaSayisi
            // 
            this.CalismaSayisi.DataPropertyName = "CalismaSayisi";
            this.CalismaSayisi.FillWeight = 50F;
            this.CalismaSayisi.HeaderText = "Çalışma Sayısı";
            this.CalismaSayisi.Name = "CalismaSayisi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalismayanListeTemizle);
            this.panel1.Controls.Add(this.btnCalismayanListeSecimKaldir);
            this.panel1.Controls.Add(this.txtnSonuc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSSISListeleGunluk);
            this.panel1.Controls.Add(this.chkSSISAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSSISAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGunlukETLListele);
            this.panel1.Controls.Add(this.lstbxCalismayanlar);
            this.panel1.Controls.Add(this.btnTetikle);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.btnHepsiniSec);
            this.panel1.Controls.Add(this.btnHepsiniTemizle);
            this.panel1.Controls.Add(this.btnMfDosyaKontrol);
            this.panel1.Controls.Add(this.btnCalismadi);
            this.panel1.Controls.Add(this.btnSeciliKontrol);
            this.panel1.Controls.Add(this.btnCalistiUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 661);
            this.panel1.TabIndex = 27;
            // 
            // btnCalismayanListeTemizle
            // 
            this.btnCalismayanListeTemizle.Location = new System.Drawing.Point(182, 553);
            this.btnCalismayanListeTemizle.Name = "btnCalismayanListeTemizle";
            this.btnCalismayanListeTemizle.Size = new System.Drawing.Size(98, 42);
            this.btnCalismayanListeTemizle.TabIndex = 38;
            this.btnCalismayanListeTemizle.Text = "Listeyi Temizle";
            this.btnCalismayanListeTemizle.UseVisualStyleBackColor = true;
            this.btnCalismayanListeTemizle.Click += new System.EventHandler(this.btnCalismayanListeTemizle_Click);
            // 
            // btnCalismayanListeSecimKaldir
            // 
            this.btnCalismayanListeSecimKaldir.Location = new System.Drawing.Point(182, 492);
            this.btnCalismayanListeSecimKaldir.Name = "btnCalismayanListeSecimKaldir";
            this.btnCalismayanListeSecimKaldir.Size = new System.Drawing.Size(98, 42);
            this.btnCalismayanListeSecimKaldir.TabIndex = 37;
            this.btnCalismayanListeSecimKaldir.Text = "Seçimi Temizle";
            this.btnCalismayanListeSecimKaldir.UseVisualStyleBackColor = true;
            this.btnCalismayanListeSecimKaldir.Click += new System.EventHandler(this.btnCalismayanListeSecimKaldir_Click);
            // 
            // txtnSonuc
            // 
            this.txtnSonuc.Location = new System.Drawing.Point(213, 31);
            this.txtnSonuc.Name = "txtnSonuc";
            this.txtnSonuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnSonuc.Size = new System.Drawing.Size(67, 23);
            this.txtnSonuc.TabIndex = 40;
            this.txtnSonuc.Text = "1";
            this.txtnSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnSonuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnSonuc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sonuc";
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(213, 60);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 41;
            this.txtTopN.Text = "0";
            this.txtTopN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gün Top N";
            // 
            // btnSSISListeleGunluk
            // 
            this.btnSSISListeleGunluk.Enabled = false;
            this.btnSSISListeleGunluk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSSISListeleGunluk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSSISListeleGunluk.Location = new System.Drawing.Point(185, 159);
            this.btnSSISListeleGunluk.Name = "btnSSISListeleGunluk";
            this.btnSSISListeleGunluk.Size = new System.Drawing.Size(95, 42);
            this.btnSSISListeleGunluk.TabIndex = 43;
            this.btnSSISListeleGunluk.Text = "Listele";
            this.btnSSISListeleGunluk.UseVisualStyleBackColor = true;
            this.btnSSISListeleGunluk.Click += new System.EventHandler(this.btnSSISListeleGunluk_Click);
            // 
            // chkSSISAdi
            // 
            this.chkSSISAdi.AutoSize = true;
            this.chkSSISAdi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSSISAdi.Location = new System.Drawing.Point(191, 131);
            this.chkSSISAdi.Name = "chkSSISAdi";
            this.chkSSISAdi.Size = new System.Drawing.Size(89, 19);
            this.chkSSISAdi.TabIndex = 44;
            this.chkSSISAdi.Text = "SSIS Adı Ara";
            this.chkSSISAdi.UseVisualStyleBackColor = true;
            this.chkSSISAdi.CheckedChanged += new System.EventHandler(this.chkSSISAdi_CheckedChanged);
            // 
            // txtSSISAdi
            // 
            this.txtSSISAdi.Location = new System.Drawing.Point(157, 102);
            this.txtSSISAdi.Name = "txtSSISAdi";
            this.txtSSISAdi.Size = new System.Drawing.Size(123, 23);
            this.txtSSISAdi.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "SSIS Adı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGunlukEtl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 661);
            this.panel2.TabIndex = 28;
            // 
            // frmGunlukKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGunlukKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Kontrol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGunlukKontrol_FormClosed);
            this.Load += new System.EventHandler(this.frmGunlukKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukEtl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lstbxCalismayanlar;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMfDosyaKontrol;
        private System.Windows.Forms.Button btnSeciliKontrol;
        private System.Windows.Forms.Button btnCalistiUpdate;
        private System.Windows.Forms.Button btnCalismadi;
        private System.Windows.Forms.Button btnHepsiniTemizle;
        private System.Windows.Forms.Button btnHepsiniSec;
        private System.Windows.Forms.Button btnTetikle;
        private System.Windows.Forms.Button btnGunlukETLListele;
        private System.Windows.Forms.DataGridView dgvGunlukEtl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SureDakika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalismaSayisi;
        private System.Windows.Forms.CheckBox chkSSISAdi;
        private System.Windows.Forms.TextBox txtSSISAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSSISListeleGunluk;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalismayanListeTemizle;
        private System.Windows.Forms.Button btnCalismayanListeSecimKaldir;
    }
}
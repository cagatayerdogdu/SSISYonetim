
namespace SSISYonetim
{
    partial class frmSSISGunlukCalisma
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
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkKod = new System.Windows.Forms.CheckBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSSISGunlukCalismaLog = new System.Windows.Forms.DataGridView();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSSISGunlukAdimLogListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkSSISAdi = new System.Windows.Forms.CheckBox();
            this.txtSSISAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSISGunlukCalismaLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(56, 84);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 21;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Top N";
            // 
            // chkKod
            // 
            this.chkKod.AutoSize = true;
            this.chkKod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKod.Location = new System.Drawing.Point(787, 48);
            this.chkKod.Name = "chkKod";
            this.chkKod.Size = new System.Drawing.Size(68, 19);
            this.chkKod.TabIndex = 18;
            this.chkKod.Text = "Kod Ara";
            this.chkKod.UseVisualStyleBackColor = true;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(732, 19);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(123, 23);
            this.txtKod.TabIndex = 17;
            this.txtKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKod_KeyPress);
            // 
            // dtLogTarih2
            // 
            this.dtLogTarih2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih2.Location = new System.Drawing.Point(511, 19);
            this.dtLogTarih2.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih2.Name = "dtLogTarih2";
            this.dtLogTarih2.ShowUpDown = true;
            this.dtLogTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSSISGunlukCalismaLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 19;
            // 
            // dgvSSISGunlukCalismaLog
            // 
            this.dgvSSISGunlukCalismaLog.AllowUserToAddRows = false;
            this.dgvSSISGunlukCalismaLog.AllowUserToDeleteRows = false;
            this.dgvSSISGunlukCalismaLog.AllowUserToOrderColumns = true;
            this.dgvSSISGunlukCalismaLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSSISGunlukCalismaLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSSISGunlukCalismaLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSSISGunlukCalismaLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gun,
            this.KayitNo,
            this.Ad,
            this.Kod,
            this.Zaman,
            this.Aciklama});
            this.dgvSSISGunlukCalismaLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSSISGunlukCalismaLog.Location = new System.Drawing.Point(0, 0);
            this.dgvSSISGunlukCalismaLog.Name = "dgvSSISGunlukCalismaLog";
            this.dgvSSISGunlukCalismaLog.ReadOnly = true;
            this.dgvSSISGunlukCalismaLog.RowHeadersWidth = 60;
            this.dgvSSISGunlukCalismaLog.RowTemplate.Height = 25;
            this.dgvSSISGunlukCalismaLog.Size = new System.Drawing.Size(961, 338);
            this.dgvSSISGunlukCalismaLog.TabIndex = 0;
            // 
            // Gun
            // 
            this.Gun.DataPropertyName = "Gun";
            this.Gun.FillWeight = 70F;
            this.Gun.HeaderText = "Gün";
            this.Gun.Name = "Gun";
            this.Gun.ReadOnly = true;
            // 
            // KayitNo
            // 
            this.KayitNo.DataPropertyName = "KayitNo";
            this.KayitNo.FillWeight = 60F;
            this.KayitNo.HeaderText = "Kayıt No";
            this.KayitNo.Name = "KayitNo";
            this.KayitNo.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "SSIS Adı";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Kod";
            this.Kod.FillWeight = 50F;
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.ReadOnly = true;
            // 
            // Zaman
            // 
            this.Zaman.DataPropertyName = "Zaman";
            this.Zaman.FillWeight = 90F;
            this.Zaman.HeaderText = "Zaman";
            this.Zaman.Name = "Zaman";
            this.Zaman.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkKod);
            this.panel1.Controls.Add(this.txtKod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSSISGunlukAdimLogListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkSSISAdi);
            this.panel1.Controls.Add(this.txtSSISAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtLogTarih1);
            this.panel1.Controls.Add(this.dtLogTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kod";
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(732, 87);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnSSISGunlukAdimLogListele
            // 
            this.btnSSISGunlukAdimLogListele.Location = new System.Drawing.Point(819, 73);
            this.btnSSISGunlukAdimLogListele.Name = "btnSSISGunlukAdimLogListele";
            this.btnSSISGunlukAdimLogListele.Size = new System.Drawing.Size(130, 42);
            this.btnSSISGunlukAdimLogListele.TabIndex = 12;
            this.btnSSISGunlukAdimLogListele.Text = "Listele";
            this.btnSSISGunlukAdimLogListele.UseVisualStyleBackColor = true;
            this.btnSSISGunlukAdimLogListele.Click += new System.EventHandler(this.btnSSISGunlukAdimLogListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(494, 48);
            this.chkLogTarih2.Name = "chkLogTarih2";
            this.chkLogTarih2.Size = new System.Drawing.Size(148, 19);
            this.chkLogTarih2.TabIndex = 10;
            this.chkLogTarih2.Text = "Log Tarihi Arasında Ara";
            this.chkLogTarih2.UseVisualStyleBackColor = true;
            // 
            // chkLogTarih1
            // 
            this.chkLogTarih1.AutoSize = true;
            this.chkLogTarih1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih1.Checked = true;
            this.chkLogTarih1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogTarih1.Location = new System.Drawing.Point(297, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(150, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "Log Tarihi Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            // 
            // chkSSISAdi
            // 
            this.chkSSISAdi.AutoSize = true;
            this.chkSSISAdi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSSISAdi.Location = new System.Drawing.Point(100, 48);
            this.chkSSISAdi.Name = "chkSSISAdi";
            this.chkSSISAdi.Size = new System.Drawing.Size(89, 19);
            this.chkSSISAdi.TabIndex = 8;
            this.chkSSISAdi.Text = "SSIS Adı Ara";
            this.chkSSISAdi.UseVisualStyleBackColor = true;
            // 
            // txtSSISAdi
            // 
            this.txtSSISAdi.Location = new System.Drawing.Point(66, 19);
            this.txtSSISAdi.Name = "txtSSISAdi";
            this.txtSSISAdi.Size = new System.Drawing.Size(123, 23);
            this.txtSSISAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSIS Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // dtLogTarih1
            // 
            this.dtLogTarih1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih1.Location = new System.Drawing.Point(316, 19);
            this.dtLogTarih1.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih1.Name = "dtLogTarih1";
            this.dtLogTarih1.ShowUpDown = true;
            this.dtLogTarih1.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih1.TabIndex = 3;
            this.dtLogTarih1.Value = new System.DateTime(2022, 11, 11, 22, 44, 31, 0);
            // 
            // frmSSISGunlukCalisma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSSISGunlukCalisma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSIS Günlük Çalışma Adımları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSSISGunlukCalisma_FormClosed);
            this.Load += new System.EventHandler(this.frmSSISGunlukCalisma_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSISGunlukCalismaLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkKod;
        private System.Windows.Forms.TextBox txtKod;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSSISGunlukCalismaLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSSISGunlukAdimLogListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkSSISAdi;
        private System.Windows.Forms.TextBox txtSSISAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
    }
}
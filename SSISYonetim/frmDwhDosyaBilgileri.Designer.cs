
namespace SSISYonetim
{
    partial class frmDwhDosyaBilgileri
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
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDwhDosyaAdi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaOlusturulmaZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosya_InsTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaAdiHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaGunlukSatirSayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWebApiLogListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkLogUygulama = new System.Windows.Forms.CheckBox();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDwhDosyaAdi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtLogTarih2
            // 
            this.dtLogTarih2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih2.Location = new System.Drawing.Point(590, 19);
            this.dtLogTarih2.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih2.Name = "dtLogTarih2";
            this.dtLogTarih2.ShowUpDown = true;
            this.dtLogTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDwhDosyaAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 19;
            // 
            // dgvDwhDosyaAdi
            // 
            this.dgvDwhDosyaAdi.AllowUserToAddRows = false;
            this.dgvDwhDosyaAdi.AllowUserToDeleteRows = false;
            this.dgvDwhDosyaAdi.AllowUserToOrderColumns = true;
            this.dgvDwhDosyaAdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDwhDosyaAdi.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDwhDosyaAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDwhDosyaAdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DosyaAdi,
            this.DosyaOlusturulmaZamani,
            this.Dosya_InsTim,
            this.DosyaAdiHam,
            this.DosyaGunlukSatirSayi});
            this.dgvDwhDosyaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDwhDosyaAdi.Location = new System.Drawing.Point(0, 0);
            this.dgvDwhDosyaAdi.Name = "dgvDwhDosyaAdi";
            this.dgvDwhDosyaAdi.ReadOnly = true;
            this.dgvDwhDosyaAdi.RowHeadersWidth = 60;
            this.dgvDwhDosyaAdi.RowTemplate.Height = 25;
            this.dgvDwhDosyaAdi.Size = new System.Drawing.Size(961, 338);
            this.dgvDwhDosyaAdi.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DosyaAdi
            // 
            this.DosyaAdi.DataPropertyName = "DosyaAdi";
            this.DosyaAdi.HeaderText = "Dosya Adı";
            this.DosyaAdi.Name = "DosyaAdi";
            this.DosyaAdi.ReadOnly = true;
            // 
            // DosyaOlusturulmaZamani
            // 
            this.DosyaOlusturulmaZamani.DataPropertyName = "DosyaOlusturulmaTarihi";
            this.DosyaOlusturulmaZamani.HeaderText = "Dosya Oluşturulma Tarihi";
            this.DosyaOlusturulmaZamani.Name = "DosyaOlusturulmaZamani";
            this.DosyaOlusturulmaZamani.ReadOnly = true;
            // 
            // Dosya_InsTim
            // 
            this.Dosya_InsTim.DataPropertyName = "DosyaInsTim";
            this.Dosya_InsTim.FillWeight = 90F;
            this.Dosya_InsTim.HeaderText = "Dosya Insert Tarihi";
            this.Dosya_InsTim.Name = "Dosya_InsTim";
            this.Dosya_InsTim.ReadOnly = true;
            // 
            // DosyaAdiHam
            // 
            this.DosyaAdiHam.DataPropertyName = "DosyaAdiHam";
            this.DosyaAdiHam.HeaderText = "Dosya Adı Ham";
            this.DosyaAdiHam.Name = "DosyaAdiHam";
            this.DosyaAdiHam.ReadOnly = true;
            // 
            // DosyaGunlukSatirSayi
            // 
            this.DosyaGunlukSatirSayi.DataPropertyName = "DosyaGunlukSatirSayi";
            this.DosyaGunlukSatirSayi.HeaderText = "Dosya Günlük Satır Sayı";
            this.DosyaGunlukSatirSayi.Name = "DosyaGunlukSatirSayi";
            this.DosyaGunlukSatirSayi.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnWebApiLogListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkLogUygulama);
            this.panel1.Controls.Add(this.txtDosyaAdi);
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
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(72, 84);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 27;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Top N";
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
            // btnWebApiLogListele
            // 
            this.btnWebApiLogListele.Location = new System.Drawing.Point(819, 73);
            this.btnWebApiLogListele.Name = "btnWebApiLogListele";
            this.btnWebApiLogListele.Size = new System.Drawing.Size(130, 42);
            this.btnWebApiLogListele.TabIndex = 12;
            this.btnWebApiLogListele.Text = "Listele";
            this.btnWebApiLogListele.UseVisualStyleBackColor = true;
            this.btnWebApiLogListele.Click += new System.EventHandler(this.btnWebApiLogListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(573, 48);
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
            this.chkLogTarih1.Location = new System.Drawing.Point(376, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(150, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "Log Tarihi Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            // 
            // chkLogUygulama
            // 
            this.chkLogUygulama.AutoSize = true;
            this.chkLogUygulama.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogUygulama.Location = new System.Drawing.Point(116, 48);
            this.chkLogUygulama.Name = "chkLogUygulama";
            this.chkLogUygulama.Size = new System.Drawing.Size(129, 19);
            this.chkLogUygulama.TabIndex = 8;
            this.chkLogUygulama.Text = "Dosya Adı Ham Ara";
            this.chkLogUygulama.UseVisualStyleBackColor = true;
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(122, 19);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(123, 23);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Adı Ham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dosya Oluşturulma Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // dtLogTarih1
            // 
            this.dtLogTarih1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih1.Location = new System.Drawing.Point(395, 19);
            this.dtLogTarih1.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih1.Name = "dtLogTarih1";
            this.dtLogTarih1.ShowUpDown = true;
            this.dtLogTarih1.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih1.TabIndex = 3;
            this.dtLogTarih1.Value = new System.DateTime(2022, 11, 13, 18, 11, 9, 0);
            // 
            // frmDwhDosyaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDwhDosyaBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dwh Dosya Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDwhDosyaBilgileri_FormClosed);
            this.Load += new System.EventHandler(this.frmDwhDosyaBilgileri_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDwhDosyaAdi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDwhDosyaAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWebApiLogListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkLogUygulama;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaOlusturulmaZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosya_InsTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaAdiHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaGunlukSatirSayi;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
    }
}
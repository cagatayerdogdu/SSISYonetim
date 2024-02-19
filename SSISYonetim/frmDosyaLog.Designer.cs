
namespace SSISYonetim
{
    partial class frmDosyaLog
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDosyaLog = new System.Windows.Forms.DataGridView();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDosyaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaSatirSayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDosyaLogListele = new System.Windows.Forms.Button();
            this.chkKayitTarih2 = new System.Windows.Forms.CheckBox();
            this.chkKayitTarih1 = new System.Windows.Forms.CheckBox();
            this.chkDosyaAdi = new System.Windows.Forms.CheckBox();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtKayitTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtKayitTarih2 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosyaLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDosyaLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 11;
            // 
            // dgvDosyaLog
            // 
            this.dgvDosyaLog.AllowUserToAddRows = false;
            this.dgvDosyaLog.AllowUserToDeleteRows = false;
            this.dgvDosyaLog.AllowUserToOrderColumns = true;
            this.dgvDosyaLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDosyaLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDosyaLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDosyaLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogId,
            this.pDosyaAdi,
            this.DosyaSatirSayi,
            this.KayitTarihi});
            this.dgvDosyaLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDosyaLog.Location = new System.Drawing.Point(0, 0);
            this.dgvDosyaLog.Name = "dgvDosyaLog";
            this.dgvDosyaLog.ReadOnly = true;
            this.dgvDosyaLog.RowHeadersWidth = 60;
            this.dgvDosyaLog.RowTemplate.Height = 25;
            this.dgvDosyaLog.Size = new System.Drawing.Size(961, 338);
            this.dgvDosyaLog.TabIndex = 0;
            // 
            // LogId
            // 
            this.LogId.DataPropertyName = "LogID";
            this.LogId.FillWeight = 60F;
            this.LogId.HeaderText = "Log ID";
            this.LogId.Name = "LogId";
            this.LogId.ReadOnly = true;
            // 
            // pDosyaAdi
            // 
            this.pDosyaAdi.DataPropertyName = "PaketDosyaAdi";
            this.pDosyaAdi.FillWeight = 200F;
            this.pDosyaAdi.HeaderText = "Dosya Adı";
            this.pDosyaAdi.Name = "pDosyaAdi";
            this.pDosyaAdi.ReadOnly = true;
            // 
            // DosyaSatirSayi
            // 
            this.DosyaSatirSayi.DataPropertyName = "DosyaSatirSayi";
            this.DosyaSatirSayi.HeaderText = "Dosya Satır Sayısı";
            this.DosyaSatirSayi.Name = "DosyaSatirSayi";
            this.DosyaSatirSayi.ReadOnly = true;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "Kayıt Tarihi";
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.ReadOnly = true;
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(709, 90);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDosyaLogListele);
            this.panel1.Controls.Add(this.chkKayitTarih2);
            this.panel1.Controls.Add(this.chkKayitTarih1);
            this.panel1.Controls.Add(this.chkDosyaAdi);
            this.panel1.Controls.Add(this.txtDosyaAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtKayitTarih1);
            this.panel1.Controls.Add(this.dtKayitTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 10;
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(65, 87);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 23;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Top N";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnDosyaLogListele
            // 
            this.btnDosyaLogListele.Location = new System.Drawing.Point(819, 22);
            this.btnDosyaLogListele.Name = "btnDosyaLogListele";
            this.btnDosyaLogListele.Size = new System.Drawing.Size(130, 42);
            this.btnDosyaLogListele.TabIndex = 12;
            this.btnDosyaLogListele.Text = "Listele";
            this.btnDosyaLogListele.UseVisualStyleBackColor = true;
            this.btnDosyaLogListele.Click += new System.EventHandler(this.btnDosyaLogListele_Click);
            // 
            // chkKayitTarih2
            // 
            this.chkKayitTarih2.AutoSize = true;
            this.chkKayitTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKayitTarih2.Location = new System.Drawing.Point(558, 51);
            this.chkKayitTarih2.Name = "chkKayitTarih2";
            this.chkKayitTarih2.Size = new System.Drawing.Size(154, 19);
            this.chkKayitTarih2.TabIndex = 10;
            this.chkKayitTarih2.Text = "Kayıt Tarihi Arasında Ara";
            this.chkKayitTarih2.UseVisualStyleBackColor = true;
            // 
            // chkKayitTarih1
            // 
            this.chkKayitTarih1.AutoSize = true;
            this.chkKayitTarih1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKayitTarih1.Location = new System.Drawing.Point(361, 51);
            this.chkKayitTarih1.Name = "chkKayitTarih1";
            this.chkKayitTarih1.Size = new System.Drawing.Size(156, 19);
            this.chkKayitTarih1.TabIndex = 9;
            this.chkKayitTarih1.Text = "Kayıt Tarihi Büyüktür Ara";
            this.chkKayitTarih1.UseVisualStyleBackColor = true;
            // 
            // chkDosyaAdi
            // 
            this.chkDosyaAdi.AutoSize = true;
            this.chkDosyaAdi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDosyaAdi.Location = new System.Drawing.Point(110, 51);
            this.chkDosyaAdi.Name = "chkDosyaAdi";
            this.chkDosyaAdi.Size = new System.Drawing.Size(100, 19);
            this.chkDosyaAdi.TabIndex = 8;
            this.chkDosyaAdi.Text = "Dosya Adı Ara";
            this.chkDosyaAdi.UseVisualStyleBackColor = true;
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(87, 22);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(123, 23);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kayıt Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // dtKayitTarih1
            // 
            this.dtKayitTarih1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtKayitTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKayitTarih1.Location = new System.Drawing.Point(386, 22);
            this.dtKayitTarih1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtKayitTarih1.Name = "dtKayitTarih1";
            this.dtKayitTarih1.ShowUpDown = true;
            this.dtKayitTarih1.Size = new System.Drawing.Size(131, 23);
            this.dtKayitTarih1.TabIndex = 3;
            // 
            // dtKayitTarih2
            // 
            this.dtKayitTarih2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtKayitTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKayitTarih2.Location = new System.Drawing.Point(581, 22);
            this.dtKayitTarih2.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtKayitTarih2.Name = "dtKayitTarih2";
            this.dtKayitTarih2.ShowUpDown = true;
            this.dtKayitTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtKayitTarih2.TabIndex = 4;
            // 
            // frmDosyaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDosyaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLI Console Dosya Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDosyaLog_FormClosed);
            this.Load += new System.EventHandler(this.frmDosyaLog_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosyaLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDosyaLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDosyaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaSatirSayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDosyaLogListele;
        private System.Windows.Forms.CheckBox chkKayitTarih2;
        private System.Windows.Forms.CheckBox chkKayitTarih1;
        private System.Windows.Forms.CheckBox chkDosyaAdi;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtKayitTarih1;
        private System.Windows.Forms.DateTimePicker dtKayitTarih2;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
    }
}
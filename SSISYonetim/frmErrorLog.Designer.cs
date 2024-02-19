
namespace SSISYonetim
{
    partial class frmErrorLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHataAciklama = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnErrorLogListele = new System.Windows.Forms.Button();
            this.chkHataAciklama = new System.Windows.Forms.CheckBox();
            this.chkHataTarih2 = new System.Windows.Forms.CheckBox();
            this.chkHataTarih1 = new System.Windows.Forms.CheckBox();
            this.chkDosyaAdi = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvErrorLog = new System.Windows.Forms.DataGridView();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDosyaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).BeginInit();
            this.SuspendLayout();
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
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(87, 22);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(123, 23);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hata Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(303, 22);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(498, 22);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hata Açıklama";
            // 
            // txtHataAciklama
            // 
            this.txtHataAciklama.Location = new System.Drawing.Point(745, 25);
            this.txtHataAciklama.Name = "txtHataAciklama";
            this.txtHataAciklama.Size = new System.Drawing.Size(179, 23);
            this.txtHataAciklama.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnErrorLogListele);
            this.panel1.Controls.Add(this.chkHataAciklama);
            this.panel1.Controls.Add(this.chkHataTarih2);
            this.panel1.Controls.Add(this.chkHataTarih1);
            this.panel1.Controls.Add(this.chkDosyaAdi);
            this.panel1.Controls.Add(this.txtDosyaAdi);
            this.panel1.Controls.Add(this.txtHataAciklama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 8;
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(65, 87);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 25;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Top N";
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(709, 90);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
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
            // btnErrorLogListele
            // 
            this.btnErrorLogListele.Location = new System.Drawing.Point(828, 76);
            this.btnErrorLogListele.Name = "btnErrorLogListele";
            this.btnErrorLogListele.Size = new System.Drawing.Size(130, 42);
            this.btnErrorLogListele.TabIndex = 12;
            this.btnErrorLogListele.Text = "Listele";
            this.btnErrorLogListele.UseVisualStyleBackColor = true;
            this.btnErrorLogListele.Click += new System.EventHandler(this.btnErrorLogListele_Click);
            // 
            // chkHataAciklama
            // 
            this.chkHataAciklama.AutoSize = true;
            this.chkHataAciklama.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHataAciklama.Location = new System.Drawing.Point(800, 51);
            this.chkHataAciklama.Name = "chkHataAciklama";
            this.chkHataAciklama.Size = new System.Drawing.Size(124, 19);
            this.chkHataAciklama.TabIndex = 11;
            this.chkHataAciklama.Text = "Hata Açıklama Ara";
            this.chkHataAciklama.UseVisualStyleBackColor = true;
            // 
            // chkHataTarih2
            // 
            this.chkHataTarih2.AutoSize = true;
            this.chkHataTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHataTarih2.Location = new System.Drawing.Point(479, 51);
            this.chkHataTarih2.Name = "chkHataTarih2";
            this.chkHataTarih2.Size = new System.Drawing.Size(150, 19);
            this.chkHataTarih2.TabIndex = 10;
            this.chkHataTarih2.Text = "Hata Tarih Arasında Ara";
            this.chkHataTarih2.UseVisualStyleBackColor = true;
            // 
            // chkHataTarih1
            // 
            this.chkHataTarih1.AutoSize = true;
            this.chkHataTarih1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHataTarih1.Location = new System.Drawing.Point(282, 51);
            this.chkHataTarih1.Name = "chkHataTarih1";
            this.chkHataTarih1.Size = new System.Drawing.Size(152, 19);
            this.chkHataTarih1.TabIndex = 9;
            this.chkHataTarih1.Text = "Hata Tarih Büyüktür Ara";
            this.chkHataTarih1.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvErrorLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 9;
            // 
            // dgvErrorLog
            // 
            this.dgvErrorLog.AllowUserToAddRows = false;
            this.dgvErrorLog.AllowUserToDeleteRows = false;
            this.dgvErrorLog.AllowUserToOrderColumns = true;
            this.dgvErrorLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvErrorLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvErrorLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogId,
            this.pDosyaAdi,
            this.HataTarih,
            this.HataAciklama});
            this.dgvErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrorLog.Location = new System.Drawing.Point(0, 0);
            this.dgvErrorLog.Name = "dgvErrorLog";
            this.dgvErrorLog.ReadOnly = true;
            this.dgvErrorLog.RowHeadersWidth = 60;
            this.dgvErrorLog.RowTemplate.Height = 25;
            this.dgvErrorLog.Size = new System.Drawing.Size(961, 338);
            this.dgvErrorLog.TabIndex = 0;
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
            this.pDosyaAdi.HeaderText = "Dosya Adı";
            this.pDosyaAdi.Name = "pDosyaAdi";
            this.pDosyaAdi.ReadOnly = true;
            // 
            // HataTarih
            // 
            this.HataTarih.DataPropertyName = "HataTarih";
            this.HataTarih.HeaderText = "Hata Tarih";
            this.HataTarih.Name = "HataTarih";
            this.HataTarih.ReadOnly = true;
            // 
            // HataAciklama
            // 
            this.HataAciklama.DataPropertyName = "HataAciklama";
            this.HataAciklama.FillWeight = 500F;
            this.HataAciklama.HeaderText = "Hata Açıklama";
            this.HataAciklama.Name = "HataAciklama";
            this.HataAciklama.ReadOnly = true;
            // 
            // frmErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmErrorLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLI Console Error Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmErrorLog_FormClosed);
            this.Load += new System.EventHandler(this.frmErrorLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHataAciklama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkHataAciklama;
        private System.Windows.Forms.CheckBox chkHataTarih2;
        private System.Windows.Forms.CheckBox chkHataTarih1;
        private System.Windows.Forms.CheckBox chkDosyaAdi;
        private System.Windows.Forms.Button btnErrorLogListele;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvErrorLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDosyaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataAciklama;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
    }
}
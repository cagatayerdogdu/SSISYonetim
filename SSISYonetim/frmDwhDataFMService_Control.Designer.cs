
namespace SSISYonetim
{
    partial class frmDwhDataFMService_Control
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
            this.dgvDataFMLog = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDataFMServiceKontrolListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkLogAciklama = new System.Windows.Forms.CheckBox();
            this.txtLogAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogKayit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFMLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDataFMLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 15;
            // 
            // dgvDataFMLog
            // 
            this.dgvDataFMLog.AllowUserToAddRows = false;
            this.dgvDataFMLog.AllowUserToDeleteRows = false;
            this.dgvDataFMLog.AllowUserToOrderColumns = true;
            this.dgvDataFMLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataFMLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDataFMLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataFMLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.LogKayit,
            this.LogAciklama,
            this.Stop});
            this.dgvDataFMLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataFMLog.Location = new System.Drawing.Point(0, 0);
            this.dgvDataFMLog.Name = "dgvDataFMLog";
            this.dgvDataFMLog.ReadOnly = true;
            this.dgvDataFMLog.RowHeadersWidth = 60;
            this.dgvDataFMLog.RowTemplate.Height = 25;
            this.dgvDataFMLog.Size = new System.Drawing.Size(961, 338);
            this.dgvDataFMLog.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDataFMServiceKontrolListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkLogAciklama);
            this.panel1.Controls.Add(this.txtLogAciklama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtLogTarih1);
            this.panel1.Controls.Add(this.dtLogTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 14;
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(685, 87);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnDataFMServiceKontrolListele
            // 
            this.btnDataFMServiceKontrolListele.Location = new System.Drawing.Point(819, 73);
            this.btnDataFMServiceKontrolListele.Name = "btnDataFMServiceKontrolListele";
            this.btnDataFMServiceKontrolListele.Size = new System.Drawing.Size(130, 42);
            this.btnDataFMServiceKontrolListele.TabIndex = 12;
            this.btnDataFMServiceKontrolListele.Text = "Listele";
            this.btnDataFMServiceKontrolListele.UseVisualStyleBackColor = true;
            this.btnDataFMServiceKontrolListele.Click += new System.EventHandler(this.btnDataFMServiceKontrolListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(549, 48);
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
            this.chkLogTarih1.Location = new System.Drawing.Point(352, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(150, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "Log Tarihi Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            // 
            // chkLogAciklama
            // 
            this.chkLogAciklama.AutoSize = true;
            this.chkLogAciklama.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogAciklama.Location = new System.Drawing.Point(131, 48);
            this.chkLogAciklama.Name = "chkLogAciklama";
            this.chkLogAciklama.Size = new System.Drawing.Size(119, 19);
            this.chkLogAciklama.TabIndex = 8;
            this.chkLogAciklama.Text = "Log Açıklama Ara";
            this.chkLogAciklama.UseVisualStyleBackColor = true;
            // 
            // txtLogAciklama
            // 
            this.txtLogAciklama.Location = new System.Drawing.Point(127, 19);
            this.txtLogAciklama.Name = "txtLogAciklama";
            this.txtLogAciklama.Size = new System.Drawing.Size(123, 23);
            this.txtLogAciklama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // dtLogTarih1
            // 
            this.dtLogTarih1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih1.Location = new System.Drawing.Point(371, 19);
            this.dtLogTarih1.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih1.Name = "dtLogTarih1";
            this.dtLogTarih1.ShowUpDown = true;
            this.dtLogTarih1.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih1.TabIndex = 3;
            this.dtLogTarih1.Value = new System.DateTime(2022, 11, 11, 22, 44, 31, 0);
            // 
            // dtLogTarih2
            // 
            this.dtLogTarih2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih2.Location = new System.Drawing.Point(566, 19);
            this.dtLogTarih2.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih2.Name = "dtLogTarih2";
            this.dtLogTarih2.ShowUpDown = true;
            this.dtLogTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih2.TabIndex = 4;
            // 
            // LogID
            // 
            this.LogID.DataPropertyName = "LogID";
            this.LogID.FillWeight = 60F;
            this.LogID.HeaderText = "Log ID";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            // 
            // LogKayit
            // 
            this.LogKayit.DataPropertyName = "LogKayit";
            this.LogKayit.HeaderText = "Log Kayıt";
            this.LogKayit.Name = "LogKayit";
            this.LogKayit.ReadOnly = true;
            // 
            // LogAciklama
            // 
            this.LogAciklama.DataPropertyName = "LogAciklama";
            this.LogAciklama.HeaderText = "Log Açıklama";
            this.LogAciklama.Name = "LogAciklama";
            this.LogAciklama.ReadOnly = true;
            // 
            // Stop
            // 
            this.Stop.DataPropertyName = "StopMailGonderildi";
            this.Stop.FillWeight = 90F;
            this.Stop.HeaderText = "Stop Mail Gönderildi";
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            // 
            // frmDwhDataFMService_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDwhDataFMService_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DwhDataFMService Kontrol Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDwhDataFMService_Control_FormClosed);
            this.Load += new System.EventHandler(this.frmDwhDataFMService_Control_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFMLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDataFMLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDataFMServiceKontrolListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkLogAciklama;
        private System.Windows.Forms.TextBox txtLogAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop;
    }
}

namespace SSISYonetim
{
    partial class frmFtpKontrolMF
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
            this.dgvFtpKontrolLog = new System.Windows.Forms.DataGridView();
            this.TStartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TFTPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNewDWHStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSISStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCPadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWHBinDosyaBilgi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkDwhBinDosya = new System.Windows.Forms.CheckBox();
            this.txtDwhBinDosya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFtpKontrolListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkTFTPName = new System.Windows.Forms.CheckBox();
            this.txtTFTPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.chkJCLAra = new System.Windows.Forms.CheckBox();
            this.txtJCL = new System.Windows.Forms.TextBox();
            this.lblJCL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFtpKontrolLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFtpKontrolLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 338);
            this.panel2.TabIndex = 21;
            // 
            // dgvFtpKontrolLog
            // 
            this.dgvFtpKontrolLog.AllowUserToAddRows = false;
            this.dgvFtpKontrolLog.AllowUserToDeleteRows = false;
            this.dgvFtpKontrolLog.AllowUserToOrderColumns = true;
            this.dgvFtpKontrolLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFtpKontrolLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvFtpKontrolLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFtpKontrolLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TStartDateTime,
            this.TFTPName,
            this.TStatus,
            this.TType,
            this.TEndDateTime,
            this.TNewDWHStatus,
            this.SSISStatus,
            this.JCL,
            this.MCPadi,
            this.DWHBinDosyaBilgi});
            this.dgvFtpKontrolLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFtpKontrolLog.Location = new System.Drawing.Point(0, 0);
            this.dgvFtpKontrolLog.Name = "dgvFtpKontrolLog";
            this.dgvFtpKontrolLog.ReadOnly = true;
            this.dgvFtpKontrolLog.RowHeadersWidth = 60;
            this.dgvFtpKontrolLog.RowTemplate.Height = 25;
            this.dgvFtpKontrolLog.Size = new System.Drawing.Size(1194, 338);
            this.dgvFtpKontrolLog.TabIndex = 0;
            // 
            // TStartDateTime
            // 
            this.TStartDateTime.DataPropertyName = "TStartDateTime";
            this.TStartDateTime.FillWeight = 90F;
            this.TStartDateTime.HeaderText = "TStartDateTime";
            this.TStartDateTime.Name = "TStartDateTime";
            this.TStartDateTime.ReadOnly = true;
            // 
            // TFTPName
            // 
            this.TFTPName.DataPropertyName = "TFTPName";
            this.TFTPName.FillWeight = 90F;
            this.TFTPName.HeaderText = "TFTPName";
            this.TFTPName.Name = "TFTPName";
            this.TFTPName.ReadOnly = true;
            // 
            // TStatus
            // 
            this.TStatus.DataPropertyName = "TStatus";
            this.TStatus.FillWeight = 60F;
            this.TStatus.HeaderText = "TStatus";
            this.TStatus.Name = "TStatus";
            this.TStatus.ReadOnly = true;
            // 
            // TType
            // 
            this.TType.DataPropertyName = "TType";
            this.TType.FillWeight = 50F;
            this.TType.HeaderText = "TType";
            this.TType.Name = "TType";
            this.TType.ReadOnly = true;
            // 
            // TEndDateTime
            // 
            this.TEndDateTime.DataPropertyName = "TEndDateTime";
            this.TEndDateTime.FillWeight = 90F;
            this.TEndDateTime.HeaderText = "TEndDateTime";
            this.TEndDateTime.Name = "TEndDateTime";
            this.TEndDateTime.ReadOnly = true;
            // 
            // TNewDWHStatus
            // 
            this.TNewDWHStatus.DataPropertyName = "TNewDWHStatus";
            this.TNewDWHStatus.FillWeight = 70F;
            this.TNewDWHStatus.HeaderText = "TNewDWHStatus";
            this.TNewDWHStatus.Name = "TNewDWHStatus";
            this.TNewDWHStatus.ReadOnly = true;
            // 
            // SSISStatus
            // 
            this.SSISStatus.DataPropertyName = "SSISStatus";
            this.SSISStatus.FillWeight = 70F;
            this.SSISStatus.HeaderText = "SSISStatus";
            this.SSISStatus.Name = "SSISStatus";
            this.SSISStatus.ReadOnly = true;
            // 
            // JCL
            // 
            this.JCL.DataPropertyName = "JCL";
            this.JCL.FillWeight = 80F;
            this.JCL.HeaderText = "JCL";
            this.JCL.Name = "JCL";
            this.JCL.ReadOnly = true;
            // 
            // MCPadi
            // 
            this.MCPadi.DataPropertyName = "MCPadi";
            this.MCPadi.HeaderText = "MCPadi";
            this.MCPadi.Name = "MCPadi";
            this.MCPadi.ReadOnly = true;
            // 
            // DWHBinDosyaBilgi
            // 
            this.DWHBinDosyaBilgi.DataPropertyName = "DWHBinDosyaBilgi";
            this.DWHBinDosyaBilgi.FillWeight = 200F;
            this.DWHBinDosyaBilgi.HeaderText = "DWHBinDosyaBilgi";
            this.DWHBinDosyaBilgi.Name = "DWHBinDosyaBilgi";
            this.DWHBinDosyaBilgi.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkJCLAra);
            this.panel1.Controls.Add(this.txtJCL);
            this.panel1.Controls.Add(this.lblJCL);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkDwhBinDosya);
            this.panel1.Controls.Add(this.txtDwhBinDosya);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFtpKontrolListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkTFTPName);
            this.panel1.Controls.Add(this.txtTFTPName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtLogTarih1);
            this.panel1.Controls.Add(this.dtLogTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 121);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "case SSISStatus when 0 then \'Basarili\' when 1 then \'Calisiyor\' when 2 then \'Hatal" +
    "i\' \r\nwhen 3 then \'Thread Basladi\' when 4 then \'Thread Hatali\' else \'ServisHatasi" +
    "\' end";
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
            // chkDwhBinDosya
            // 
            this.chkDwhBinDosya.AutoSize = true;
            this.chkDwhBinDosya.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDwhBinDosya.Location = new System.Drawing.Point(750, 48);
            this.chkDwhBinDosya.Name = "chkDwhBinDosya";
            this.chkDwhBinDosya.Size = new System.Drawing.Size(147, 19);
            this.chkDwhBinDosya.TabIndex = 18;
            this.chkDwhBinDosya.Text = "DWHBinDosyaBilgi Ara";
            this.chkDwhBinDosya.UseVisualStyleBackColor = true;
            // 
            // txtDwhBinDosya
            // 
            this.txtDwhBinDosya.Location = new System.Drawing.Point(774, 19);
            this.txtDwhBinDosya.Name = "txtDwhBinDosya";
            this.txtDwhBinDosya.Size = new System.Drawing.Size(123, 23);
            this.txtDwhBinDosya.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "DWHBinDosyaBilgi";
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(902, 86);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(848, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnFtpKontrolListele
            // 
            this.btnFtpKontrolListele.Location = new System.Drawing.Point(989, 72);
            this.btnFtpKontrolListele.Name = "btnFtpKontrolListele";
            this.btnFtpKontrolListele.Size = new System.Drawing.Size(130, 42);
            this.btnFtpKontrolListele.TabIndex = 12;
            this.btnFtpKontrolListele.Text = "Listele";
            this.btnFtpKontrolListele.UseVisualStyleBackColor = true;
            this.btnFtpKontrolListele.Click += new System.EventHandler(this.btnFtpKontrolListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(466, 48);
            this.chkLogTarih2.Name = "chkLogTarih2";
            this.chkLogTarih2.Size = new System.Drawing.Size(176, 19);
            this.chkLogTarih2.TabIndex = 10;
            this.chkLogTarih2.Text = "TEndDateTime Küçüktür Ara";
            this.chkLogTarih2.UseVisualStyleBackColor = true;
            this.chkLogTarih2.CheckedChanged += new System.EventHandler(this.chkLogTarih2_CheckedChanged);
            // 
            // chkLogTarih1
            // 
            this.chkLogTarih1.AutoSize = true;
            this.chkLogTarih1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih1.Location = new System.Drawing.Point(267, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(180, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "TStartDateTime Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            this.chkLogTarih1.CheckedChanged += new System.EventHandler(this.chkLogTarih1_CheckedChanged);
            // 
            // chkTFTPName
            // 
            this.chkTFTPName.AutoSize = true;
            this.chkTFTPName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTFTPName.Location = new System.Drawing.Point(92, 48);
            this.chkTFTPName.Name = "chkTFTPName";
            this.chkTFTPName.Size = new System.Drawing.Size(106, 19);
            this.chkTFTPName.TabIndex = 8;
            this.chkTFTPName.Text = "TFTPName Ara";
            this.chkTFTPName.UseVisualStyleBackColor = true;
            // 
            // txtTFTPName
            // 
            this.txtTFTPName.Location = new System.Drawing.Point(75, 19);
            this.txtTFTPName.Name = "txtTFTPName";
            this.txtTFTPName.Size = new System.Drawing.Size(123, 23);
            this.txtTFTPName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TFTPName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TStartDateTime";
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
            // chkJCLAra
            // 
            this.chkJCLAra.AutoSize = true;
            this.chkJCLAra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkJCLAra.Location = new System.Drawing.Point(1047, 47);
            this.chkJCLAra.Name = "chkJCLAra";
            this.chkJCLAra.Size = new System.Drawing.Size(65, 19);
            this.chkJCLAra.TabIndex = 25;
            this.chkJCLAra.Text = "JCL Ara";
            this.chkJCLAra.UseVisualStyleBackColor = true;
            // 
            // txtJCL
            // 
            this.txtJCL.Location = new System.Drawing.Point(989, 19);
            this.txtJCL.Name = "txtJCL";
            this.txtJCL.Size = new System.Drawing.Size(123, 23);
            this.txtJCL.TabIndex = 24;
            // 
            // lblJCL
            // 
            this.lblJCL.AutoSize = true;
            this.lblJCL.Location = new System.Drawing.Point(958, 25);
            this.lblJCL.Name = "lblJCL";
            this.lblJCL.Size = new System.Drawing.Size(25, 15);
            this.lblJCL.TabIndex = 23;
            this.lblJCL.Text = "JCL";
            // 
            // frmFtpKontrolMF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFtpKontrolMF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Kontrol -MF Dosya Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFtpKontrolMF_FormClosed);
            this.Load += new System.EventHandler(this.frmFtpKontrolMF_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFtpKontrolMF_KeyPress);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFtpKontrolLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFtpKontrolLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDwhBinDosya;
        private System.Windows.Forms.TextBox txtDwhBinDosya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFtpKontrolListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkTFTPName;
        private System.Windows.Forms.TextBox txtTFTPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TStartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TFTPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNewDWHStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSISStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCPadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWHBinDosyaBilgi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkJCLAra;
        private System.Windows.Forms.TextBox txtJCL;
        private System.Windows.Forms.Label lblJCL;
    }
}
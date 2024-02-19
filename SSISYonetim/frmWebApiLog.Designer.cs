
namespace SSISYonetim
{
    partial class frmWebApiLog
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
            this.lblSatirSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWebApiLogListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkLogUygulama = new System.Windows.Forms.CheckBox();
            this.txtLogUygulama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dgvWebApiLog = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogUygulama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogZaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogHata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLogDurum = new System.Windows.Forms.CheckBox();
            this.txtLogDurum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebApiLog)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // chkLogUygulama
            // 
            this.chkLogUygulama.AutoSize = true;
            this.chkLogUygulama.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogUygulama.Location = new System.Drawing.Point(100, 48);
            this.chkLogUygulama.Name = "chkLogUygulama";
            this.chkLogUygulama.Size = new System.Drawing.Size(124, 19);
            this.chkLogUygulama.TabIndex = 8;
            this.chkLogUygulama.Text = "Log Uygulama Ara";
            this.chkLogUygulama.UseVisualStyleBackColor = true;
            // 
            // txtLogUygulama
            // 
            this.txtLogUygulama.Location = new System.Drawing.Point(101, 19);
            this.txtLogUygulama.Name = "txtLogUygulama";
            this.txtLogUygulama.Size = new System.Drawing.Size(123, 23);
            this.txtLogUygulama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Uygulama";
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
            // dgvWebApiLog
            // 
            this.dgvWebApiLog.AllowUserToAddRows = false;
            this.dgvWebApiLog.AllowUserToDeleteRows = false;
            this.dgvWebApiLog.AllowUserToOrderColumns = true;
            this.dgvWebApiLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWebApiLog.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvWebApiLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWebApiLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.LogUygulama,
            this.LogZaman,
            this.LogHata,
            this.logResponse,
            this.logDurum});
            this.dgvWebApiLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWebApiLog.Location = new System.Drawing.Point(0, 0);
            this.dgvWebApiLog.Name = "dgvWebApiLog";
            this.dgvWebApiLog.ReadOnly = true;
            this.dgvWebApiLog.RowHeadersWidth = 60;
            this.dgvWebApiLog.RowTemplate.Height = 25;
            this.dgvWebApiLog.Size = new System.Drawing.Size(961, 338);
            this.dgvWebApiLog.TabIndex = 0;
            // 
            // LogID
            // 
            this.LogID.DataPropertyName = "LogID";
            this.LogID.FillWeight = 60F;
            this.LogID.HeaderText = "Log ID";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            // 
            // LogUygulama
            // 
            this.LogUygulama.DataPropertyName = "LogUygulama";
            this.LogUygulama.HeaderText = "Log Uygulama";
            this.LogUygulama.Name = "LogUygulama";
            this.LogUygulama.ReadOnly = true;
            // 
            // LogZaman
            // 
            this.LogZaman.DataPropertyName = "LogZaman";
            this.LogZaman.HeaderText = "Log Zaman";
            this.LogZaman.Name = "LogZaman";
            this.LogZaman.ReadOnly = true;
            // 
            // LogHata
            // 
            this.LogHata.DataPropertyName = "LogHata";
            this.LogHata.FillWeight = 90F;
            this.LogHata.HeaderText = "Log Hata";
            this.LogHata.Name = "LogHata";
            this.LogHata.ReadOnly = true;
            // 
            // logResponse
            // 
            this.logResponse.DataPropertyName = "LogResponse";
            this.logResponse.HeaderText = "Log Response";
            this.logResponse.Name = "logResponse";
            this.logResponse.ReadOnly = true;
            // 
            // logDurum
            // 
            this.logDurum.DataPropertyName = "LogDurum";
            this.logDurum.HeaderText = "Log Durum";
            this.logDurum.Name = "logDurum";
            this.logDurum.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvWebApiLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkLogDurum);
            this.panel1.Controls.Add(this.txtLogDurum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnWebApiLogListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkLogUygulama);
            this.panel1.Controls.Add(this.txtLogUygulama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtLogTarih1);
            this.panel1.Controls.Add(this.dtLogTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 16;
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
            // chkLogDurum
            // 
            this.chkLogDurum.AutoSize = true;
            this.chkLogDurum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogDurum.Location = new System.Drawing.Point(767, 48);
            this.chkLogDurum.Name = "chkLogDurum";
            this.chkLogDurum.Size = new System.Drawing.Size(107, 19);
            this.chkLogDurum.TabIndex = 18;
            this.chkLogDurum.Text = "Log Durum Ara";
            this.chkLogDurum.UseVisualStyleBackColor = true;
            // 
            // txtLogDurum
            // 
            this.txtLogDurum.Location = new System.Drawing.Point(751, 19);
            this.txtLogDurum.Name = "txtLogDurum";
            this.txtLogDurum.Size = new System.Drawing.Size(123, 23);
            this.txtLogDurum.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Log Durum";
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
            // frmWebApiLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmWebApiLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web API Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWebApiLog_FormClosed);
            this.Load += new System.EventHandler(this.frmWebApiLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebApiLog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWebApiLogListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkLogUygulama;
        private System.Windows.Forms.TextBox txtLogUygulama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        private System.Windows.Forms.DataGridView dgvWebApiLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogUygulama;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogZaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogHata;
        private System.Windows.Forms.DataGridViewTextBoxColumn logResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDurum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.CheckBox chkLogDurum;
        private System.Windows.Forms.TextBox txtLogDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
    }
}
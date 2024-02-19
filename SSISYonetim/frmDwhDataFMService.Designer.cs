
namespace SSISYonetim
{
    partial class frmDwhDataFMService
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
            this.btnDataFMServiceListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkLogTip = new System.Windows.Forms.CheckBox();
            this.txtLogTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dgvDataFMLog = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkParameters = new System.Windows.Forms.CheckBox();
            this.txtParameters = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFMLog)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnDataFMServiceListele
            // 
            this.btnDataFMServiceListele.Location = new System.Drawing.Point(819, 73);
            this.btnDataFMServiceListele.Name = "btnDataFMServiceListele";
            this.btnDataFMServiceListele.Size = new System.Drawing.Size(130, 42);
            this.btnDataFMServiceListele.TabIndex = 12;
            this.btnDataFMServiceListele.Text = "Listele";
            this.btnDataFMServiceListele.UseVisualStyleBackColor = true;
            this.btnDataFMServiceListele.Click += new System.EventHandler(this.btnDataFMServiceListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(480, 48);
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
            this.chkLogTarih1.Location = new System.Drawing.Point(283, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(150, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "Log Tarihi Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            // 
            // chkLogTip
            // 
            this.chkLogTip.AutoSize = true;
            this.chkLogTip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTip.Location = new System.Drawing.Point(123, 51);
            this.chkLogTip.Name = "chkLogTip";
            this.chkLogTip.Size = new System.Drawing.Size(87, 19);
            this.chkLogTip.TabIndex = 8;
            this.chkLogTip.Text = "Log Tip Ara";
            this.chkLogTip.UseVisualStyleBackColor = true;
            // 
            // txtLogTip
            // 
            this.txtLogTip.Location = new System.Drawing.Point(87, 22);
            this.txtLogTip.Name = "txtLogTip";
            this.txtLogTip.Size = new System.Drawing.Size(123, 23);
            this.txtLogTip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "between";
            // 
            // dtLogTarih1
            // 
            this.dtLogTarih1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih1.Location = new System.Drawing.Point(302, 19);
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
            this.dtLogTarih2.Location = new System.Drawing.Point(497, 19);
            this.dtLogTarih2.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih2.Name = "dtLogTarih2";
            this.dtLogTarih2.ShowUpDown = true;
            this.dtLogTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih2.TabIndex = 4;
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
            this.ProcessNo,
            this.User_Name,
            this.LogDate,
            this.LogType,
            this.Method,
            this.Parameters,
            this.Message,
            this.UserIP});
            this.dgvDataFMLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataFMLog.Location = new System.Drawing.Point(0, 0);
            this.dgvDataFMLog.Name = "dgvDataFMLog";
            this.dgvDataFMLog.ReadOnly = true;
            this.dgvDataFMLog.RowHeadersWidth = 60;
            this.dgvDataFMLog.RowTemplate.Height = 25;
            this.dgvDataFMLog.Size = new System.Drawing.Size(961, 338);
            this.dgvDataFMLog.TabIndex = 0;
            // 
            // LogID
            // 
            this.LogID.DataPropertyName = "LogID";
            this.LogID.FillWeight = 60F;
            this.LogID.HeaderText = "Log ID";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            // 
            // ProcessNo
            // 
            this.ProcessNo.DataPropertyName = "ProcessNo";
            this.ProcessNo.HeaderText = "Process No";
            this.ProcessNo.Name = "ProcessNo";
            this.ProcessNo.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "UserName";
            this.User_Name.FillWeight = 90F;
            this.User_Name.HeaderText = "User Name";
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // LogDate
            // 
            this.LogDate.DataPropertyName = "LogDate";
            this.LogDate.HeaderText = "Log Date";
            this.LogDate.Name = "LogDate";
            this.LogDate.ReadOnly = true;
            // 
            // LogType
            // 
            this.LogType.DataPropertyName = "LogType";
            this.LogType.FillWeight = 70F;
            this.LogType.HeaderText = "Log Type";
            this.LogType.Name = "LogType";
            this.LogType.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.DataPropertyName = "Method";
            this.Method.FillWeight = 150F;
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // Parameters
            // 
            this.Parameters.DataPropertyName = "Parameters";
            this.Parameters.HeaderText = "Parameters";
            this.Parameters.Name = "Parameters";
            this.Parameters.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.FillWeight = 375F;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // UserIP
            // 
            this.UserIP.DataPropertyName = "UserIp";
            this.UserIP.FillWeight = 70F;
            this.UserIP.HeaderText = "User IP";
            this.UserIP.Name = "UserIP";
            this.UserIP.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDataFMLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkParameters);
            this.panel1.Controls.Add(this.txtParameters);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDataFMServiceListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkLogTip);
            this.panel1.Controls.Add(this.txtLogTip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtLogTarih1);
            this.panel1.Controls.Add(this.dtLogTarih2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 121);
            this.panel1.TabIndex = 12;
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(66, 84);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 19;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Top N";
            // 
            // chkParameters
            // 
            this.chkParameters.AutoSize = true;
            this.chkParameters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkParameters.Location = new System.Drawing.Point(810, 48);
            this.chkParameters.Name = "chkParameters";
            this.chkParameters.Size = new System.Drawing.Size(87, 19);
            this.chkParameters.TabIndex = 17;
            this.chkParameters.Text = "ETL Adı Ara";
            this.chkParameters.UseVisualStyleBackColor = true;
            // 
            // txtParameters
            // 
            this.txtParameters.Location = new System.Drawing.Point(718, 19);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Size = new System.Drawing.Size(179, 23);
            this.txtParameters.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "ETL Adı";
            // 
            // frmDwhDataFMService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDwhDataFMService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DwhDataFMService Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDwhDataFMService_FormClosed);
            this.Load += new System.EventHandler(this.frmDwhDataFMService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFMLog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDataFMServiceListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkLogTip;
        private System.Windows.Forms.TextBox txtLogTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        private System.Windows.Forms.DataGridView dgvDataFMLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkParameters;
        private System.Windows.Forms.TextBox txtParameters;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIP;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
    }
}

namespace SSISYonetim
{
    partial class frmSessionKontrol
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
            this.btnSessionKontrolListele = new System.Windows.Forms.Button();
            this.dgvSessionKontrol = new System.Windows.Forms.DataGridView();
            this.Sec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTextSorgu = new System.Windows.Forms.CheckBox();
            this.btnSeciliKill = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoginName = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.chkLoginName = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionKontrol)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(57, 43);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnSessionKontrolListele
            // 
            this.btnSessionKontrolListele.Location = new System.Drawing.Point(3, 73);
            this.btnSessionKontrolListele.Name = "btnSessionKontrolListele";
            this.btnSessionKontrolListele.Size = new System.Drawing.Size(130, 42);
            this.btnSessionKontrolListele.TabIndex = 12;
            this.btnSessionKontrolListele.Text = "Listele";
            this.btnSessionKontrolListele.UseVisualStyleBackColor = true;
            this.btnSessionKontrolListele.Click += new System.EventHandler(this.btnSessionKontrolListele_Click);
            // 
            // dgvSessionKontrol
            // 
            this.dgvSessionKontrol.AllowUserToAddRows = false;
            this.dgvSessionKontrol.AllowUserToDeleteRows = false;
            this.dgvSessionKontrol.AllowUserToOrderColumns = true;
            this.dgvSessionKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionKontrol.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSessionKontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSessionKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sec});
            this.dgvSessionKontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessionKontrol.Location = new System.Drawing.Point(0, 0);
            this.dgvSessionKontrol.Name = "dgvSessionKontrol";
            this.dgvSessionKontrol.RowHeadersWidth = 60;
            this.dgvSessionKontrol.RowTemplate.Height = 25;
            this.dgvSessionKontrol.Size = new System.Drawing.Size(1196, 338);
            this.dgvSessionKontrol.TabIndex = 0;
            this.dgvSessionKontrol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessionKontrol_CellContentClick);
            this.dgvSessionKontrol.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessionKontrol_CellValueChanged);
            // 
            // Sec
            // 
            this.Sec.FillWeight = 40F;
            this.Sec.HeaderText = "Seç";
            this.Sec.Name = "Sec";
            this.Sec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSessionKontrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 338);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkTextSorgu);
            this.panel1.Controls.Add(this.btnSeciliKill);
            this.panel1.Controls.Add(this.txtText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbLoginName);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.chkLoginName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSessionKontrolListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 121);
            this.panel1.TabIndex = 20;
            // 
            // chkTextSorgu
            // 
            this.chkTextSorgu.AutoSize = true;
            this.chkTextSorgu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTextSorgu.Location = new System.Drawing.Point(831, 41);
            this.chkTextSorgu.Name = "chkTextSorgu";
            this.chkTextSorgu.Size = new System.Drawing.Size(110, 19);
            this.chkTextSorgu.TabIndex = 24;
            this.chkTextSorgu.Text = "Text - Sorgu Ara";
            this.chkTextSorgu.UseVisualStyleBackColor = true;
            // 
            // btnSeciliKill
            // 
            this.btnSeciliKill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSeciliKill.Location = new System.Drawing.Point(1068, 0);
            this.btnSeciliKill.Name = "btnSeciliKill";
            this.btnSeciliKill.Size = new System.Drawing.Size(128, 121);
            this.btnSeciliKill.TabIndex = 24;
            this.btnSeciliKill.Text = "Seçilileri KILL Et";
            this.btnSeciliKill.UseVisualStyleBackColor = true;
            this.btnSeciliKill.Click += new System.EventHandler(this.btnSeciliKill_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(818, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(123, 23);
            this.txtText.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Text - Sorgu";
            // 
            // cmbLoginName
            // 
            this.cmbLoginName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginName.FormattingEnabled = true;
            this.cmbLoginName.Location = new System.Drawing.Point(471, 12);
            this.cmbLoginName.Name = "cmbLoginName";
            this.cmbLoginName.Size = new System.Drawing.Size(226, 23);
            this.cmbLoginName.TabIndex = 23;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(212, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(145, 23);
            this.cmbStatus.TabIndex = 22;
            // 
            // chkLoginName
            // 
            this.chkLoginName.AutoSize = true;
            this.chkLoginName.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLoginName.Location = new System.Drawing.Point(585, 39);
            this.chkLoginName.Name = "chkLoginName";
            this.chkLoginName.Size = new System.Drawing.Size(112, 19);
            this.chkLoginName.TabIndex = 21;
            this.chkLoginName.Text = "Login Name Ara";
            this.chkLoginName.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login Name";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Location = new System.Drawing.Point(278, 41);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(79, 19);
            this.chkStatus.TabIndex = 17;
            this.chkStatus.Text = "Status Ara";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            // 
            // frmSessionKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSessionKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Kontrol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSessionKontrol_FormClosed);
            this.Load += new System.EventHandler(this.frmSessionKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionKontrol)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSessionKontrolListele;
        private System.Windows.Forms.DataGridView dgvSessionKontrol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoginName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sec;
        private System.Windows.Forms.Button btnSeciliKill;
        private System.Windows.Forms.CheckBox chkTextSorgu;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label2;
    }
}

namespace SSISYonetim
{
    partial class frmSSISHataLog
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
            this.btnSSISHataLogListele = new System.Windows.Forms.Button();
            this.chkLogTarih2 = new System.Windows.Forms.CheckBox();
            this.chkLogTarih1 = new System.Windows.Forms.CheckBox();
            this.chkPaketAdi = new System.Windows.Forms.CheckBox();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLogTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDwhDosyaAdi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtLogTarih2 = new System.Windows.Forms.DateTimePicker();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaketAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HataMesaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDwhDosyaAdi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSatirSayi
            // 
            this.lblSatirSayi.AutoSize = true;
            this.lblSatirSayi.Location = new System.Drawing.Point(745, 87);
            this.lblSatirSayi.Name = "lblSatirSayi";
            this.lblSatirSayi.Size = new System.Drawing.Size(0, 15);
            this.lblSatirSayi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Satır Sayı:";
            // 
            // btnSSISHataLogListele
            // 
            this.btnSSISHataLogListele.Location = new System.Drawing.Point(819, 73);
            this.btnSSISHataLogListele.Name = "btnSSISHataLogListele";
            this.btnSSISHataLogListele.Size = new System.Drawing.Size(130, 42);
            this.btnSSISHataLogListele.TabIndex = 12;
            this.btnSSISHataLogListele.Text = "Listele";
            this.btnSSISHataLogListele.UseVisualStyleBackColor = true;
            this.btnSSISHataLogListele.Click += new System.EventHandler(this.btnSSISHataLogListele_Click);
            // 
            // chkLogTarih2
            // 
            this.chkLogTarih2.AutoSize = true;
            this.chkLogTarih2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih2.Location = new System.Drawing.Point(550, 48);
            this.chkLogTarih2.Name = "chkLogTarih2";
            this.chkLogTarih2.Size = new System.Drawing.Size(214, 19);
            this.chkLogTarih2.TabIndex = 10;
            this.chkLogTarih2.Text = "Baslangıç Bitiş Zamanı Arasında Ara";
            this.chkLogTarih2.UseVisualStyleBackColor = true;
            // 
            // chkLogTarih1
            // 
            this.chkLogTarih1.AutoSize = true;
            this.chkLogTarih1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogTarih1.Location = new System.Drawing.Point(335, 48);
            this.chkLogTarih1.Name = "chkLogTarih1";
            this.chkLogTarih1.Size = new System.Drawing.Size(191, 19);
            this.chkLogTarih1.TabIndex = 9;
            this.chkLogTarih1.Text = "Başlangıç Zamanı Büyüktür Ara";
            this.chkLogTarih1.UseVisualStyleBackColor = true;
            // 
            // chkPaketAdi
            // 
            this.chkPaketAdi.AutoSize = true;
            this.chkPaketAdi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPaketAdi.Location = new System.Drawing.Point(116, 48);
            this.chkPaketAdi.Name = "chkPaketAdi";
            this.chkPaketAdi.Size = new System.Drawing.Size(97, 19);
            this.chkPaketAdi.TabIndex = 8;
            this.chkPaketAdi.Text = "Paket Adı Ara";
            this.chkPaketAdi.UseVisualStyleBackColor = true;
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(90, 19);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(123, 23);
            this.txtDosyaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paket Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç ve Bitiş Zamanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 25);
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
            this.PaketAdi,
            this.BaslangicZamani,
            this.BitisZamani,
            this.HataMesaji});
            this.dgvDwhDosyaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDwhDosyaAdi.Location = new System.Drawing.Point(0, 0);
            this.dgvDwhDosyaAdi.Name = "dgvDwhDosyaAdi";
            this.dgvDwhDosyaAdi.ReadOnly = true;
            this.dgvDwhDosyaAdi.RowHeadersWidth = 60;
            this.dgvDwhDosyaAdi.RowTemplate.Height = 25;
            this.dgvDwhDosyaAdi.Size = new System.Drawing.Size(961, 338);
            this.dgvDwhDosyaAdi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDwhDosyaAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 338);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTopN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSatirSayi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSSISHataLogListele);
            this.panel1.Controls.Add(this.chkLogTarih2);
            this.panel1.Controls.Add(this.chkLogTarih1);
            this.panel1.Controls.Add(this.chkPaketAdi);
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
            this.panel1.TabIndex = 20;
            // 
            // dtLogTarih2
            // 
            this.dtLogTarih2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtLogTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLogTarih2.Location = new System.Drawing.Point(633, 19);
            this.dtLogTarih2.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtLogTarih2.Name = "dtLogTarih2";
            this.dtLogTarih2.ShowUpDown = true;
            this.dtLogTarih2.Size = new System.Drawing.Size(131, 23);
            this.dtLogTarih2.TabIndex = 4;
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(77, 84);
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(67, 23);
            this.txtTopN.TabIndex = 23;
            this.txtTopN.Text = "500";
            this.txtTopN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Top N";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "LogID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PaketAdi
            // 
            this.PaketAdi.DataPropertyName = "PaketAdi";
            this.PaketAdi.HeaderText = "Paket Adı";
            this.PaketAdi.Name = "PaketAdi";
            this.PaketAdi.ReadOnly = true;
            // 
            // BaslangicZamani
            // 
            this.BaslangicZamani.DataPropertyName = "BaslangicZamani";
            this.BaslangicZamani.HeaderText = "Başlangıç Zamanı";
            this.BaslangicZamani.Name = "BaslangicZamani";
            this.BaslangicZamani.ReadOnly = true;
            // 
            // BitisZamani
            // 
            this.BitisZamani.DataPropertyName = "BitisZamani";
            this.BitisZamani.FillWeight = 90F;
            this.BitisZamani.HeaderText = "Bitiş Zamanı";
            this.BitisZamani.Name = "BitisZamani";
            this.BitisZamani.ReadOnly = true;
            // 
            // HataMesaji
            // 
            this.HataMesaji.DataPropertyName = "HataMesaji";
            this.HataMesaji.HeaderText = "Hata Mesajı";
            this.HataMesaji.Name = "HataMesaji";
            this.HataMesaji.ReadOnly = true;
            // 
            // frmSSISHataLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSSISHataLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSIS Hata Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSSISHataLog_FormClosed);
            this.Load += new System.EventHandler(this.frmSSISHataLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDwhDosyaAdi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSatirSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSSISHataLogListele;
        private System.Windows.Forms.CheckBox chkLogTarih2;
        private System.Windows.Forms.CheckBox chkLogTarih1;
        private System.Windows.Forms.CheckBox chkPaketAdi;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtLogTarih1;
        private System.Windows.Forms.DataGridView dgvDwhDosyaAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtLogTarih2;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaketAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn HataMesaji;
    }
}
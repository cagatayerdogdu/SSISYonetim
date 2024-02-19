
namespace SSISYonetim
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gunlukSSISKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSSISEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logMonitörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLIConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwhDataFmServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwhDataFmServiceKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webAPILogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwhDosyaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSISHataLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPKontrolMFFileBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.sessionKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gunlukSSISKontrolToolStripMenuItem,
            this.yeniSSISEkleToolStripMenuItem,
            this.logMonitörToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gunlukSSISKontrolToolStripMenuItem
            // 
            this.gunlukSSISKontrolToolStripMenuItem.Name = "gunlukSSISKontrolToolStripMenuItem";
            this.gunlukSSISKontrolToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gunlukSSISKontrolToolStripMenuItem.Tag = "gunluk_kontrol";
            this.gunlukSSISKontrolToolStripMenuItem.Text = "Günlük SSIS Kontrol";
            this.gunlukSSISKontrolToolStripMenuItem.Click += new System.EventHandler(this.gunlukSSISKontrolToolStripMenuItem_Click);
            // 
            // yeniSSISEkleToolStripMenuItem
            // 
            this.yeniSSISEkleToolStripMenuItem.Name = "yeniSSISEkleToolStripMenuItem";
            this.yeniSSISEkleToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.yeniSSISEkleToolStripMenuItem.Tag = "yeni_ssis_ekle";
            this.yeniSSISEkleToolStripMenuItem.Text = "Yeni SSIS Ekle";
            this.yeniSSISEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniSSISEkleToolStripMenuItem_Click);
            // 
            // logMonitörToolStripMenuItem
            // 
            this.logMonitörToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLIConsoleToolStripMenuItem,
            this.dwhDataFmServiceToolStripMenuItem,
            this.dwhDataFmServiceKontrolToolStripMenuItem,
            this.webAPILogToolStripMenuItem,
            this.dwhDosyaBilgileriToolStripMenuItem,
            this.sSISHataLogToolStripMenuItem,
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem,
            this.fTPKontrolMFFileBilgileriToolStripMenuItem,
            this.sessionKontrolToolStripMenuItem});
            this.logMonitörToolStripMenuItem.Name = "logMonitörToolStripMenuItem";
            this.logMonitörToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.logMonitörToolStripMenuItem.Text = "Log Monitör";
            // 
            // pLIConsoleToolStripMenuItem
            // 
            this.pLIConsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLogToolStripMenuItem,
            this.dosyaLogToolStripMenuItem});
            this.pLIConsoleToolStripMenuItem.Name = "pLIConsoleToolStripMenuItem";
            this.pLIConsoleToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.pLIConsoleToolStripMenuItem.Text = "PLI Console";
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.errorLogToolStripMenuItem.Tag = "error_log";
            this.errorLogToolStripMenuItem.Text = "Error Log";
            this.errorLogToolStripMenuItem.Click += new System.EventHandler(this.errorLogToolStripMenuItem_Click);
            // 
            // dosyaLogToolStripMenuItem
            // 
            this.dosyaLogToolStripMenuItem.Name = "dosyaLogToolStripMenuItem";
            this.dosyaLogToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dosyaLogToolStripMenuItem.Tag = "dosya_log";
            this.dosyaLogToolStripMenuItem.Text = "Dosya Log";
            this.dosyaLogToolStripMenuItem.Click += new System.EventHandler(this.dosyaLogToolStripMenuItem_Click);
            // 
            // dwhDataFmServiceToolStripMenuItem
            // 
            this.dwhDataFmServiceToolStripMenuItem.Name = "dwhDataFmServiceToolStripMenuItem";
            this.dwhDataFmServiceToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.dwhDataFmServiceToolStripMenuItem.Tag = "ddfm_service";
            this.dwhDataFmServiceToolStripMenuItem.Text = "DwhDataFmService";
            this.dwhDataFmServiceToolStripMenuItem.Click += new System.EventHandler(this.dwhDataFmServiceToolStripMenuItem_Click);
            // 
            // dwhDataFmServiceKontrolToolStripMenuItem
            // 
            this.dwhDataFmServiceKontrolToolStripMenuItem.Name = "dwhDataFmServiceKontrolToolStripMenuItem";
            this.dwhDataFmServiceKontrolToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.dwhDataFmServiceKontrolToolStripMenuItem.Tag = "ddfm_service_kontrol";
            this.dwhDataFmServiceKontrolToolStripMenuItem.Text = "DwhDataFmService Kontrol";
            this.dwhDataFmServiceKontrolToolStripMenuItem.Click += new System.EventHandler(this.dwhDataFmServiceKontrolToolStripMenuItem_Click);
            // 
            // webAPILogToolStripMenuItem
            // 
            this.webAPILogToolStripMenuItem.Name = "webAPILogToolStripMenuItem";
            this.webAPILogToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.webAPILogToolStripMenuItem.Tag = "webapi_log";
            this.webAPILogToolStripMenuItem.Text = "Web API Log";
            this.webAPILogToolStripMenuItem.Click += new System.EventHandler(this.webAPILogToolStripMenuItem_Click);
            // 
            // dwhDosyaBilgileriToolStripMenuItem
            // 
            this.dwhDosyaBilgileriToolStripMenuItem.Name = "dwhDosyaBilgileriToolStripMenuItem";
            this.dwhDosyaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.dwhDosyaBilgileriToolStripMenuItem.Tag = "dwh_dosya_bilgileri";
            this.dwhDosyaBilgileriToolStripMenuItem.Text = "Dwh Dosya Bilgileri";
            this.dwhDosyaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.dwhDosyaBilgileriToolStripMenuItem_Click);
            // 
            // sSISHataLogToolStripMenuItem
            // 
            this.sSISHataLogToolStripMenuItem.Name = "sSISHataLogToolStripMenuItem";
            this.sSISHataLogToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sSISHataLogToolStripMenuItem.Tag = "ssis_hata_log";
            this.sSISHataLogToolStripMenuItem.Text = "SSIS Hata Log";
            this.sSISHataLogToolStripMenuItem.Click += new System.EventHandler(this.sSISHataLogToolStripMenuItem_Click);
            // 
            // sSISGünlükÇalışmaAdımlarıToolStripMenuItem
            // 
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem.Name = "sSISGünlükÇalışmaAdımlarıToolStripMenuItem";
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem.Tag = "ssis_gunluk_calisma_adimlari";
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem.Text = "SSIS Günlük Çalışma Adımları";
            this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem.Click += new System.EventHandler(this.sSISGünlükÇalışmaAdımlarıToolStripMenuItem_Click);
            // 
            // fTPKontrolMFFileBilgileriToolStripMenuItem
            // 
            this.fTPKontrolMFFileBilgileriToolStripMenuItem.Name = "fTPKontrolMFFileBilgileriToolStripMenuItem";
            this.fTPKontrolMFFileBilgileriToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.fTPKontrolMFFileBilgileriToolStripMenuItem.Tag = "ftp_kontrol";
            this.fTPKontrolMFFileBilgileriToolStripMenuItem.Text = "FTP Kontrol - MF File Bilgileri";
            this.fTPKontrolMFFileBilgileriToolStripMenuItem.Click += new System.EventHandler(this.fTPKontrolMFFileBilgileriToolStripMenuItem_Click);
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.ItemSize = new System.Drawing.Size(0, 20);
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1098, 25);
            this.tcMain.TabIndex = 9;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // sessionKontrolToolStripMenuItem
            // 
            this.sessionKontrolToolStripMenuItem.Name = "sessionKontrolToolStripMenuItem";
            this.sessionKontrolToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sessionKontrolToolStripMenuItem.Tag = "session_kontrol";
            this.sessionKontrolToolStripMenuItem.Text = "Session Kontrol";
            this.sessionKontrolToolStripMenuItem.Click += new System.EventHandler(this.sessionKontrolToolStripMenuItem_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 444);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnasayfa";
            this.Text = "SSIS Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnasayfa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnasayfa_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gunlukSSISKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSSISEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logMonitörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLIConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwhDataFmServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwhDataFmServiceKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webAPILogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwhDosyaBilgileriToolStripMenuItem;
        public System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem sSISHataLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSISGünlükÇalışmaAdımlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPKontrolMFFileBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionKontrolToolStripMenuItem;
    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSISYonetim
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        public int EkranSayisi = -1;
        public List<Form> DiziFormlar = new List<Form>();
        public List<string> DiziFormNo = new List<string>();
        public List<string> DiziFormTag = new List<string>();
        private void gunlukSSISKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            frmGunlukKontrol frmGunlukKontrol = new frmGunlukKontrol();
            frmGunlukKontrol.MdiParent = this;           

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmGunlukKontrol.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmGunlukKontrol.Show();
                frmGunlukKontrol.EkranNo = EkranSayisi.ToString();
                frmGunlukKontrol.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmGunlukKontrol);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void yeniSSISEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniSSISEkle frmYenisisEkle = new frmYeniSSISEkle();
            frmYenisisEkle.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmYenisisEkle.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmYenisisEkle.Show();
                frmYenisisEkle.EkranNo = EkranSayisi.ToString();
                frmYenisisEkle.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmYenisisEkle);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmErrorLog frmErrorLog = new frmErrorLog();
            frmErrorLog.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmErrorLog.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmErrorLog.Show();
                frmErrorLog.EkranNo = EkranSayisi.ToString();
                frmErrorLog.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmErrorLog);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void dosyaLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDosyaLog frmDosyaLog = new frmDosyaLog();
            frmDosyaLog.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmDosyaLog.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmDosyaLog.Show();
                frmDosyaLog.EkranNo = EkranSayisi.ToString();
                frmDosyaLog.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmDosyaLog);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void dwhDataFmServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDwhDataFMService frmDwhDataFMService = new frmDwhDataFMService();
            frmDwhDataFMService.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmDwhDataFMService.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmDwhDataFMService.Show();
                frmDwhDataFMService.EkranNo = EkranSayisi.ToString();
                frmDwhDataFMService.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmDwhDataFMService);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void dwhDataFmServiceKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDwhDataFMService_Control frmDwhDataFMService_Control = new frmDwhDataFMService_Control();
            frmDwhDataFMService_Control.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmDwhDataFMService_Control.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmDwhDataFMService_Control.Show();
                frmDwhDataFMService_Control.EkranNo = EkranSayisi.ToString();
                frmDwhDataFMService_Control.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmDwhDataFMService_Control);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void webAPILogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWebApiLog frmWebApiLog = new frmWebApiLog();
            frmWebApiLog.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmWebApiLog.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmWebApiLog.Show();
                frmWebApiLog.EkranNo = EkranSayisi.ToString();
                frmWebApiLog.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmWebApiLog);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void dwhDosyaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDwhDosyaBilgileri frmDwhDosyaBilgileri = new frmDwhDosyaBilgileri();
            frmDwhDosyaBilgileri.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmDwhDosyaBilgileri.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmDwhDosyaBilgileri.Show();
                frmDwhDosyaBilgileri.EkranNo = EkranSayisi.ToString();
                frmDwhDosyaBilgileri.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmDwhDosyaBilgileri);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void sSISHataLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSSISHataLog frmSSISHataLog = new frmSSISHataLog();
            frmSSISHataLog.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmSSISHataLog.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmSSISHataLog.Show();
                frmSSISHataLog.EkranNo = EkranSayisi.ToString();
                frmSSISHataLog.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmSSISHataLog);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void sSISGünlükÇalışmaAdımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSSISGunlukCalisma frmSSISGunlukCalisma = new frmSSISGunlukCalisma();
            frmSSISGunlukCalisma.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmSSISGunlukCalisma.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmSSISGunlukCalisma.Show();
                frmSSISGunlukCalisma.EkranNo = EkranSayisi.ToString();
                frmSSISGunlukCalisma.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmSSISGunlukCalisma);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void fTPKontrolMFFileBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFtpKontrolMF frmFtpKontrolMF = new frmFtpKontrolMF();
            frmFtpKontrolMF.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmFtpKontrolMF.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmFtpKontrolMF.Show();
                frmFtpKontrolMF.EkranNo = EkranSayisi.ToString();
                frmFtpKontrolMF.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmFtpKontrolMF);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }
        private void sessionKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSessionKontrol frmSessionKontrol = new frmSessionKontrol();
            frmSessionKontrol.MdiParent = this;

            if (DiziFormTag.Contains(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                TabSec(((ToolStripMenuItem)sender).Tag.ToString());
            }
            else
            {
                EkranSayisi++;
                TabPage tp = new TabPage();
                tp.Parent = tcMain;
                tp.Text = frmSessionKontrol.Text;
                tp.Tag = ((ToolStripMenuItem)sender).Tag.ToString();
                tp.Show();

                frmSessionKontrol.Show();
                frmSessionKontrol.EkranNo = EkranSayisi.ToString();
                frmSessionKontrol.frmAnasayfa = this;
                tcMain.SelectedTab = tp;
                DiziFormlar.Add(frmSessionKontrol);
                DiziFormNo.Add(EkranSayisi.ToString());
                DiziFormTag.Add(((ToolStripMenuItem)sender).Tag.ToString());
            }
        }

        private void frmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Cevap = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz?", "Program kapatılacak", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = (Cevap == DialogResult.No);
        }

        private void frmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        public void TabCikar(string TabTag)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == TabTag)
                {
                    tcMain.TabPages.Remove(tabPag);
                }
            }
            SonTabSec();
        }

        public void TabSec(string TabTag)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == TabTag)
                {
                    tcMain.SelectedTab = tabPag;
                    break;
                }
            }
        }

        public void SonTabSec()
        {
            int TabSayisi = tcMain.TabCount;
            int Sayac = 0;
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                Sayac++;
                if (Sayac == TabSayisi)
                {
                    tcMain.SelectedTab = tabPag;
                    break;
                }
            }
        }

        public void FormSec(string formNo)
        {
            foreach (TabPage tabPag in tcMain.TabPages)
            {
                if (tabPag.Tag.ToString() == formNo)
                {
                    tcMain.SelectedTab = tabPag;
                }
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Sayac = -1;
            if (tcMain.TabPages.Count == 0) return;

            string seciliNo = tcMain.SelectedTab.Tag.ToString();
            foreach (Form frm in DiziFormlar)
            {
                Sayac++;
                if (seciliNo == DiziFormTag[Sayac])
                {
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
        }

    }
}

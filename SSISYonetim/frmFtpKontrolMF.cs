using Microsoft.EntityFrameworkCore;
using SSISYonetim.Models.HostDataMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SSISYonetim
{
    public partial class frmFtpKontrolMF : Form
    {
        public frmFtpKontrolMF()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private int DwhBinDosyaBilgi = 0;
        private void frmFtpKontrolMF_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);

        }
        private void frmFtpKontrolMF_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("ftp_kontrol");
            frmAnasayfa.TabCikar("ftp_kontrol");
        }
        private void frmFtpKontrolMF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FtpKontrolMfFileBilgiGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new HostDataMasterContext())
                {
                    if (chkTFTPName.Checked)
                    {
                        if (txtTFTPName.Text == "")
                        {
                            MessageBox.Show("TFTPName Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                       .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                       .Where(w => w.TFTPName.Contains(txtTFTPName.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvFtpKontrolLog.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                       .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                       .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1))
                                       .Take(topN)
                                       .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TEndDateTime <= Convert.ToDateTime(dt2))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1) && w.TEndDateTime <= Convert.ToDateTime(dt2))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtTFTPName.Text != "" && chkTFTPName.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1) && w.TFTPName.Contains(txtTFTPName.Text.ToUpper()))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                    }
                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtTFTPName.Text != "" && chkTFTPName.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1) && w.TEndDateTime <= Convert.ToDateTime(dt2)
                                            && w.TFTPName.Contains(txtTFTPName.Text.ToUpper()))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtDwhBinDosya.Text != "" && chkDwhBinDosya.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1) && w.DWHBinDosyaBilgi.Contains(txtDwhBinDosya.Text))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                        DwhBinDosyaBilgi = 1;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtDwhBinDosya.Text != "" && chkDwhBinDosya.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                        .Where(w => w.TStartDateTime >= Convert.ToDateTime(dt1) && w.TEndDateTime <= Convert.ToDateTime(dt2)
                                            && w.DWHBinDosyaBilgi.Contains(txtDwhBinDosya.Text.ToString()))
                                        .Take(topN)
                                        .ToList();
                        dgvFtpKontrolLog.DataSource = list;
                        DwhBinDosyaBilgi = 2;
                    }
                    if (chkDwhBinDosya.Checked && DwhBinDosyaBilgi == 0)
                    {
                        if (txtDwhBinDosya.Text == "")
                        {
                            MessageBox.Show("DwhBinDosyaBilgi Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                         .Where(w => w.DWHBinDosyaBilgi.Contains(txtDwhBinDosya.Text.ToString()))
                                         .Take(topN)
                                         .ToList();
                            dgvFtpKontrolLog.DataSource = list;
                        }
                    }

                    if (chkJCLAra.Checked)
                    {
                        if (chkJCLAra.Text == "")
                        {
                            MessageBox.Show("JCL Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            var list = db.TblFtpControl
                                         .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                        .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                         .Where(w => w.JCL.Contains(txtJCL.Text.ToString()))
                                         .Take(topN)
                                         .ToList();
                            dgvFtpKontrolLog.DataSource = list;
                        }
                    }

                    if (!chkTFTPName.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked && !chkDwhBinDosya.Checked && !chkJCLAra.Checked)
                    {
                        //Thread th = new Thread(new ThreadStart(() =>
                        //   dgvWebApiLog.DataSource = db.TblSsisgunlukCalismaAdimlaris
                        //               .OrderByDescending(o => o.Zaman).ThenBy(t=> t.KayitNo).ToList()));
                        //th.Start();
                        //Thread.Sleep(150);
                        List<string> istenmeyenler = new List<string>
                            (new []
                            {
                               "LCWORKDAILY","GNTCKMDAILY","WRLDKAMPN","RTSACIKLDAILY","ECCFDRAFTREV"
                                ,"TAVHARKTDAILY","TAVHARINDAILY","CTBTRANSINFO","CTBHARKTDAILY","CTBHARINDAILY","AVEHARKTDAILY"
                                ,"AVEHARINDAILY","ABRTOZETFULL","ABRTISTDAILY","ABRTHRKTDAILY","ABNPROVZ","ABNHARKTDAILY","ABNHARINDAILY","OZYHARINDAILY","OZYHARKTDAILY","BRRTOZETFULL","BRRTHRKTDAILY","BRRTISTDAILY" ,"TAKALLHUP" ,"PTADRES","BNSHKART"
                            });
                        string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 00:00:00");
                        var dt1 = Convert.ToDateTime(dun); //dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblFtpControl
                                     .Join(db.TblFileBilgileri,
                                             ftp_ => EF.Functions.Collate(ftp_.Tftpname, "Turkish_CI_AS"),
                                             file_ => file_.HostFileAdi,
                                             (ftp_, file_) => new
                                             {
                                                 TStartDateTime = ftp_.TstartDateTime,
                                                 TFTPName = ftp_.Tftpname,
                                                 TStatus = ftp_.Tstatus,
                                                 TType = ftp_.Ttype,
                                                 TEndDateTime = ftp_.TendDateTime,
                                                 TNewDWHStatus = ftp_.TnewDwhstatus,
                                                 SSISStatus = ftp_.Ssisstatus,
                                                 JCL = file_.Jcl,
                                                 MCPadi = file_.Mcpadi,
                                                 DWHBinDosyaBilgi = file_.DwhbinDosyaBilgi
                                             })
                                     .OrderByDescending(o => o.TNewDWHStatus).ThenBy(t => t.SSISStatus).ThenBy(t => t.JCL).ThenBy(t => t.MCPadi)
                                     .Where(
                                            w => w.TStartDateTime >= Convert.ToDateTime(dt1) && 
                                            (w.SSISStatus == null || w.SSISStatus != 0 
                                             || w.TStatus != 1 || w.TNewDWHStatus != Convert.ToBoolean(1))
                                         //   (w.SSISStatus == null || w.SSISStatus != 0 || w.SSISStatus.Equals(string.Empty)
                                           )                                            
                                     .Take(topN)
                                     .ToList();
                        var list2 = from L in list where !istenmeyenler.Contains(L.TFTPName) select L;
                        dgvFtpKontrolLog.DataSource = list2.ToList();
                    }
                }
                foreach (DataGridViewRow row in dgvFtpKontrolLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvFtpKontrolLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void btnFtpKontrolListele_Click(object sender, EventArgs e)
        {
            FtpKontrolMfFileBilgiGetir();
        }

        private void chkLogTarih1_CheckedChanged(object sender, EventArgs e)
        {
            DwhBinDosyaBilgi = 0;
        }

        private void chkLogTarih2_CheckedChanged(object sender, EventArgs e)
        {
            DwhBinDosyaBilgi = 0;
        }

        private void txtTopN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

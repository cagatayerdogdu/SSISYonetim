using SSISYonetim.Models;
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
    public partial class frmDosyaLog : Form
    {
        public frmDosyaLog()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmDosyaLog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmDosyaLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("dosya_log");
            frmAnasayfa.TabCikar("dosya_log");
        }

        private void DosyaLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DWHLogDBContext())
                {                    
                    if (chkDosyaAdi.Checked)
                    {
                        if (txtDosyaAdi.Text == "")
                        {
                            MessageBox.Show("Dosya Adı Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.PliConsoleFileLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.PaketDosyaAdi.Contains(txtDosyaAdi.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvDosyaLog.DataSource = list;
                        }
                    }
                    if (chkKayitTarih1.Checked && !chkKayitTarih2.Checked)
                    {
                        var dt1 = dtKayitTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleFileLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.KayitTarihi >= Convert.ToDateTime(dt1))
                                   .Take(topN)
                                   .ToList();
                        dgvDosyaLog.DataSource = list;
                    }

                    if (chkKayitTarih2.Checked && !chkKayitTarih1.Checked)
                    {
                        var dt2 = dtKayitTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleFileLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.KayitTarihi <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDosyaLog.DataSource = list;
                    }

                    if (chkKayitTarih1.Checked && chkKayitTarih2.Checked)
                    {
                        var dt1 = dtKayitTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtKayitTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleFileLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.KayitTarihi >= Convert.ToDateTime(dt1) && w.KayitTarihi <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDosyaLog.DataSource = list;
                    }

                    if (chkKayitTarih1.Checked && txtDosyaAdi.Text != "" && chkDosyaAdi.Checked)
                    {
                        var dt1 = dtKayitTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleFileLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.KayitTarihi >= Convert.ToDateTime(dt1) && w.PaketDosyaAdi.Contains(txtDosyaAdi.Text))
                                   .Take(topN)
                                   .ToList();
                        dgvDosyaLog.DataSource = list;
                    }

                    if (!chkDosyaAdi.Checked && !chkKayitTarih1.Checked && !chkKayitTarih2.Checked)
                    {
                        var list = db.PliConsoleFileLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Take(topN)
                                       .ToList();
                        dgvDosyaLog.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvDosyaLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvDosyaLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }
        private void btnDosyaLogListele_Click(object sender, EventArgs e)
        {
            DosyaLogGetir();
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

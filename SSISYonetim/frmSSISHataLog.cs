using SSISYonetim.Models.DTSZamanlama;
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
    public partial class frmSSISHataLog : Form
    {
        public frmSSISHataLog()
        {
            InitializeComponent();
        }
        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";

        private void frmSSISHataLog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  
        }

        private void frmSSISHataLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("ssis_hata_log");
            frmAnasayfa.TabCikar("ssis_hata_log");
        }
        private void SSISLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DTSZamanlamaContext())
                {
                    if (chkPaketAdi.Checked)
                    {
                        if (txtDosyaAdi.Text == "")
                        {
                            MessageBox.Show("Paket Adı Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.TblSsisHataLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.PaketAdi.Contains(txtDosyaAdi.Text.ToUpper()))
                                       .Take(topN)
                                       .ToList();
                            dgvDwhDosyaAdi.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisHataLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.BaslangicZamani >= Convert.ToDateTime(dt1))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisHataLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.BitisZamani <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisHataLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.BaslangicZamani >= Convert.ToDateTime(dt1) && w.BitisZamani <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtDosyaAdi.Text != "" && chkPaketAdi.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisHataLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.BaslangicZamani >= Convert.ToDateTime(dt1) && w.PaketAdi.Contains(txtDosyaAdi.Text.ToUpper()))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (!chkPaketAdi.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var list = db.TblSsisHataLogs
                                     .OrderByDescending(o => o.LogId)
                                     .Take(topN)
                                     .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvDwhDosyaAdi.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvDwhDosyaAdi.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void txtTopN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSSISHataLogListele_Click(object sender, EventArgs e)
        {
            SSISLogGetir();
        }
    }
}

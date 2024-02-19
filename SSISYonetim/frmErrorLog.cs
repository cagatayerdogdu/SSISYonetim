using SSISYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SSISYonetim
{
    public partial class frmErrorLog : Form
    {
        public frmErrorLog()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";

        private void frmErrorLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("error_log");
            frmAnasayfa.TabCikar("error_log");
        }
        private void btnErrorLogListele_Click(object sender, EventArgs e)
        {
            ErrorLogGetir();
        }

        private void ErrorLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DWHLogDBContext())
                {
                    if (chkHataAciklama.Checked)
                    {
                        if (txtHataAciklama.Text == "")
                        {
                            MessageBox.Show("Hata Açıklama Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.PliConsoleErrorLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.HataAciklama.Contains(txtHataAciklama.Text))
                                       .Take(topN)
                                       .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                            dgvErrorLog.DataSource = list;
                        }
                    }
                    if (chkDosyaAdi.Checked)
                    {
                        if (txtDosyaAdi.Text == "")
                        {
                            MessageBox.Show("Dosya Adı Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.PliConsoleErrorLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.PaketDosyaAdi.Contains(txtDosyaAdi.Text))
                                       .Take(topN)
                                       .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                            dgvErrorLog.DataSource = list;
                        }
                    }
                    if (chkHataTarih1.Checked && !chkHataTarih2.Checked)
                    {
                        var dt1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleErrorLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.HataTarih >= Convert.ToDateTime(dt1))
                                   .Take(topN)
                                   .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }

                    if (chkHataTarih2.Checked && !chkHataTarih1.Checked)
                    {
                        var dt2 = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleErrorLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.HataTarih <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }

                    if (chkHataTarih1.Checked && chkHataTarih2.Checked)
                    {
                        var dt1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleErrorLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.HataTarih >= Convert.ToDateTime(dt1) && w.HataTarih <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }

                    if (chkHataTarih1.Checked && txtDosyaAdi.Text != "" && chkDosyaAdi.Checked)
                    {
                        var dt1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleErrorLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.HataTarih >= Convert.ToDateTime(dt1) && w.PaketDosyaAdi.Contains(txtDosyaAdi.Text))
                                   .Take(topN)
                                   .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }

                    if (chkHataTarih1.Checked && txtHataAciklama.Text != "" && chkHataAciklama.Checked)
                    {
                        var dt1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.PliConsoleErrorLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.HataTarih >= Convert.ToDateTime(dt1) && w.HataAciklama.Contains(txtHataAciklama.Text))
                                   .Take(topN)
                                   .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }

                    if (!chkDosyaAdi.Checked && !chkHataAciklama.Checked && !chkHataTarih1.Checked && !chkHataTarih2.Checked)
                    {
                        var list = db.PliConsoleErrorLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Take(topN)
                                       .Select(s => new { s.LogId, s.PaketDosyaAdi, s.HataTarih, s.HataAciklama }).ToList();
                        dgvErrorLog.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvErrorLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvErrorLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void frmErrorLog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

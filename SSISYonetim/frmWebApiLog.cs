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
    public partial class frmWebApiLog : Form
    {
        public frmWebApiLog()
        {
            InitializeComponent();
        }
        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmWebApiLog_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);
        }

        private void frmWebApiLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("webapi_log");
            frmAnasayfa.TabCikar("webapi_log");
        }
        private void WebApiLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DWHLogDBContext())
                {
                    if (chkLogUygulama.Checked)
                    {
                        if (txtLogUygulama.Text == "")
                        {
                            MessageBox.Show("Log Tip Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.WebApiLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.LogUygulama.Contains(txtLogUygulama.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvWebApiLog.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman >= Convert.ToDateTime(dt1))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman >= Convert.ToDateTime(dt1) && w.LogZaman <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtLogUygulama.Text != "" && chkLogUygulama.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman >= Convert.ToDateTime(dt1) && w.LogUygulama.Contains(txtLogUygulama.Text.ToUpper()))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtLogDurum.Text != "" && chkLogDurum.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman >= Convert.ToDateTime(dt1) && w.LogDurum.Contains(txtLogDurum.Text))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtLogDurum.Text != "" && chkLogDurum.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.WebApiLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogZaman >= Convert.ToDateTime(dt1) && w.LogZaman <= Convert.ToDateTime(dt2) && w.LogDurum.Contains(txtLogDurum.Text))
                                   .Take(topN)
                                   .ToList();
                        dgvWebApiLog.DataSource = list;
                    }

                    else if (chkLogDurum.Checked)
                    {
                        if (txtLogDurum.Text == "")
                        {
                            MessageBox.Show("ETL Adı checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            var list = db.WebApiLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.LogDurum.Contains(txtLogDurum.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvWebApiLog.DataSource = list;
                        }
                    }

                    if (!chkLogUygulama.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked && !chkLogDurum.Checked)
                    {
                        //Thread th = new Thread(new ThreadStart(() =>
                        //   dgvWebApiLog.DataSource = db.WebApiLogs
                        //               .OrderByDescending(o => o.LogId).ToList()));
                        //th.Start();
                        //Thread.Sleep(150);
                        var list = db.WebApiLogs
                                     .OrderByDescending(o => o.LogId)
                                     .Take(topN)
                                     .ToList();
                        dgvWebApiLog.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvWebApiLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvWebApiLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void btnWebApiLogListele_Click(object sender, EventArgs e)
        {
            WebApiLogGetir();
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

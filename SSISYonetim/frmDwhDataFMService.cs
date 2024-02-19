using SSISYonetim.Models.BISReportsDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SSISYonetim
{
    public partial class frmDwhDataFMService : Form
    {
        public frmDwhDataFMService()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmDwhDataFMService_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);
        }
        private void frmDwhDataFMService_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("ddfm_service");
            frmAnasayfa.TabCikar("ddfm_service");
        }
        private void DataFMLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new BISReportsDBContext())
                {
                    if (chkLogTip.Checked)
                    {
                        if (txtLogTip.Text == "")
                        {
                            MessageBox.Show("Log Tip Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.DwhdataFmserviceLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.LogType.Contains(txtLogTip.Text.ToUpper()))
                                       .Take(topN)
                                       .ToList();
                            dgvDataFMLog.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate >= Convert.ToDateTime(dt1))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate >= Convert.ToDateTime(dt1) && w.LogDate <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtLogTip.Text != "" && chkLogTip.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate >= Convert.ToDateTime(dt1) && w.LogType.Contains(txtLogTip.Text.ToUpper()))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtParameters.Text != "" && chkParameters.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate >= Convert.ToDateTime(dt1) && w.Parameters.Contains(txtParameters.Text))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtParameters.Text != "" && chkParameters.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhdataFmserviceLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogDate >= Convert.ToDateTime(dt1) && w.LogDate <= Convert.ToDateTime(dt2) && w.Parameters.Contains(txtParameters.Text))
                                   .Take(topN)
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    else if (chkParameters.Checked)
                    {
                        if (txtParameters.Text == "")
                        {
                            MessageBox.Show("ETL Adı checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            var list = db.DwhdataFmserviceLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.Parameters.Contains(txtParameters.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvDataFMLog.DataSource = list;
                        }
                    }

                    if (!chkLogTip.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked && !chkParameters.Checked)
                    {
                        //Thread th = new Thread(new ThreadStart(() =>
                        //   dgvDataFMLog.DataSource = db.DwhdataFmserviceLogs
                        //               .OrderByDescending(o => o.LogId).ToList()));
                        //th.Start();
                        //Thread.Sleep(150);
                        var list = db.DwhdataFmserviceLogs
                                     .OrderByDescending(o => o.LogId)
                                     .Take(topN)
                                     .ToList();
                        dgvDataFMLog.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvDataFMLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvDataFMLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void btnDataFMServiceListele_Click(object sender, EventArgs e)
        {
            DataFMLogGetir();
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

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
    public partial class frmDwhDataFMService_Control : Form
    {
        public frmDwhDataFMService_Control()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmDwhDataFMService_Control_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);
        }

        private void frmDwhDataFMService_Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("ddfm_service_kontrol");
            frmAnasayfa.TabCikar("ddfm_service_kontrol");
        }

        private void DataFMKontrolLogGetir()
        {
            try
            {
                using (var db = new DWHLogDBContext())
                {
                    if (chkLogAciklama.Checked)
                    {
                        if (txtLogAciklama.Text == "")
                        {
                            MessageBox.Show("Log Açıklama Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.DwhDataFmserviceControlLogs
                                       .OrderByDescending(o => o.LogId)
                                       .Where(w => w.LogAciklama.Contains(txtLogAciklama.Text))
                                       .ToList();
                            dgvDataFMLog.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit >= Convert.ToDateTime(dt1))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit <= Convert.ToDateTime(dt2))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit >= Convert.ToDateTime(dt1) && w.LogKayit <= Convert.ToDateTime(dt2))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtLogAciklama.Text != "" && chkLogAciklama.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit >= Convert.ToDateTime(dt1) && w.LogAciklama.Contains(txtLogAciklama.Text))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtLogAciklama.Text != "" && chkLogAciklama.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit >= Convert.ToDateTime(dt1) && w.LogAciklama.Contains(txtLogAciklama.Text))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtLogAciklama.Text != "" && chkLogAciklama.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDataFmserviceControlLogs
                                   .OrderByDescending(o => o.LogId)
                                   .Where(w => w.LogKayit >= Convert.ToDateTime(dt1) && w.LogKayit <= Convert.ToDateTime(dt2) && w.LogAciklama.Contains(txtLogAciklama.Text))
                                   .ToList();
                        dgvDataFMLog.DataSource = list;
                    }

                    //else if (chkLogAciklama.Checked)
                    //{
                    //    if (txtLogAciklama.Text == "")
                    //    {
                    //        MessageBox.Show("Log Açıklama checkbox seçili fakat geçerli bir açıklama girmediniz.");
                    //    }
                    //    else
                    //    {
                    //        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    //        var list = db.DwhDataFmserviceControlLogs
                    //                   .OrderByDescending(o => o.LogId)
                    //                   .Where(w => w.LogAciklama.Contains(txtLogAciklama.Text) && w.LogKayit >= Convert.ToDateTime(dt1))
                    //                   .ToList();
                    //        dgvDataFMLog.DataSource = list;
                    //    }
                    //}

                    if (!chkLogAciklama.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var list = db.DwhDataFmserviceControlLogs
                                       .OrderByDescending(o => o.LogId).ToList();
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
        private void btnDataFMServiceKontrolListele_Click(object sender, EventArgs e)
        {
            DataFMKontrolLogGetir();
        }
    }
}

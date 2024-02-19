
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
    public partial class frmDwhDosyaBilgileri : Form
    {
        public frmDwhDosyaBilgileri()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        private void frmDwhDosyaBilgileri_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);
        }
        private void frmDwhDosyaBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("dwh_dosya_bilgileri");
            frmAnasayfa.TabCikar("dwh_dosya_bilgileri");
        }
        private void DosyaBilgileriGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DTSZamanlamaContext())
                {
                    if (chkLogUygulama.Checked)
                    {
                        if (txtDosyaAdi.Text == "")
                        {
                            MessageBox.Show("Log Tip Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.DwhDosyaBilgileri
                                       .OrderByDescending(o => o.Id)
                                       .Where(w => w.DosyaAdiHam.Contains(txtDosyaAdi.Text.ToUpper()))
                                       .Take(topN)
                                       .ToList();
                            dgvDwhDosyaAdi.DataSource = list;
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDosyaBilgileri
                                   .OrderByDescending(o => o.Id)
                                   .Where(w => w.DosyaOlusturulmaTarihi >= Convert.ToDateTime(dt1))
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDosyaBilgileri
                                   .OrderByDescending(o => o.Id)
                                   .Where(w => w.DosyaOlusturulmaTarihi <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDosyaBilgileri
                                   .OrderByDescending(o => o.Id)
                                   .Where(w => w.DosyaOlusturulmaTarihi >= Convert.ToDateTime(dt1) && w.DosyaOlusturulmaTarihi <= Convert.ToDateTime(dt2))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtDosyaAdi.Text != "" && chkLogUygulama.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.DwhDosyaBilgileri
                                   .OrderByDescending(o => o.Id)
                                   .Where(w => w.DosyaOlusturulmaTarihi >= Convert.ToDateTime(dt1) && w.DosyaAdiHam.Contains(txtDosyaAdi.Text.ToUpper()))
                                   .Take(topN)
                                   .ToList();
                        dgvDwhDosyaAdi.DataSource = list;
                    }                

                    if (!chkLogUygulama.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        //Thread th = new Thread(new ThreadStart(() =>
                        //   dgvWebApiLog.DataSource = db.DwhDosyaBilgileri
                        //               .OrderByDescending(o => o.Id).ToList()));
                        //th.Start();
                        //Thread.Sleep(150);
                        var list = db.DwhDosyaBilgileri
                                     .OrderByDescending(o => o.Id)
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
        private void btnWebApiLogListele_Click(object sender, EventArgs e)
        {
            DosyaBilgileriGetir();
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

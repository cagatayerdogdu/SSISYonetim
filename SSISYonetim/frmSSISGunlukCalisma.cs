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
    public partial class frmSSISGunlukCalisma : Form
    {
        public frmSSISGunlukCalisma()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";

        private void frmSSISGunlukCalisma_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string dun = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss");
            dtLogTarih1.Value = Convert.ToDateTime(dun);
        }

        private void frmSSISGunlukCalisma_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("ssis_gunluk_calisma_adimlari");
            frmAnasayfa.TabCikar("ssis_gunluk_calisma_adimlari");
        }
        private void SSISGunlukAdimLogGetir()
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                using (var db = new DTSZamanlamaContext())
                {
                    if (chkSSISAdi.Checked)
                    {
                        if (txtSSISAdi.Text == "")
                        {
                            MessageBox.Show("SSIS Adı Ara checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var list = db.TblSsisgunlukCalismaAdimlaris
                                       .Join(db.TblSsis,
                                             ssiscalisma => ssiscalisma.KayitNo,
                                             ssis => ssis.KayitNo,
                                             (ssiscalisma, ssis) => new
                                             {
                                                 Gun = ssiscalisma.Gun,
                                                 KayitNo = ssiscalisma.KayitNo,
                                                 Ad = ssis.Ad,
                                                 Kod = ssiscalisma.Kod,
                                                 Aciklama = ssiscalisma.Aciklama,
                                                 Zaman = ssiscalisma.Zaman
                                             })
                                       .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                       .Where(w => w.Ad.Contains(txtSSISAdi.Text))
                                       .Take(topN)
                                       .ToList();
                            dgvSSISGunlukCalismaLog.DataSource = list;

                           /* Bu kodda çalışıyor 2. query yöntem
                            var listJoin = from a in db.TblSsisgunlukCalismaAdimlaris
                                           join b in db.TblSsis on a.KayitNo equals b.KayitNo
                                           where b.Ad.Contains(txtSSISAdi.Text)
                                           orderby a.Zaman descending
                                           orderby a.KayitNo
                                           select new 
                                           {
                                               Gun = a.Gun, KayitNo = a.KayitNo, 
                                               Ad = b.Ad, Kod = a.Kod,
                                               Aciklama = a.Aciklama, Zaman = a.Zaman
                                           };
                            dgvSSISGunlukCalismaLog.DataSource = listJoin.ToList();
                           */
                        }
                    }
                    if (chkLogTarih1.Checked && !chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    if (chkLogTarih2.Checked && !chkLogTarih1.Checked)
                    {
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman <= Convert.ToDateTime(dt2))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1) && w.Zaman <= Convert.ToDateTime(dt2))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtSSISAdi.Text != "" && chkSSISAdi.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1) && w.Ad.Contains(txtSSISAdi.Text.ToUpper()))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }
                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtSSISAdi.Text != "" && chkSSISAdi.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1) && w.Zaman <= Convert.ToDateTime(dt2)
                                            && w.Ad.Contains(txtSSISAdi.Text.ToUpper()))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && txtKod.Text != "" && chkKod.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1) && w.Kod.ToString().Contains(txtKod.Text.ToString()))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    if (chkLogTarih1.Checked && chkLogTarih2.Checked && txtKod.Text != "" && chkKod.Checked)
                    {
                        var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var dt2 = dtLogTarih2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Where(w => w.Zaman >= Convert.ToDateTime(dt1) && w.Zaman <= Convert.ToDateTime(dt2) 
                                            && w.Kod.ToString().Contains(txtKod.Text.ToString()))
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }

                    else if (chkKod.Checked)
                    {
                        if (txtKod.Text == "")
                        {
                            MessageBox.Show("ETL Adı checkbox seçili fakat geçerli bir açıklama girmediniz.");
                        }
                        else
                        {
                            var dt1 = dtLogTarih1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            var list = db.TblSsisgunlukCalismaAdimlaris
                                         .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                         .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                         .Where(w => w.Kod.ToString().Contains(txtKod.Text.ToString()))
                                         .Take(topN)
                                         .ToList();
                            dgvSSISGunlukCalismaLog.DataSource = list;
                        }
                    }

                    if (!chkSSISAdi.Checked && !chkLogTarih1.Checked && !chkLogTarih2.Checked && !chkKod.Checked)
                    {
                        //Thread th = new Thread(new ThreadStart(() =>
                        //   dgvWebApiLog.DataSource = db.TblSsisgunlukCalismaAdimlaris
                        //               .OrderByDescending(o => o.Zaman).ThenBy(t=> t.KayitNo).ToList()));
                        //th.Start();
                        //Thread.Sleep(150);
                        var list = db.TblSsisgunlukCalismaAdimlaris
                                     .Join(db.TblSsis,
                                            ssiscalisma => ssiscalisma.KayitNo,
                                            ssis => ssis.KayitNo,
                                            (ssiscalisma, ssis) => new
                                            {
                                                Gun = ssiscalisma.Gun,
                                                KayitNo = ssiscalisma.KayitNo,
                                                Ad = ssis.Ad,
                                                Kod = ssiscalisma.Kod,
                                                Aciklama = ssiscalisma.Aciklama,
                                                Zaman = ssiscalisma.Zaman
                                            })
                                     .OrderByDescending(o => o.Zaman).ThenBy(t => t.KayitNo)
                                     .Take(topN)
                                     .ToList();
                        dgvSSISGunlukCalismaLog.DataSource = list;
                    }
                }
                foreach (DataGridViewRow row in dgvSSISGunlukCalismaLog.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                }
                lblSatirSayi.Text = dgvSSISGunlukCalismaLog.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı:\n\r\n\r" + ex.ToString());
            }
        }

        private void btnSSISGunlukAdimLogListele_Click(object sender, EventArgs e)
        {
            SSISGunlukAdimLogGetir();
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

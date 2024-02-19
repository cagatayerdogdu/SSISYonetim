using SSISYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SSISYonetim.Models.DTSZamanlama;

namespace SSISYonetim
{
    public partial class frmYeniSSISEkle : Form
    {
        public frmYeniSSISEkle()
        {
            InitializeComponent();
        }
        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        public long seciliKayitNo = -1;

        private void frmYeniSSISEkle_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            VisibleFalse();
        }
        private void frmGunlukKontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("yeni_ssis_ekle");
            frmAnasayfa.TabCikar("yeni_ssis_ekle");
        }
        private void tblSSISGetir()
        {
            using (var db = new DTSZamanlamaContext())
            {
                var liste = db.TblSsis.AsNoTracking().OrderByDescending(o => o.KayitNo).ToList();
                dgvSSIS.DataSource = liste;
            }
            foreach (DataGridViewRow row in dgvSSIS.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            lblSatirSayi.Text = dgvSSIS.Rows.Count.ToString();
            VisibleFalse();
        }
        private void tblSSISGetir(string _Ad)
        {
            if (_Ad != "")
            {
                using (var db = new DTSZamanlamaContext())
                {
                    var list = db.TblSsis.Where(w => w.Ad.Contains(_Ad)).ToList();
                    if (list.Count < 1 || list == null)
                    {
                        MessageBox.Show("Bu isimde SSIS bulunamamıştır.");
                    }
                    else
                    {
                        dgvSSIS.DataSource = list;
                        foreach (DataGridViewRow row in dgvSSIS.Rows)
                        {
                            row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                        }
                        lblSatirSayi.Text = dgvSSIS.Rows.Count.ToString();
                        VisibleFalse();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ad kısmına SSIS adı girmediniz.");
            }
        }
        private void SSISKaydet()
        {
            try
            {
                using (var db = new DTSZamanlamaContext())
                {
                    int result = 0;
                    string SSISEkleSql = "exec SSIS_KAYDET @Durum, @KurumNo, @Ad, @CalismaSekli, @HaftaninGunleri, @AyinGunleri, @AyinOzelGunleri, @YilinGunleri, @YilinOzelGunleri, @Oncelik, @BaslamaSaati, @TekrarlamaSayisi, @TekrarlamaDakika, @Kontroller, @Aciklama, @KayitKullanıci, @KayitZamani, @KullanilanDB, @KullanilanTablolar, @KullanilanDosya";
                    
                    List<SqlParameter> param = new List<SqlParameter>
                    {
                        new SqlParameter {ParameterName = "@Durum", Value = int.Parse(txtDurum.Text)},
                        new SqlParameter {ParameterName = "@KurumNo", Value = txtKurumNo.Text},
                        new SqlParameter {ParameterName = "@Ad", Value = txtAd.Text},
                        new SqlParameter {ParameterName = "@CalismaSekli", Value = int.Parse(txtCalismaSekli.Text)},
                        new SqlParameter {ParameterName = "@HaftaninGunleri", Value = txtHaftaninGunleri.Text},
                        new SqlParameter {ParameterName = "@AyinGunleri", Value = int.Parse(txtAyinGunleri.Text)},
                        new SqlParameter {ParameterName = "@AyinOzelGunleri", Value = txtAyinOzelGunleri.Text},
                        new SqlParameter {ParameterName = "@YilinGunleri", Value = int.Parse(txtYilinGunleri.Text)},
                        new SqlParameter {ParameterName = "@YilinOzelGunleri", Value = txtYilinOzelGunleri.Text},
                        new SqlParameter {ParameterName = "@Oncelik", Value = int.Parse(txtOncelik.Text)},
                        new SqlParameter {ParameterName = "@BaslamaSaati", Value = txtBaslamaSaati.Text},
                        new SqlParameter {ParameterName = "@TekrarlamaSayisi", Value = int.Parse(txtTekrarlamaSayisi.Text)},
                        new SqlParameter {ParameterName = "@TekrarlamaDakika", Value = txtTekrarlamaDakika.Text},
                        new SqlParameter {ParameterName = "@Kontroller", Value = txtKontroller.Text},
                        new SqlParameter {ParameterName = "@Aciklama", Value = txtAciklama.Text},
                        new SqlParameter {ParameterName = "@KayitKullanıci", Value = txtKayitKullanıci.Text},
                        new SqlParameter {ParameterName = "@KayitZamani", Value = dtKayitZamani.Value.ToString("yyyy-MM-dd HH:mm:ss")},
                        //new SqlParameter {ParameterName = "@DuzenleyenKullanici", Value = txtDuzenleyenKullanici.Text},
                        //new SqlParameter {ParameterName = "@DuzenlemeZamani", Value = txtDuzenlemeZamani.Text},
                        new SqlParameter {ParameterName = "@KullanilanDB", Value = txtKullanilanDB.Text},
                        new SqlParameter {ParameterName = "@KullanilanTablolar", Value = txtKullanilanTablolar.Text},
                        new SqlParameter {ParameterName = "@KullanilanDosya", Value = txtKullanilanDosya.Text}
                    };
                    if (!txtKayitKullanıci.Text.Contains('.'))
                    {
                        epHataDedektoru.SetError(txtKayitKullanıci, "Kullanıcı adında isim soyisim arasında nokta girmediniz.");
                    }
                    else
                    {
                        result = db.Database.ExecuteSqlRaw(SSISEkleSql, param.ToArray());
                    }                    

                    if (result != 0)
                    {
                        MessageBox.Show("Yeni SSIS Ekleme başarılı.");

                        var yeniKayit = db.TblSsis.OrderByDescending(o => o.KayitNo).Take(1).ToList();
                        dgvSSIS.DataSource = yeniKayit;

                        var updateDuzenleme = (from x in db.TblSsis
                                               where x.KayitNo == yeniKayit.Select(s => s.KayitNo).FirstOrDefault() //Convert.ToInt64(dgvSSIS.CurrentRow.Cells["KayitNo"].Value
                                               select x).FirstOrDefault();
                        updateDuzenleme.DuzenlemeZamani = updateDuzenleme.KayitZamani;
                        updateDuzenleme.DuzenleyenKullanici = updateDuzenleme.KayitKullanıci;
                        db.Update(updateDuzenleme);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Yeni SSIS Ekleme başarısız.");
                    }
                    //// Kontroller_String update edilecek.
                    /*update tblSSIS
                    set Kontroller_String = case when Kontroller != '0' then replace(('''' + replace(replace(Kontroller, '#', ''' '), ' ', ',''') + '#'), ',''#', '')  else '0' end
                    where Kontroller_String is null*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void SSISGuncelle()
        {
            if (seciliKayitNo > -1)
            {
                try
                {
                    using (var db = new DTSZamanlamaContext())
                    {
                        //db.Configuration.LazyLoadingEnabled = false;
                        var resultUpdate = (from x in db.TblSsis//.AsNoTracking()
                                            where x.KayitNo == seciliKayitNo
                                            select x).FirstOrDefault();
                        resultUpdate.Durum = Convert.ToInt32(txtDurum.Text);
                        resultUpdate.KurumNo = txtKurumNo.Text;
                        resultUpdate.Ad = txtAd.Text;
                        resultUpdate.CalismaSekli = Convert.ToInt32(txtCalismaSekli.Text);
                        resultUpdate.HaftaninGunleri = txtHaftaninGunleri.Text;
                        resultUpdate.AyinGunleri = Convert.ToInt32(txtAyinGunleri.Text);
                        resultUpdate.AyinOzelGunleri = txtAyinOzelGunleri.Text;
                        resultUpdate.YilinGunleri = Convert.ToInt32(txtYilinGunleri.Text);
                        resultUpdate.YilinOzelGunleri = txtYilinOzelGunleri.Text;
                        resultUpdate.Oncelik = Convert.ToInt32(txtOncelik.Text);
                        resultUpdate.BaslamaSaati = txtBaslamaSaati.Text;
                        resultUpdate.TekrarlamaSayisi = Convert.ToInt32(txtTekrarlamaSayisi.Text);
                        resultUpdate.TekrarlamaDakika = txtTekrarlamaDakika.Text;
                        resultUpdate.Kontroller = txtKontroller.Text;
                        resultUpdate.Aciklama = txtAciklama.Text;
                        resultUpdate.KayitKullanıci = txtKayitKullanıci.Text;
                        resultUpdate.KayitZamani = dtKayitZamani.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        resultUpdate.KullanilanDb = txtKullanilanDB.Text;
                        resultUpdate.KullanilanTablolar = txtKullanilanTablolar.Text;
                        resultUpdate.KullanilanDosya = txtKullanilanDosya.Text;
                        resultUpdate.DuzenleyenKullanici = txtDuzenleyenKullanici.Text;
                        resultUpdate.DuzenlemeZamani = dtDuzenlemeZamani.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        db.Update(resultUpdate);
                        var result = db.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("SSIS Güncelleme başarılı.");

                            var guncellenenSsis = db.TblSsis.Where(w => w.KayitNo == seciliKayitNo).Take(1).ToList();
                            dgvSSIS.DataSource = guncellenenSsis;
                        }
                        else
                        {
                            MessageBox.Show("SSIS Güncelleme başarısız.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Henüz bir kayıt seçilmedi.\n\r\n\r SeciliKayitNo = -1");
            }
        }

        private void btnSSISListeGetir_Click(object sender, EventArgs e)
        {
            if (chkSSISAdi.Checked)
            {
                tblSSISGetir(txtAd.Text);
            }
            else
            {
                tblSSISGetir();
            }
            BoxClear();
        }

        private void btnSSISEkle_Click(object sender, EventArgs e)
        {
            epHataDedektoru.Clear();
            if (chkGuncelle.Checked == true)
            {
                SSISGuncelle();
            }
            else
            {
                SSISKaydet();
            }
            VisibleFalse();
            BoxClear();
        }
        private void txtDurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCalismaSekli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAyinGunleri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtYilinGunleri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtOncelik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTekrarlamaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSSIS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                chkGuncelle.Visible = true;
                lblDuzenleyenKullanici.Visible = true;
                lblDuzenlemeZamani.Visible = true;
                txtDuzenleyenKullanici.Visible = true;
                dtDuzenlemeZamani.Visible = true;


                seciliKayitNo = Convert.ToInt64(dgvSSIS.CurrentRow.Cells["KayitNo"].Value);
                txtDurum.Text = dgvSSIS.CurrentRow.Cells["Durum"].Value.ToString();
                txtKurumNo.Text = dgvSSIS.CurrentRow.Cells["KurumNo"].Value.ToString();
                txtAd.Text = dgvSSIS.CurrentRow.Cells["Ad"].Value.ToString();
                txtCalismaSekli.Text = dgvSSIS.CurrentRow.Cells["CalismaSekli"].Value.ToString();
                txtHaftaninGunleri.Text = dgvSSIS.CurrentRow.Cells["HaftaninGunleri"].Value.ToString();
                txtAyinGunleri.Text = dgvSSIS.CurrentRow.Cells["AyinGunleri"].Value.ToString();
                txtAyinOzelGunleri.Text = dgvSSIS.CurrentRow.Cells["AyinOzelGunleri"].Value.ToString();
                txtYilinGunleri.Text = dgvSSIS.CurrentRow.Cells["YilinGunleri"].Value.ToString();
                txtYilinOzelGunleri.Text = dgvSSIS.CurrentRow.Cells["YilinOzelGunleri"].Value.ToString();
                txtOncelik.Text = dgvSSIS.CurrentRow.Cells["Oncelik"].Value.ToString();
                txtBaslamaSaati.Text = dgvSSIS.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                txtTekrarlamaSayisi.Text = dgvSSIS.CurrentRow.Cells["TekrarlamaSayisi"].Value.ToString();
                txtTekrarlamaDakika.Text = dgvSSIS.CurrentRow.Cells["TekrarlamaDakika"].Value.ToString();
                txtKontroller.Text = dgvSSIS.CurrentRow.Cells["Kontroller"].Value.ToString();
                txtAciklama.Text = dgvSSIS.CurrentRow.Cells["Aciklama"].Value.ToString();
                txtKayitKullanıci.Text = dgvSSIS.CurrentRow.Cells["KayitKullanıci"].Value.ToString();
                dtKayitZamani.Text = dgvSSIS.CurrentRow.Cells["KayitZamani"].Value.ToString();
                txtKullanilanDB.Text = dgvSSIS.CurrentRow.Cells["KullanilanDB"].Value.ToString();
                txtKullanilanTablolar.Text = dgvSSIS.CurrentRow.Cells["KullanilanTablolar"].Value.ToString();
                txtKullanilanDosya.Text = dgvSSIS.CurrentRow.Cells["KullanilanDosya"].Value.ToString();

                txtDuzenleyenKullanici.Text = dgvSSIS.CurrentRow.Cells["DuzenleyenKullanici"].Value.ToString();
                    //(dgvSSIS.CurrentRow.Cells["DuzenleyenKullanici"].Value.ToString() == null) ? "" : dgvSSIS.CurrentRow.Cells["DuzenleyenKullanici"].Value.ToString();
                dtDuzenlemeZamani.Text = dgvSSIS.CurrentRow.Cells["DuzenlemeZamani"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void chkGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSSISEkle.Text == "SSIS Güncelle")
            {
                btnSSISEkle.Text = "SSIS Ekle";
            }
            else
            {
                btnSSISEkle.Text = "SSIS Güncelle";
            }                       
        }

        void VisibleFalse() 
        {
            chkGuncelle.Visible = false;
            chkGuncelle.Checked = false;
            lblDuzenleyenKullanici.Visible = false;
            lblDuzenlemeZamani.Visible = false;
            txtDuzenleyenKullanici.Visible = false;
            dtDuzenlemeZamani.Visible = false;
            chkSSISAdi.Checked = false;
        }
        void BoxClear()
        {
            if (btnSSISEkle.Text == "SSIS Güncelle")
            {
                btnSSISEkle.Text = "SSIS Ekle";
            }
            seciliKayitNo = -1;
            txtDurum.Text = "";
            txtKurumNo.Text = "";
            txtAd.Text = "";
            txtCalismaSekli.Text = "";
            txtHaftaninGunleri.Text = "";
            txtAyinGunleri.Text = "";
            txtAyinOzelGunleri.Text = "";
            txtYilinGunleri.Text = "";
            txtYilinOzelGunleri.Text = "";
            txtOncelik.Text = "";
            txtBaslamaSaati.Text = "";
            txtTekrarlamaSayisi.Text = "";
            txtTekrarlamaDakika.Text = "";
            txtKontroller.Text = "";
            txtAciklama.Text = "";
            txtKayitKullanıci.Text = "";
            dtKayitZamani.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            txtKullanilanDB.Text = "";
            txtKullanilanTablolar.Text = "";
            txtKullanilanDosya.Text = "";

            txtDuzenleyenKullanici.Text = "";
            dtDuzenlemeZamani.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void dgvSSIS_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menusSecilenKaydiSifirla.Visible = true;
                menusag.Show(dgvSSIS.PointToScreen(e.Location));
            }
        }

        private void menusSecilenKaydiSifirla_Click(object sender, EventArgs e)
        {
            BoxClear();
            VisibleFalse();
        }
    }
}

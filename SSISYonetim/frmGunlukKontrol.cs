using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Dts.Runtime;
using SSISYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.SqlServer.Dts.Runtime.Application;
using System.Collections.Generic;
using System.Collections;
using System.Xml;
using System.IO;
using System.Threading;
using SSISYonetim.Models.DTSZamanlama;

namespace SSISYonetim
{
    public partial class frmGunlukKontrol : Form
    {
        public frmGunlukKontrol()
        {
            InitializeComponent();
        }

        string seciliAd = ""; int? seciliKayitNo = (int?)null; int seciliID = 0;
        int SeciliSatirSayi = 0;
        DataTable dt_EtlListele = new DataTable { Columns = { { "ID", typeof(long) }, { "Ad", typeof(string) }, { "KayitNo", typeof(int) } } };

        int _Gun = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
        int Dun = Convert.ToInt32(DateTime.Now.AddDays(-1).ToString("yyyyMMdd"));

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";

        SeciliSSIS seciliSSIS = new SeciliSSIS();

        private void btnGunlukETLListele_Click(object sender, EventArgs e)
        {
            try
            {
                var topN = int.Parse(txtTopN.Text);
                var nSonuc = int.Parse(txtnSonuc.Text);
                using (DTSZamanlamaContext db = new DTSZamanlamaContext())
                {
                    /* //Method syntax, buda çalışıyor fakat suredakikayı burada yapamadım.
                    var calismayanSSIS = db.TblSsisGunluk
                        .Where(w => w.Gun == Gun && w.Sonuc != 4)
                        .Select(s => new { s.Id, s.Gun, s.KayitNo, s.Ad, s.Saat, s.BaslamaTarihi, s.BaslamaSaat, s.BitisSaat, s.Sonuc, s.Aciklama, s.BitisTarihi, s.CalismaSayisi})
                        //(select top 1 SureDakika from dbo.tblSSISGunluk b where a.Ad = b.Ad and b.Gun = cast(CONVERT(varchar(8), GETDATE() - 1, 112) as INT)) Dunku_SureDakika
                        .OrderByDescending(o => (o.BaslamaSaat)).ThenByDescending(o => o.Sonuc)  //new { o.BaslamaSaat, o.Sonuc, o.CalismaSayisi })
                        .ToList();
                    */
                    /*Query syntax*/
                    if (txtSSISAdi.Text != "")
                    {
                        var s0nuc = ">" + nSonuc.ToString();
                        
                        if (nSonuc != 0)
                        {
                            s0nuc = "== " + nSonuc.ToString();
                        } // burada dinamik operator denedim 5 dk. kadar olmadı denemeye devam etmek lazım... güzel olur..
                        if (topN != 0) { _Gun = Convert.ToInt32(DateTime.Now.AddDays(-topN).ToString("yyyyMMdd")); }
                        else { _Gun = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")); }
                        
                        var arananETL = (from a in db.TblSsisGunluk.AsNoTracking()
                                         where (a.Gun >= _Gun && a.Sonuc == nSonuc)
                                         select new
                                         {
                                             a.Id,
                                             a.Gun,
                                             a.KayitNo,
                                             a.Ad,
                                             a.Saat,
                                             a.BaslamaTarihi,
                                             a.BaslamaSaat,
                                             a.BitisSaat,
                                             a.Sonuc,
                                             a.Aciklama,
                                             a.BitisTarihi,
                                             a.CalismaSayisi,
                                             SureDakika = (from b in db.TblSsisGunluk
                                                           where b.Gun == Dun && b.Ad == a.Ad
                                                           select b.SureDakika).FirstOrDefault()
                                         }).OrderByDescending(o => (o.BaslamaSaat)).ThenByDescending(o => o.Sonuc).ThenByDescending(o => o.CalismaSayisi).ThenBy(o => o.Gun).ThenBy(o => o.Saat)
                                       .Where(w => w.Ad.Contains(txtSSISAdi.Text) && w.Gun >= _Gun)
                                       //.Take(topN)
                                       .ToList();
                        dgvGunlukEtl.DataSource = arananETL.OrderByDescending(o => o.Gun).ToList();
                        foreach (DataGridViewRow row in dgvGunlukEtl.Rows)
                        {
                            row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                        }
                        foreach (var item in arananETL)
                        {
                            dt_EtlListele.Rows.Add(item.Id, item.Ad, item.KayitNo);
                        }
                        lblSatirSayi.Text = dgvGunlukEtl.Rows.Count.ToString();
                    }
                    else
                    {
                        if (topN != 0) { _Gun = Convert.ToInt32(DateTime.Now.AddDays(-topN).ToString("yyyyMMdd")); }
                        else { _Gun = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")); }
                        var calismayanETL = (from a in db.TblSsisGunluk.AsNoTracking()
                                             where (a.Gun == _Gun && a.Sonuc != 4)
                                             select new
                                             {
                                                 //SatirSayi = (from c in db.TblSsisGunluk where c.Gun == Gun && c.Sonuc != 4 && a.Id == c.Id select c.Id).Count(), çalıştı ama 1 hepsi
                                                 //SatirSayi = (db.TblSsisGunluk.GroupBy(b => b.Id)
                                                 //               .SelectMany(g => g.OrderBy(b => b.Id).Select((b, i) => new { b.Id, rn = i + 1 }))
                                                 //             ), hata aldı
                                                 //SatirSayi = (db.TblSsisGunluk.OrderBy(o => o.Id).Select((s, sirano) => new {SiraNo = (sirano +1) })), hata aldı
                                                 a.Id,
                                                 a.Gun,
                                                 a.KayitNo,
                                                 a.Ad,
                                                 a.Saat,
                                                 a.BaslamaTarihi,
                                                 a.BaslamaSaat,
                                                 a.BitisSaat,
                                                 a.Sonuc,
                                                 a.Aciklama,
                                                 a.BitisTarihi,
                                                 a.CalismaSayisi,
                                                 SureDakika = (from b in db.TblSsisGunluk
                                                               where b.Gun == Dun && b.Ad == a.Ad
                                                               //orderby b.Id descending
                                                               select b.SureDakika).FirstOrDefault()
                                             }).OrderByDescending(o => (o.BaslamaSaat)).ThenByDescending(o => o.Sonuc).ThenByDescending(o => o.CalismaSayisi).ThenBy(o => o.Gun).ThenBy(o => o.Saat)
                                         .ToList();
                        dgvGunlukEtl.DataSource = calismayanETL;
                        foreach (DataGridViewRow row in dgvGunlukEtl.Rows)
                        {
                            row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                        }
                        foreach (var item in calismayanETL)
                        {
                            dt_EtlListele.Rows.Add(item.Id, item.Ad, item.KayitNo);
                        }
                        lblSatirSayi.Text = dgvGunlukEtl.Rows.Count.ToString();
                    }                    
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }

        }
        private void btnTetikle_Click(object sender, EventArgs e)
        {
            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                if (lstbxCalismayanlar.SelectedItem != null)
                {
                    if (MessageBox.Show("Çalışmayan SSIS Listesindeki seçili olan SSIS tetiklenecektir, emin misiniz?\n\r\n\rSağ taraftaki listeden tetiklemek için Çalışmayan SSIS Listesindeki seçimi temizleyerek tekrar deneyiniz.","ÇALIŞMAYAN SSIS LİSTESİNDEN Seçim Yapılarak SSIS Tetiklendi.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CalismayanSSISTetikle();
                        MessageBox.Show("Seçili ETL tetiklendi.\n\r\n\rETL tamamlanana kadar uygulamayı kapatmayınız.").ToString();
                        lstbxCalismayanlar.Items.Remove(lstbxCalismayanlar.SelectedItem);
                    }                    
                }
                else
                {
                    if (SeciliSatirSayi > 0)
                    {
                        //SecilileriTespitEt();
                        SsisCalistir();
                        MessageBox.Show("Seçili ETL'ler tetiklendi.\n\r\n\rETL'ler tamamlanana kadar uygulamayı kapatmayınız.").ToString();
                        btnGunlukETLListele_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }
        //public void SecilileriTespitEt()
        //{
        //    foreach (DataGridViewRow row in dgvGunlukEtl.Rows)
        //    {
        //        bool chkSecili = Convert.ToBoolean(row.Cells["Sec"].Value);
        //        if (chkSecili)
        //        {
        //            SeciliSatirSayi++;
        //        }
        //    }

        //}
        List<long> seciliList = new List<long>();

        public List<long> SecilileriTespitEt() //List<SeciliSSIS> //List<long>  //int tip
        {
            foreach (DataGridViewRow row in dgvGunlukEtl.Rows)
            {
                bool chkSecili = Convert.ToBoolean(row.Cells["Sec"].Value);
                if (chkSecili)
                {
                    seciliSSIS.ID = Convert.ToInt32(row.Cells["ID"].Value);
                    seciliSSIS.Ad = row.Cells["Ad"].Value.ToString();
                    seciliSSIS.KayitNo = Convert.ToInt32(row.Cells["KayitNo"].Value);
                    seciliKayitNo = seciliSSIS.KayitNo;

                    seciliID = Convert.ToInt32(row.Cells["ID"].Value);
                    //seciliAd = row.Cells["Ad"].Value.ToString();
                    //seciliKayitNo = Convert.ToInt32(row.Cells["KayitNo"].Value);
                    //seciliList.Add(seciliID.ToString() + ";" + seciliAd + ";" + seciliKayitNo.ToString());
                    seciliList.Add(seciliID);

                    SeciliSatirSayi++;
                }
            }
            return seciliList;
        }
        public void CalismadiUpdate()
        {
            //var seciliList = SecilileriTespitEt(1);
            using (var db = new DTSZamanlamaContext())
            {
                /*Liste şeklinde gelen id lerin toplu update i*/
                var result = db.TblSsisGunluk.Where(w => seciliList.Contains(w.Id)).ToList(); // List<string> seciliList yaptığımda kullandığım yöntem bu olmuştu. 3 kolonu almak için class yaptım onu listeye atadım ve alttaki resultta alıyorum.[31.10.2022 10:59]
                //var result2 = db.TblSsisGunluk.Where(w => seciliList2.Contains(w.Id)).ToList();
                result.ForEach(f =>
                {
                    f.Sonuc = 0; f.Aciklama = null; f.BaslamaTarihi = null;
                    f.BaslamaSaat = null; f.BitisTarihi = null; f.BitisSaat = null; f.CalismaSayisi = 0;
                });
                db.SaveChanges();

                #region Farklı Yöntemler
                /*Tek tek id lerde dönerek update.*/
                //foreach (var item in seciliList)
                //{
                //    var ID = Convert.ToInt32(item.ToString());

                //db.TblSsisGunluk.Where(w => w.Gun == _Gun && w.Id == ID)
                //  .UpdateFromQuery(x => new calismadi {Sonuc==0, Aciklama == null, BaslamaTarihi == null, BaslamaSaat == null, BitisTarihi == null,
                //  BitisSaat == null, CalismaSayisi == 0});

                /*1. Yöntem Tek tek id lerde dönerek update.*/
                /*
                var result = (from x in db.TblSsisGunluk
                              where x.Id == ID && x.Gun == _Gun
                              select x).First();
                result.Sonuc = 0;
                result.Aciklama = null;
                result......... kolonları yazmaya devam.
                db.SaveChanges();
                */

                /*2. Yöntem Tek tek id lerde dönerek update.                  
                var _result = db.TblSsisGunluk
                    //.AsNoTracking() // update etmeden önce, EF select sorgusu çalıştırmasın diye.. Bunu select lerde kullanmak gerek yoksa izleme yapmadığı için update etmiyor.
                    .Where(w => w.Id == ID && w.Gun == _Gun)
                    .FirstOrDefault();
                if (_result != null)
                {
                    _result.Sonuc = 0;
                    _result.Aciklama = null;
                    _result.BaslamaTarihi = null;
                    _result.BaslamaSaat = null;
                    _result.BitisTarihi = null;
                    _result.BitisSaat = null;
                    _result.CalismaSayisi = 0;
                    db.SaveChanges();
                }*/
                //}
                #endregion
            }
        }
        public void CalistiUpdate(int Tip, int seciliId)
        {
            //var seciliList = SecilileriTespitEt(2);
            using (var db = new DTSZamanlamaContext())
            {
                if (Tip == 1)   // 1 = Butondan gelen.
                {
                    /*Liste şeklinde gelen id lerin toplu update i*/
                    var result = db.TblSsisGunluk.Where(w => seciliList.Contains(w.Id)).ToList();
                    result.ForEach(f =>
                    {
                        f.Sonuc = 4; f.Aciklama = "ssis manuel çalıştı ve bitti"; f.BaslamaTarihi = _Gun;
                        f.BaslamaSaat = DateTime.Now.ToString("HH:mm:ss"); f.BitisTarihi = _Gun; f.BitisSaat = DateTime.Now.ToString("HH:mm:ss"); f.CalismaSayisi = f.CalismaSayisi + 1;
                    });
                    db.SaveChanges();
                }
                if (Tip == 2) // SsisCalistir() dan gelen.
                {
                    /* Tek tek id lerde dönerek update. */
                    //foreach (var item in seciliList)
                    //{
                    //var ID = Convert.ToInt32(item.ToString());
                    var result = (from x in db.TblSsisGunluk
                                  where x.Id == seciliID && x.Gun == _Gun
                                  select x).First();
                    result.Sonuc = 1;
                    result.Aciklama = "SSISYonetim.exe içinden manuel çalıştırıldı.";   //"ssis manuel çalıştı ve bitti";
                    result.BaslamaTarihi = _Gun;
                    result.BaslamaSaat = DateTime.Now.ToString("HH:mm:ss");                   
                    result.CalismaSayisi = result.CalismaSayisi + 1;
                    db.SaveChanges();
                    //}
                }
                if (Tip == 4) // SsisCalistir() dan gelen. Testler için
                {
                    /* Tek tek id lerde dönerek update. */
                    //foreach (var item in seciliList)
                    //{
                    //var ID = Convert.ToInt32(item.ToString());
                    var result = (from x in db.TblSsisGunluk
                                  where x.Id == seciliID && x.Gun == _Gun
                                  select x).First();
                    result.Sonuc = 4;
                    result.Aciklama = "ssis manuel çalıştı ve bitti. SSIS Yönetim.exe";                    
                    result.BitisTarihi = _Gun;
                    result.BitisSaat = DateTime.Now.ToString("HH:mm:ss");
                    result.CalismaSayisi = result.CalismaSayisi + 1;
                    db.SaveChanges();
                    //}
                }
                if (Tip == 5) // SsisCalistir() dan gelen. Testler için
                {
                    /* Tek tek id lerde dönerek update. */
                    //foreach (var item in seciliList)
                    //{
                    //var ID = Convert.ToInt32(item.ToString());
                    var result = (from x in db.TblSsisGunluk
                                  where x.Id == seciliID && x.Gun == _Gun
                                  select x).First();
                    result.Sonuc = 5;
                    result.Aciklama = "TEST Çalıştı.";//"ssis manuel çalıştı ve bitti";
                    result.BaslamaTarihi = _Gun;
                    result.BaslamaSaat = DateTime.Now.ToString("HH:mm:ss");                   
                    result.CalismaSayisi = 1;
                    db.SaveChanges();
                    //}
                }

                #region Farklı Yöntemler
                // 2 farklı yöntemi yukarı koydum. 3. Yöntem de çalışmadı update fonksiyonunda var.
                #endregion
            }
        }
        private void SeciliSSISBilgi(long ID)
        {
            seciliAd = (from DataRow dr in dt_EtlListele.Rows
                        where (long)dr["ID"] == seciliID
                        select (string)dr["Ad"]).FirstOrDefault();

            //if (seciliKayitNo > 0 || seciliKayitNo != null)
            //{
            //    seciliKayitNo = (from DataRow dr in dt_EtlListele.Rows
            //                     where (long)dr["ID"] == seciliID
            //                     //select (int?)dr["KayitNo"]).FirstOrDefault();
            //                     select (Int32)dr["KayitNo"]).FirstOrDefault();
            //}
            
            //select new { KayitNo = Convert.ToInt32(dr["KayitNo"]) ?? "99999" }).FirstOrDefault();
        }
        public void SsisCalistir()
        {
            //for (int i = 0; i < SeciliSatirSayi; i++)
            //{
            //bool secili = false;
            //try { secili = Convert.ToBoolean(dgvGunlukEtl.Rows[i].Cells["Sec"].Value); }
            //catch { secili = false; }

            int hataSay = 0;

            //if (secili)
            //{
            //seciliAd = dgvGunlukEtl.Rows[i].Cells["Ad"].Value.ToString();
            //seciliKayitNo = Convert.ToInt32(dgvGunlukEtl.Rows[i].Cells["KayitNo"].Value);
            //seciliID = Convert.ToInt32(dgvGunlukEtl.Rows[i].Cells["ID"].Value);
            foreach (var item in seciliList)
            {
                try
                {
                    seciliID = Convert.ToInt32(item.ToString());
                    SeciliSSISBilgi(seciliID);
                    string ssis_yer = ConfigurationSettings.AppSettings["SsisKlasor"] + seciliAd;
                    /*
                    Application ssis = new Application();
                    Package calis = ssis.LoadPackage(ssis_yer, null);
                    calis.PackagePassword = ConfigurationSettings.AppSettings["SsisPassword"];
                    DTSExecResult sonuc = calis.Execute();
                    */

                    PackageRun(ssis_yer);

                    CalistiUpdate(2, seciliID);
                    /*
                    if (package.Execute() != DTSExecResult.Success) //(sonuc == DTSExecResult.Failure)
                    {
                        foreach (DtsError hata in package.Errors)
                        {
                            hataVar = package.Name + " errcode[" + hata.ErrorCode + "] source[" + hata.Source.Trim() + "] description[" + hata.Description.Trim() + "]";
                            //Loglama yyapılabilir.
                            ++hataSay;
                            MessageBox.Show(hataVar.ToString());
                        }
                    }
                    */
                    if (hataSay == 0)
                    {
                        //CalistiUpdate(4, seciliID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //Log atılabilir.
                    //throw;
                }
            }

            //}
            //}
        }
        void CalismayanSSISTetikle()
        {
            try
            {
                string ssis_yer = ConfigurationSettings.AppSettings["SsisKlasor"] + seciliAd;
                PackageRun(ssis_yer);
                //CalistiUpdate(2, seciliID); 
                // Burada tblSSISGunluk tablosunda kayıt olmadığı için eğer ssis te ilgili task lar yok ise kayıtsız kalacak. Ne yapılabilir yada gerek var mı iyice düşüneceğim. Gerek yok olduğuna karar verdim. [ÇE_2022.12.04 00:13]
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Çalışmayan SSIS Listesinden Tetiklenen ETL de Alınan Hata");
            }
        }
        private static async Task<string> PackageRun(string ssisDizin)
        {
            try
            {
                Package package = new Application()
                {
                    PackagePassword = ConfigurationManager.AppSettings["SsisPassword"]
                }.LoadPackage(ssisDizin, (IDTSEvents)null);
                //var result = package.Execute();
                Thread th = new Thread(new ThreadStart(() => package.Execute()));
                th.Start();
                Thread.Sleep(150);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ETL Tetiklerken alnan hata: \n\r\n\r" + ex.ToString());
            }         

            return null;
        }
        private int dgvKontrol()
        {
            var kontrol = Convert.ToInt32(dgvGunlukEtl.Rows.Count);
            return kontrol;
        }
        private void btnHepsiniSec_Click(object sender, EventArgs e)
        {
            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                for (int i = 0; i < dgvGunlukEtl.Rows.Count; i++)
                {
                    dgvGunlukEtl.Rows[i].Cells["Sec"].Value = true;
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }

        private void btnHepsiniTemizle_Click(object sender, EventArgs e)
        {
            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                if (SeciliSatirSayi > 0)
                {
                    for (int i = 0; i < dgvGunlukEtl.Rows.Count; i++)
                    {
                        dgvGunlukEtl.Rows[i].Cells["Sec"].Value = false;
                    }
                }
                else
                {
                    MessageBox.Show("Hiç seçim yapmadınız.");
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }
        private void btnCalismadi_Click(object sender, EventArgs e)
        {
            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                if (SeciliSatirSayi > 0)
                {
                    CalismadiUpdate();
                    MessageBox.Show("Seçili liste Çalışmadı olarak Update edildi.").ToString();
                    btnGunlukETLListele_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }
        private void btnCalistiUpdate_Click(object sender, EventArgs e)
        {
            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                if (SeciliSatirSayi > 0)
                {
                    CalistiUpdate(1, 0);
                    MessageBox.Show("Seçili liste Çalıştı olarak Update edildi.").ToString();
                    btnGunlukETLListele_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }

        private void dgvGunlukEtl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGunlukEtl.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvGunlukEtl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SeciliSatirSayi = 0;
            seciliList.Clear();
            lstbxCalismayanlar.Items.Clear();
            SecilileriTespitEt();
        }

        private void btnSeciliKontrol_Click(object sender, EventArgs e)
        {
            //var isim = Path.GetFileName(System.Windows.Forms.Application.ExecutablePath);
            //isim = isim.Substring(0, isim.IndexOf(".dll"));
            //this.Text = this.Text + " - " + seciliAd;

            var kontrol = dgvKontrol();
            if (kontrol > 0)
            {
                if (SeciliSatirSayi == 1)
                {
                    SeciliSSISBilgi(seciliID);
                    using (var db = new DTSZamanlamaContext())
                    {
                        /* var resultUpdate = (from x in db.TblSsis
                                             where x.KontrollerString == null
                                             select x).FirstOrDefault();
                         resultUpdate.KontrollerString = new { resultUpdate.Kontroller!= "0" ? : }
                        // case when Kontroller != '0' then replace(('''' + replace(replace(Kontroller, '#', ''' '), ' ', ',''') + '#'), ',''#', '')  else '0' end
                        */
                        var result = db.TblSsis.Where(w => w.KayitNo == seciliKayitNo)
                                    .Select(s => new { s.KayitNo, s.Ad, s.Kontroller, s.KontrollerString }).FirstOrDefault();
                        if (result != null && result.Kontroller != "0")
                        {
                            MessageBox.Show("Seçili ETL için tblSSIS tablosunda Kontroller alanındaki '" + result.Kontroller + "' ETL leri tek tek aranıyor...");
                            string[] _kontroller = result.Kontroller.Split('#');
                            _kontroller = _kontroller.Take(_kontroller.Count() - 1).ToArray(); // En sonunda "" olarak bi index daha alıyor onu kaldırıyoruz. "" alma sebebi ise tümünün sonunda # olması orayı da split edip değer olarak alıyor.
                            int kontrolEdilecekETLsayisi = _kontroller.Count();
                            int say = 0;
                            foreach (var item in _kontroller)
                            {
                                seciliAd = item.ToString();
                                if (seciliAd != "")
                                {
                                    var seciliETLCalismismi = db.TblSsisGunluk.Where(w => w.Ad == seciliAd && w.Gun == _Gun)
                                            .Select(s => new { s.Id, s.Ad, s.Sonuc }).FirstOrDefault();
                                    if (seciliETLCalismismi == null)
                                    {
                                        MessageBox.Show("' " + seciliAd + " ' SSIS i için bugün tblSSISGunluk tablosunda kayıt görünmüyor. ' " + seciliAd + " ' ETL i bugün çalışacaklar listesine eklenmemiştir.");
                                        lstbxCalismayanlar.Items.Add(seciliAd);
                                    }
                                    else if (seciliETLCalismismi.Sonuc == 4)
                                    {
                                        MessageBox.Show(seciliAd + " SSIS i için bugün tblSSISGunluk tablosundaki sonuç 'ÇALIŞMIŞ' olarak görünüyor.");
                                        say++;
                                    }
                                    else
                                    {
                                        MessageBox.Show(seciliAd + " SSIS i için bugün tblSSISGunluk tablosundaki sonuç: '" + seciliETLCalismismi.Sonuc + "' görünüyor. ' " + seciliAd + " ' ETL i 'ÇALIŞMAMIŞTIR'.");
                                        lstbxCalismayanlar.Items.Add(seciliAd);
                                    }
                                }
                            }
                            if (kontrolEdilecekETLsayisi > say)
                            {
                                MessageBox.Show("Seçili ETL için kontroller tamamlanmıştır. tblSSIS tablosundaki Kontroller alanındaki tüm ETL lerin 'ÇALIŞMADIĞI' görülmüştür.\n\r\n\rBu sebeple bu ETL i 'ÇALIŞTIRMAMAK' gerekmektedir. Öncelikli olarak çalışmayan diğer ETL lerin çalıştığına emin olunmalıdır.");
                            }
                            else
                            {
                                MessageBox.Show("Seçili ETL 'TETİKLENEBİLİR'. Bağımlı olduğu tüm ETL ler 'ÇALIŞMIŞ' durumdadır.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seçili ETL'in bağımlı olduğu başka bir ETL bulunmamaktadır..\n\r\n\rÇalışmayan SSIS listesinden '" + seciliAd + "'\n\r\n\rETL'ini seçerek dosya kontrolünü yapabilirsiniz.");
                            lstbxCalismayanlar.Items.Add(seciliAd);
                        }

                    }                    
                }
                else if (SeciliSatirSayi > 1)
                {
                    MessageBox.Show("Birden fazla ETL seçimi yaptınız. Bu işlev için tek bir ETL seçmelisiniz.");
                }
                else
                {
                    MessageBox.Show("ETL seçmediniz. Tek bir seçim yaparak tekrar deneyiniz.");
                }
            }
            else
            {
                MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
            }
        }
        private void SSISKontrol()
        {

        }

        private void DosyaKontrol(string _seciliCalismayanETL)
        {
            try
            {
                var kontrol = dgvKontrol();
                if (kontrol > 0)
                {
                    string SSISFileList = ConfigurationSettings.AppSettings["SSISFileList"];
                    string FileDefinitions = ConfigurationSettings.AppSettings["FileDefinitions"];
                    string HostInputs = ConfigurationSettings.AppSettings["HostInputs"];
                    string DTSInputs = ConfigurationSettings.AppSettings["DTSInputs"];
                    if (SeciliSatirSayi == 1)
                    {
                        SeciliSSISBilgi(seciliID);

                        string BINFileName = "";
                        string SSISFileName = "";
                        /*
                        XmlDocument xmlFile = new XmlDocument();
                        xmlFile.Load(SSISFileList);
                        XmlNodeList xml_tags = xmlFile.SelectNodes("/SSISFile");
                        foreach (XmlNode xmlTag in xml_tags)
                        {
                            //SSISFileName = xmlTag["SSISFileName"].InnerText;
                            SSISFileName = xmlTag["HostFileName"]["SSISFileName"].InnerText;
                            BINFileName = xmlTag["HostFileName"]["BINFileName"].InnerText;
                        }
                        */
                        XmlTextReader xmlReader_SSISFileList = new XmlTextReader(SSISFileList);
                        while (xmlReader_SSISFileList.Read())
                        {
                            if (xmlReader_SSISFileList.NodeType == XmlNodeType.Element && xmlReader_SSISFileList.Name == "SSISFileName")
                            {
                                xmlReader_SSISFileList.Read();
                                SSISFileName = xmlReader_SSISFileList.Value;
                            }
                            else if (xmlReader_SSISFileList.NodeType == XmlNodeType.Element && xmlReader_SSISFileList.Name == "BINFileName" && _seciliCalismayanETL.ToUpper() == SSISFileName.ToUpper())    // _seciliCalismayanETL yerine seciliAd vardı.
                            {
                                xmlReader_SSISFileList.Read();
                                BINFileName = xmlReader_SSISFileList.Value;
                                //BINFileName = BINFileName.Split('.').First() + ".bin"; // Sonundaki .zip kaldırmak için ayırıyorum .bin ekliyorum.
                                BINFileName = BINFileName.Substring(0, BINFileName.IndexOf(".zip")); // Sonundaki .zip kaldırmak için ayırıyorum .bin ekliyorum. 
                                /*Üstteki iki yöntemde çalışıyor örnek olsun diye ikisini de yazdım.*/
                                break;
                            }
                        }
                        string InputDataFile = HostInputs + BINFileName;
                        string OutPutDtsFile = DTSInputs + BINFileName.Split('.').First() + ".txt";
                        /* Burası  PLICOnsole uygulamasından bakılarak yapılabilir YAPMAK GEREKİR, çünkü bazı dosyalar dtsinputsa farklı isimle atılıyor sayısı az ama olsun.
                        XmlTextReader xmlReader_FileDefinitions = new XmlTextReader(FileDefinitions);
                        while (xmlReader_FileDefinitions.Read())
                        {
                            if (xmlReader_FileDefinitions.NodeType == XmlNodeType.Element && xmlReader_FileDefinitions.Name  == "InputDataFile")
                            {
                                xmlReader_FileDefinitions.Read();
                                var tt = xmlReader_FileDefinitions.Value;
                            }
                            xmlReader_FileDefinitions.Read();
                        }
                        */
                        if (BINFileName == "")
                        {
                            MessageBox.Show("FileDefinitions.xml içinde '" + _seciliCalismayanETL + "' ETL'ine ait bir kayıt bulunmamaktadır.\n\r\n\rBu yüzden dosya kontrolüne gerek yoktur.");
                        }
                        else
                        {
                            var HostOK = HostInputsKontrol(InputDataFile);
                            if (HostOK)
                            {
                                DTSInputsKontrol(OutPutDtsFile);
                            }
                        }
                    }
                    else if (SeciliSatirSayi > 1)
                    {
                        MessageBox.Show("Birden fazla ETL seçimi yaptınız. Bu işlev için tek bir ETL seçmelisiniz.");
                    }
                    else
                    {
                        MessageBox.Show("ETL seçmediniz. Tek bir seçim yaparak tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("ETL Listele butonuna basılmadan işlem yapamazsınız.\n\r\n\rETL Listele butonu sonrası veri gelmemiş olabilir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region denemeler
        /*
         if (e.RowIndex< 0)
                return;
            if (dgvGunlukEtl.RowCount > 0)
            {
                bool isChecked = (bool)dgvGunlukEtl.Rows[e.RowIndex].Cells[0].Value;

                if (isChecked)
                {
                    SeciliSatirSayi += 1;
                }
                else
                {
                    SeciliSatirSayi -= 1;
                }
            }            
        }

        private void dgvGunlukEtl_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvGunlukEtl.IsCurrentCellDirty)
            {
                dgvGunlukEtl.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }*/
        #endregion

        private void btnMfDosyaKontrol_Click(object sender, EventArgs e)
        {
            if (lstbxCalismayanlar.SelectedItem != null)
            {
                var seciliCalismayanETL = lstbxCalismayanlar.SelectedItem.ToString();
                DosyaKontrol(seciliCalismayanETL);
                //lstbxCalismayanlar.Items.Clear();
            }
            else
            {
                SeciliSSISBilgi(seciliID);
                DosyaKontrol(seciliAd);
            }                        
        }

        private bool HostInputsKontrol(string _InputDataFile)
        {
            FileInfo fileInfo = new FileInfo(_InputDataFile);
            DateTime today = DateTime.Now.Date;
            DateTime _date_hostinputs;
            _date_hostinputs = File.GetLastWriteTime(_InputDataFile);
            _date_hostinputs = _date_hostinputs.Date;
            bool result;
            DateTime _date_hostinputs_tarih;
            var _InputDataFile_Tarih = _InputDataFile.Substring(0, _InputDataFile.IndexOf(".bin")) + today.ToString("yyyy-MM-dd") + ".bin";
            _date_hostinputs_tarih = File.GetLastWriteTime(_InputDataFile_Tarih);
            _date_hostinputs_tarih = _date_hostinputs_tarih.Date;

            if (today == _date_hostinputs)
            {
                MessageBox.Show("HostInputs'ta bugüne ait; " + _InputDataFile + " isimli dosya mevcuttur.\n\r\n\rDTSInputs dosyası aranıyor..");
                result = true;
            }
            else if (today == _date_hostinputs_tarih)
            {
                MessageBox.Show("HostInputs'ta bugüne ait; " + _InputDataFile_Tarih + " isimli dosya mevcuttur.\n\r\n\rDTSInputs dosyası aranıyor..");
                result = true;
            }
            else
            {
                
                MessageBox.Show("HostInputs'ta bugüne ait; " + _InputDataFile + " isimli dosya bulunmamaktadır.");
                result = false;
            }
            return result;
        }
        private void DTSInputsKontrol(string _OutPutDtsFile)
        {
            FileInfo fileInfo = new FileInfo(_OutPutDtsFile);
            DateTime today = DateTime.Now.Date;
            DateTime _date_Dtsinputs;
            _date_Dtsinputs = File.GetLastWriteTime(_OutPutDtsFile);
            _date_Dtsinputs = _date_Dtsinputs.Date;

            if (today == _date_Dtsinputs)
            {
                MessageBox.Show("DTSInputs'ta bugüne ait; " + _OutPutDtsFile + " isimli dosya mevcuttur.\r\nETL tetiklenebilir.");
            }
            else
            {
                MessageBox.Show("DTSInputs'ta bugüne ait; " + _OutPutDtsFile + " isimli dosya bulunmamaktadır.\n\r\n\rFakat dosya HostInputsta yer aldığı için ETL tetiklenebilir.");
            }
        }

        private void lstbxCalismayanlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lstbxCalismayanlar.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void frmGunlukKontrol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmGunlukKontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("gunluk_kontrol");
            frmAnasayfa.TabCikar("gunluk_kontrol");
        }

        private void chkSSISAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSSISAdi.Checked)
            {
                btnSSISListeleGunluk.Enabled = true;
            }
            else
            {
                btnSSISListeleGunluk.Enabled = false;
                txtSSISAdi.Text = "";
                txtnSonuc.Text = "1";
                txtTopN.Text = "0";
            }
        }

        private void btnSSISListeleGunluk_Click(object sender, EventArgs e)
        {
            if (chkSSISAdi.Checked && txtSSISAdi.Text != "" && txtnSonuc.Text != "" && txtTopN.Text != "")
            {
                btnGunlukETLListele_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Arama yapmak için SSIS Ara checkbox seçili ve arama textbox'ları boş olmamalıdır.");
            }
        }

        private void txtTopN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCalismayanListeSecimKaldir_Click(object sender, EventArgs e)
        {
            lstbxCalismayanlar.SelectedItem = null;
        }

        private void btnCalismayanListeTemizle_Click(object sender, EventArgs e)
        {
            lstbxCalismayanlar.Items.Clear();
        }
    }
}

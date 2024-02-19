using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class TblSsis
    {
        public long KayitNo { get; set; }
        public int? Durum { get; set; }
        public string KurumNo { get; set; }
        public string Ad { get; set; }
        public int? CalismaSekli { get; set; }
        public string HaftaninGunleri { get; set; }
        public int? AyinGunleri { get; set; }
        public string AyinOzelGunleri { get; set; }
        public int? YilinGunleri { get; set; }
        public string YilinOzelGunleri { get; set; }
        public int? Oncelik { get; set; }
        public string BaslamaSaati { get; set; }
        public int? TekrarlamaSayisi { get; set; }
        public string TekrarlamaDakika { get; set; }
        public string Kontroller { get; set; }
        public string Aciklama { get; set; }
        public string KayitKullanıci { get; set; }
        public string KayitZamani { get; set; }
        public string DuzenleyenKullanici { get; set; }
        public string DuzenlemeZamani { get; set; }
        public string KullanilanDb { get; set; }
        public string KullanilanTablolar { get; set; }
        public string KullanilanDosya { get; set; }
        public string RaporAdi { get; set; }
        public string KontrollerEski { get; set; }
        public byte? UpdateDbnotNull { get; set; }
        public string KontrollerString { get; set; }
    }
}

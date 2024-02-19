using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.DTSZamanlama
{
    public partial class DwhDosyaBilgileri
    {
        public int Id { get; set; }
        public string DosyaAdi { get; set; }
        public DateTime? DosyaOlusturulmaTarihi { get; set; }
        public DateTime? DosyaInsTim { get; set; }
        public string DosyaAdiHam { get; set; }
        public int? DosyaGunlukSatirSayi { get; set; }
    }
}

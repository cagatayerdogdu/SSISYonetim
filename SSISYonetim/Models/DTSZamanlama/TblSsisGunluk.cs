using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.DTSZamanlama
{
    public partial class TblSsisgunluk
    {
        public long Id { get; set; }
        public long? Gun { get; set; }
        public long? KayitNo { get; set; }
        public string Ad { get; set; }
        public string Saat { get; set; }
        public long? BaslamaTarihi { get; set; }
        public string BaslamaSaat { get; set; }
        public int? Sonuc { get; set; }
        public string Aciklama { get; set; }
        public long? BitisTarihi { get; set; }
        public string BitisSaat { get; set; }
        public int? CalismaSayisi { get; set; }
        public int? SureSaniye { get; set; }
        public int? SureDakika { get; set; }
    }
}

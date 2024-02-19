using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.DTSZamanlama
{
    public partial class TblSsisgunlukCalismaAdimlari
    {
        public decimal? Gun { get; set; }
        public long? KayitNo { get; set; }
        public int? Kod { get; set; }
        public string Aciklama { get; set; }
        public DateTime? Zaman { get; set; }
    }
}

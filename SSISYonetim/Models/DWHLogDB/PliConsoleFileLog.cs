using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class PliConsoleFileLog
    {
        public int LogId { get; set; }
        public string PaketDosyaAdi { get; set; }
        public long? DosyaSatirSayi { get; set; }
        public DateTime? KayitTarihi { get; set; }
    }
}

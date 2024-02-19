using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class PliConsoleErrorLog
    {
        public int LogId { get; set; }
        public string PaketDosyaAdi { get; set; }
        public DateTime? HataTarih { get; set; }
        public string HataAciklama { get; set; }
        public bool? HataMailGonderildi { get; set; }
    }
}

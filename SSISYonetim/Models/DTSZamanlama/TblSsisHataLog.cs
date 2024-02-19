using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.DTSZamanlama
{
    public partial class TblSsisHataLog
    {
        public int LogId { get; set; }
        public string PaketAdi { get; set; }
        public string TaskAdi { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public string HataMesaji { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class DwhDataFmserviceControlLog
    {
        public long LogId { get; set; }
        public DateTime? LogKayit { get; set; }
        public string LogAciklama { get; set; }
        public string LogExeInfo { get; set; }
        public byte? StopMailGonderildi { get; set; }
    }
}

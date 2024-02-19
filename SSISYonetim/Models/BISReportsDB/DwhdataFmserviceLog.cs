using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.BISReportsDB
{
    public partial class DwhdataFmserviceLog
    {
        public long LogId { get; set; }
        public long ProcessNo { get; set; }
        public string UserName { get; set; }
        public DateTime LogDate { get; set; }
        public string LogType { get; set; }
        public string Method { get; set; }
        public string Parameters { get; set; }
        public string Message { get; set; }
        public string UserIp { get; set; }
    }
}

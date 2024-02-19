using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class WebApiLog
    {
        public int LogId { get; set; }
        public string LogUygulama { get; set; }
        public DateTime? LogZaman { get; set; }
        public string LogHata { get; set; }
        public string LogResponse { get; set; }
        public string LogDurum { get; set; }
    }
}

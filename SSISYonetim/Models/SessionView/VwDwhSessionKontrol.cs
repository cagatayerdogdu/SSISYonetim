using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.SessionView
{
    public partial class VwDwhSessionKontrol
    {
        public int? SessionId { get; set; }
        public int? FarkDakika { get; set; }
        public string ClientNetAddress { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ConnectTime { get; set; }
        public string ProgramName { get; set; }
        public string LoginName { get; set; }
        public string HostName { get; set; }
        public string Dbname { get; set; }
    }
}

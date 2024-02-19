using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.HostDataMaster
{
    public partial class TblFtpControl
    {
        public DateTime TstartDateTime { get; set; }
        public string Tftpname { get; set; }
        public short? Tstatus { get; set; }
        public string Ttype { get; set; }
        public DateTime? TendDateTime { get; set; }
        public bool? TnewDwhstatus { get; set; }
        public short? Ssisstatus { get; set; }
    }
}

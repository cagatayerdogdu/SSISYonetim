using System;
using System.Collections.Generic;

#nullable disable

namespace SSISYonetim.Models.HostDataMaster
{
    public partial class TblFileBilgileri
    {
        public int? Id { get; set; }
        public string Jcl { get; set; }
        public string HostFileAdi { get; set; }
        public string Mcpadi { get; set; }
        public string DwhbinDosyaBilgi { get; set; }
        public string Jclsira { get; set; }
        public int? CalismaDurum { get; set; }
    }
}

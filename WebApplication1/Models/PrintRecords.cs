using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PrintRecords
    {
        public int Id { get; set; }
        public int? PrintPage { get; set; }
        public string PrintFileName { get; set; }
        public string PrintServer { get; set; }
        public DateTime? PrintDt { get; set; }
        public string PrintUser { get; set; }
        public double? FileByte { get; set; }
        public string PrintClient { get; set; }
        public string DepNo { get; set; }
        public string Depdesc { get; set; }
        public string SubDepNo { get; set; }
        public string TopDepNo { get; set; }
    }
}

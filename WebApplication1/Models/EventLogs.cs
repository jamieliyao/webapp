using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class EventLogs
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int EventId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

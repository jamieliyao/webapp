using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EventLogsViewModel
    {
        public string Description { get; set; }
        public int EventId { get; set; }
        public DateTime CreateDate { get; set; }

        public int Count { get; set; }
    }
}

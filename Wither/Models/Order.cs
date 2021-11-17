using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wither.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Не определен";

        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int KboardId { get; set; }
        public Kboard Kboard { get; set; }
    }
}

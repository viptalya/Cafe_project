using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class table
    {
        public int tableId { get; set; }
        public int table_number { get; set; }
        public DateTime table_order_time { get; set; }
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
    }
}

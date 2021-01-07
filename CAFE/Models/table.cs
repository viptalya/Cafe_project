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
<<<<<<< HEAD
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
=======
        public int? orderId { get; set; }
        public virtual order Order { get; set; }
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
    }
}

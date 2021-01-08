using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class order
    {
        public int orderId { get; set; }
        public DateTime order_time { get; set; }
        public int price { get; set; }
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
        public int? courierId { get; set; }
        public virtual courier Courier { get; set; }
        public virtual ICollection<mo> Mos { get; set; }
        public order()
        {
            Mos = new List<mo>();
        }
    }
}

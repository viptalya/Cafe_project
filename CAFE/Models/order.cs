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
        public int order_price { get; set; }
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
        public virtual ICollection<table> Tables { get; set; }
        public virtual ICollection<mo> Mos { get; set; }
        public order()
        {
            Tables = new List<table>();
            Mos = new List<mo>();
        }
    }
}

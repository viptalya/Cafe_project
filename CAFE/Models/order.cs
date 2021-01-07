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
<<<<<<< HEAD
        public int price { get; set; }
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
        public virtual courier Courier { get; set; }
        public virtual ICollection<mo> Mos { get; set; }
        public order()
        {
=======
        public int order_price { get; set; }
        public int? customerId { get; set; }
        public virtual customer Customer { get; set; }
        public virtual ICollection<table> Tables { get; set; }
        public virtual ICollection<mo> Mos { get; set; }
        public order()
        {
            Tables = new List<table>();
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
            Mos = new List<mo>();
        }
    }
}

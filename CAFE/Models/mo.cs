using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class mo
    {
        public int moId { get; set; }
<<<<<<< HEAD
        public int? orderId { get; set; }
        public virtual order Order { get; set; }
        public int? menu_itemId { get; set; }
        public virtual menu_item Menu_item { get; set; }
        public string order_items_quantity { get; set; }
=======
        public int? customerId { get; set; }
        public virtual customer customer { get; set; }
        public int? menu_itemId { get; set; }
        public virtual menu_item Menu_item { get; set; }
        public System.String order_items_quantity { get; set; }
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
    }
}

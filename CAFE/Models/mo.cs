using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class mo
    {
        public int moId { get; set; }
        public int? orderId { get; set; }
        public virtual order Order { get; set; }
        public int? menu_itemId { get; set; }
        public virtual menu_item Menu_item { get; set; }
        public int order_items_quantity { get; set; }

    }
}

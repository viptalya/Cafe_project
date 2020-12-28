using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class ingredient
    {
        public int ingredientId { get; set; }
        public string ingredient_name { get; set; }
        public int ingredient_price { get; set; }
        public int? menu_itemId { get; set; }
        public virtual menu_item Menu_Item { get; set; }
    }
}

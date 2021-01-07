using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class menu_item
    {
        public int menu_itemId { get; set; }
        public int menu_item_price { get; set; }
        public string desc { get; set; }
<<<<<<< HEAD
        public string weight { get; set; }
=======
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
        public string menu_item_name { get; set; }
        public virtual ICollection<ingredient> Ingredients { get; set; }
        public virtual ICollection<mo> Mos { get; set; }
        public menu_item()
        {
            Ingredients = new List<ingredient>();
            Mos = new List<mo>();
        }
        public int mealtimeId { get; set; }
    }
}

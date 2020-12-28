using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class customer
    {
        public int customerId { get; set; }
        public string cus_Sname { get; set; }
        public string cus_Name { get; set; }
        public string cus_Pname { get; set; }
        public string cus_number { get; set; }
        public string cus_email { get; set; }
        public virtual ICollection<order> Orders { get; set; }
        public customer()
        {
            Orders = new List<order>();
        }
    }
}

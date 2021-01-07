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
<<<<<<< HEAD
        public string cus_street { get; set; }
        public string cus_house { get; set; }
        public string cus_entrance { get; set; }
        public string cus_apartment { get; set; }
        public virtual ICollection<order> Orders { get; set; }
        public virtual ICollection<table> Tables { get; set; }
        public customer()
        {
            Orders = new List<order>();
            Tables = new List<table>();
=======
        public virtual ICollection<order> Orders { get; set; }
        public customer()
        {
            Orders = new List<order>();
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
        }
    }
}

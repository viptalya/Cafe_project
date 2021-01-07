using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAFE.Models
{
    public class courier
    {
        public int courierId { get; set; }
        public string c_Sname { get; set; }
        public string c_name { get; set; }
        public string c_Pname { get; set; }
        public string c_phone { get; set; }
        public string c_email { get; set; }
        public string c_login { get; set; }
        public string c_password { get; set; }
        public virtual ICollection<order> Orders { get; set; }
        public courier()
        {
            Orders = new List<order>();
        }

    }
}

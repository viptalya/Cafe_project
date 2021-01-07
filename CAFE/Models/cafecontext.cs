using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAFE.Models;
using Microsoft.EntityFrameworkCore;

namespace CAFE.Models
{
    public class cafecontext : DbContext
    {
        public DbSet<customer> Customers { get; set; }
        public DbSet<ingredient> Ingredients { get; set; }
        public DbSet<mealtime> Mealtimes { get; set; }
        public DbSet<menu_item> Menu_Items { get; set; }
        public DbSet<order> Orders { get; set; }
        public DbSet<table> Tables { get; set; }
<<<<<<< HEAD
        public DbSet<admin> Admins { get; set; }
        public DbSet<courier> Couriers { get; set; }
        public DbSet<mo> Mos { get; set; }
=======
>>>>>>> 05a3788746d2f6707a32e838ed7309da389913cb
        public cafecontext(DbContextOptions<cafecontext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

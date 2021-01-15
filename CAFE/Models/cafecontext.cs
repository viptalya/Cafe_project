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
        public DbSet<admin> Admins { get; set; }
        public DbSet<courier> Couriers { get; set; }
        public DbSet<mo> Mos { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public cafecontext(DbContextOptions<cafecontext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

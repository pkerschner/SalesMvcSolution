using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMvc.Models;

namespace SalesMvc.Data
{
    public class SalesMvcContext : DbContext
    {
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }

        public SalesMvcContext (DbContextOptions<SalesMvcContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
        
        }

    }
}

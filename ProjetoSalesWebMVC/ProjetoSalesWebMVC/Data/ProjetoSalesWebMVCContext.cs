using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSalesWebMVC.Models;

namespace ProjetoSalesWebMVC.Data
{
    public class ProjetoSalesWebMVCContext : DbContext
    {
        public ProjetoSalesWebMVCContext (DbContextOptions<ProjetoSalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

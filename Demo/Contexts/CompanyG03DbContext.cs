using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class CompanyG03DbContext : DbContext
    {
        public CompanyG03DbContext():base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = .;initial Catalog = CompcanyG03; integrated Security = True;");
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyG03Db; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Employee> Employees { get; set; }

    }
}

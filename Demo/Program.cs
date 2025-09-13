using Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CompanyG03DbContext dbContext = new CompanyG03DbContext();

            //try
            //{
            //    // Some Code
            //} 
            //finally
            //{
            //    dbContext.Dispose();
            //}

            //using (CompanyG03DbContext dbContext = new CompanyG03DbContext())
            //{
            //    dbContext.Database.EnsureCreated();
            //}

            using CompanyG03DbContext dbContext = new CompanyG03DbContext();

            //dbContext.Database.EnsureCreated();
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.Migrate();

        }
    }
}

using Entity = HostingCalculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingCalculator.Repos.Repositories
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext() : base("HostingCalculator")
        {
        }
        
        public DbSet<Entity.Customer> Customers { get; set; }
    }
}

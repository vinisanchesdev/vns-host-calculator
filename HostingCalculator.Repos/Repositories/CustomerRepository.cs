using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = HostingCalculator.Domain.Entities;

namespace HostingCalculator.Repos.Repositories
{
    public class CustomerRepository
    {
        public List<Entity.Customer> GetAllCustomers()
        {
            List<Entity.Customer> customers = new List<Entity.Customer>();

            customers.Add(new Entity.Customer(Guid.NewGuid(), "Vini", "vinicius.guimaraes@rakuten.com.br", "22-06-1993"));
            customers.Add(new Entity.Customer(Guid.NewGuid(), "Carla", "carla.jemaitis@gmail.com", "06-05-1994"));

            return customers;
        }

               
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingCalculator.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerBirthDate { get; set; }

        public Customer()
        {
        }

        public Customer(Guid id, string customerName, string customerEmail, string customerBirthDate)
        {
            Id = id;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerBirthDate = customerBirthDate;
        }
    }
}

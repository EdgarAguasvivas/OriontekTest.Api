using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

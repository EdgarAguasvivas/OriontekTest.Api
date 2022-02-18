using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

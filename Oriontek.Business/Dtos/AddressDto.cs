﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerDto Customer { get; set; }
    }
}

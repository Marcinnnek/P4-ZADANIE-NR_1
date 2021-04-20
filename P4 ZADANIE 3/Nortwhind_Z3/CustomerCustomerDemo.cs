using System;
using System.Collections.Generic;

#nullable disable

namespace P4_ZADANIE_3.Nortwhind_Z3
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}

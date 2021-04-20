using System;
using System.Collections.Generic;

#nullable disable

namespace P4_ZADANIE_3.Nortwhind_Z3
{
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}

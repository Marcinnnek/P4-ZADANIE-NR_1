using System;
using System.Collections.Generic;

#nullable disable

namespace P4_ZADANIE_3.Nortwhind_Z3
{
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}

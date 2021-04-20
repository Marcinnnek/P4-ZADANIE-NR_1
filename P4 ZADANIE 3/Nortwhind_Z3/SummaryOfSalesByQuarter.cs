using System;
using System.Collections.Generic;

#nullable disable

namespace P4_ZADANIE_3.Nortwhind_Z3
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}

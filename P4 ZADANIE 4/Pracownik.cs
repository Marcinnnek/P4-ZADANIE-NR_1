using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZADANIE_4
{
    public class Pracownik : Osoba
    {
        public DateTime DataZatrudnienia { get; set; }
        public DateTime? DataZwolnienia { get; set; }
    }
}

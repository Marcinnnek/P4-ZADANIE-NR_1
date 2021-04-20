using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZADANIE_4
{
    public class MyTPHContext : DbContext
    {
        public DbSet<Osoba>Osoby {get;set;}

    }
}

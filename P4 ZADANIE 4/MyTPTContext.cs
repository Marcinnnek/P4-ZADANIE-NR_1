using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZADANIE_4
{
    public class MyTPTContext :DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pracownik>().ToTable("Pracownicy");
            modelBuilder.Entity<Osoba>().ToTable("Osoby");

        }
    }
}

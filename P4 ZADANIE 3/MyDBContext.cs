using System;
using System.Collections.Generic;
using System.Text;
using P4_ZADANIE_3.Nortwhind_Z3;
using Microsoft.EntityFrameworkCore;
namespace P4_ZADANIE_3
{
    public class MyDBContext :DbContext
    {
        public DbSet<MyUsers> Urzyszkodnicy { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=Northwind;
                                        Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

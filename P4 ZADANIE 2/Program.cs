using System;
using Dapper;


namespace P4_ZADANIE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB(@"Data Source=(localdb)\MSSQLLocalDB;
                            Initial Catalog=ZNorthwind;
                            Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;
                            TrustServerCertificate=False;
                            ApplicationIntent=ReadWrite;
                            MultiSubnetFailover=False");


            SqlInsertZN(db);
            Console.WriteLine();
            SqlReaderZN(db);
            Console.WriteLine();
            SqlUpdateZN(db);
            Console.WriteLine();
            SqlReaderZN(db);
            Console.WriteLine();
            SqlDeleteZN(db);
            Console.WriteLine();
            SqlReaderZN(db);

            SqlSingleReaderZN(db);

        }

        private static void SqlSingleReaderZN(DB db)
        {
            Console.WriteLine("Podaj Id kategorii");
            int ID = 1;
            bool state = int.TryParse(Console.ReadLine(), out ID);
            var singleCategory = db.GetCategoryByID(ID);
            Console.WriteLine($"ID: {singleCategory.IDkategorii}: {singleCategory.NazwaKategorii}: {singleCategory.Opis}");
        }

        private static void SqlUpdateZN(DB db)
        {
            //db.UpdateCategory(new DBKategorie() { IDkategorii = 15, NazwaKategorii ="xxxxxxxxxxxx", Opis = "yyyyyyyyyyyyyyy" });
            Console.Write("Podaj nową nazwę kategorii: ");
            string NewCategoryName = Console.ReadLine();

            while (NewCategoryName.Length >= 20)
            {
                Console.WriteLine("Maksymalna długość nazwy kategorii wynosi 20 znaków.");
                NewCategoryName = Console.ReadLine();
            }

            Console.Write("Podaj nowy opis kategorii: ");
            string NewDescription = Console.ReadLine();
            db.UpdateCategory(new DBKategorie() { IDkategorii = 15, NazwaKategorii = NewCategoryName, Opis = NewDescription });
        }

        private static void SqlDeleteZN(DB db)
        {
            db.DelCategory(new DBKategorie() { IDkategorii = 15 });
        }

        private static void SqlInsertZN(DB db)
        {
            db.AddCategory(new DBKategorie() { IDkategorii = 15, NazwaKategorii = "Nowa kategoria!", Opis = "Opis nowej Kategorii!" });
        }

        private static void SqlReaderZN(DB db)
        {
            foreach (DBKategorie kategorie in db.GetCategories())
            {
                Console.WriteLine($"ID: {kategorie.IDkategorii}: {kategorie.NazwaKategorii}: {kategorie.Opis}");
            }
        }


    }
}

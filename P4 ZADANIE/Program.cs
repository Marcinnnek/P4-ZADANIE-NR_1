using System;
using System.Data.SqlClient;

namespace P4_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlReaderZN(connection);
            Console.WriteLine();
            SqlInsertZN(connection);
            SqlReaderZN(connection);
            Console.WriteLine();
            SqlUpdateZN(connection);
            SqlReaderZN(connection);
            Console.WriteLine();
            SqlDeleteZN(connection);
            SqlReaderZN(connection);
        }

        private static void SqlDeleteZN(SqlConnection connection)
        {
            Console.WriteLine("Usunięcie wiersza.");
            connection.Open();

            var deleteSQL = "DELETE from mg.Kategorie WHERE IDkategorii = @IDkat";
            var deleteCommand = new SqlCommand(deleteSQL, connection);

            deleteCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }

        private static void SqlUpdateZN(SqlConnection connection)
        {
            Console.WriteLine("Aktualizacja wartości w danym wierszu.");
            connection.Open();

            var updateSQL = "UPDATE mg.Kategorie SET NazwaKategorii = @newName, Opis = @newDescription WHERE IDkategorii = @IDkat";
            var updateCommand = new SqlCommand(updateSQL, connection);

            updateCommand.Parameters.Add(new SqlParameter("@newName", "AKT. nazwy kategorii"));
            updateCommand.Parameters.Add(new SqlParameter("@newDescription", "AKT. Opis nowej kategorii"));
            updateCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            updateCommand.ExecuteNonQuery();

            connection.Close();
        }

        private static void SqlInsertZN(SqlConnection connection)
        {
            Console.WriteLine("Wstawienie nowego wiersza.");
            connection.Open();

            var insertSQL = "INSERT INTO mg.Kategorie (IDkategorii, NazwaKategorii, Opis) VALUES (@IDkat, @Nkat, @Op)";
            var insertCommand = new SqlCommand(insertSQL, connection);

            insertCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            insertCommand.Parameters.Add(new SqlParameter("Nkat", "Nowa Kategoria"));
            insertCommand.Parameters.Add(new SqlParameter("Op", "Opis nowej kategorii"));
            insertCommand.ExecuteNonQuery();

            connection.Close();
        }

        private static void SqlReaderZN(SqlConnection connection)
        {
            Console.WriteLine("Odczytanie wierszy tabeli.");
            connection.Open();
            var readSQL = "SELECT * FROM mg.Kategorie";
            var readCommand = new SqlCommand(readSQL, connection);

            var reader = readCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.Write($"{reader.GetInt32(0)} - {reader.GetString(1)} -  {reader.GetString(2)}");
                Console.WriteLine();
            }

            connection.Close();
        }
    }
}

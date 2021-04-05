using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace P4_ZADANIE
{
    class DBconnection
    {

        private SqlConnection _dbConnection;
        public DBconnection(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public void SqlDeleteZN()
        {
            Console.WriteLine("Usunięcie wiersza.");
            _dbConnection.Open();

            var deleteSQL = "DELETE from mg.Kategorie WHERE IDkategorii = @IDkat";
            var deleteCommand = new SqlCommand(deleteSQL, _dbConnection);

            deleteCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            deleteCommand.ExecuteNonQuery();

            _dbConnection.Close();
        }

       public void SqlUpdateZN()
        {
            Console.WriteLine("Aktualizacja wartości w danym wierszu.");
            _dbConnection.Open();

            var updateSQL = "UPDATE mg.Kategorie SET NazwaKategorii = @newName, Opis = @newDescription WHERE IDkategorii = @IDkat";
            var updateCommand = new SqlCommand(updateSQL,  _dbConnection);

            updateCommand.Parameters.Add(new SqlParameter("@newName", "AKT. nazwy kategorii"));
            updateCommand.Parameters.Add(new SqlParameter("@newDescription", "AKT. Opis nowej kategorii"));
            updateCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            updateCommand.ExecuteNonQuery();

            _dbConnection.Close();
        }

        public void SqlInsertZN()
        {
            Console.WriteLine("Wstawienie nowego wiersza.");
            _dbConnection.Open();

            var insertSQL = "INSERT INTO mg.Kategorie (IDkategorii, NazwaKategorii, Opis) VALUES (@IDkat, @Nkat, @Op)";
            var insertCommand = new SqlCommand(insertSQL, _dbConnection);

            insertCommand.Parameters.Add(new SqlParameter("IDkat", 15));
            insertCommand.Parameters.Add(new SqlParameter("Nkat", "Nowa Kategoria"));
            insertCommand.Parameters.Add(new SqlParameter("Op", "Opis nowej kategorii"));
            insertCommand.ExecuteNonQuery();

            _dbConnection.Close();
        }

        public void SqlReaderZN()
        {
            Console.WriteLine("Odczytanie wierszy tabeli.");
            _dbConnection.Open();
            var readSQL = "SELECT * FROM mg.Kategorie";
            var readCommand = new SqlCommand(readSQL, _dbConnection);

            var reader = readCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.Write($"{reader.GetInt32(0)} - {reader.GetString(1)} -  {reader.GetString(2)}");
                Console.WriteLine();
            }

            _dbConnection.Close();
        }
    }

}

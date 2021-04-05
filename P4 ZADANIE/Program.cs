using System;
using System.Data.SqlClient;

namespace P4_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                    Initial Catalog=ZNorthwind;
                                    Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";

            var dataBaseObj = new DBconnection(connectionString);

            dataBaseObj.SqlReaderZN();
            Console.WriteLine();
            dataBaseObj.SqlInsertZN();
            dataBaseObj.SqlReaderZN();
            Console.WriteLine();
            dataBaseObj.SqlUpdateZN();
            dataBaseObj.SqlReaderZN();
            Console.WriteLine();
            dataBaseObj.SqlDeleteZN();
            dataBaseObj.SqlReaderZN();
        }
    }
}

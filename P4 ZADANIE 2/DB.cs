using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace P4_ZADANIE_2
{
    public class DB
    {
        private IDbConnection _dbConnection;
        public DB(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        public IEnumerable<DBKategorie> GetCategories()
        {
            return _dbConnection.Query<DBKategorie>("SELECT * FROM mg.Kategorie");
        }

        public DBKategorie GetCategoryByID(int ID)
        {
            var query = _dbConnection.QuerySingleOrDefault<DBKategorie>("SELECT * FROM mg.Kategorie WHERE IDkategorii = @id",
                new { id = ID });
            return query;
        }

        public bool AddCategory(DBKategorie categories)
        {
            var result = _dbConnection.Execute("INSERT INTO mg.Kategorie (IDkategorii, NazwaKategorii, Opis) VALUES (@IDkat, @Nkat, @Op)",
                new { IDkat = categories.IDkategorii, Nkat = categories.NazwaKategorii, Op = categories.Opis });
            return result == 1;
        }

        public bool DelCategory(DBKategorie categories)
        {
            var result = _dbConnection.Execute("DELETE from mg.Kategorie WHERE IDkategorii = @IDkat",
                new { IDkat = categories.IDkategorii });

            return result == 1;
        }

        public bool UpdateCategory(DBKategorie categories)
        {
            var result = _dbConnection.Execute("UPDATE mg.Kategorie SET NazwaKategorii = @newName, Opis = @newDescription WHERE IDkategorii = @IDkat",
                new { newName = categories.NazwaKategorii, newDescription = categories.Opis, IDkat = categories.IDkategorii });

            return result == 1;
        }
    }
}

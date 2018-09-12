using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus05a
{
    class Program
    {
        private static string databaseFil = "personer.db";
        private static string connectionString = "Data Source=" + databaseFil + ";Version=3;";

        static void Main(string[] args)
        {
            Setup();

        }
        private static void Setup()
        {
            SQLiteConnection.CreateFile(databaseFil);
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                cn.Open();
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    cm.CommandText = "create table person (PersonId INTEGER PRIMARY KEY AUTOINCREMENT, Navn VARCHAR(50), Alder INT)";
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.ExecuteNonQuery();
                }

                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    string sql = "insert into person (navn, alder) values('Mikkel',15);";
                    sql += "insert into person (navn, alder) values('Mathias',12);";
                    sql += "insert into person (navn, alder) values('Lene',53);";
                    sql += "insert into person (navn, alder) values('Michell',51);";
                    sql += "insert into person (navn, alder) values('Lis',73);";
                    sql += "insert into person (navn, alder) values('Bjarne',72);";
                    cm.CommandText = sql;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.ExecuteNonQuery();
                }

            }
        }
    }
}

using System;
using System.Data.SQLite;

namespace FUTO_Patient_Management_Software.Utilities
{
    public static class DatabaseHelper
    {
        private static string _connectionString = "Data Source=clinic.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}


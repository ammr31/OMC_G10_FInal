using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace OMC_G10_Final
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CareCart_Database_FINALOMC.accdb");
        private static string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connString);
        }
    }
}

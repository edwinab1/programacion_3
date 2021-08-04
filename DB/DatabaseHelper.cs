using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTienda.DB
{
    class DatabaseHelper
    {
        string db = "server=(local); database=programacion3; integrated security=true";

        public DatabaseHelper() { }


        public SqlConnection openConnection()
        {
            SqlConnection connection = new SqlConnection(db);
            connection.Open();
            return connection;

        }

        public void sqlQuery(string sql)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DAL
{
    class DBconnection
    {
        // Database connectie wordt geïnitialiseerd
        SqlConnection conn;

        public DBconnection()
        {
            string connString = ConfigurationManager
                    .ConnectionStrings["ReserveringenConnectionStringSQL"]
                    .ConnectionString;

            // Database connectie wordt gelegd
            conn = new SqlConnection(connString);

        }
    }
}

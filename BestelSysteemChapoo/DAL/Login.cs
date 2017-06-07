using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginScherm
{
    class Login
    {
        // Maak variabelen aan waarmee ingelogd kan worden
        public int id;
        public string wachtwoord;

        // Maak connectie met database
        string connectionString = ConfigurationManager;

        // SqlConnection connection = new SqlConnection();

        // Lees login en wachtwoord

        // Controleer of wachtwoord klopt (en in de database staat)

        // Sluit connectie met database

    }
}

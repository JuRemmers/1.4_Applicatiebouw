using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.DAO
{
    class BestelItemDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public BestelItemDAO()
        {
            conn = dbconn.GetConnection();
        }
    }
}

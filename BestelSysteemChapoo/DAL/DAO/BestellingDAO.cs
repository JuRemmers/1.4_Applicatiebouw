﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.DAO
{
    class BestellingDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public BestellingDAO()
        {
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }
    }
}

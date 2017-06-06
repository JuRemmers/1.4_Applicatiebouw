using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

// Geschreven door Kayleigh Vossen
namespace DAL.DAO
{
    class RekeningDAO
    {
        protected SqlConnection conn;
        protected DBconnection dbconn;

        public RekeningDAO()
        {
            conn = dbconn.GetConnection();
        }

        public void GetAll()
        {

        }

        public void GetAllForBetaald()
        {

        }

        public void GetForTafelId()
        {

        }

        public void GetForId()
        {

        }

        public void GetForDatum()
        {

        }

        public void GetForMedewerkerId()
        {

        }
    }
}

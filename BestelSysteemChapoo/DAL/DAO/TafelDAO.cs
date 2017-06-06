using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.DAO
{

    //Gemaakt door Julian Remmers
    public class TafelDAO
    {
        protected SqlConnection conn;

        public Tafel ReadTafel()
        {
            
        }

        //Haal alle tafels op
        public List<Tafel> GetAll()
        {
            List<Tafel> tafel = new List<Tafel>();

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Tafel tafel = ReadBoek(reader);
                tafel.Add(tafel);
            }

            reader.Close();
            conn.Close();

            return tafel;
        }

        //Haal de ID voor de tafels op
        public Tafel GetForId(int id)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE ID=" + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Tafel tafel = ReadTafel(reader);

            reader.Close();
            conn.Close();

            return tafel;
        }
        //Haal de status van de tafels op
        public Tafel GetAllBezet(bool bezet)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tafel WHERE Bezet=" + bezet, conn);
            SqlDataReader reader = command.ExecuteReader();



            if (reader = "true")
            {

            }
        }
    }
}

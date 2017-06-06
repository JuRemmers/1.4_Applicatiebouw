﻿using System;
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
            dbconn = new DBconnection();
            conn = dbconn.GetConnection();
        }


        public void UpdateTip(int id, int fooi)
        {
            // creeër command
            string com = "UPDATE Rekening SET Fooi=@fooi  WHERE ID=@id";
            SqlCommand command = new SqlCommand(com,conn);

            // Addwithvalue omdat dat minder code schrijven is, kan direct de waarde toevoegen.
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fooi", fooi);

            // Voer command uit
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void GetTafelOverzicht()
        {
            string com = "";
            SqlCommand command = new SqlCommand(com);
        }
        
        public void GetRekeningById()
        {
            string com = "";
            SqlCommand command = new SqlCommand(com);
        }

        public void GetAll()
        {

        }

        public void GetAllForBetaald()
        {

        }

        public void GetAllForOpen()
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

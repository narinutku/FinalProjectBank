using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class LoanDal
    {
        public LoanDal(){}
        Connection connection = new Connection();
        public double getInterest(String type)
        {
            double interest = 0;
            try
            {connection.openConnection();

            MySqlCommand command = new MySqlCommand("Select Monthlyinterest from loan where type=@Type", connection.mysqlconnect);
            command.Parameters.AddWithValue("@Type", type);
            // int result = command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                     interest= double.Parse(String.Format("{0}", reader["Monthlyinterest"]));

                         
                }
            }


            }
            catch(Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
           return interest; 
            
        }
        public int getMaxMonth(String type)
        {
            int maxMonth = 0;
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select MaxMonth from loan where type=@Type", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Type", type);
                // int result = command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                      return  maxMonth = Int32.Parse(String.Format("{0}", reader["MaxMonth"]));
                       

                    }
                }


            }
            catch (Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
            return 0;

        }
       


    }
}

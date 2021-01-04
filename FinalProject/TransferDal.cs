using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class TransferDal
    {
        public TransferDal() { }
        Connection connection = new Connection();

        public DataTable getAccount(String customer_id)
        {
            MySqlDataReader dr = null;
            var table = new DataTable();
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select * from transfer where remitter_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                // int result = command.ExecuteNonQuery();
                dr = command.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("You have no transfer information");
                }
                dr.Close();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = command;
                 table = new DataTable();
                Console.WriteLine("count" + count);
                da.Fill(table);
                
                

               



            }
            catch (Exception e)
            {
               // e.StackTrace.ToString();
                Console.WriteLine(e.StackTrace);

            }
            connection.closeConnection();
            return table;
            
        }
        public void Addtransfer(String customer_id, String remittee_id, double amount)
        {
           
            try
            {
                connection.openConnection();

                DateTime date = DateTime.Now;

                MySqlCommand command = new MySqlCommand("Insert into transfer  (remitter_id, remittee_id,  amount, date) VALUES(@param1,@param2,@param3,@param4)", connection.mysqlconnect);
                    command.Parameters.AddWithValue("@param1", customer_id);
                    command.Parameters.AddWithValue("@param2", remittee_id);
                    command.Parameters.AddWithValue("@param3", amount.ToString());
                    command.Parameters.AddWithValue("@param4", date.ToString());
                    // int result = command.ExecuteNonQuery();
                    command.ExecuteNonQuery();

                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            connection.closeConnection();

        }






    }

}

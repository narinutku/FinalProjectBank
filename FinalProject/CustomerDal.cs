using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class CustomerDal
    {
        
            public CustomerDal() { }
            Connection connection = new Connection();
            public double getBalance(String customer_id)
            {
                double balance = 0;
                try
                {
                    connection.openConnection();

                    MySqlCommand command = new MySqlCommand("Select balance from customer where customer_id=@Id", connection.mysqlconnect);
                    command.Parameters.AddWithValue("@Id", customer_id);
                    // int result = command.ExecuteNonQuery();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = double.Parse(String.Format("{0}", reader["balance"]));


                        }
                    }


                }
                catch (Exception e)
                {
                    e.StackTrace.ToString();

                }
                connection.closeConnection();
                return balance;

            }
            public int getMaxMonth(String type)
            {
                int maxMonth = 0;
                try
                {
                    connection.openConnection();

                    MySqlCommand command = new MySqlCommand("Select MaxMonth from loan where type=@Id", connection.mysqlconnect);
                    command.Parameters.AddWithValue("@Id", type);
                    // int result = command.ExecuteNonQuery();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return maxMonth = Int32.Parse(String.Format("{0}", reader["MaxMonth"]));


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
        public String getCustomerName(String customer_id)
        {
            String name = null;
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select customer_name from customer where customer_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                // int result = command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = String.Format("{0}", reader["customer_name"]);


                    }
                }


            }
            catch (Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
            return name;

        }

     
        public double getCustomerSalary(String customer_id)
        {
            double salary = 0;
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select salary from customer where customer_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                // int result = command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        salary = double.Parse(String.Format("{0}", reader["salary"]));


                    }
                }


            }
            catch (Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
            return salary;

        }
        public void setCreditDebt(String customer_id,double credit)
        {
           
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Update customer set creditDebt=@CreditDebt where customer_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                command.Parameters.AddWithValue("@creditDebt", credit);
                // int result = command.ExecuteNonQuery();
                int i = command.ExecuteNonQuery();
                Console.WriteLine(i);

            }
            catch (Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
           

        }
        public double getCustomerCreditDebt(String customer_id)
        {
            double debt = 0;
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select creditDebt from customer where customer_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                // int result = command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        debt = double.Parse(String.Format("{0}", reader["creditDebt"]));


                    }
                }


            }
            catch (Exception e)
            {
                e.StackTrace.ToString();

            }
            connection.closeConnection();
            return debt;

        }

        public void sendMoney(String customer_id,String remitte_id,int amount)
        {
            double customerBalance = getBalance(customer_id)-amount;
            double remitteBalance = getBalance(remitte_id)+amount;
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Update customer set balance=@balance where customer_id=@Id", connection.mysqlconnect);
                command.Parameters.AddWithValue("@Id", customer_id);
                command.Parameters.AddWithValue("@balance", customerBalance);
                // int result = command.ExecuteNonQuery();
                int i = command.ExecuteNonQuery();
                MySqlCommand command2 = new MySqlCommand("Update customer set balance=@balance where customer_id=@Id", connection.mysqlconnect);
                command2.Parameters.AddWithValue("@Id", remitte_id);
                command2.Parameters.AddWithValue("@balance", remitteBalance);
                // int result = command.ExecuteNonQuery();
                int j = command2.ExecuteNonQuery();

                if (i > 0 && j > 0)
                {
                    MessageBox.Show("Money was sent succesfully");


                }
                else
                { 
                    MessageBox.Show("Error! Please Check Filled Information");


                }
               
                

            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
               
            }
            connection.closeConnection();

        }

        public int updateBalance(String customer_id,double updated_balance)
        {
            try
            {
                connection.openConnection();
                MySqlCommand command = new MySqlCommand("Update customer set balance=@updated_balance where customer_id=@Id", connection.mysqlconnect);
            command.Parameters.AddWithValue("@Id", customer_id);
            command.Parameters.AddWithValue("@updated_balance", updated_balance);
            int k = command.ExecuteNonQuery();
            return k;


            }
            catch(Exception e)

            {
                MessageBox.Show(e.Message);

            }
            return 0;
           connection.closeConnection();
        }
        


    }
    }


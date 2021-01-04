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
    class BillDal
    {

        public BillDal() { }
        Connection connection = new Connection();
        List<String> list;
        double payment;
        

        public DataTable getBill(String customer_id)
        {
            MySqlDataReader dr = null;
            var table = new DataTable();
            try
            {
                connection.openConnection();

                MySqlCommand command = new MySqlCommand("Select * from bill where customer_id=@Id", connection.mysqlconnect);
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
  public void AddBill(String customer_id,List<String> list,double payment)
    {
            this.list = list;
            try
            {
                connection.openConnection();
                
                foreach (String date in list) { 
                
                MySqlCommand command = new MySqlCommand("Insert into bill   (Type, Amount,  Deadline, customer_id) VALUES(@param1,@param2,@param3,@param4)", connection.mysqlconnect);
                command.Parameters.AddWithValue("@param1", "loan");
                command.Parameters.AddWithValue("@param2", payment.ToString());
                command.Parameters.AddWithValue("@param3", date);
                command.Parameters.AddWithValue("@param4", customer_id);
                // int result = command.ExecuteNonQuery();
                 command.ExecuteNonQuery();
                
 }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            connection.closeConnection();

        } 
    public void PayBill(String customer_id,double customer_balance,double bill_amount,int bill_id,String type)
    {
            int j;
            try
            { connection.openConnection();
                double updated_balance = customer_balance - bill_amount;
                MySqlCommand command = new MySqlCommand("DELETE FROM bill WHERE Bill_ID =@Id ", connection.mysqlconnect);
            command.Parameters.AddWithValue("@Id", bill_id);
                int i = command.ExecuteNonQuery(); 
                CustomerDal customerDal = new CustomerDal();

                if (type == "loan")
                {
                   
                    double debt = customerDal.getCustomerCreditDebt(customer_id);
                    double updated_debt = debt - bill_amount;
                    
                    MySqlCommand command2 = new MySqlCommand("Update customer set creditDebt=@updated_debt where customer_id=@Id", connection.mysqlconnect);
                    command2.Parameters.AddWithValue("@Id", customer_id);
                    command2.Parameters.AddWithValue("@updated_debt", updated_debt);
                    j = command2.ExecuteNonQuery();
                   

                  int k=  customerDal.updateBalance(customer_id, updated_balance);
                }
                else
                {
                   
                  j=  customerDal.updateBalance(customer_id, updated_balance);

                }



               
               
                if (i > 0 && j > 00)
                {
                    MessageBox.Show("Bill was paid succesfully");

                }
                else
                {
                    MessageBox.Show("Operation could not complete please try again");

                }
            }
            catch(Exception e)
            {

                MessageBox.Show(e.Message);
            }

            connection.closeConnection();
        }
    }

    
    
    
}

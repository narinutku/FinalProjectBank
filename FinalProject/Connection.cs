using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    class Connection
    {
 public MySqlConnection mysqlconnect = new MySqlConnection("Server=localhost;Database=Atm;Uid=root;Pwd='1234'");

        public Connection() { }

     public void openConnection()
    {
       

        try
        {
            mysqlconnect.Open();
           
            
        }
        catch (Exception err)
        {
          //  MessageBox.Show("Error! " + err.Message, "There is a error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
   public void closeConnection() {
            mysqlconnect.Close();
    }
    }
    

}
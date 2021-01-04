using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                //Connection String   
                Connection connection = new Connection();
                connection.openConnection();
                MySqlCommand cmd = new MySqlCommand("select * from Customer where customer_id=@UserId and password =@Password", connection.mysqlconnect);
                cmd.Parameters.AddWithValue("@UserId", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                string customer_id = txtUsername.Text;

                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Connection open here   
               
                int i = cmd.ExecuteNonQuery();
                
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in");
                    new Form1(customer_id).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                    txtUsername.Clear();
                    txtpassword.Clear();
                    txtUsername.Focus();
                }
                connection.closeConnection();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

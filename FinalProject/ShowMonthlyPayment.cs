using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ShowMonthlyPayment : Form
    {
        public List<String> deadlineList;
        public ShowMonthlyPayment()
        {
            InitializeComponent();
           
        }

        public ShowMonthlyPayment(List<String> deadlineList , double payment)
        {
            InitializeComponent();
             listview_showcreditpayment.View = View.Details;
            listview_showcreditpayment.Columns.Add("Month", 150);
            listview_showcreditpayment.Columns.Add("Payment",150);
            listview_showcreditpayment.Columns.Add("Last Payment Date",150);
            this.deadlineList = deadlineList;
            int i = 1;
            foreach(string date in deadlineList)
            {
                var item1 = new ListViewItem(new[] {i.ToString() ,payment.ToString() , date });
                i++;
                listview_showcreditpayment.Items.Add(item1);
                

            }
        


        }

      
    }
}

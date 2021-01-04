using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        CustomerDal customerDal = new CustomerDal();
        LoanDal loanDal = new LoanDal();
        TransferDal transferDal = new TransferDal();
        BillDal billDal = new BillDal();
        String customer_id = null;
        double customerDebt = 0;
        


        public Form1(String customer_id)
        {
            
            this.customer_id = customer_id;
            InitializeComponent();
            dataGridView2.Visible = false;
            cbx_creditPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_loanCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_customerBalance.Text = String.Format(new CultureInfo("en-US"), "{0:C}", customerDal.getBalance(customer_id));
            String customer_name= customerDal.getCustomerName(customer_id).ToString();
            lbl_welcome.Text = "WELCOME" + " " + customer_name.ToUpper(); ;
            lbl_customerName.Text = "Dear Customer " + customer_name.ToUpper() + " You Can Easily Apply For a Loan";
            double customerDebt = customerDal.getCustomerCreditDebt(customer_id);
            lbl_customerCreditDebt.Visible = false;
            if (customerDebt != 0)
            {
                lbl_customerCreditDebt.Visible = true;

                lbl_customerCreditDebt.Text = ($" Your Remaining Loan Debt is  {String.Format(new CultureInfo("en-US"), "{0:C}", customerDebt)} ");

            }
            

        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable table = billDal.getBill(customer_id);
            dataGridView1.DataSource = table;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {

                double customerbalance = customerDal.getBalance(customer_id);
                int bill_Id = Int32.Parse(textBoxBillID.Text);
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //string Amount = Convert.ToString();
               
                double Bill_Amount = Double.Parse(selectedRow.Cells["Amount"].Value.ToString());
                String type = selectedRow.Cells["Type"].Value.ToString();
                

                double updated_balance = customerbalance - Bill_Amount;
                if (customerbalance >= Bill_Amount)
                {
                  
                    billDal.PayBill(customer_id,customerbalance,Bill_Amount,bill_Id,type);

                    //amaç sayfayı yenilemek.
                    DataTable table = billDal.getBill(customer_id);
                    dataGridView1.DataSource = table;
                    lbl_customerBalance.Text = String.Format(new CultureInfo("en-US"), "{0:C}", customerDal.getBalance(customer_id));
                    textBoxBillID.Clear();
                    if (type=="loan")
                    {
                        double debt = customerDal.getCustomerCreditDebt(customer_id);
                      
                        lbl_customerCreditDebt.Text = ($" Your Remaining Loan Debt is  {String.Format(new CultureInfo("en-US"), "{0:C}", debt)} ");
                       

                    }

                    



                }
                else
                {
                    MessageBox.Show("INSUFFICIENT BALANCE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Your Input Must Be Number!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxBillID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string BıllId = Convert.ToString(selectedRow.Cells["Bill_ID"].Value);
            textBoxBillID.Text = BıllId;
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            DataTable table=transferDal.getAccount(customer_id);
            dataGridView2.DataSource = table;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {

                double customerbalance = customerDal.getBalance(customer_id);
                int customeramount = Int32.Parse(textBoxAmount.Text);
                int remitte_id = Int32.Parse(textBoxRemitte.Text);
                if (customerbalance >= customeramount)
                {
                    customerDal.sendMoney(customer_id, remitte_id.ToString(), customeramount);
                    //amaç ana sayfada güncel bakiyeyi göstermek
                    transferDal.Addtransfer(customer_id, remitte_id.ToString(), customeramount);
                    textBoxAmount.Clear();
                    textBoxRemitte.Clear();
                    textBoxDescription.Clear();
                    lbl_customerBalance.Text = String.Format(new CultureInfo("en-US"), "{0:C}", customerDal.getBalance(customer_id));
                }
                else
                {
                    MessageBox.Show("INSUFFICIENT BALANCE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ " Your Input Must Be Number!!");
            }
           
        }




        private void btn_calculate_Click(object sender, EventArgs e)
        {
            float salary = (float)customerDal.getCustomerSalary(customer_id);
            if (cbx_loanCategory.SelectedItem!=null&& cbx_creditPeriod.SelectedItem!=null&& 
                tbx_loanAmount.Text.All(char.IsDigit)&&tbx_loanAmount.Text.Length!=0&& Int64.Parse(tbx_loanAmount.Text)>=1000)
                if (customerDal.getCustomerCreditDebt(customer_id) == 0)
                {

                    {
                        int loanAmount = (int)Int64.Parse(tbx_loanAmount.Text);
                        //int creditPeriod = Int32.Parse(cbx_creditPeriod.SelectedItem.ToString());
                        var result = Regex.Match(cbx_creditPeriod.SelectedItem.ToString(), @"\d+").Value;
                        Console.WriteLine(result);
                        int creditPeriod = Int32.Parse(result);

                        switch (cbx_loanCategory.SelectedIndex)
                        {
                            case 0:

                                MortgageLoan mortageLoan = new MortgageLoan(salary, creditPeriod, loanAmount);

                                double totalPayment = mortageLoan.calculateMonthlyPayment();
                                double monthlyPayment = totalPayment / creditPeriod;
                                monthlyPayment = (Math.Round(monthlyPayment, 2));
                                if (mortageLoan.isCustomerAvailableForLoan())
                                {
                                   
                                    applyLoan(totalPayment, monthlyPayment, creditPeriod,loanAmount);

                                }
                                else
                                {
                                    MessageBox.Show("Monthly loan amount cannot exceed eighty percent of your salary. Please make sure you select a valid loan term.", 
                                        "Inadequate limit or Invalid Credit Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }



                                //

                                break;
                            case 1:
                                AutoLoan autoLoan = new AutoLoan(salary, creditPeriod, loanAmount);

                                totalPayment = autoLoan.calculateMonthlyPayment();
                                monthlyPayment = totalPayment / creditPeriod;
                                monthlyPayment = (Math.Round(monthlyPayment, 2));
                                if (autoLoan.isCustomerAvailableForLoan())
                                {
                                   
                                    applyLoan(totalPayment, monthlyPayment, creditPeriod,loanAmount);

                                }
                                else
                                {
                                    MessageBox.Show("Monthly loan amount cannot exceed eighty percent of your salary. Please make sure you select a valid loan term.",
                                        "Inadequate limit or Invalid Credit Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }

                                break;
                            case 2:
                                BusinessLoan businessLoan = new BusinessLoan(salary, creditPeriod, loanAmount);

                                totalPayment = businessLoan.calculateMonthlyPayment();
                                monthlyPayment = totalPayment / creditPeriod;
                                monthlyPayment = (Math.Round(monthlyPayment, 2));
                                if (businessLoan.isCustomerAvailableForLoan())
                                {
                                    
                                    applyLoan(totalPayment, monthlyPayment, creditPeriod,loanAmount);

                                }
                                else
                                {
                                    MessageBox.Show("Monthly loan amount cannot exceed eighty percent of your salary. Please make sure you select a valid loan term.", 
                                        "Inadequate limit or Invalid Credit Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }

                                break;
                            case 3:
                                PersonelLoan personelLoan = new PersonelLoan(salary, creditPeriod, loanAmount);

                                totalPayment = personelLoan.calculateMonthlyPayment();
                                monthlyPayment = totalPayment / creditPeriod;
                                monthlyPayment = (Math.Round(monthlyPayment, 2));
                                if (personelLoan.isCustomerAvailableForLoan())
                                {
                                    
                                    applyLoan(totalPayment, monthlyPayment, creditPeriod,loanAmount);

                                }
                                else
                                {
                                    MessageBox.Show("Monthly loan amount cannot exceed eighty percent of your salary. Please make sure you select a valid loan term.",
                                        "Inadequate limit or Invalid Credit Period", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }

                                break;



                        }




                    }
                  



            }  else
                    {
           MessageBox.Show("You have a loan debt, so you cannot request a new loan. ");

                    }
            else
            {
                MessageBox.Show("You have entered missing information.Please try again. ");

            }
            
        }

        private Boolean applyLoan(double totalPayment,double monthlyPayment,int creditPeriod,int loanAmount)
        {
            //MessageBox.Show(String.Format("{0:C}", totalPayment));
                
            DialogResult dialogResult = MessageBox.Show("Monthly Payment: " + String.Format(new CultureInfo("en-US"), "{0:C}", monthlyPayment) + "\n" +"\n"+
                        "Total Payment: " + String.Format(new CultureInfo("en-US"), "{0:C}", totalPayment), "onaylıyor musunuz", MessageBoxButtons.YesNo);
             double updated_balance = customerDal.getBalance(customer_id) + loanAmount;
            if (dialogResult == DialogResult.Yes)
            {
                customerDal.setCreditDebt(customer_id,totalPayment);
               
                customerDal.updateBalance(customer_id, updated_balance);
                List<String> list = new List<string>();
                DateTime startDate = DateTime.Now.AddMonths(1);
                DateTime endDate= DateTime.Now.AddYears(creditPeriod/12).AddMonths(1);
                for (DateTime dt = startDate; dt < endDate; dt = dt.AddMonths(1))
                {
                    String lastday = dt.ToString("dd/MM/yyyy");

                    list.Add(lastday);
    
                   
                }
                
                MessageBox.Show("Your loan request has been received.");



                
                //Çok fazla insert işlemi yaptığı için çok vakit alıyor diğer işlemleri engelliyordu bu yüzden thread kullandık.
                //İşlem bitene kadar bill tablosu connecton açık kaldığı için kredi çeker çekmez fatura sorgulama kısmına girerseniz hata verebilir.
                Thread t = new Thread(() =>billDal.AddBill(customer_id, list, monthlyPayment));
                t.Start();
                

                
                MessageBox.Show("Your loan request has been approved.");
                
                ShowMonthlyPayment showMonthlyPayment = new ShowMonthlyPayment(list, monthlyPayment);
                showMonthlyPayment.Show();
                tbx_loanAmount.Clear();
                lbl_customerCreditDebt.Text = ($" Your Remaining Loan Debt is  {String.Format(new CultureInfo("en-US"), "{0:C}", totalPayment)} $.");
                lbl_customerCreditDebt.Visible = true;
                lbl_customerBalance.Text = String.Format(new CultureInfo("en-US"), "{0:C}", customerDal.getBalance(customer_id));
            }
            return false;
        }

        private void cbx_loanCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            double interest = loanDal.getInterest(cbx_loanCategory.Text.ToString());
            MessageBox.Show("Monthly interest rate:" + interest);
           
            int month = loanDal.getMaxMonth(cbx_loanCategory.Text.ToString());
                
            MessageBox.Show("Max loan period:" + month+" Month");
        }

       
    }
}

using System;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_customerCreditDebt = new System.Windows.Forms.Label();
            this.lbl_customerBalance = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.tabPage_SendMoney = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxRemitte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_PayBill = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBillID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_TakeLoan = new System.Windows.Forms.TabPage();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.label_loanAmount = new System.Windows.Forms.Label();
            this.tbx_loanAmount = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.cbx_creditPeriod = new System.Windows.Forms.ComboBox();
            this.cbx_loanCategory = new System.Windows.Forms.ComboBox();
            this.lbl_creditPeriod = new System.Windows.Forms.Label();
            this.lbl_loanCatgeory = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage_SendMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage_PayBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_TakeLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage_SendMoney);
            this.tabControl1.Controls.Add(this.tabPage_PayBill);
            this.tabControl1.Controls.Add(this.tabPage_TakeLoan);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_customerCreditDebt);
            this.tabPage1.Controls.Add(this.lbl_customerBalance);
            this.tabPage1.Controls.Add(this.label_balance);
            this.tabPage1.Controls.Add(this.lbl_welcome);
            this.tabPage1.ImageIndex = 2;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1106, 621);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_customerCreditDebt
            // 
            this.lbl_customerCreditDebt.AutoSize = true;
            this.lbl_customerCreditDebt.Location = new System.Drawing.Point(233, 357);
            this.lbl_customerCreditDebt.Name = "lbl_customerCreditDebt";
            this.lbl_customerCreditDebt.Size = new System.Drawing.Size(79, 29);
            this.lbl_customerCreditDebt.TabIndex = 3;
            this.lbl_customerCreditDebt.Text = "label2";
            // 
            // lbl_customerBalance
            // 
            this.lbl_customerBalance.AutoSize = true;
            this.lbl_customerBalance.Location = new System.Drawing.Point(392, 239);
            this.lbl_customerBalance.Name = "lbl_customerBalance";
            this.lbl_customerBalance.Size = new System.Drawing.Size(79, 29);
            this.lbl_customerBalance.TabIndex = 2;
            this.lbl_customerBalance.Text = "label4";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(228, 239);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(163, 29);
            this.label_balance.TabIndex = 1;
            this.label_balance.Text = "Your Balance:";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_welcome.Location = new System.Drawing.Point(390, 101);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(218, 42);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "WELCOME";
            // 
            // tabPage_SendMoney
            // 
            this.tabPage_SendMoney.Controls.Add(this.dataGridView2);
            this.tabPage_SendMoney.Controls.Add(this.buttonAccount);
            this.tabPage_SendMoney.Controls.Add(this.buttonSend);
            this.tabPage_SendMoney.Controls.Add(this.textBoxDescription);
            this.tabPage_SendMoney.Controls.Add(this.textBoxAmount);
            this.tabPage_SendMoney.Controls.Add(this.textBoxRemitte);
            this.tabPage_SendMoney.Controls.Add(this.label7);
            this.tabPage_SendMoney.Controls.Add(this.label6);
            this.tabPage_SendMoney.Controls.Add(this.label5);
            this.tabPage_SendMoney.Controls.Add(this.label4);
            this.tabPage_SendMoney.ImageIndex = 3;
            this.tabPage_SendMoney.Location = new System.Drawing.Point(4, 39);
            this.tabPage_SendMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_SendMoney.Name = "tabPage_SendMoney";
            this.tabPage_SendMoney.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_SendMoney.Size = new System.Drawing.Size(1106, 621);
            this.tabPage_SendMoney.TabIndex = 2;
            this.tabPage_SendMoney.Text = "Send Money";
            this.tabPage_SendMoney.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.Location = new System.Drawing.Point(513, 151);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(551, 154);
            this.dataGridView2.TabIndex = 4;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(309, 325);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(164, 50);
            this.buttonAccount.TabIndex = 3;
            this.buttonAccount.Text = "ACCOUNT HISTORY";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(85, 325);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(164, 50);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(240, 255);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(219, 34);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(240, 208);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(219, 34);
            this.textBoxAmount.TabIndex = 1;
            // 
            // textBoxRemitte
            // 
            this.textBoxRemitte.Location = new System.Drawing.Point(240, 161);
            this.textBoxRemitte.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemitte.Name = "textBoxRemitte";
            this.textBoxRemitte.Size = new System.Drawing.Size(219, 34);
            this.textBoxRemitte.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "DESCRIPTION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "AMOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "REMITTEE ID NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(682, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter the remittee\'s ID Number and amount to send money";
            // 
            // tabPage_PayBill
            // 
            this.tabPage_PayBill.Controls.Add(this.label8);
            this.tabPage_PayBill.Controls.Add(this.textBoxBillID);
            this.tabPage_PayBill.Controls.Add(this.label3);
            this.tabPage_PayBill.Controls.Add(this.buttonCheck);
            this.tabPage_PayBill.Controls.Add(this.buttonPay);
            this.tabPage_PayBill.Controls.Add(this.dataGridView1);
            this.tabPage_PayBill.ImageIndex = 0;
            this.tabPage_PayBill.Location = new System.Drawing.Point(4, 39);
            this.tabPage_PayBill.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_PayBill.Name = "tabPage_PayBill";
            this.tabPage_PayBill.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_PayBill.Size = new System.Drawing.Size(1106, 621);
            this.tabPage_PayBill.TabIndex = 1;
            this.tabPage_PayBill.Text = "Pay Bill";
            this.tabPage_PayBill.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Press Check to see the list of bills";
            // 
            // textBoxBillID
            // 
            this.textBoxBillID.Location = new System.Drawing.Point(603, 347);
            this.textBoxBillID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBillID.Name = "textBoxBillID";
            this.textBoxBillID.Size = new System.Drawing.Size(132, 34);
            this.textBoxBillID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select the ID number of bill you want to pay";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(52, 272);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(164, 50);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(51, 400);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(164, 50);
            this.buttonPay.TabIndex = 1;
            this.buttonPay.Text = "PAY";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(51, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(920, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage_TakeLoan
            // 
            this.tabPage_TakeLoan.BackColor = System.Drawing.Color.Gray;
            this.tabPage_TakeLoan.Controls.Add(this.lbl_customerName);
            this.tabPage_TakeLoan.Controls.Add(this.label_loanAmount);
            this.tabPage_TakeLoan.Controls.Add(this.tbx_loanAmount);
            this.tabPage_TakeLoan.Controls.Add(this.lbl_result);
            this.tabPage_TakeLoan.Controls.Add(this.btn_calculate);
            this.tabPage_TakeLoan.Controls.Add(this.cbx_creditPeriod);
            this.tabPage_TakeLoan.Controls.Add(this.cbx_loanCategory);
            this.tabPage_TakeLoan.Controls.Add(this.lbl_creditPeriod);
            this.tabPage_TakeLoan.Controls.Add(this.lbl_loanCatgeory);
            this.tabPage_TakeLoan.ImageKey = "icons8-debt-64.png";
            this.tabPage_TakeLoan.Location = new System.Drawing.Point(4, 39);
            this.tabPage_TakeLoan.Name = "tabPage_TakeLoan";
            this.tabPage_TakeLoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TakeLoan.Size = new System.Drawing.Size(1106, 621);
            this.tabPage_TakeLoan.TabIndex = 2;
            this.tabPage_TakeLoan.Text = "Take Out Loan";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AllowDrop = true;
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_customerName.Location = new System.Drawing.Point(184, 22);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(95, 36);
            this.lbl_customerName.TabIndex = 9;
            this.lbl_customerName.Text = "label2";
            // 
            // label_loanAmount
            // 
            this.label_loanAmount.AutoSize = true;
            this.label_loanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_loanAmount.Location = new System.Drawing.Point(416, 322);
            this.label_loanAmount.Name = "label_loanAmount";
            this.label_loanAmount.Size = new System.Drawing.Size(297, 29);
            this.label_loanAmount.TabIndex = 8;
            this.label_loanAmount.Text = "Please Enter Loan Amount";
            // 
            // tbx_loanAmount
            // 
            this.tbx_loanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_loanAmount.Location = new System.Drawing.Point(476, 367);
            this.tbx_loanAmount.Name = "tbx_loanAmount";
            this.tbx_loanAmount.Size = new System.Drawing.Size(170, 34);
            this.tbx_loanAmount.TabIndex = 7;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.Location = new System.Drawing.Point(264, 483);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(404, 58);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "\r\nThe minimum loan amount is $ 1000.";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calculate.Location = new System.Drawing.Point(733, 468);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(225, 70);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate Monthly Payment";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // cbx_creditPeriod
            // 
            this.cbx_creditPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_creditPeriod.FormattingEnabled = true;
            this.cbx_creditPeriod.Items.AddRange(new object[] {
            "36 Month",
            "48 Month",
            "60 Month",
            "96 Month",
            "120 Month",
            "240 Month"});
            this.cbx_creditPeriod.Location = new System.Drawing.Point(776, 190);
            this.cbx_creditPeriod.Name = "cbx_creditPeriod";
            this.cbx_creditPeriod.Size = new System.Drawing.Size(288, 33);
            this.cbx_creditPeriod.TabIndex = 4;
            // 
            // cbx_loanCategory
            // 
            this.cbx_loanCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_loanCategory.FormattingEnabled = true;
            this.cbx_loanCategory.Items.AddRange(new object[] {
            "Mortgage",
            "Auto Loan",
            "Small Business Loan",
            "Personel Loan"});
            this.cbx_loanCategory.Location = new System.Drawing.Point(189, 190);
            this.cbx_loanCategory.Name = "cbx_loanCategory";
            this.cbx_loanCategory.Size = new System.Drawing.Size(282, 33);
            this.cbx_loanCategory.TabIndex = 3;
            this.cbx_loanCategory.SelectedValueChanged += new System.EventHandler(this.cbx_loanCategory_SelectedValueChanged);
            // 
            // lbl_creditPeriod
            // 
            this.lbl_creditPeriod.AutoSize = true;
            this.lbl_creditPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_creditPeriod.Location = new System.Drawing.Point(699, 139);
            this.lbl_creditPeriod.Name = "lbl_creditPeriod";
            this.lbl_creditPeriod.Size = new System.Drawing.Size(368, 29);
            this.lbl_creditPeriod.TabIndex = 2;
            this.lbl_creditPeriod.Text = "Please Select Your Credit Period";
            // 
            // lbl_loanCatgeory
            // 
            this.lbl_loanCatgeory.AutoSize = true;
            this.lbl_loanCatgeory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_loanCatgeory.Location = new System.Drawing.Point(127, 139);
            this.lbl_loanCatgeory.Name = "lbl_loanCatgeory";
            this.lbl_loanCatgeory.Size = new System.Drawing.Size(381, 29);
            this.lbl_loanCatgeory.TabIndex = 0;
            this.lbl_loanCatgeory.Text = "Please Select Your Loan Category";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.BlanchedAlmond;
            this.ımageList1.Images.SetKeyName(0, "icons8-bill-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-debt-64.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-home-64.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-money-transfer-80.png");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage_SendMoney.ResumeLayout(false);
            this.tabPage_SendMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage_PayBill.ResumeLayout(false);
            this.tabPage_PayBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_TakeLoan.ResumeLayout(false);
            this.tabPage_TakeLoan.PerformLayout();
            this.ResumeLayout(false);

        }

       

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxRemitte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SendMoney;
        private System.Windows.Forms.TabPage tabPage_PayBill;
        private System.Windows.Forms.TabPage tabPage_TakeLoan;
        private System.Windows.Forms.Label lbl_loanCatgeory;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ComboBox cbx_creditPeriod;
        private System.Windows.Forms.ComboBox cbx_loanCategory;
        private System.Windows.Forms.Label lbl_creditPeriod;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label_loanAmount;
        private System.Windows.Forms.TextBox tbx_loanAmount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_customerBalance;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_customerCreditDebt;
    }
}


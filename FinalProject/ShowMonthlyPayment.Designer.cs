namespace FinalProject
{
    partial class ShowMonthlyPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listview_showcreditpayment = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listview_showcreditpayment
            // 
            this.listview_showcreditpayment.HideSelection = false;
            this.listview_showcreditpayment.Location = new System.Drawing.Point(44, 26);
            this.listview_showcreditpayment.Name = "listview_showcreditpayment";
            this.listview_showcreditpayment.Size = new System.Drawing.Size(587, 488);
            this.listview_showcreditpayment.TabIndex = 0;
            this.listview_showcreditpayment.UseCompatibleStateImageBehavior = false;
            this.listview_showcreditpayment.View = System.Windows.Forms.View.Details;
            // 
            // ShowMonthlyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 540);
            this.Controls.Add(this.listview_showcreditpayment);
            this.Name = "ShowMonthlyPayment";
            this.Text = "ShowMonthlyPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listview_showcreditpayment;
    }
}
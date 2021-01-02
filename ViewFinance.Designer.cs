namespace RealEstateDB
{
    partial class ViewFinance
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumBuyers = new System.Windows.Forms.TextBox();
            this.NumSellers = new System.Windows.Forms.TextBox();
            this.NumProperties = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.TextBox();
            this.TotProfit = new System.Windows.Forms.TextBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.NumTans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1030, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Buyers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Sellers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Properties On Record";
            // 
            // NumBuyers
            // 
            this.NumBuyers.Location = new System.Drawing.Point(272, 18);
            this.NumBuyers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumBuyers.Name = "NumBuyers";
            this.NumBuyers.Size = new System.Drawing.Size(148, 27);
            this.NumBuyers.TabIndex = 9;
            this.NumBuyers.TextChanged += new System.EventHandler(this.NumBuyers_TextChanged);
            // 
            // NumSellers
            // 
            this.NumSellers.Location = new System.Drawing.Point(272, 73);
            this.NumSellers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumSellers.Name = "NumSellers";
            this.NumSellers.Size = new System.Drawing.Size(148, 27);
            this.NumSellers.TabIndex = 10;
            this.NumSellers.TextChanged += new System.EventHandler(this.NumSellers_TextChanged);
            // 
            // NumProperties
            // 
            this.NumProperties.Location = new System.Drawing.Point(272, 140);
            this.NumProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumProperties.Name = "NumProperties";
            this.NumProperties.Size = new System.Drawing.Size(148, 27);
            this.NumProperties.TabIndex = 11;
            this.NumProperties.TextChanged += new System.EventHandler(this.NumProperties_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Profits to Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Profits FROM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "TO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Profit
            // 
            this.Profit.Location = new System.Drawing.Point(885, 263);
            this.Profit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(148, 27);
            this.Profit.TabIndex = 16;
            this.Profit.TextChanged += new System.EventHandler(this.Profit_TextChanged);
            // 
            // TotProfit
            // 
            this.TotProfit.Location = new System.Drawing.Point(690, 18);
            this.TotProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotProfit.Name = "TotProfit";
            this.TotProfit.Size = new System.Drawing.Size(148, 27);
            this.TotProfit.TabIndex = 17;
            this.TotProfit.TextChanged += new System.EventHandler(this.TotProfit_TextChanged);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(153, 263);
            this.DateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(294, 27);
            this.DateStart.TabIndex = 18;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(544, 263);
            this.DateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(294, 27);
            this.DateEnd.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Number of Transactions to Date";
            // 
            // NumTans
            // 
            this.NumTans.Location = new System.Drawing.Point(272, 202);
            this.NumTans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumTans.Name = "NumTans";
            this.NumTans.Size = new System.Drawing.Size(148, 27);
            this.NumTans.TabIndex = 21;
            this.NumTans.TextChanged += new System.EventHandler(this.NumTans_TextChanged);
            // 
            // ViewFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.NumTans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.TotProfit);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumProperties);
            this.Controls.Add(this.NumSellers);
            this.Controls.Add(this.NumBuyers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewFinance";
            this.Text = "ViewFinance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumBuyers;
        private System.Windows.Forms.TextBox NumSellers;
        private System.Windows.Forms.TextBox NumProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.TextBox TotProfit;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumTans;
    }
}
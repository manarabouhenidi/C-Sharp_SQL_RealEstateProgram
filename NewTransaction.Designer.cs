namespace RealEstateDB
{
    partial class NewTransaction
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.propnum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyerssn = new System.Windows.Forms.TextBox();
            this.sellerssn = new System.Windows.Forms.TextBox();
            this.propertynum = new System.Windows.Forms.TextBox();
            this.sellingprice = new System.Windows.Forms.TextBox();
            this.transnum = new System.Windows.Forms.TextBox();
            this.transactionnumber = new System.Windows.Forms.Label();
            this.agentid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Confirm Transaction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buyer SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seller SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Transaction";
            // 
            // propnum
            // 
            this.propnum.AutoSize = true;
            this.propnum.Location = new System.Drawing.Point(30, 243);
            this.propnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.propnum.Name = "propnum";
            this.propnum.Size = new System.Drawing.Size(131, 19);
            this.propnum.TabIndex = 5;
            this.propnum.Text = "Property Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Selling Price ";
            // 
            // buyerssn
            // 
            this.buyerssn.Location = new System.Drawing.Point(182, 66);
            this.buyerssn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buyerssn.MaxLength = 9;
            this.buyerssn.Name = "buyerssn";
            this.buyerssn.Size = new System.Drawing.Size(198, 27);
            this.buyerssn.TabIndex = 8;
            this.buyerssn.TextChanged += new System.EventHandler(this.buyerssn_TextChanged);
            // 
            // sellerssn
            // 
            this.sellerssn.Location = new System.Drawing.Point(182, 157);
            this.sellerssn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellerssn.MaxLength = 9;
            this.sellerssn.Name = "sellerssn";
            this.sellerssn.Size = new System.Drawing.Size(198, 27);
            this.sellerssn.TabIndex = 9;
            this.sellerssn.TextChanged += new System.EventHandler(this.sellerssn_TextChanged);
            // 
            // propertynum
            // 
            this.propertynum.Location = new System.Drawing.Point(182, 243);
            this.propertynum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propertynum.MaxLength = 9;
            this.propertynum.Name = "propertynum";
            this.propertynum.Size = new System.Drawing.Size(198, 27);
            this.propertynum.TabIndex = 11;
            this.propertynum.TextChanged += new System.EventHandler(this.propertynum_TextChanged);
            // 
            // sellingprice
            // 
            this.sellingprice.Location = new System.Drawing.Point(566, 66);
            this.sellingprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellingprice.Name = "sellingprice";
            this.sellingprice.Size = new System.Drawing.Size(198, 27);
            this.sellingprice.TabIndex = 13;
            // 
            // transnum
            // 
            this.transnum.Location = new System.Drawing.Point(566, 145);
            this.transnum.MaxLength = 14;
            this.transnum.Name = "transnum";
            this.transnum.Size = new System.Drawing.Size(198, 27);
            this.transnum.TabIndex = 14;
            this.transnum.TextChanged += new System.EventHandler(this.transnum_TextChanged);
            // 
            // transactionnumber
            // 
            this.transactionnumber.AutoSize = true;
            this.transactionnumber.Location = new System.Drawing.Point(408, 145);
            this.transactionnumber.Name = "transactionnumber";
            this.transactionnumber.Size = new System.Drawing.Size(153, 19);
            this.transactionnumber.TabIndex = 15;
            this.transactionnumber.Text = "Transaction Number";
            // 
            // agentid
            // 
            this.agentid.Location = new System.Drawing.Point(566, 230);
            this.agentid.MaxLength = 9;
            this.agentid.Name = "agentid";
            this.agentid.Size = new System.Drawing.Size(189, 27);
            this.agentid.TabIndex = 16;
            this.agentid.TextChanged += new System.EventHandler(this.agentid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Agent ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 27);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(853, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agentid);
            this.Controls.Add(this.transactionnumber);
            this.Controls.Add(this.transnum);
            this.Controls.Add(this.sellingprice);
            this.Controls.Add(this.propertynum);
            this.Controls.Add(this.sellerssn);
            this.Controls.Add(this.buyerssn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.propnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewTransaction";
            this.Text = "NewTransaction";
            this.Load += new System.EventHandler(this.NewTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label propnum;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox buyerssn;
        public System.Windows.Forms.TextBox sellerssn;
        public System.Windows.Forms.TextBox propertynum;
        public System.Windows.Forms.TextBox sellingprice;
        public System.Windows.Forms.TextBox transnum;
        private System.Windows.Forms.Label transactionnumber;
        public System.Windows.Forms.TextBox agentid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
    }
}
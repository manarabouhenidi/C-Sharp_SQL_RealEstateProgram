using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RealEstateDB
{
    public partial class UpdateTransaction : Form
    {
        private Label label1;
        public TextBox buyerssn;
        private Label label2;
        public TextBox sellerssn;
        private Label label3;
        public TextBox propertynum;
        private Label label4;
        private Label label6;
        public TextBox sellingprice;
        private Label label7;
        private Button Update;
        private Button button2;
        public TextBox agentid;
        private Label label5;
        public DateTimePicker dateTimePicker1;
        private Button button1;
        public TextBox transnum;

        public UpdateTransaction()
        {
            InitializeComponent();
        }

        private void ZipCode_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
          //  Update_Transaction(transnum.Text, buyerssn.Text, sellerssn.Text, propertynum.Text, propertytype.Text, dateoftrans.Text, float.Parse(sellingprice.Text), float.Parse(profitbox.Text));

        }

        public void Update_Transaction(string tno, string bssn, string sssn, string pno, string ptype, DateTimePicker date, float price, float profit, string agent)
        {
            {
                SqlCommand Update_Transaction = SqlConnectionCommand.getCommand();
                Update_Transaction.CommandText = "USE srdb UPDATE TRANSACTIONS SET " +
                    "BSSN = @strbssn, SSSN = @strsssn, Pno = @strpno,PType = @strptype, Date = @strdate, Price = @floatprice, Profit = @floatprofit, AgentID = @stragent WHERE tnum = @strtno;";

                //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);

                Update_Transaction.Parameters.AddWithValue("@strtno", tno);
                Update_Transaction.Parameters.AddWithValue("@strbssn", bssn);
                Update_Transaction.Parameters.AddWithValue("@strsssn", sssn);
                Update_Transaction.Parameters.AddWithValue("@strpno", pno);
                Update_Transaction.Parameters.AddWithValue("@strptype", ptype);
                Update_Transaction.Parameters.AddWithValue("@strdate", dateTimePicker1.Value);
                Update_Transaction.Parameters.AddWithValue("@floatprice", price);
                Update_Transaction.Parameters.AddWithValue("@floatprofit", profit);
                Update_Transaction.Parameters.AddWithValue("@stragent", agent);
                MessageBox.Show(Update_Transaction.CommandText.ToString());
                try
                {
                    Update_Transaction.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated" + " " + tno + " " + date,
                    "Updated Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    SelectedTransaction select_trans = new SelectedTransaction();
                    select_trans.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Please make sure BSSN, SSSN, Property Number and Agent ID is valid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //MessageBox.Show(" Please Enter a Different PNO Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show("Failed to Update a transaction: " + ex.Message, "Update transaction Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//end
                Updateowner(propertynum.Text, buyerssn.Text);
            }

        }

        private void comboPno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            SelectedProperty Selected_props = new SelectedProperty();
            Selected_props.Show(); */

        }

        private void InitializeComponent()
        {
            this.transnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyerssn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellerssn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.propertynum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sellingprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.agentid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transnum
            // 
            this.transnum.Location = new System.Drawing.Point(21, 49);
            this.transnum.MaxLength = 14;
            this.transnum.Name = "transnum";
            this.transnum.Size = new System.Drawing.Size(223, 27);
            this.transnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Number";
            // 
            // buyerssn
            // 
            this.buyerssn.Location = new System.Drawing.Point(328, 49);
            this.buyerssn.Name = "buyerssn";
            this.buyerssn.Size = new System.Drawing.Size(179, 27);
            this.buyerssn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "BSSN";
            // 
            // sellerssn
            // 
            this.sellerssn.Location = new System.Drawing.Point(328, 225);
            this.sellerssn.Name = "sellerssn";
            this.sellerssn.Size = new System.Drawing.Size(177, 27);
            this.sellerssn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "SSSN";
            // 
            // propertynum
            // 
            this.propertynum.Location = new System.Drawing.Point(598, 49);
            this.propertynum.Name = "propertynum";
            this.propertynum.Size = new System.Drawing.Size(171, 27);
            this.propertynum.TabIndex = 6;
            this.propertynum.TextChanged += new System.EventHandler(this.propertynum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Property Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of Transaction";
            // 
            // sellingprice
            // 
            this.sellingprice.Location = new System.Drawing.Point(21, 400);
            this.sellingprice.Name = "sellingprice";
            this.sellingprice.Size = new System.Drawing.Size(223, 27);
            this.sellingprice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Selling Price";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(812, 400);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(158, 36);
            this.Update.TabIndex = 16;
            this.Update.Text = "Confirm";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // agentid
            // 
            this.agentid.Location = new System.Drawing.Point(598, 225);
            this.agentid.Name = "agentid";
            this.agentid.Size = new System.Drawing.Size(189, 27);
            this.agentid.TabIndex = 18;
            this.agentid.TextChanged += new System.EventHandler(this.agentid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Agent ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 27);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateTransaction
            // 
            this.ClientSize = new System.Drawing.Size(1000, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agentid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sellingprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.propertynum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellerssn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyerssn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transnum);
            this.Name = "UpdateTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            float profit = float.Parse(sellingprice.Text) - GetPrice(float.Parse(propertynum.Text));
            String ptype = Gettype(propertynum.Text);
            Update_Transaction(transnum.Text, buyerssn.Text, sellerssn.Text, propertynum.Text, ptype, dateTimePicker1, float.Parse(sellingprice.Text), profit, agentid.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactions Selected_props = new ViewTransactions();
            Selected_props.Show();
        }

        private void propertynum_TextChanged(object sender, EventArgs e)
        {

        }

        private void profitbox_TextChanged(object sender, EventArgs e)
        {

        }

        public float GetPrice(float propertynum)
        {
            SqlCommand profit = SqlConnectionCommand.getCommand();
            profit.CommandText = "USE SRDB SELECT Price FROM PROPERTY WHERE Pno = @strpno ; ";

            profit.Parameters.AddWithValue("@strpno", propertynum);

            SqlDataReader Rd = profit.ExecuteReader();
            Rd.Read();
            MessageBox.Show(Rd[0].ToString());
            return float.Parse(Rd[0].ToString());
        }

        public string Gettype(string propertynumb)
        {
            SqlCommand ptype = SqlConnectionCommand.getCommand();
            ptype.CommandText = "USE SRDB SELECT Type FROM PROPERTY WHERE Pno = @strpno ; ";

            ptype.Parameters.AddWithValue("@strpno", propertynumb);

            var proptype = ptype.ExecuteScalar();
            if (proptype == DBNull.Value)
            {
                MessageBox.Show("error");
                return null;
            }
            else
            {
                MessageBox.Show(proptype.ToString());
                return (proptype.ToString());
            }
        }

        public void Updateowner(string pnum, string bssn)
        {
            SqlCommand Update_ownerssn = SqlConnectionCommand.getCommand();
            Update_ownerssn.CommandText = "USE srdb UPDATE PROPERTY SET " +
                "Ownerssn = @strbssn WHERE Pno = @strpno ;";

            //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);

            Update_ownerssn.Parameters.AddWithValue("@strpno", pnum);
            Update_ownerssn.Parameters.AddWithValue("@strbssn", bssn);
            try
            {
                Update_ownerssn.ExecuteNonQuery();
                /*  MessageBox.Show("Successfully Updated" + " " + tno + " " + date,
                  "Updated Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  this.Hide();
                  SelectedTransaction select_trans = new SelectedTransaction();
                  select_trans.Show(); */
            }
            catch (Exception ex)
            {


            }
        }


        private void agentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home_page = new HomePage();
            home_page.Show();
        }
    }

}


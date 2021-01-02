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
    public partial class NewTransaction : Form
    {
        public NewTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirm Transaction 
            int i;
            float profit = float.Parse(sellingprice.Text) - GetPrice(float.Parse(propertynum.Text));
            String ptype = Gettype(propertynum.Text);
            if (string.IsNullOrWhiteSpace(buyerssn.Text))
            {
                MessageBox.Show("Please enter a buyer ssn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(sellerssn.Text))
            {
                MessageBox.Show("Please enter a seller ssn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (buyerssn.TextLength != 9 || !int.TryParse(buyerssn.Text, out i))
            {

                MessageBox.Show("Please enter a 9 digit BSSN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (sellerssn.TextLength != 9 || !int.TryParse(sellerssn.Text, out i))
            {

                MessageBox.Show("Please enter a 9 digit SSSN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please enter a date of transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(propertynum.Text))
            {
                MessageBox.Show("Please enter a property number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* else if (State.SelectedItem == null)
             {
                 MessageBox.Show("Please select a state", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             } */
            else if (string.IsNullOrWhiteSpace(transnum.Text))

            {

                MessageBox.Show("Please enter a 14 digit transaction number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            /*else if (Type.SelectedItem == null)
            {
                MessageBox.Show("Please Specify if this person is a seller or buyer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
           /* else if (string.IsNullOrWhiteSpace(propertytype.Text))

            {
                MessageBox.Show("Please enter a 9 digit property type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
            /*else if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter an e-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */

            else
            {
                this.Hide();
            NewTransaction BS_Page = new NewTransaction();
            newtrans(transnum.Text, buyerssn.Text, sellerssn.Text, propertynum.Text, ptype, dateTimePicker1, float.Parse(sellingprice.Text), profit, agentid.Text);
            BS_Page.Show();


             }

            Updateowner(propertynum.Text, buyerssn.Text);
        }

        public void newtrans(string tno, string bssn, string sssn, string pno, string ptype, DateTimePicker date, float price, float profit, string agentids)
        {


            SqlCommand newtran = SqlConnectionCommand.getCommand();
            newtran.CommandText = "USE SRDB INSERT INTO TRANSACTIONS Values " +
                "(@strtno, @strbssn, @strsssn, @strpno, @strptype, @strdate, @floatprice, @floatprofit, @stragent)";

          
            newtran.Parameters.AddWithValue("@strtno", tno);
            newtran.Parameters.AddWithValue("@strbssn", bssn);
            newtran.Parameters.AddWithValue("@strsssn", sssn);
            newtran.Parameters.AddWithValue("@strpno", pno);
            newtran.Parameters.AddWithValue("@strptype", ptype);
            newtran.Parameters.AddWithValue("@strdate", dateTimePicker1.Value);
            newtran.Parameters.AddWithValue("@floatprice", price);
            newtran.Parameters.AddWithValue("@floatprofit", profit);
            newtran.Parameters.AddWithValue("@stragent", agentids);


            try
            {
                newtran.ExecuteNonQuery();
                MessageBox.Show("Successfully added" + " " + tno + " " + date , "new transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.ToString());
             //   MessageBox.Show("Please make sure BSSN, SSSN, Property Number and Agent ID is valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show("Please make sure BSSN, SSSN, Property Number and Agent ID is valid" , MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show(" Please make sure BSSN, SSSN, Property Number and Agent ID is valid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //  MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //end



        }

        private void propertynum_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                float.Parse(propertynum.Text);
            }

            catch
            {
                MessageBox.Show("Please Enter a number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void propertytype_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                float.Parse(propertytype.Text);
            }

            catch
            {
                MessageBox.Show("Please Enter a number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
        }

        private void dateoftrans_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                float.Parse(dateoftrans.Text);
                if (dateoftrans.Text.Length > 4 && dateoftrans.Text != null)
                {
                    dateoftrans.Text = null;
                }
            }

            catch
            {
                MessageBox.Show("Please Enter correct date format MM/DD/YYYY ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void sellerssn_TextChanged(object sender, EventArgs e)
        {
           /* try
            {
                float.Parse(sellerssn.Text);
                if (sellerssn.Text.Length > 9 && sellerssn.Text != null)
                {
                    sellerssn.Text = null;
                }
            }

            catch
            {
                MessageBox.Show(" Please Enter 9 digit SSSN  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
        }

        private void buyerssn_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                float.Parse(buyerssn.Text);
                if (buyerssn.Text.Length > 9 && buyerssn.Text != null)
                {
                    buyerssn.Text = null;
                }
            }

            catch
            {
                MessageBox.Show(" Please Enter 9 digit BSSN  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void transnum_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                float.Parse(transnum.Text);
                if (transnum.Text.Length > 14 && transnum.Text != null)
                {
                    transnum.Text = null;
                }
            }

            catch
            {
                MessageBox.Show(" Please Enter 14 digit Transaction Number  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void profitbox_TextChanged(object sender, EventArgs e)
        {

        }

        public float GetPrice(float propertynum) {
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactions viewtranspage = new ViewTransactions();
            viewtranspage.Show();
        }
    }
}
    


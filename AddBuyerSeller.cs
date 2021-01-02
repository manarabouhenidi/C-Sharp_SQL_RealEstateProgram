using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateDB
{
    public partial class AddBuyerSeller : Form
    {

       // SSNTextBox.Text = 
        public AddBuyerSeller()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void AddBuyerSeller_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            long j;
            if (string.IsNullOrWhiteSpace(Fname.Text))
            {
                MessageBox.Show("Please enter a first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Lname.Text))
            {
                MessageBox.Show("Please enter a last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SSNText.TextLength != 9 || !int.TryParse(SSNText.Text, out i))
            {

                MessageBox.Show("Please enter a 9 digit SSN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(StrAdd.Text))
            {
                MessageBox.Show("Please enter a street address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(City.Text))
            {
                MessageBox.Show("Please enter a city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (State.SelectedItem == null)
            {
                MessageBox.Show("Please select a state", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Zip.TextLength != 5 || !int.TryParse(Zip.Text, out i))
            {

                MessageBox.Show("Please enter a 5 digit Zip Code ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Type.SelectedItem == null)
            {
                MessageBox.Show("Please Specify if this person is a seller or buyer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Phone.TextLength != 10 || !long.TryParse(Phone.Text, out j))
            {
                MessageBox.Show("Please enter a 10 digit phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter an e-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
               
               addBUYERSELLER(Type.SelectedItem.ToString(), SSNText.Text, Fname.Text, Mname.Text, Lname.Text, Email.Text,
               Phone.Text, StrAdd.Text, City.Text, State.SelectedItem.ToString(), Zip.Text); 

            }

            
        }

        public void addBUYERSELLER(string atype, string aSSN, string afname, string amname, string alname, string aemail, string aphone,
            string astreetAdd, string acity, string aBS_State, string azip)
        {
            {
                float zero = 0;
                string status = "Active";
                SqlCommand addbs = SqlConnectionCommand.getCommand();
                addbs.CommandText = "USE SRDB INSERT INTO BUYERSELLER Values " +
                "(@strtype, @strSSN, @strfname, @strmname, @strlname, @stremail, @strphone, @strstreetAdd, @strcity, @strState, @strzip, @floatProfit, @strstatus)";
                addbs.Parameters.AddWithValue("@strtype", atype);
                addbs.Parameters.AddWithValue("@strSSN", aSSN);
                addbs.Parameters.AddWithValue("@strfname", afname);
                addbs.Parameters.AddWithValue("@strmname", amname);
                addbs.Parameters.AddWithValue("@strlname", alname);
                addbs.Parameters.AddWithValue("@stremail", aemail);
                addbs.Parameters.AddWithValue("@strphone", aphone);
                addbs.Parameters.AddWithValue("@strstreetAdd", astreetAdd);
                addbs.Parameters.AddWithValue("@strcity", acity);
                addbs.Parameters.AddWithValue("@strState", aBS_State);
                addbs.Parameters.AddWithValue("@strzip", azip);
                addbs.Parameters.AddWithValue("@floatProfit", zero);
                addbs.Parameters.AddWithValue("@strstatus", status);

                try
                {
                    addbs.ExecuteNonQuery();
                    MessageBox.Show("Successfully added");
                    this.Hide();
                    ViewBuyerSeller BS_Page = new ViewBuyerSeller();
                    BS_Page.Show();

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.ToString());
                    MessageBox.Show("The SSN entered already exists, Please enter another SSN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
                }

            }


        }

        private void SSNText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void City_TextChanged(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

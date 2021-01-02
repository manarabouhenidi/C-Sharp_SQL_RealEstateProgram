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
    public partial class EditBuyerSeller : Form
    {
        public EditBuyerSeller()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home_page = new HomePage();
            home_page.Show();
        }

        private void SSNText_TextChanged(object sender, EventArgs e)
        {
            SSNText.ReadOnly = true;
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
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
            else if (Phone.TextLength != 10 || !long.TryParse(Phone.Text, out j))
            {
                MessageBox.Show("Please enter a 10 digit phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter an e-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                this.Hide();
                ViewBuyerSeller BS_Page = new ViewBuyerSeller();

                updateBUYERSELLER( SSNText.Text, Fname.Text, Mname.Text, Lname.Text, Email.Text,
                       Phone.Text, StrAdd.Text, City.Text, State.SelectedItem.ToString(), Zip.Text, status.SelectedItem.ToString());


                BS_Page.Show();
            }
        }


        public void updateBUYERSELLER(string aSSN, string afname, string amname, string alname, string aemail, string aphone,
         string astreetAdd, string acity, string aBS_State, string azip, string status)
        {
            {
                float zero = 0;
                SqlCommand addbs = SqlConnectionCommand.getCommand();
                addbs.CommandText = "USE SRDB UPDATE BUYERSELLER SET " +
                "Fname = @strfname, Mname = @strmname, Lname = @strlname, Email = @stremail, Phone = @strphone, " +
                "StreetAddress = @strstreetAdd, City = @strcity, BS_State = @strstate, Zip = @strzip, status = @strstatus" + 
                " WHERE SSN = @strSSN;"; 
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
                addbs.Parameters.AddWithValue("@strstatus", status);

                try
                {
                    addbs.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not update. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}

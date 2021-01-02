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
//using System.G

namespace RealEstateDB
{
    public partial class AddProperty : Form
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddProperty_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            //The following function is to add new property to the databases
 
                
            if (ownerssnbox.TextLength< 9 )
            {
                MessageBox.Show(" You Enterd Less than 9 digits, Please Enter 9 Digits SSN! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (zipbox.TextLength < 5)
            {
                MessageBox.Show(" You Enterd Less than 5 digits, Please Enter 5 Digits ZipCode ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

            if (DateBuiltbox.TextLength < 4)
            {
                MessageBox.Show(" You Enterd Less than 4 digits, Please Enter 4 digits Date! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                addproperty(Pnobox.Text, comboboxtype.SelectedItem.ToString(), combostatus.SelectedItem.ToString(), addressbox.Text,
                citybox.Text, combostates.Text, zipbox.Text, countybox.Text, float.Parse(areabox.Text), float.Parse(pricebox.Text), float.Parse(taxbox.Text), DateBuiltbox.Text, ownerssnbox.Text);
            }


        }  

        public void addproperty(string Pno, string type, string status, string Address,  string city, string state, string zip, string county, 
        float Area, float price, float tax, string Date, string ownerssn)
        {
            {
                SqlCommand addproperty = SqlConnectionCommand.getCommand();
                addproperty.CommandText = "USE SRDB INSERT INTO PROPERTY Values" +
                    "(@strPNO, @strtype, @strDate, @floatprice, @strstatus, @floatTax, @strAddress, @strcity, @strstate, @strzip," +
                    "@strcounty, @floatArea, @strownerssn)";

                //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);
                    addproperty.Parameters.AddWithValue("@strPno", Pno);
                    addproperty.Parameters.AddWithValue("@strtype", type);
                    addproperty.Parameters.AddWithValue("@strstatus", status);
                    addproperty.Parameters.AddWithValue("@strAddress", Address);
                    addproperty.Parameters.AddWithValue("@strCity", city);
                    addproperty.Parameters.AddWithValue("@strstate", state);
                    addproperty.Parameters.AddWithValue("@strzip", zip);
                    addproperty.Parameters.AddWithValue("@strcounty", county);
                    addproperty.Parameters.AddWithValue("@floatarea",Area);
                    addproperty.Parameters.AddWithValue("@floatprice", price);
                    addproperty.Parameters.AddWithValue("@floatTax", tax);
                    addproperty.Parameters.AddWithValue("@strDate", Date);
                    addproperty.Parameters.AddWithValue("@strownerssn", ownerssn);

                  //  MessageBox.Show(addproperty.CommandText.ToString());   
                    try
                    {
                        addproperty.ExecuteNonQuery();
                        MessageBox.Show("Successfully added" + " " + Pno   + " " + type ,
                        "Added property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ViewProps view_props = new ViewProps();
                            view_props.Show();

                }
                    catch (Exception ex)
                    {
                       MessageBox.Show(" Please Make sure that you Entered a Valid Seller SSN Number in the OwnerSSN Box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     

                    // MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//end

            }


            }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(areabox.Text);
            }

            catch
            {
                MessageBox.Show("Please Enter a number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* Random slumpGenerator = new Random(); int tal;
             tal = slumpGenerator.Next(1000000000);
             Pnobox.Text = tal.ToString();*/

            System.Guid guid = System.Guid.NewGuid();
            String id = guid.ToString();
        }

        private void statebox_TextChanged(object sender, EventArgs e)
        {
            //if (combostates.TextLength>2)
            // {

              //  MessageBox.Show("Please Use the State Abbreviation ","Incorrect text",MessageBoxButtons.OK,MessageBoxIcon.Error);

           //  }
                
        }

        private void pricebox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(pricebox.Text);
            }

            catch
            {
                MessageBox.Show("Please Enter a dollar amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void zipbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
               float.Parse(zipbox.Text);
                if (zipbox.Text.Length > 5 && zipbox.Text != null)
                {
                    zipbox.Text = null;
                }
            }

            catch
            {
                MessageBox.Show("Please Enter 5 zip code digits ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void taxbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(taxbox.Text);
            }

            catch
            {
                MessageBox.Show("Please Enter a dollar amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DateBuiltbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(DateBuiltbox.Text);
                if (DateBuiltbox.Text.Length>4 && DateBuiltbox.Text !=null)
                {
                    DateBuiltbox.Text = null;
                }
            }

            catch
            {
                MessageBox.Show("Please Enter 4 digit year built ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ownerssnbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(ownerssnbox.Text);
                if (ownerssnbox.Text.Length > 9 && ownerssnbox.Text != null)
                {
                    ownerssnbox.Text = null;
                }
            }

            catch
            {
                MessageBox.Show(" Please Enter 9 digit SSN  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProps view_props = new ViewProps();
            view_props.Show();

        }


        /*
        public class Employee
        {
            public Guid Id { get; private set; } = Guid.NewGuid();
            public string EmployeeName { get; set; }
            public string Address { get; set; }
        }
        */

    }
}

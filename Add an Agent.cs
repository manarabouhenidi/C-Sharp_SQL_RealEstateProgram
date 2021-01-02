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
    public partial class Add_an_Agent : Form
    {
        public Add_an_Agent()
        {
            InitializeComponent();
        }

        private void Add_an_Agent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addnewagentbutton_Click(object sender, EventArgs e)
        {
            SearchAgent(AgentIDbox.Text, Firstnamebox.Text, LastNamebox.Text, AddressBox.Text, Citybox.Text, combostate.SelectedItem.ToString(), zipbox.Text, phonebox.Text,
        emailbox.Text, DOB, StartDate, statuscombobox.SelectedItem.ToString());
        }

        public void SearchAgent(string AgentID, string Fname, string Lname, string Address, string city, string state, string zip, string phone,
        string Email, DateTimePicker DOB, DateTimePicker StartDate, string status)
        {
            {
                SqlCommand SearchAgent = SqlConnectionCommand.getCommand();
                SearchAgent.CommandText = "USE SRDB INSERT INTO AGENT Values" +
                    "(@strAgent_id, @strFirst_name, @strLast_name, @strStreet, @strCity, @strState, @strZip, @strA_phone," +
                    " @strA_email, @strDate, @strDOB, @strstatus)";

                //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);
                SearchAgent.Parameters.AddWithValue("@strstatus", status);
                SearchAgent.Parameters.AddWithValue("@strAgent_id", AgentID);
                SearchAgent.Parameters.AddWithValue("@strFirst_name", Fname);
                SearchAgent.Parameters.AddWithValue("@strLast_name", Lname);
                SearchAgent.Parameters.AddWithValue("@strStreet", Address);
                SearchAgent.Parameters.AddWithValue("@strCity", city);
                SearchAgent.Parameters.AddWithValue("@strState", state);
                SearchAgent.Parameters.AddWithValue("@strZip", zip);
                SearchAgent.Parameters.AddWithValue("@strA_phone", phone);
                SearchAgent.Parameters.AddWithValue("@strA_email", Email);
                SearchAgent.Parameters.AddWithValue("@strDate", StartDate.Value);
                SearchAgent.Parameters.AddWithValue("@strDOB", DOB.Value);

             //   MessageBox.Show(SearchAgent.CommandText.ToString());   
                try
                {
                    SearchAgent.ExecuteNonQuery();
                    MessageBox.Show("Successfully added" + " " + AgentID + " " + Fname,
                    "Added as an Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewAgents Home_page = new ViewAgents();
                    Home_page.Show();
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.ToString());
                   // MessageBox.Show(" Please Enter a Different Agent Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//end

            }
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAgents Home_page = new ViewAgents();
            Home_page.Show();
        }

        private void phonebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOBbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void statuscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}



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
    public partial class Edit_Agent : Form
    {
        public Edit_Agent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectedAgent select_agent = new SelectedAgent();
            select_agent.Show();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            updateAgent(AgentIDbox.Text, FirstNameBox.Text, LastNamebox.Text, Adressbox.Text, citybox.Text, statecombobox.Text, zipbox.Text, phonebox.Text,
        emailbox.Text, dateTimePicker1, dateTimePicker2, StatusBox.Text);

        }
            public void updateAgent(string AgentID, string Fname, string Lname, string Address, string city, string state, string zip, string phone,
        string Email, DateTimePicker DOB, DateTimePicker StartDate, string Status)
            {
                {
                    SqlCommand updateAgent = SqlConnectionCommand.getCommand();
                    updateAgent.CommandText = "USE SRDB UPDATE AGENT SET " +
                        "First_name = @strFirst_name, Last_name =  @strLast_name, Street = @strStreet, City = @strCity, State =  @strState, Zip = @strZip, A_phone = @strA_phone," +
                        " A_email =  @strA_email, Start_Date = @strDate, DOB = @strDOB, Status = @strstatus WHERE Agent_id = @strAgent_id";

                    //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);
                    updateAgent.Parameters.AddWithValue("@strAgent_id", AgentID);
                    updateAgent.Parameters.AddWithValue("@strFirst_name", Fname);
                    updateAgent.Parameters.AddWithValue("@strLast_name", Lname);
                    updateAgent.Parameters.AddWithValue("@strStreet", Address);
                    updateAgent.Parameters.AddWithValue("@strCity", city);
                    updateAgent.Parameters.AddWithValue("@strState", state);
                    updateAgent.Parameters.AddWithValue("@strZip", zip);
                    updateAgent.Parameters.AddWithValue("@strA_phone", phone);
                    updateAgent.Parameters.AddWithValue("@strA_email", Email);
                    updateAgent.Parameters.AddWithValue("@strDate", StartDate.Value);
                    updateAgent.Parameters.AddWithValue("@strDOB", DOB.Value);
                    updateAgent.Parameters.AddWithValue("@strstatus", Status);


              //  MessageBox.Show(updateAgent.CommandText.ToString());
                    try
                    {
                        
                        updateAgent.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated" + " " + AgentID + " " + Fname,
                        "Added as an Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewAgents view_agent = new ViewAgents();
                    view_agent.Show();

                }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        // MessageBox.Show(" Please Enter a Different Agent Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//end

                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home_page = new HomePage();
            home_page.Show();
        }

        private void statecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SelectedAgent : Form
    {
        public SelectedAgent()
        {
            InitializeComponent();
        }

        private void DeleteAgent_Click(object sender, EventArgs e)
        {
           // delete_Agent(AgentID);

        }

        //---------------------------- delete function-------------------
        public void delete_Agent(string AgentID)
        {
            /*
            var delete = MessageBox.Show("Delete Agent ?", "Confirm Delete Agent" , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (delete == DialogResult.Yes)
            *
                SqlCommand delete_props = SqlConnectionCommand.getCommand();
                delete_props.CommandText = "USE SRDB DELETE FROM AGENT WHERE AGENT = @AGENTID";
                delete_props.Parameters.AddWithValue("@AGENT", AgentID;
                delete_props.ExecuteNonQuery();

                try
                {
                    MessageBox.Show("Successfully Deleted" + " " + AgentID,
                        "Added property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewAgents Agents_page = new ViewAgents();
                    Agents_page.Show();
                    
                }

                catch (Exception ex)
                {

                }*/

            }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAgents viewagents_page = new ViewAgents();
            viewagents_page.Show();
        }

        private void editagent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Agent EditAgent_page = new Edit_Agent();

            EditAgent_page.AgentIDbox.Text = AgentIDBox.Text;
            EditAgent_page.FirstNameBox.Text = Firstnamebox.Text;
            EditAgent_page.LastNamebox.Text = Lastnamrbox.Text;
            EditAgent_page.Adressbox.Text = AddressBox.Text;
            EditAgent_page.citybox.Text = CityBox.Text;
            EditAgent_page.statecombobox.Text = statetextbox.Text;
            EditAgent_page.zipbox.Text = Zipcodebox.Text;
            EditAgent_page.phonebox.Text = PhoneBox.Text;
            EditAgent_page.emailbox.Text = EmailBox.Text;
            EditAgent_page.dateTimePicker1.Text = StartDateBOx.Text;
            EditAgent_page.dateTimePicker2.Text = DOBBox.Text;
            EditAgent_page.StatusBox.Text = StatusBox.Text;
            


            EditAgent_page.Show();
        }

        private void agentgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectedAgent_Load(object sender, EventArgs e)
        {

            SqlCommand Seach_trans_Agent = SqlConnectionCommand.getCommand();
            Seach_trans_Agent.CommandText = "USE SRDB SELECT * FROM TRANSACTIONS Where AgentId = @Agent_ID";

            Seach_trans_Agent.Parameters.AddWithValue("@Agent_ID", AgentIDBox.Text);
            try
            {

                SqlDataReader reader = Seach_trans_Agent.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                agentgrid.DataSource = dataTable;

                //   MessageBox.Show("Successfully added" + " " +  + " " + type,
            }
            catch (Exception ex)
            {

            }//end





        }




        private void StateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgentIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

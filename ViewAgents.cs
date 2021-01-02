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
    public partial class ViewAgents : Form
    {
        public ViewAgents()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean value1 = true; // to check each index if its skipped or has values and excutes it in sql 

            SqlCommand SearchAgent = SqlConnectionCommand.getCommand();
            SearchAgent.CommandText = "USE SRDB SELECT * FROM AGENT Where";


            // search box for the state only if the box is not empty or null than exceute that SQL statment
            // checking each index if it is empty or working


            if (!(string.IsNullOrEmpty(AgentIDBox.Text)))
            {
                SearchAgent.CommandText += " Agent_id = @strAgent_id";
                value1 = false;
            }
             //search DOB and SD 
             
            if (!(DOBdateTimePicker.Text == " ") && value1 == true)
            {
                SearchAgent.CommandText += " DOB = @strDOB";
                 value1 = false;
            }

            else if (!(DOBdateTimePicker.Text == " ") && value1 == false)
             {
                SearchAgent.CommandText += " AND DOB = @strDOB";
                  value1 = false;
             }

             if (!(SDdateTimePicker.Text == " ") && value1 == true)
             {
                SearchAgent.CommandText += " Start_Date = @strDate";
                value1 = false;
             }

            else if (!(SDdateTimePicker.Text == " ") && value1 == false)
             {
                SearchAgent.CommandText += " AND Start_Date = @strStart_Date";
                value1 = false;
             }
             //-------------------------------------------------------------------
             if (!(string.IsNullOrEmpty(FirstNameBox.Text)) && value1 == true)
             {
                SearchAgent.CommandText += " First_name = @strFirst_name";
                value1 = false;
             }

             else if (!(string.IsNullOrEmpty(FirstNameBox.Text)) && value1 == false)
             {
                SearchAgent.CommandText += " AND First_name = @strFirst_name";
                value1 = false;
             }

             if (!(string.IsNullOrEmpty(Lastnamebox.Text)) && value1 == true)
             {
                SearchAgent.CommandText += " Last_name = @Last_name";
                value1 = false;
             }

            else if (!(string.IsNullOrEmpty(Lastnamebox.Text)) && value1 == false)
            {
                SearchAgent.CommandText += " AND Last_name = @strLast_name";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(combostatus.Text.ToString())) && value1 == true)
            {
                SearchAgent.CommandText += " status = @strstatus";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(combostatus.Text.ToString())) && value1 == false)
            {
                SearchAgent.CommandText += " AND status = @strstatus";
                value1 = false;
            }
            /*  private void ViewAgent_Load(object sender, EventArgs e)
              {
                  SqlCommand GetAgent = SqlConnectionCommand.getCommand();
                  GetAgent.CommandText = "USE srdb SELECT * FROM AGENT";
                  SqlDataReader reader = GetAgent.ExecuteReader();

                  DataTable dataTable = new DataTable();
                  dataTable.Load(reader);

                  Agentgrid.DataSource = dataTable;
             */ //}

            SearchAgent.Parameters.AddWithValue("@strAgent_id", AgentIDBox.Text);
            SearchAgent.Parameters.AddWithValue("@strFirst_name", FirstNameBox.Text);
            SearchAgent.Parameters.AddWithValue("@strLast_name", Lastnamebox.Text);
         //   SearchAgent.Parameters.AddWithValue("@strA_Profit", Phone);
            SearchAgent.Parameters.AddWithValue("@strStart_Date", SDdateTimePicker.Value.ToString("yyyy-MM-dd"));
            SearchAgent.Parameters.AddWithValue("@strDOB", DOBdateTimePicker.Value.ToString("yyyy-MM-dd"));
            SearchAgent.Parameters.AddWithValue("strstatus", combostatus.Text.ToString());

           // MessageBox.Show(SearchAgent.CommandText.ToString());
            try
            {
                SearchAgent.ExecuteNonQuery();
                //MessageBox.Show("Successfully Searched" + " " + AgentID + " " + Fname,
                // "Searched an Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataReader reader = SearchAgent.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                Agentgrid.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                // MessageBox.Show(" Please Enter a Different Agent Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end

        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand GetAgents = SqlConnectionCommand.getCommand();
            GetAgents.CommandText = "USE srdb SELECT * FROM AGENT ";
            SqlDataReader reader = GetAgents.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Agentgrid.DataSource = dataTable;



            Agentgrid.ReadOnly = true;
            String type = Agentgrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            this.Hide();

            SelectedAgent Agent_page = new SelectedAgent();

            Agent_page.AgentIDBox.Text = Agentgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            Agent_page.Firstnamebox.Text = Agentgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Agent_page.Lastnamrbox.Text = Agentgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            Agent_page.AddressBox.Text = Agentgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            Agent_page.CityBox.Text = Agentgrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            Agent_page.statetextbox.Text = Agentgrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            Agent_page.Zipcodebox.Text = Agentgrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            Agent_page.PhoneBox.Text = Agentgrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            Agent_page.EmailBox.Text = Agentgrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            Agent_page.StartDateBOx.Text = Agentgrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            Agent_page.DOBBox.Text = Agentgrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            Agent_page.StatusBox.Text = Agentgrid.Rows[e.RowIndex].Cells[11].Value.ToString();



            /*Property_page.Fname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[2].Value.ToString();
                     Property_page.Mname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[3].Value.ToString();
                     Property_page.Lname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[4].Value.ToString();
                     Property_page.Email.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[5].Value.ToString();
                     Property_page.Phone.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[6].Value.ToString();
                     Property_page.StrAdd.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[7].Value.ToString();
                     Property_page.City.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[8].Value.ToString();
                     Property_page.State.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[9].Value.ToString();
                     Property_page.Zip.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[10].Value.ToString();*/

            Agent_page.Show();

        }

        private void ViewAgents_Load(object sender, EventArgs e)
        {
            SqlCommand GetAgent = SqlConnectionCommand.getCommand();
            GetAgent.CommandText = "USE srdb SELECT * FROM AGENT";
            SqlDataReader reader = GetAgent.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Agentgrid.DataSource = dataTable;

        // DOBdateTimePicker.Value.tos = null;
        // SDdateTimePicker.Value = null;

        }


        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();


        }

        private void SearchAgent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_an_Agent SearchAgent_page = new Add_an_Agent();
            SearchAgent_page.Show();
        }

        private void DOBdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DOBdateTimePicker.CustomFormat = "MM/dd/yyyy";
 
        }

        private void SDdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SDdateTimePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Agentgrid.ReadOnly = true;
            SqlCommand GetAgentinfo = SqlConnectionCommand.getCommand();
            GetAgentinfo.CommandText = "USE srdb SELECT * FROM AGENTS";
            SqlDataReader reader = GetAgentinfo.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Agentgrid.DataSource = dataTable;
        }
    }
}

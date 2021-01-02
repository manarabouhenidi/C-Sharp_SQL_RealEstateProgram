using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateDB
{
    public partial class ViewBuyerSeller : Form
    {
        public ViewBuyerSeller()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBuyerSeller Add_page = new AddBuyerSeller();
            Add_page.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBuyerSeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            String type = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[0].Value.ToString();
            

            if (type == "Seller" || type == "SELLER") {
                this.Hide();

                SelectedSeller Seller_page = new SelectedSeller();

                Seller_page.SSNText.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[1].Value.ToString();
                Seller_page.Fname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[2].Value.ToString();
                Seller_page.Mname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[3].Value.ToString();
                Seller_page.Lname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[4].Value.ToString();
                Seller_page.Email.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[5].Value.ToString();
                Seller_page.Phone.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[6].Value.ToString();
                Seller_page.StrAdd.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[7].Value.ToString();
                Seller_page.City.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[8].Value.ToString();
                Seller_page.State.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[9].Value.ToString();
                Seller_page.Zip.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[10].Value.ToString();
                Seller_page.status.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[12].Value.ToString();


                Seller_page.Show();

            }
            else if (type == "Buyer" || type == "BUYER") {
                this.Hide();
                SelectedBuyer Buyer_page = new SelectedBuyer();

                Buyer_page.SSNText.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[1].Value.ToString();
                Buyer_page.Fname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[2].Value.ToString();
                Buyer_page.Mname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[3].Value.ToString();
                Buyer_page.Lname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[4].Value.ToString();
                Buyer_page.Email.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[5].Value.ToString();
                Buyer_page.Phone.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[6].Value.ToString();
                Buyer_page.StrAdd.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[7].Value.ToString();
                Buyer_page.City.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[8].Value.ToString();
                Buyer_page.State.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[9].Value.ToString();
                Buyer_page.Zip.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[10].Value.ToString();
                Buyer_page.status.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[12].Value.ToString();
                Buyer_page.Show();

            }
            

        }

        private void ViewBuyerSeller_Load(object sender, EventArgs e)
        {
            dataGridViewBuyerSeller.ReadOnly = true;
            SqlCommand GetBuyerSeller = SqlConnectionCommand.getCommand();
            GetBuyerSeller.CommandText = "USE srdb SELECT * FROM BUYERSELLER";
            SqlDataReader reader = GetBuyerSeller.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridViewBuyerSeller.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Boolean value1 = true; // to check each index if its skipped or has values and excutes it in sql 

            SqlCommand searchperson = SqlConnectionCommand.getCommand();
            searchperson.CommandText = "USE SRDB SELECT * FROM BUYERSELLER Where";


            // search box for the state only if the box is not empty or null than exceute that SQL statment
            // checking each index if it is empty or working

            if (!(string.IsNullOrEmpty(Fnametxt.Text)))
            {
                searchperson.CommandText += " Fname = @strfname";
                value1 = false;
            }

            //search 
            if (!(string.IsNullOrEmpty(Mnametxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " Mname = @strmname";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Mnametxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND Mname = @strmname";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(Lnametxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " Lname = @strlname";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Lnametxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND Lname = @strlname";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(SSNtxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " SSN = @strssn";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(SSNtxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND SSN = @strssn";
                value1 = false;
            }

            if (!(TypeCombo.SelectedItem == null) && value1 == true)
            {
                searchperson.CommandText += " Type = @strtype";
                value1 = false;
            }

            else if (!(TypeCombo.SelectedItem == null) && value1 == false)
            {
                searchperson.CommandText += " AND Type = @strtype";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(Citytxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " City = @strcity";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Citytxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND City = @strcity";
                value1 = false;
            }

            if (!(StateCombo.SelectedItem == null) && value1 == true)
            {
                searchperson.CommandText += " BS_State = @strstate";
                value1 = false;
            }

            else if (!(StateCombo.SelectedItem == null) && value1 == false)
            {
                searchperson.CommandText += " AND BS_State = @strstate";
                value1 = false;
            }

            if (!(status.SelectedItem == null) && value1 == true)
            {
                searchperson.CommandText += " status = @strstatus";
                value1 = false;
            }

            else if (!(status.SelectedItem == null) && value1 == false)
            {
                searchperson.CommandText += " AND status = @strstatus";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(Ziptxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " Zip = @strzip";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Ziptxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND Zip = @strzip";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(Phonetxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " Phone = @strphone";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Phonetxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND Phone = @strphone";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(Emailtxt.Text)) && value1 == true)
            {
                searchperson.CommandText += " Email = @stremail";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(Emailtxt.Text)) && value1 == false)
            {
                searchperson.CommandText += " AND Email = @stremail";
                value1 = false;
            }

            searchperson.Parameters.AddWithValue("@strfname", Fnametxt.Text);
            searchperson.Parameters.AddWithValue("@strmname", Mnametxt.Text);
            searchperson.Parameters.AddWithValue("@strlname", Lnametxt.Text);
            searchperson.Parameters.AddWithValue("@strssn", SSNtxt.Text);
            searchperson.Parameters.AddWithValue("@strtype", TypeCombo.Text);
            searchperson.Parameters.AddWithValue("@strcity", Citytxt.Text);
            searchperson.Parameters.AddWithValue("@strstate", StateCombo.Text);
            searchperson.Parameters.AddWithValue("@strzip", Ziptxt.Text);
            searchperson.Parameters.AddWithValue("@strphone", Phonetxt.Text);
            searchperson.Parameters.AddWithValue("@stremail", Emailtxt.Text);
            searchperson.Parameters.AddWithValue("@strstatus", status.Text);

            try
            {

                SqlDataReader reader = searchperson.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewBuyerSeller.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }//end
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridViewBuyerSeller.ReadOnly = true;
            SqlCommand GetBuyerSeller = SqlConnectionCommand.getCommand();
            GetBuyerSeller.CommandText = "USE srdb SELECT * FROM BUYERSELLER";
            SqlDataReader reader = GetBuyerSeller.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridViewBuyerSeller.DataSource = dataTable;
        }

        private void StateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


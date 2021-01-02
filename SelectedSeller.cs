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
    public partial class SelectedSeller : Form
    {
        public SelectedSeller()
        {
            InitializeComponent();
        }

        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home_page = new HomePage();
            home_page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBuyerSeller edit_page = new EditBuyerSeller();
            edit_page.Fname.Text = Fname.Text;
            edit_page.Mname.Text = Mname.Text;
            edit_page.Lname.Text = Lname.Text;
            edit_page.SSNText.Text = SSNText.Text;
            edit_page.StrAdd.Text = StrAdd.Text;
            edit_page.City.Text = City.Text;
            edit_page.State.Text = State.Text;
            edit_page.Zip.Text = Zip.Text;
            edit_page.Phone.Text = Phone.Text;
            edit_page.Email.Text = Email.Text;
            edit_page.status.Text = status.Text;
            edit_page.Show();
        }

        private void SSNText_TextChanged(object sender, EventArgs e)
        {
            SSNText.ReadOnly = true;
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            Fname.ReadOnly = true;
        }

        private void Mname_TextChanged(object sender, EventArgs e)
        {
            Mname.ReadOnly = true;
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {
            Lname.ReadOnly = true;
        }

        private void StrAdd_TextChanged(object sender, EventArgs e)
        {
            StrAdd.ReadOnly = true;
        }

        private void City_TextChanged(object sender, EventArgs e)
        {
            City.ReadOnly = true;
        }

        private void State_TextChanged(object sender, EventArgs e)
        {
            State.ReadOnly = true;
        }

        private void Zip_TextChanged(object sender, EventArgs e)
        {
            Zip.ReadOnly = true;
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            Phone.ReadOnly = true;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            Email.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ssn = SSNText.Text;
            SqlCommand delete = SqlConnectionCommand.getCommand();
            delete.CommandText = "USE SRDB DELETE FROM BUYERSELLER WHERE SSN = @strssn;";

            delete.Parameters.AddWithValue("@strssn", ssn);

            try
            {
                delete.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Cannot save ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Faild to Add a property: " + ex.Message, "Add Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end 

            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            status.ReadOnly = true;
        }

        private void GVPropOwn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GVPropOwn.ReadOnly = true;
            SqlCommand GetProps = SqlConnectionCommand.getCommand();
            GetProps.CommandText = "USE srdb SELECT * FROM PROPERTY Where Ownerssn = @strssn;";
            SqlDataReader reader = GetProps.ExecuteReader();

            GetProps.Parameters.AddWithValue("@strssn", SSNText.Text);

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            GVPropOwn.DataSource = dataTable;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Load(object sender, EventArgs e)
        {
            GVPropOwn.ReadOnly = true;

            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.Parameters.AddWithValue("@strssn", SSNText.Text);
            GetData.CommandText = "USE srdb SELECT * FROM PROPERTY Where Ownerssn = @strssn ; ";
            SqlDataReader reader = GetData.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            GVPropOwn.DataSource = dataTable;

        }

        private void dataGridView2_Load(object sender, EventArgs e)
        {
            TransGV.ReadOnly = true;

            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.Parameters.AddWithValue("@strssn", SSNText.Text);
            GetData.CommandText = "USE srdb SELECT * FROM TRANSACTIONS Where sssn = @strssn ; ";
            SqlDataReader reader = GetData.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            TransGV.DataSource = dataTable;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewBuyerSeller view_buyer_seller_page = new ViewBuyerSeller();
            view_buyer_seller_page.Show();
        }

        private void TransGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


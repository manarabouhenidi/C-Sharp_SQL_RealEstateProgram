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
    public partial class SelectedBuyer : Form
    {
        public SelectedBuyer()
        {
            InitializeComponent();
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

        private void SSNText_TextChanged(object sender, EventArgs e)
        {
            SSNText.ReadOnly = true;
       
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

     

        private void status_TextChanged(object sender, EventArgs e)
        {
            status.ReadOnly = true;
        }

        private void ViewBuyerSeller_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlCommand GetProp = SqlConnectionCommand.getCommand();
            GetProp.CommandText = "USE srdb SELECT * FROM PROPERTY Where Ownerssn = @strssn;";
            SqlDataReader reader = GetProp.ExecuteReader();

            GetProp.Parameters.AddWithValue("@strssn", SSNText.Text);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.Parameters.AddWithValue("@strssn", SSNText.Text);
            GetData.CommandText = "USE srdb SELECT * FROM PROPERTY Where Ownerssn = @strssn ; ";
            SqlDataReader reader = GetData.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView2_Load(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;

            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.Parameters.AddWithValue("@strssn", SSNText.Text);
            GetData.CommandText = "USE srdb SELECT * FROM TRANSACTIONS Where bssn = @strssn ; ";
            SqlDataReader reader = GetData.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView2.DataSource = dataTable;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBuyerSeller view_buyer_seller_page = new ViewBuyerSeller();
            view_buyer_seller_page.Show();
        }
    }
}

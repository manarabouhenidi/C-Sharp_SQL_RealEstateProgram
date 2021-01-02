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
    public partial class ViewProps : Form
    {
        public ViewProps()
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
            AddProperty add_page = new AddProperty();
            add_page.Show();
        }


        private void dataGridViewProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewProps_Load(object sender, EventArgs e)
        {
            SqlCommand GetProperty = SqlConnectionCommand.getCommand();
            GetProperty.CommandText = "USE srdb SELECT * FROM PROPERTY";
            SqlDataReader reader = GetProperty.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridViewProperties.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean value1 = true; // to check each index if its skipped or has values and excutes it in sql 

            SqlCommand Searchprops = SqlConnectionCommand.getCommand();
            Searchprops.CommandText = "USE SRDB SELECT * FROM PROPERTY Where";


            // search box for the state only if the box is not empty or null than exceute that SQL statment
            // checking each index if it is empty or working

            if (!(string.IsNullOrEmpty(Pnobox.Text)))
            {
                Searchprops.CommandText += " Pno = @strPno";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(combostates.Text)) && value1 == true)
            {
                Searchprops.CommandText += " state = @strstate";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(combostates.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND state = @strstate";
                value1 = false;
            }

            //search 
            if (!(string.IsNullOrEmpty(citybox1.Text)) && value1 == true)
            {
                Searchprops.CommandText += " city = @strcity";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(citybox1.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND city = @strcity";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(ziptextbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " zip = @strzip";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(ziptextbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND zip = @strzip";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(countytextbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " county = @strcounty";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(countytextbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND county = @strcounty";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(statusbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " Status = @strstatus";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(statusbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND Status = @strstatus";
                value1 = false;
            }

            
            if (!(string.IsNullOrEmpty(pricetextbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " Price >= " + pricetextbox.Text;
                value1 = false;
            }
            else if (!(string.IsNullOrEmpty(pricetextbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND Price >= " + pricetextbox.Text ;
                value1 = false;
            
            }

            if (!(string.IsNullOrEmpty(pricetotextbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " Price <= " + pricetotextbox.Text;
                value1 = false;
            }
            else if (!(string.IsNullOrEmpty(pricetotextbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND Price <= " + pricetotextbox.Text;
                value1 = false;

            }

           

            if (!(string.IsNullOrEmpty(areatextbox1.Text)) && value1 == true)
            {
                Searchprops.CommandText += " Area = @floatArea";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(areatextbox1.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND Area = @floatArea";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(taxtextbox.Text)) && value1 == true)
            {
                Searchprops.CommandText += " Tax = @floatTax";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(taxtextbox.Text)) && value1 == false)
            {
                Searchprops.CommandText += " AND Tax = @floatTax";
                value1 = false;
            }




            //SearchAgent.CommandText += ";";
            //"(@strPNO, @strtype, @strDate, @floatprice, @strstatus, @floatTax, @strAddress, @strcity, @strstate, @strzip," +
            // "@strcounty, @floatArea, @strownerssn)";



            //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);
            //addproperty.Parameters.AddWithValue("@strPno", Pno);
            //addproperty.Parameters.AddWithValue("@strtype", type);
            //addproperty.Parameters.AddWithValue("@floatarea", Area);
            //addproperty.Parameters.AddWithValue("@strAddress", Address);
            //SearchAgent.Parameters.AddWithValue("@floatpriceto", pricetotextbox.Text);
            //addproperty.Parameters.AddWithValue("@strDate", Date);
            //addproperty.Parameters.AddWithValue("@strownerssn", ownerssn);
            //MessageBox.Show(SearchAgent.CommandText.ToString());   
            //MessageBox.Show("Successfully added" + " " +  + " " + type,

            Searchprops.Parameters.AddWithValue("@strPno", Pnobox.Text);
            Searchprops.Parameters.AddWithValue("@strCity", citybox1.Text);
            Searchprops.Parameters.AddWithValue("@strstate", combostates.Text);
            Searchprops.Parameters.AddWithValue("@strzip", ziptextbox.Text);
            Searchprops.Parameters.AddWithValue("@strcounty", countytextbox.Text);
            Searchprops.Parameters.AddWithValue("@floatprice", pricetextbox.Text);
            Searchprops.Parameters.AddWithValue("@floattoprice", pricetotextbox.Text);
            Searchprops.Parameters.AddWithValue("@floatarea", areatextbox1.Text);
            Searchprops.Parameters.AddWithValue("@floatTax", taxtextbox.Text);
            Searchprops.Parameters.AddWithValue("@strstatus", statusbox.Text);

         //   MessageBox.Show(Searchprops.CommandText.ToString());
            try
            {
              
                SqlDataReader reader = Searchprops.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewProperties.DataSource = dataTable;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }//end
        }

        private void dataGridViewProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProperties.ReadOnly=true;
            String type = dataGridViewProperties.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();

                SelectedProperty Property_page = new SelectedProperty();

            Property_page.Pnotextbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[0].Value.ToString();
            Property_page.typebox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[1].Value.ToString();
            Property_page.DateBuiltbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[2].Value.ToString();
            Property_page.pricebox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[3].Value.ToString();
            Property_page.statusbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[4].Value.ToString();
            Property_page.taxbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[5].Value.ToString();
            Property_page.addressbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[6].Value.ToString();
            Property_page.citybox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[7].Value.ToString();
            Property_page.statebox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[8].Value.ToString();
            Property_page.zipbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[9].Value.ToString();
            Property_page.countybox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[10].Value.ToString();
            Property_page.areabox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[11].Value.ToString();
            Property_page.ownerbox.Text = dataGridViewProperties.Rows[e.RowIndex].Cells[12].Value.ToString();

            /*Property_page.Fname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[2].Value.ToString();
                     Property_page.Mname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[3].Value.ToString();
                     Property_page.Lname.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[4].Value.ToString();
                     Property_page.Email.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[5].Value.ToString();
                     Property_page.Phone.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[6].Value.ToString();
                     Property_page.StrAdd.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[7].Value.ToString();
                     Property_page.City.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[8].Value.ToString();
                     Property_page.State.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[9].Value.ToString();
                     Property_page.Zip.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[10].Value.ToString();*/

            Property_page.Show();
            }

        private void pricetotextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void areatextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statebox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ziptextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pnobox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewProperties.ReadOnly = true;
            SqlCommand GetBuyerSeller = SqlConnectionCommand.getCommand();
            GetBuyerSeller.CommandText = "USE srdb SELECT * FROM PROPERTY";
            SqlDataReader reader = GetBuyerSeller.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridViewProperties.DataSource = dataTable;
        }

        private void statusbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

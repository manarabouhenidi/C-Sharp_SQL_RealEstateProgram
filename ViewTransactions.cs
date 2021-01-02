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
    public partial class ViewTransactions : Form
    {
        public ViewTransactions()
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
            NewTransaction new_trans = new NewTransaction();
            
            new_trans.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void state1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            /*dataGridView1.ReadOnly = true;

            SqlCommand GetTransactions = SqlConnectionCommand.getCommand();
            GetTransactions.CommandText = "USE srdb SELECT * FROM TRANSACTIONS";
            SqlDataReader reader = GetTransactions.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable; */
            //// dataGridView1.ReadOnly = true;

            //SqlCommand GetTransactions = SqlConnectionCommand.getCommand();
            // GetTransactions.CommandText = "USE srdb SELECT * FROM TRANSACTIONS";
            //SqlDataReader reader = GetTransactions.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);

            //dataGridView1.DataSource = dataTable;

            // MessageBox.Show(.ToString());
            SqlCommand searchtransactions = SqlConnectionCommand.getCommand();
            searchtransactions.CommandText = "USE SRDB SELECT * FROM TRANSACTIONS";

            try
            {

                SqlDataReader reader = searchtransactions.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                //   MessageBox.Show("Successfully added" + " " +  + " " + type,
            }
            catch (Exception ex)
            {

            }//end
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            //String type = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


            this.Hide();

            SelectedTransaction Transaction_page = new SelectedTransaction();


            Transaction_page.transnum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Transaction_page.transdate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Transaction_page.sssnselect.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Transaction_page.bssnselect.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Transaction_page.selectpno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Transaction_page.selectptype.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Transaction_page.selectprofit.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Transaction_page.selectprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Transaction_page.agentid.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            //  Seller_page.State.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[9].Value.ToString();
            //  Seller_page.Zip.Text = dataGridViewBuyerSeller.Rows[e.RowIndex].Cells[10].Value.ToString();

            Transaction_page.Show();
            //this.Controls.Add(vScrollBar1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean value1 = true;
            
            SqlCommand searchtransactions = SqlConnectionCommand.getCommand();
            searchtransactions.CommandText = "USE SRDB SELECT * FROM TRANSACTIONS Where";

            if (!(string.IsNullOrEmpty(agentid.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " agentid = @stragentid";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(agentid.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND agentid = @stragentid";
                value1 = false;
            }
            

            if (!(string.IsNullOrEmpty(bssn1.Text)))
            {
                searchtransactions.CommandText += " bssn = @strbssn";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(sssn1.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " sssn = @strsssn";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(sssn1.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND sssn = @strsssn";
                value1 = false;
            }


            if (!(string.IsNullOrEmpty(numtrans.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " tnum = @strtno";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(numtrans.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND tnum = @strtno";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(numprop.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " pno = @strpno";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(numprop.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND pno = @strpno";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(typeprop.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " ptype = @strptype";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(typeprop.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND ptype = @strptype";
                value1 = false;
            }

            if (!(string.IsNullOrEmpty(trandate.Text)) && value1 == true)
            {
                searchtransactions.CommandText += " date = @strdate";
                value1 = false;
            }

            else if (!(string.IsNullOrEmpty(trandate.Text)) && value1 == false)
            {
                searchtransactions.CommandText += " AND date = @strdate";
                value1 = false;
            }
            searchtransactions.Parameters.AddWithValue("@stragentid", agentid.Text);
            searchtransactions.Parameters.AddWithValue("@strtno", numtrans.Text);
            searchtransactions.Parameters.AddWithValue("@strsssn", sssn1.Text);
            searchtransactions.Parameters.AddWithValue("@strbssn", bssn1.Text);
            searchtransactions.Parameters.AddWithValue("@strpno", numprop.Text);
            searchtransactions.Parameters.AddWithValue("@strptype", typeprop.Text);
            searchtransactions.Parameters.AddWithValue("@strdate", trandate.Text);
           // searchtransactions.Parameters.AddWithValue("@strdate", trandate.Text);


            try
            {

                SqlDataReader reader = searchtransactions.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                //   MessageBox.Show("Successfully added" + " " +  + " " + type,
            }
            catch (Exception ex)
            {

            }//end
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlCommand GetTransinfo = SqlConnectionCommand.getCommand();
            GetTransinfo.CommandText = "USE SRDB SELECT * FROM TRANSACTIONS";
            SqlDataReader reader = GetTransinfo.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dataGridView1.DataSource = dataTable;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}

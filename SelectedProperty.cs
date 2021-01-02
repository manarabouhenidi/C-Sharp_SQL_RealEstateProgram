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
    public partial class SelectedProperty : Form
    {
        public SqlConnection PropertySQLConnection;

        public SelectedProperty(SqlConnection conn)
        {
            PropertySQLConnection = conn;
        }

        public SelectedProperty()
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
            UpdateProperty add_page = new UpdateProperty();

            add_page.pnobox.Text = Pnotextbox.Text;
            add_page.citybox.Text = citybox.Text;
            add_page.Addressbox.Text = addressbox.Text;
            add_page.statebox.Text = statebox.Text;
            add_page.zipbox.Text = zipbox.Text;
            add_page.countybox.Text = countybox.Text;
            add_page.pricebox.Text = pricebox.Text;
            add_page.taxbox.Text = taxbox.Text;
            add_page.areabox.Text = areabox.Text;
            add_page.comboPno.Text = typebox.Text;
            add_page.onerssnbox.Text = ownerbox.Text;
            add_page.yearbuiltbox.Text = DateBuiltbox.Text;


            add_page.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Pnotextbox.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  comboBoxtype.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pnotextbox.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            addressbox.ReadOnly = true;

        }

        private void SelectedProperty_Load(object sender, EventArgs e)
        {

            SqlCommand Seach_trans_Props = SqlConnectionCommand.getCommand();
            Seach_trans_Props.CommandText = "USE SRDB SELECT * FROM TRANSACTIONS Where Pno = @Pno";

            Seach_trans_Props.Parameters.AddWithValue("@Pno", Pnotextbox.Text);
            try
            {

                SqlDataReader reader = Seach_trans_Props.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                //   MessageBox.Show("Successfully added" + " " +  + " " + type,
            }
            catch (Exception ex)
            {

            }//end
        }

        private void statebox_TextChanged(object sender, EventArgs e)
        {
            statebox.ReadOnly = true;
        }

        private void zipbox_TextChanged(object sender, EventArgs e)
        {
            zipbox.ReadOnly = true;
        }

        private void countybox_TextChanged(object sender, EventArgs e)
        {
            countybox.ReadOnly = true; //country box
        }

        private void pricebox_TextChanged(object sender, EventArgs e)
        {
            pricebox.ReadOnly = true;
        }

        private void taxbox_TextChanged(object sender, EventArgs e)
        {
            taxbox.ReadOnly = true;
        }

        private void squarebox_TextChanged(object sender, EventArgs e)
        {
            areabox.ReadOnly = true;
        }

        private void statusbox_TextChanged(object sender, EventArgs e)
        {
            statusbox.ReadOnly = true;

        }

        private void ownerbox_TextChanged(object sender, EventArgs e)
        {
            ownerbox.ReadOnly = true;
        }

        private void DataBuiltbox_TextChanged(object sender, EventArgs e)
        {
            DateBuiltbox.ReadOnly = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            typebox.ReadOnly = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void citybox_TextChanged(object sender, EventArgs e)
        {
            citybox.ReadOnly = true;

        }


        /*
         *   SqlCommand view_trans = SqlConnectionCommand.getCommand();
            view_trans.CommandText = "USE SRDB SELECT(*) FROM TRANSACTIONS WHERE Pno = @pno";
            view_trans.Parameters.AddWithValue("@Pno", Pnotextbox);
            view_trans.ExecuteNonQuery();
            */
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }


        //---------------------------- delete function-------------------
        public void delete_props(string Pno)
        {

            var delete = MessageBox.Show("Delete Property ?", "Confirm Delete Property", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (delete == DialogResult.Yes)
            {
                SqlCommand delete_props = SqlConnectionCommand.getCommand();
                delete_props.CommandText = "USE SRDB DELETE FROM PROPERTY WHERE Pno = @pno";
                delete_props.Parameters.AddWithValue("@Pno", Pno);
                delete_props.ExecuteNonQuery();

                try
                {
                    MessageBox.Show("Successfully Deleted" + " " + Pno ,
                        "Added property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewProps Props_page = new ViewProps();
                    Props_page.Show();

                }

                catch (Exception ex)
                {

                }
            }


            //  MessageBox.Show(delete_props.CommandText.ToString());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            delete_props(Pnotextbox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProps view_props = new ViewProps();
            view_props.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand view_trans = SqlConnectionCommand.getCommand();
            view_trans.CommandText = "USE SRDB SELECT(*) FROM TRANSACTIONS WHERE Pno = @pno";
            view_trans.Parameters.AddWithValue("@Pno", Pnotextbox);
            view_trans.ExecuteNonQuery();
        }
    }
}

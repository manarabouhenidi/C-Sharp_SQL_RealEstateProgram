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
    public partial class ViewFinance : Form
    {
        public ViewFinance()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home_page = new HomePage();
            Home_page.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NumBuyers_TextChanged(object sender, EventArgs e)
        {
           
            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.CommandText = "USE srdb SELECT COUNT (*) FROM BUYERSELLER WHERE Type = 'Buyer'  ; ";
            SqlDataReader reader = GetData.ExecuteReader();
            reader.Read();
            NumBuyers.Text = reader[0].ToString();
            NumBuyers.ReadOnly = true; 

        }

        private void NumSellers_TextChanged(object sender, EventArgs e)
        {
            NumSellers.ReadOnly = true;
            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.CommandText = "USE srdb SELECT COUNT (*) FROM BUYERSELLER WHERE Type = 'Seller'  ; ";
            SqlDataReader reader = GetData.ExecuteReader();
            reader.Read();
            NumSellers.Text = reader[0].ToString();
        }

        private void NumProperties_TextChanged(object sender, EventArgs e)
        {
            
            NumProperties.ReadOnly = true;
            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.CommandText = "USE srdb SELECT COUNT (*) FROM PROPERTY  ; ";
            SqlDataReader reader = GetData.ExecuteReader();
            reader.Read();
            NumProperties.Text = reader[0].ToString();
        }

        private void NumTans_TextChanged(object sender, EventArgs e)
        {
      
            NumTans.ReadOnly = true;
            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.CommandText = "USE srdb SELECT COUNT (*) FROM PROPERTY  ; ";
            SqlDataReader reader = GetData.ExecuteReader();
            reader.Read();
            NumTans.Text = reader[0].ToString();
        }

        private void TotProfit_TextChanged(object sender, EventArgs e)
        {
            TotProfit.ReadOnly = true;
            SqlCommand GetData = SqlConnectionCommand.getCommand();
            GetData.CommandText = "USE srdb SELECT SUM (Profit) FROM TRANSACTIONS  ; ";
            SqlDataReader reader = GetData.ExecuteReader();
            reader.Read();
            TotProfit.Text = reader[0].ToString();
        }

        private void Profit_TextChanged(object sender, EventArgs e)
        {
            Profit.ReadOnly = true;
        }
    }
}

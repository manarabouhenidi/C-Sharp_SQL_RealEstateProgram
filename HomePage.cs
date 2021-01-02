using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateDB
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProps Prop_page = new ViewProps();
           Prop_page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFinance Finance_page = new ViewFinance();
            Finance_page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           ViewBuyerSeller BuyerSeller_page = new ViewBuyerSeller();
            BuyerSeller_page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactions Trans_page = new ViewTransactions();
            Trans_page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAgents Agents_page = new ViewAgents();
            Agents_page.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

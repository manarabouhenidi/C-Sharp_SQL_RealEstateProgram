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
    public partial class SelectedTransaction : Form
    {
        public SelectedTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home_page = new HomePage();
            home_page.Show();
        }

        private void SelectedTransaction_Load(object sender, EventArgs e)
        {
            
        }

        private void transnum_TextChanged(object sender, EventArgs e)
        {
            transnum.ReadOnly = true;
        }

        private void transdate_TextChanged(object sender, EventArgs e)
        {
            transdate.ReadOnly = true;
        }

        private void selectprice_TextChanged(object sender, EventArgs e)
        {
            selectprice.ReadOnly = true;
        }

        private void sssnselect_TextChanged(object sender, EventArgs e)
        {
            sssnselect.ReadOnly = true;
        }

        private void bssnselect_TextChanged(object sender, EventArgs e)
        {
            bssnselect.ReadOnly = true;
        }

        private void selectpno_TextChanged(object sender, EventArgs e)
        {
            selectpno.ReadOnly = true;
        }

        private void selectptype_TextChanged(object sender, EventArgs e)
        {
            selectptype.ReadOnly = true;
        }

        private void selectprofit_TextChanged(object sender, EventArgs e)
        {
            selectprofit.ReadOnly = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTransaction addtran = new UpdateTransaction();
            addtran.transnum.Text = transnum.Text;
            addtran.dateTimePicker1.Text = transdate.Text;
            addtran.sellingprice.Text = selectprice.Text;
            addtran.sellerssn.Text = sssnselect.Text;
            addtran.buyerssn.Text = bssnselect.Text;
            addtran.propertynum.Text = selectpno.Text;
            addtran.agentid.Text = agentid.Text;

            //addtran.propertytype.Text = selectptype.Text;
            //addtran.profitbox.Text = selectprofit.Text;


            addtran.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTransaction Add_page = new UpdateTransaction();
            Add_page.Show();
        }

        private void Deletetrans_Click(object sender, EventArgs e)
        {


            delete_trans(transnum.Text);
            }

            public void delete_trans(string tnum)
            {
                var delete = MessageBox.Show("Delete Selected Transaction ?", "Confirm Delete Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (delete == DialogResult.Yes)
            {
                SqlCommand delete_trans = SqlConnectionCommand.getCommand();
                delete_trans.CommandText = "USE SRDB DELETE FROM TRANSACTIONS WHERE tnum = @strtno";
                delete_trans.Parameters.AddWithValue("@strtno", tnum);
                delete_trans.ExecuteNonQuery();

                try
                {
                    MessageBox.Show("Successfully Deleted" + " " + tnum,
                        "Deleted transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewTransactions Trans_page = new ViewTransactions();
                    Trans_page.Show();

                }

                catch (Exception ex)
                {

                }
            }
        }

        private void agentid_TextChanged(object sender, EventArgs e)
        {
            agentid.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactions viewtranspage = new ViewTransactions();
            viewtranspage.Show();
        }
    }
    }


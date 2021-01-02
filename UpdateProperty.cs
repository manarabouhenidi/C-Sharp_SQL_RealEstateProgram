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
    public partial class UpdateProperty : Form
    {
        public UpdateProperty()
        {
            InitializeComponent();
        }

        private void ZipCode_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Update_Property(comboPno.Text, pnobox.Text, Address.Text, citybox.Text, statebox.Text, zipbox.Text, countybox.Text, combostatus.Text,
       float.Parse(areabox.Text), float.Parse(pricebox.Text), float.Parse(taxbox.Text), yearbuiltbox.Text, onerssnbox.Text);
            
        }

        public void Update_Property(string type, string Pno, string Address, string city, string state, string zip, string county, string status,
       float Area, float price, float tax, string Date, string ownerssn)
        {
            {
                SqlCommand Update_Property = SqlConnectionCommand.getCommand();
                Update_Property.CommandText = "USE srdb UPDATE PROPERTY SET " +
                    "Type = @strtype, Date = @strDate, price = @floatprice, status = @strstatus, Tax = @floatTax, Address = @strAddress, city = @strcity, state = @strstate, zip = @strzip," +
                    " county = @strcounty, Area = @floatArea, ownerssn = @strOwnerssn WHERE PNO = @strPno";

                //addproperty.Parameters.AddWithValue("@strproperty", comboboxtype.SelectedText);
                Update_Property.Parameters.AddWithValue("@strPno", Pno);
                Update_Property.Parameters.AddWithValue("@strtype", type);
                Update_Property.Parameters.AddWithValue("@strstatus", status);
                Update_Property.Parameters.AddWithValue("@strAddress", Address);
                Update_Property.Parameters.AddWithValue("@strCity", city);
                Update_Property.Parameters.AddWithValue("@strstate", state);
                Update_Property.Parameters.AddWithValue("@strzip", zip);
                Update_Property.Parameters.AddWithValue("@strcounty", county);
                Update_Property.Parameters.AddWithValue("@floatarea", Area);
                Update_Property.Parameters.AddWithValue("@floatprice", price);
                Update_Property.Parameters.AddWithValue("@floatTax", tax);
                Update_Property.Parameters.AddWithValue("@strDate", Date);
                Update_Property.Parameters.AddWithValue("@strOwnerssn", ownerssn);

             //   MessageBox.Show(Update_Property.CommandText.ToString());   
                try
                {
                    Update_Property.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated" + " " + Pno + " " + type,
                    "Updated property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ViewProps view_props = new ViewProps();
                    view_props.Show();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(" Please Enter a Different PNO Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Faild to Update a property: " + ex.Message, "Update Property Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//end

            }

         }

        private void comboPno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProps view_props = new ViewProps();
            view_props.Show();

        }
    }
}

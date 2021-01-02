using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RealEstateDB 
{
    class SqlConnectionCommand
    {
        public static SqlConnection sqlconnSystemConnection;
        //This Method returns the command container to carry SQL statement to be executed 
        public static SqlCommand getCommand()
        {
            sqlconnSystemConnection = openSQLConnection();
            SqlCommand cmdContainer = sqlconnSystemConnection.CreateCommand();
            return cmdContainer;
        }
        //This Method returns an SQL connection with the database 

        public static SqlConnection openSQLConnection()
        {
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = "Server=srdb.cpm0af6q6ase.us-east-2.rds.amazonaws.com,1433;Persist Security Info = true;User ID = SimplisticRealstate;Password= Srdatabase123";

            try
            {
                sqlConnection1.Open();
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

            return sqlConnection1;
        }


    }
}

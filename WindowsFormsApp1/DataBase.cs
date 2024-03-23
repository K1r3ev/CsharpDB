using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataBase
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-2N6UCTK; Initial Catalog = Remont;Integrated Security = True");


        public void openConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {

                sqlConnection.Open();

            }

        }
        public void closeConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {

                sqlConnection.Close();

            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}

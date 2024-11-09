using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
    public class DBController
    {
        public static void FillDGV(DataGridView dgv, SqlCommand sqlCommand)
        {
            Program.connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dgv.DataSource = null;
            dgv.DataSource = dataTable;

            Program.connection.Close();
        }
    }
}

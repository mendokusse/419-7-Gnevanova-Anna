using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            string query = "select * from Bookings where StatusID = 2";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));

            query = "select * from Bookings where StatusID = 1";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView_Cabins.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Cabins.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["BookingID"].Value.ToString());
            }

            string query = $"update Bookings set StatusID = 1 where BookingID = {id}";

            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView_Cabins.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Cabins.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["BookingID"].Value.ToString());
            }

            string query = $"update Bookings set StatusID = 3 where BookingID = {id}";

            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();

            query = "select * from Bookings where StatusID = 2";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));

            query = "select * from Bookings where StatusID = 1";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["BookingID"].Value.ToString());
            }

            string query = $"update Bookings set StatusID = 4 where BookingID = {id}";

            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();

            query = "select * from Bookings where StatusID = 2";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));

            query = "select * from Bookings where StatusID = 1";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));
        }


    }


}

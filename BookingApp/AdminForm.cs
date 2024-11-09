using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookingApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            string query = "select * from Users where Role = N'Работник'";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));

            query = "select * from Cabins";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));

            query = "select * from Services";
            DBController.FillDGV(dataGridView2, new SqlCommand(query, Program.connection));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView_Cabins.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Cabins.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["UserID"].Value.ToString());
            }

            string query = $"delete from Users where UserID = {id}";


            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();

            query = "select * from Users where Role = N'Работник'";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["CabinID"].Value.ToString());
            }

            string query = $"delete from Cabins where CabinID = {id}";


            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();

            query = "select * from Cabins";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["ServiceID"].Value.ToString());
            }

            string query = $"delete from Services where ServiceID = {id}";


            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();

            query = "select * from Services";
            DBController.FillDGV(dataGridView2, new SqlCommand(query, Program.connection));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.ShowDialog();

            string query = "select * from Users where Role = N'Работник'";
            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query, Program.connection));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCabin add = new AddCabin();
            add.ShowDialog();

            string query = "select * from Cabins";
            DBController.FillDGV(dataGridView1, new SqlCommand(query, Program.connection));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();

            string query = "select * from Services";
            DBController.FillDGV(dataGridView2, new SqlCommand(query, Program.connection));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

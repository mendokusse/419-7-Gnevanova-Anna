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
    public partial class AddCabin : Form
    {
        public AddCabin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int capacity = 0, pricePerNight = 0;
            string desc = "";

            try
            {
                pricePerNight = int.Parse(textBox_Price.Text);
                desc = richTextBox_Desc.Text;
                capacity = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения: " + ex.Message);
                return;
            }

            string queryinsert = "insert into Cabins (Capacity, PricePerNight, Description) " +
                $"values ({capacity}, {pricePerNight}, N'{desc}')";

            SqlCommand command = new SqlCommand(queryinsert, Program.connection);

            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();
            MessageBox.Show("Домик добавлен");
        }
    }
}

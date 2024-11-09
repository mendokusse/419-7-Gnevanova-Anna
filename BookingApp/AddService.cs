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
    public partial class AddService : Form
    {

        //name description price

        public AddService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            string desc = "", name = "";

            try
            {
                price = int.Parse(textBox_Price.Text);
                desc = richTextBox_Desc.Text;
                name = textBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения: " + ex.Message);
                return;
            }

            string queryinsert = "insert into Services (ServiceName, ServiceDescription, Price) " +
               $"values (N'{name}', N'{desc}', {price})";

            SqlCommand command = new SqlCommand(queryinsert, Program.connection);

            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();
            MessageBox.Show("Услуга добавлена");
        }
    }
}

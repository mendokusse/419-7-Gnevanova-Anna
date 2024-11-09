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
    public partial class AddWorker : Form
    {
        private int WorkerID = -1;

        public AddWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            string phone = textBox_Phone.Text;
            string email = textBox_Email.Text;


            string query = $"insert into Users (Name, Username, PasswordHash, PhoneNumber, Email, DateCreated, Role) " +
                $"values (N'{name}', N'{username}', N'{password}', N'{phone}', N'{email}', '{DateTime.Now:yyyy-MM-dd}', N'Работник')";

            SqlCommand command = new SqlCommand(query, Program.connection);

            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();
            MessageBox.Show("Пользователь добавлен");
        }



        private void AddWorker_Load(object sender, EventArgs e)
        {
             
        }
    }
}

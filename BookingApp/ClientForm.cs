using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookingApp
{
    public partial class ClientForm : Form
    {
        int ClientID;

        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(int id)
        {
            InitializeComponent();
            ClientID = id;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            string query = @"select BookingID as ID,
                            CabinID as [Домик],
                            CheckInDate as [Дата въезда],
                            CheckOutDate as [Дата выезда],
                            Status.StatusName as [Статус],
                            TotalAmount as [Стоимость]
                            from Bookings
                            inner join Status on Status.StatusID = Bookings.StatusID
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@UserID", ClientID);

            DBController.FillDGV(dataGridView1, command);

            string query1 = "select * from Cabins";

            DBController.FillDGV(dataGridView_Cabins, new SqlCommand(query1, Program.connection));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            }

            string query = $"update Bookings set StatusID = 3 where BookingID = {id}";

            SqlCommand command = new SqlCommand(query, Program.connection);
            Program.connection.Open();
            command.ExecuteNonQuery();
            Program.connection.Close();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            int userId = ClientID;
            int cabinId = -1;

            DateTime checkInDate = dateTimePicker1.Value;
            DateTime checkOutDate = dateTimePicker2.Value;
            Decimal totalAmount;
            
            if (dataGridView_Cabins.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_Cabins.SelectedRows[0];
                cabinId = int.Parse(selectedRow.Cells["CabinID"].Value.ToString());
                decimal pricePerNight = Convert.ToDecimal(selectedRow.Cells["PricePerNight"].Value.ToString());

                TimeSpan bookingDuration = checkOutDate - checkInDate;
                int numberOfNights = bookingDuration.Days;

                if (numberOfNights <= 0)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                    return;
                }

                totalAmount = pricePerNight * numberOfNights;

                string queryinsert = @$"INSERT INTO Bookings(UserID, CabinID, CheckInDate, CheckOutDate, StatusID, TotalAmount)
                VALUES ({userId}, {cabinId}, '{checkInDate:yyyy-MM-dd}', '{checkOutDate:yyyy-MM-dd}', 2, {(int)totalAmount})";

                Program.connection.Open();
                SqlCommand commandinsert = new SqlCommand(queryinsert, Program.connection);
                commandinsert.ExecuteNonQuery();
                Program.connection.Close();

                MessageBox.Show("Забронировано!");
            }

            string query = @"select BookingID as ID,
                            CabinID as [Домик],
                            CheckInDate as [Дата въезда],
                            CheckOutDate as [Дата выезда],
                            Status.StatusName as [Статус],
                            TotalAmount as [Стоимость]
                            from Bookings
                            inner join Status on Status.StatusID = Bookings.StatusID
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@UserID", ClientID);

            DBController.FillDGV(dataGridView1, command);
        }
    }


}

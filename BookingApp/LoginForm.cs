using Microsoft.Data.SqlClient;

namespace BookingApp
{
    public partial class LogScreen : Form
    {
        public LogScreen()
        {
            InitializeComponent();
        }

        public void Button_Login_Click(object sender, EventArgs e)
        {
            Program.connection.Open();

            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            string query = @"select UserID, Role
                            from Users 
                            where Username = @Username 
                            and PasswordHash = @password";

            SqlCommand command = new SqlCommand(query, Program.connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue ("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            string role = "";
            int id = 0;

            while (reader.Read())
            {
                id = int.Parse(reader["UserID"].ToString());
                role = reader["Role"].ToString();
            }
            Program.connection.Close();

            if (role.Equals("Клиент"))
            {
                ClientForm clientForm = new ClientForm(id);
                clientForm.FormClosing += delegate { this.Show(); };
                clientForm.Show();
                this.Hide();
            }
            else if (role.Equals("Работник"))
            {
                WorkerForm workerForm = new WorkerForm();
                workerForm.FormClosing += delegate { this.Show(); };
                workerForm.Show();
                this.Hide();
            }
            else if (role.Equals("Администратор"))
            {
                AdminForm adminForm = new AdminForm();
                adminForm.FormClosing += delegate { this.Show(); };
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            };

           
        }
    }
}

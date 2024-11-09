namespace BookingApp
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPage_MakeBooking = new TabPage();
            Button_Login = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView_Cabins = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPage_MyBookings = new TabPage();
            button1 = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabPage_MakeBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).BeginInit();
            tabPage_MyBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_MakeBooking);
            tabControl.Controls.Add(tabPage_MyBookings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1119, 439);
            tabControl.TabIndex = 0;
            // 
            // tabPage_MakeBooking
            // 
            tabPage_MakeBooking.BackColor = Color.FromArgb(242, 232, 207);
            tabPage_MakeBooking.Controls.Add(Button_Login);
            tabPage_MakeBooking.Controls.Add(label5);
            tabPage_MakeBooking.Controls.Add(label3);
            tabPage_MakeBooking.Controls.Add(label2);
            tabPage_MakeBooking.Controls.Add(dataGridView_Cabins);
            tabPage_MakeBooking.Controls.Add(dateTimePicker2);
            tabPage_MakeBooking.Controls.Add(dateTimePicker1);
            tabPage_MakeBooking.Location = new Point(4, 29);
            tabPage_MakeBooking.Margin = new Padding(4);
            tabPage_MakeBooking.Name = "tabPage_MakeBooking";
            tabPage_MakeBooking.Padding = new Padding(4);
            tabPage_MakeBooking.Size = new Size(1111, 406);
            tabPage_MakeBooking.TabIndex = 0;
            tabPage_MakeBooking.Text = "Забронировать";
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(188, 71, 73);
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Login.ForeColor = Color.FromArgb(242, 232, 207);
            Button_Login.Location = new Point(41, 304);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(255, 47);
            Button_Login.TabIndex = 8;
            Button_Login.Text = "Забронировать";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += Button_Login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(56, 102, 65);
            label5.Location = new Point(376, 20);
            label5.Name = "label5";
            label5.Size = new Size(252, 20);
            label5.TabIndex = 7;
            label5.Text = "Выберите доступный домик:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(56, 102, 65);
            label3.Location = new Point(40, 111);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Дата выезда:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 102, 65);
            label2.Location = new Point(40, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Дата въезда:";
            // 
            // dataGridView_Cabins
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 232, 207);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(167, 201, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_Cabins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Cabins.BackgroundColor = Color.FromArgb(56, 102, 65);
            dataGridView_Cabins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cabins.GridColor = Color.FromArgb(56, 102, 65);
            dataGridView_Cabins.Location = new Point(376, 45);
            dataGridView_Cabins.Margin = new Padding(4);
            dataGridView_Cabins.Name = "dataGridView_Cabins";
            dataGridView_Cabins.Size = new Size(708, 306);
            dataGridView_Cabins.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(40, 136);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(256, 26);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 45);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPage_MyBookings
            // 
            tabPage_MyBookings.BackColor = Color.FromArgb(242, 232, 207);
            tabPage_MyBookings.Controls.Add(button1);
            tabPage_MyBookings.Controls.Add(label6);
            tabPage_MyBookings.Controls.Add(dataGridView1);
            tabPage_MyBookings.Location = new Point(4, 24);
            tabPage_MyBookings.Margin = new Padding(4);
            tabPage_MyBookings.Name = "tabPage_MyBookings";
            tabPage_MyBookings.Padding = new Padding(4);
            tabPage_MyBookings.Size = new Size(1111, 411);
            tabPage_MyBookings.TabIndex = 1;
            tabPage_MyBookings.Text = "Мои бронирования";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(188, 71, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(242, 232, 207);
            button1.Location = new Point(29, 318);
            button1.Name = "button1";
            button1.Size = new Size(246, 50);
            button1.TabIndex = 9;
            button1.Text = "Отменить бронь";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(56, 102, 65);
            label6.Location = new Point(29, 13);
            label6.Name = "label6";
            label6.Size = new Size(185, 20);
            label6.TabIndex = 8;
            label6.Text = "Ваши бронирования:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 232, 207);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(167, 201, 87);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.BackgroundColor = Color.FromArgb(56, 102, 65);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(56, 102, 65);
            dataGridView1.Location = new Point(29, 38);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1049, 273);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(56, 102, 65);
            label1.Location = new Point(936, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 2;
            label1.Text = "sunset dreams";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 207);
            ClientSize = new Size(1119, 439);
            Controls.Add(label1);
            Controls.Add(tabControl);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "ClientForm";
            Text = "sunset dreams — база отдыха";
            Load += ClientForm_Load;
            tabControl.ResumeLayout(false);
            tabPage_MakeBooking.ResumeLayout(false);
            tabPage_MakeBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).EndInit();
            tabPage_MyBookings.ResumeLayout(false);
            tabPage_MyBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TabControl tabControl;
        public TabPage tabPage_MakeBooking;
        public TabPage tabPage_MyBookings;
        public Label label1;
        public DateTimePicker dateTimePicker2;
        public DateTimePicker dateTimePicker1;
        public DataGridView dataGridView_Cabins;
        public Label label3;
        public Label label2;
        public Label label5;
        public Button Button_Login;
        public Button button1;
        public Label label6;
        public DataGridView dataGridView1;
    }
}
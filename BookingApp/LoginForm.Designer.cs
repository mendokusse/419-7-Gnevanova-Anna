namespace BookingApp
{
    partial class LogScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            Button_Login = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(56, 102, 65);
            label1.Location = new Point(108, 29);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 0;
            label1.Text = "sunset dreams";
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = SystemColors.ControlLightLight;
            textBox_Username.BorderStyle = BorderStyle.None;
            textBox_Username.ForeColor = SystemColors.WindowFrame;
            textBox_Username.Location = new Point(73, 132);
            textBox_Username.Margin = new Padding(10);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(242, 19);
            textBox_Username.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = SystemColors.ControlLightLight;
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.ForeColor = SystemColors.WindowFrame;
            textBox_Password.Location = new Point(73, 184);
            textBox_Password.Margin = new Padding(10);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(242, 19);
            textBox_Password.TabIndex = 2;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.FromArgb(188, 71, 73);
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button_Login.Location = new Point(128, 255);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(128, 36);
            Button_Login.TabIndex = 5;
            Button_Login.Text = "Войти";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += Button_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(106, 153, 78);
            label2.Location = new Point(147, 61);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 6;
            label2.Text = "база отдыха";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(106, 153, 78);
            label3.Location = new Point(73, 107);
            label3.Name = "label3";
            label3.Size = new Size(141, 18);
            label3.TabIndex = 7;
            label3.Text = "Имя пользователя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(106, 153, 78);
            label4.Location = new Point(73, 161);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 8;
            label4.Text = "Пароль";
            // 
            // LogScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 232, 207);
            ClientSize = new Size(389, 356);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(242, 232, 207);
            Name = "LogScreen";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBox_Username;
        public TextBox textBox_Password;
        private Button Button_Login;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

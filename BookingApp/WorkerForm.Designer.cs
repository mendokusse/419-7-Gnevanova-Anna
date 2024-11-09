namespace BookingApp
{
    partial class WorkerForm
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
            tabPage_Approving = new TabPage();
            button2 = new Button();
            button3 = new Button();
            dataGridView_Cabins = new DataGridView();
            tabPage_MyBookings = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            tabControl.SuspendLayout();
            tabPage_Approving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).BeginInit();
            tabPage_MyBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_Approving);
            tabControl.Controls.Add(tabPage_MyBookings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(5, 6, 5, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1130, 506);
            tabControl.TabIndex = 1;
            // 
            // tabPage_Approving
            // 
            tabPage_Approving.BackColor = Color.FromArgb(242, 232, 207);
            tabPage_Approving.Controls.Add(button2);
            tabPage_Approving.Controls.Add(button3);
            tabPage_Approving.Controls.Add(dataGridView_Cabins);
            tabPage_Approving.Location = new Point(4, 29);
            tabPage_Approving.Margin = new Padding(5, 6, 5, 6);
            tabPage_Approving.Name = "tabPage_Approving";
            tabPage_Approving.Padding = new Padding(5, 6, 5, 6);
            tabPage_Approving.Size = new Size(1122, 473);
            tabPage_Approving.TabIndex = 0;
            tabPage_Approving.Text = "Подтверждение";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(188, 71, 73);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.FromArgb(242, 232, 207);
            button2.Location = new Point(776, 382);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(316, 54);
            button2.TabIndex = 12;
            button2.Text = "Отменить бронь";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(188, 71, 73);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.FromArgb(242, 232, 207);
            button3.Location = new Point(25, 382);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(316, 54);
            button3.TabIndex = 11;
            button3.Text = "Подтвердить бронь";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            dataGridView_Cabins.Location = new Point(25, 32);
            dataGridView_Cabins.Margin = new Padding(5, 6, 5, 6);
            dataGridView_Cabins.Name = "dataGridView_Cabins";
            dataGridView_Cabins.Size = new Size(1067, 340);
            dataGridView_Cabins.TabIndex = 3;
            // 
            // tabPage_MyBookings
            // 
            tabPage_MyBookings.BackColor = Color.FromArgb(242, 232, 207);
            tabPage_MyBookings.Controls.Add(dataGridView1);
            tabPage_MyBookings.Controls.Add(button1);
            tabPage_MyBookings.Location = new Point(4, 24);
            tabPage_MyBookings.Margin = new Padding(5, 6, 5, 6);
            tabPage_MyBookings.Name = "tabPage_MyBookings";
            tabPage_MyBookings.Padding = new Padding(5, 6, 5, 6);
            tabPage_MyBookings.Size = new Size(1122, 478);
            tabPage_MyBookings.TabIndex = 1;
            tabPage_MyBookings.Text = "Подтверждённые бронирования";
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
            dataGridView1.Location = new Point(26, 29);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1067, 343);
            dataGridView1.TabIndex = 10;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(188, 71, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(242, 232, 207);
            button1.Location = new Point(26, 382);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(266, 55);
            button1.TabIndex = 9;
            button1.Text = "Зарегистрировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(56, 102, 65);
            label1.Location = new Point(947, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 3;
            label1.Text = "sunset dreams";
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 207);
            ClientSize = new Size(1130, 506);
            Controls.Add(label1);
            Controls.Add(tabControl);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "WorkerForm";
            Text = "sunset dreams — бронирования";
            Load += WorkerForm_Load;
            tabControl.ResumeLayout(false);
            tabPage_Approving.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).EndInit();
            tabPage_MyBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_Approving;
        private DataGridView dataGridView_Cabins;
        private TabPage tabPage_MyBookings;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
    }
}
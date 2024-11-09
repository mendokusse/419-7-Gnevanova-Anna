namespace BookingApp
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            dataGridView_Cabins = new DataGridView();
            button1 = new Button();
            tabPage2 = new TabPage();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            tabPage3 = new TabPage();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            button6 = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1115, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(242, 232, 207);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dataGridView_Cabins);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1107, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Работники";
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(188, 71, 73);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.FromArgb(242, 232, 207);
            button2.Location = new Point(236, 349);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(189, 41);
            button2.TabIndex = 12;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            dataGridView_Cabins.Location = new Point(39, 27);
            dataGridView_Cabins.Margin = new Padding(4);
            dataGridView_Cabins.Name = "dataGridView_Cabins";
            dataGridView_Cabins.Size = new Size(1028, 314);
            dataGridView_Cabins.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(188, 71, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(242, 232, 207);
            button1.Location = new Point(39, 349);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(189, 41);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(242, 232, 207);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1107, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Домики";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(188, 71, 73);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.FromArgb(242, 232, 207);
            button3.Location = new Point(236, 349);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(189, 41);
            button3.TabIndex = 15;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            dataGridView1.Location = new Point(39, 27);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1028, 314);
            dataGridView1.TabIndex = 14;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(188, 71, 73);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.FromArgb(242, 232, 207);
            button4.Location = new Point(39, 349);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(189, 41);
            button4.TabIndex = 13;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(242, 232, 207);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1107, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Услуги";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(188, 71, 73);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.FromArgb(242, 232, 207);
            button5.Location = new Point(236, 349);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(189, 41);
            button5.TabIndex = 15;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 232, 207);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(167, 201, 87);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.BackgroundColor = Color.FromArgb(56, 102, 65);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.FromArgb(56, 102, 65);
            dataGridView2.Location = new Point(39, 27);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1028, 314);
            dataGridView2.TabIndex = 14;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(188, 71, 73);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.FromArgb(242, 232, 207);
            button6.Location = new Point(39, 349);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(189, 41);
            button6.TabIndex = 13;
            button6.Text = "Добавить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(56, 102, 65);
            label1.Location = new Point(932, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 3;
            label1.Text = "sunset dreams";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 207);
            ClientSize = new Size(1115, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "sunset dreams — администратор";
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cabins).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private DataGridView dataGridView_Cabins;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView2;
        private Button button6;
        private Label label1;
        private Button button1;
    }
}
namespace BookingApp
{
    partial class AddService
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
            label5 = new Label();
            textBox_Price = new TextBox();
            richTextBox_Desc = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(106, 153, 78);
            label5.Location = new Point(67, 52);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 22;
            label5.Text = "Название";
            // 
            // textBox_Price
            // 
            textBox_Price.BackColor = SystemColors.ControlLightLight;
            textBox_Price.BorderStyle = BorderStyle.None;
            textBox_Price.ForeColor = SystemColors.WindowFrame;
            textBox_Price.Location = new Point(66, 288);
            textBox_Price.Margin = new Padding(10);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(242, 16);
            textBox_Price.TabIndex = 21;
            // 
            // richTextBox_Desc
            // 
            richTextBox_Desc.BorderStyle = BorderStyle.None;
            richTextBox_Desc.Location = new Point(66, 144);
            richTextBox_Desc.Name = "richTextBox_Desc";
            richTextBox_Desc.Size = new Size(242, 96);
            richTextBox_Desc.TabIndex = 25;
            richTextBox_Desc.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(106, 153, 78);
            label1.Location = new Point(67, 123);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 24;
            label1.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(106, 153, 78);
            label2.Location = new Point(66, 260);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 27;
            label2.Text = "Цена";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(67, 80);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 16);
            textBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(188, 71, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(242, 232, 207);
            button1.Location = new Point(89, 339);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(189, 41);
            button1.TabIndex = 28;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 207);
            ClientSize = new Size(375, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox_Desc);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textBox_Price);
            Name = "AddService";
            Text = "AddService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox_Price;
        private RichTextBox richTextBox_Desc;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}
namespace BT_NHom
{
    partial class trinh_do
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(677, 24);
            label1.Name = "label1";
            label1.Size = new Size(427, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản lý trình độ học vị";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(745, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 732);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách các học vị hiện có";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 546);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(243, 114);
            button1.Name = "button1";
            button1.Size = new Size(392, 42);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 59);
            label2.Name = "label2";
            label2.Size = new Size(209, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên hoặc Mã học vị";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 38);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 732);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(392, 39);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(182, 600);
            button7.Name = "button7";
            button7.Size = new Size(103, 42);
            button7.TabIndex = 9;
            button7.Text = "Làm mới";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(332, 600);
            button6.Name = "button6";
            button6.Size = new Size(103, 42);
            button6.TabIndex = 8;
            button6.Text = "In";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(482, 535);
            button5.Name = "button5";
            button5.Size = new Size(103, 42);
            button5.TabIndex = 7;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(332, 535);
            button4.Name = "button4";
            button4.Size = new Size(103, 42);
            button4.TabIndex = 6;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(182, 535);
            button3.Name = "button3";
            button3.Size = new Size(103, 42);
            button3.TabIndex = 5;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(32, 535);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 4;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 415);
            label9.Name = "label9";
            label9.Size = new Size(176, 31);
            label9.TabIndex = 3;
            label9.Text = "Năm tốt nghiệp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 353);
            label8.Name = "label8";
            label8.Size = new Size(171, 31);
            label8.TabIndex = 3;
            label8.Text = "Trường đào tạo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 291);
            label7.Name = "label7";
            label7.Size = new Size(190, 31);
            label7.TabIndex = 3;
            label7.Text = "Quốc gia đào tạo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 228);
            label6.Name = "label6";
            label6.Size = new Size(167, 31);
            label6.TabIndex = 3;
            label6.Text = "Ngành đào tạo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 170);
            label5.Name = "label5";
            label5.Size = new Size(136, 31);
            label5.TabIndex = 3;
            label5.Text = "Tên trình độ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 117);
            label4.Name = "label4";
            label4.Size = new Size(154, 31);
            label4.TabIndex = 3;
            label4.Text = "Tên nhân viên";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(243, 412);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(392, 38);
            textBox8.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(243, 350);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(392, 38);
            textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(243, 288);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(392, 38);
            textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(243, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(392, 38);
            textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(392, 38);
            textBox3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 59);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 1;
            label3.Text = "Mã nhân viên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 38);
            textBox2.TabIndex = 0;
            // 
            // trinh_do
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1697, 883);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "trinh_do";
            StartPosition = FormStartPosition.CenterScreen;
            Load += trinh_do_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}
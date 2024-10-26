namespace BT_NHom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            label4 = new Label();
            button1 = new Button();
            pass = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 53);
            label1.Name = "label1";
            label1.Size = new Size(431, 38);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 110);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            label2.UseWaitCursor = true;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(38, 156);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(490, 66);
            username.TabIndex = 1;
            username.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 461);
            label4.Name = "label4";
            label4.Size = new Size(361, 28);
            label4.TabIndex = 7;
            label4.Text = "Hãy đăng ký nếu bạn chưa có tài khoản!";
            label4.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.SpringGreen;
            button1.Location = new Point(390, 445);
            button1.Name = "button1";
            button1.Size = new Size(149, 53);
            button1.TabIndex = 4;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            // 
            // pass
            // 
            pass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(38, 294);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(490, 66);
            pass.TabIndex = 2;
            pass.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 248);
            label3.Name = "label3";
            label3.Size = new Size(193, 28);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu đăng nhập";
            label3.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(211, 382);
            button2.Name = "button2";
            button2.Size = new Size(149, 53);
            button2.TabIndex = 3;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(528, 2);
            button3.Name = "button3";
            button3.Size = new Size(42, 45);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(572, 548);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pass);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private Button login;
        private Label label4;
        private Button button1;
        private TextBox pass;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}

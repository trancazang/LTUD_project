namespace BT_NHom
{
    partial class TranhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranhChinh));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            radioButton_home = new RadioButton();
            radioButton_NV = new RadioButton();
            radioButton_trinhDo = new RadioButton();
            radioButton_luong = new RadioButton();
            panel_nav = new Panel();
            button1 = new Button();
            panel_body = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel_nav.SuspendLayout();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // radioButton_home
            // 
            radioButton_home.AutoSize = true;
            radioButton_home.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_home.Image = (Image)resources.GetObject("radioButton_home.Image");
            radioButton_home.Location = new Point(12, 12);
            radioButton_home.Name = "radioButton_home";
            radioButton_home.Size = new Size(213, 44);
            radioButton_home.TabIndex = 17;
            radioButton_home.TabStop = true;
            radioButton_home.Text = "Trang chủ";
            radioButton_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton_home.UseVisualStyleBackColor = true;
            radioButton_home.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton_NV
            // 
            radioButton_NV.AutoSize = true;
            radioButton_NV.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_NV.Image = (Image)resources.GetObject("radioButton_NV.Image");
            radioButton_NV.Location = new Point(250, 12);
            radioButton_NV.Name = "radioButton_NV";
            radioButton_NV.Size = new Size(214, 44);
            radioButton_NV.TabIndex = 18;
            radioButton_NV.TabStop = true;
            radioButton_NV.Text = "Nhân viên";
            radioButton_NV.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton_NV.UseVisualStyleBackColor = true;
            radioButton_NV.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton_trinhDo
            // 
            radioButton_trinhDo.AutoSize = true;
            radioButton_trinhDo.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_trinhDo.Image = (Image)resources.GetObject("radioButton_trinhDo.Image");
            radioButton_trinhDo.Location = new Point(483, 12);
            radioButton_trinhDo.Name = "radioButton_trinhDo";
            radioButton_trinhDo.Size = new Size(187, 44);
            radioButton_trinhDo.TabIndex = 19;
            radioButton_trinhDo.TabStop = true;
            radioButton_trinhDo.Text = "Trình độ";
            radioButton_trinhDo.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton_trinhDo.UseVisualStyleBackColor = true;
            radioButton_trinhDo.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton_luong
            // 
            radioButton_luong.AutoSize = true;
            radioButton_luong.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_luong.Image = (Image)resources.GetObject("radioButton_luong.Image");
            radioButton_luong.Location = new Point(706, 12);
            radioButton_luong.Name = "radioButton_luong";
            radioButton_luong.Size = new Size(160, 44);
            radioButton_luong.TabIndex = 20;
            radioButton_luong.TabStop = true;
            radioButton_luong.Text = "Lương";
            radioButton_luong.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton_luong.UseVisualStyleBackColor = true;
            radioButton_luong.CheckedChanged += radioButton_luong_CheckedChanged;
            // 
            // panel_nav
            // 
            panel_nav.BackColor = Color.LightSeaGreen;
            panel_nav.Controls.Add(button1);
            panel_nav.Location = new Point(0, 0);
            panel_nav.Name = "panel_nav";
            panel_nav.Size = new Size(1697, 70);
            panel_nav.TabIndex = 21;
            panel_nav.Paint += panel_nav_Paint;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1634, 3);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel_body
            // 
            panel_body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_body.Controls.Add(pictureBox1);
            panel_body.Controls.Add(label1);
            panel_body.Dock = DockStyle.Bottom;
            panel_body.Location = new Point(0, 76);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1697, 883);
            panel_body.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(101, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1495, 538);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(389, 56);
            label1.Name = "label1";
            label1.Size = new Size(918, 60);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN CỦA TRƯỜNG ĐẠI HỌC";
            // 
            // TranhChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1697, 959);
            Controls.Add(panel_body);
            Controls.Add(radioButton_luong);
            Controls.Add(radioButton_trinhDo);
            Controls.Add(radioButton_NV);
            Controls.Add(radioButton_home);
            Controls.Add(panel_nav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TranhChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TranhChinh";
            Load += TranhChinh_Load;
            panel_nav.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton_home;
        private RadioButton radioButton_NV;
        private RadioButton radioButton_trinhDo;
        private RadioButton radioButton_luong;
        private Panel panel_nav;
        private Panel panel_body;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
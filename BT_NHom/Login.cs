namespace BT_NHom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Căn giữa button login theo chiều ngang và dọc


        }

        private void login_Click(object sender, EventArgs e)
        {
            TranhChinh chinh = new TranhChinh();
            chinh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && pass.Text == "123")
            {
                TranhChinh home = new TranhChinh();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

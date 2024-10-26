using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_NHom
{
    public partial class TranhChinh : Form
    {

        teacher add_ = new teacher();
        trinh_do fix_ = new trinh_do();
        public TranhChinh()
        {
            InitializeComponent();
        }

        private Form currentformChild;
        private void OpenChildForm(Form childform)
        {
            if (currentformChild != null)
            {
                currentformChild.Close();
            }
            currentformChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TranhChinh ch = new TranhChinh();
            ch.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void TranhChinh_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (currentformChild != null)
            {
                currentformChild.Close();
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new teacher());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new trinh_do());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void radioButton_luong_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Luong());
        }

        private void panel_nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình",
                                                  "Thoát chương trình", 
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question, 
                                                  MessageBoxDefaultButton.Button2);
            if (ketqua == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}

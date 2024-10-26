using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT_NHom
{
    public partial class trinh_do : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham func = new Ham();
        public trinh_do()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trinh_do_Load(object sender, EventArgs e)
        {
            func.KetNoi(conn);
            //func.HienThiDG(dataGridView1, "select * from co_trinhdo", conn);
            string tentd = "select * from trinhdo";
            func.HienThiCombobox(tentd, conn, comboBox1, "tentd", "matd");
            string sql = "select n.manv as 'Mã Nhân Viên', n.tennv  as N'Tên Nhân Viên', t.tentd as N'Trình Độ', c.nganh as N'Ngành đào tạo',c.quocgia as N'Quốc gia', c.truong as N'Trường đào tạo', c.nam as N'Năm TN' \r\nfrom cotrinhdo c join nhanvien n on c.manv = n.manv\r\n\t\t\t\tjoin trinhdo t  on c.matd = t.matd";
            func.HienThiDG(dataGridView1, sql, conn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string m = textBox2.Text;
            string t = textBox3.Text;
            string td = comboBox1.SelectedValue.ToString();
            string n = textBox5.Text;
            string qg = textBox6.Text;
            string th = textBox7.Text;
            string ntn = textBox8.Text;

            string sql = "insert into coTrinhdo values ('" + td + "','" + m + "',N'" + n + "',N'" + qg + "','N" + th + "','" + ntn + "');";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            func.HienThiDG(dataGridView1, "select * from cotrinhdo", conn);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string m = textBox2.Text;
            string t = textBox3.Text;
            string td = comboBox1.SelectedValue.ToString();
            string n = textBox5.Text;
            string qg = textBox6.Text;
            string th = textBox7.Text;
            string ntn = textBox8.Text;

            string sql = "update coTrinhdo set matd = '" + td + "',nganh = N'" + n + "',quocgia = N'" + qg + "',truong = N'" + th + "',nam = '" + ntn + "' where manv = '" + m + "' and matd = '" + td + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            func.HienThiDG(dataGridView1, "select * from cotrinhdo", conn);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string m = textBox2.Text;
            string td = comboBox1.SelectedValue.ToString();
            string sql = "delete from cotrinhdo where manv = '"+m+"' and matd = '"+td+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            func.HienThiDG(dataGridView1, "select * from cotrinhdo", conn);
        }
    }
}

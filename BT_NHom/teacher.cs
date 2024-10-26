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
    public partial class teacher : Form
    {
        SqlConnection conn = new SqlConnection();
        Ham func = new Ham();

        public teacher()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            func.KetNoi(conn);
            func.HienThiDG(dataGridView1, "select * from nhanvien", conn);
          

        }
    }
}

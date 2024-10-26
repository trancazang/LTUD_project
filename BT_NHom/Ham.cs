using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BT_NHom
{
    internal class Ham
    {
        string path = AppDomain.CurrentDomain.BaseDirectory;
        public void KetNoi(SqlConnection conn)
        {
            string chuoiketnoi = "Server = DESKTOP-0RP3KFB\\SQLEXPRESS; Database = BT_Nhom_QLNhanVien; Integrated Security = True";
            conn.ConnectionString = chuoiketnoi;
            conn.Open();
        }

        public void HienThiDG(DataGridView dg, string sql, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet table = new DataSet();
            adapter.Fill(table, "abc");
            dg.DataSource = table;
            dg.DataMember = "abc";
        }
        public void HienThiCombobox(string truyvan, SqlConnection conn, ComboBox cb, string hienthi, string giatri)
        {
            SqlCommand comd = new SqlCommand(truyvan, conn);
            SqlDataReader reader = comd.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(reader);
            cb.DataSource = dtTable;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        public void LoadImageToPictureBox(string manv, PictureBox pb)
        {
            string folderPath = path + "\\Picture\\";
            string imagePath = Path.Combine(folderPath, manv + ".jpg");
            if (File.Exists(imagePath))
            {
                pb.Image = Image.FromFile(imagePath);
            }
        }
    }
}

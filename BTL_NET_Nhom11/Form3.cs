using BTL_NET_Nhom11.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET_Nhom11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


      
        public string GetTenPhong(int idPhong)
        {
            string tenPhong = "";

            //using (SqlConnection conn = new SqlConnection(Strconn))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT tenphong FROM tbl_phong WHERE idphong = @idPhong", conn);
            //    cmd.Parameters.AddWithValue("@idPhong", idPhong);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        tenPhong = reader.GetString(reader.GetOrdinal("tenphong"));
            //    }
            //}

            var reader = database.Instance.db_select("SELECT tenphong FROM tbl_phong WHERE idphong = @idPhong");
            if (reader.Read())
            {
                tenPhong = reader.GetString(reader.GetOrdinal("tenphong"));
            }

            return tenPhong;
        }


        private void btn_exit_rent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var reader = database.Instance.db_select("SELECT * FROM tbl_phong WHERE TinhTrang LIKE '%Trong%'");
            List<Phong> danhSachPhong = new List<Phong>();
            while (reader.Read())
            {
                Phong phong = new Phong();
                phong.TenPhong = reader["TenPhong"].ToString();
                phong.MaPhong = reader["MaPhong"].ToString();
                danhSachPhong.Add(phong);
            }
            cbophongthue.DataSource = danhSachPhong;
            cbophongthue.DisplayMember = "TenPhong";
            cbophongthue.ValueMember = "MaPhong";
            hienthi();
        }

        class Phong
        {
            public string TenPhong { get; set; }
            public string MaPhong { get; set; }
        }



        private void btn_add_rent_Click(object sender, EventArgs e)
        {


            listView1.Items.Clear();
            Dictionary<string, string> data = new Dictionary<string, string>();
            string tenkhachhang = txttenkhachhang.Text;
            string sodienthoai = txtsodienthoai.Text;
            string phongthue = cbophongthue.SelectedValue.ToString();
            //MessageBox.Show(phongthue);

            string thoigian = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            DateTime thoiGianDateTime = DateTime.ParseExact(thoigian, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            string batdau = thoiGianDateTime.ToString("yyyy-MM-dd HH:mm"); // Chuyển đổi thoiGianDateTime thành chuỗi định dạng thời gian theo định dạng "yyyy-MM-dd HH:mm:ss" cách chuyển về định dạng 24h


            data.Add("TenKhachHang", tenkhachhang);
            data.Add("SoDienThoai", sodienthoai);
            data.Add("Phong", phongthue);
            data.Add("ThoiGian", batdau); // Thêm chuỗi định dạng thời gian vào dictionary data
            database.Instance.db_insert("tbl_dat_phong", data);

            Dictionary<string, string> dulieu = new Dictionary<string, string>();
            dulieu.Add("TinhTrang", "Có khách");
            database.Instance.db_update("tbl_phong", dulieu, "MaPhong = '" + phongthue + "'");
            hienthi();
        }


        public void hienthi()
        {
            var reader =database.Instance.db_select("SELECT ID,TenKhachHang,Phong,SoDienThoai,ThoiGian FROM tbl_dat_phong");
            int i = 0;
            while (reader.Read())
            {
                listView1.Items.Add(reader[0].ToString());
                listView1.Items[i].SubItems.Add(reader[1].ToString());
                listView1.Items[i].SubItems.Add(reader[2].ToString());
              

                listView1.Items[i].SubItems.Add(reader[3].ToString());
                listView1.Items[i].SubItems.Add(reader[4].ToString());

                i++;
            }
            //conn.Close();
        }


        private void btn_xoa_rent_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string id = txtid.Text;

            database.Instance.db_delete("tbl_dat_phong", "ID = '" + id + "'");
            //conn.Close();
            hienthi();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txttenkhachhang.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsodienthoai.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

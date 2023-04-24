using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET_Nhom11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Strconn = @"Data Source=CHAOXA\MSSQLSERVER01;Initial Catalog=SQLQuanlykhachsan_gr11;Integrated Security=True";
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public static int LoggedInUserId { get; set; }

        public void check_login(string tk, string mk, string sql)
        {
            SqlConnection conn = new SqlConnection(Strconn);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable tbl_admin = new DataTable();
            adapter.Fill(tbl_admin);

            bool success = false;
            foreach (DataRow row in tbl_admin.Rows)
            {
                if (row["username"].ToString() == tk && row["password"].ToString() == mk)
                {
                    // Lưu ID của tài khoản đăng nhập vào biến LoggedInUserId của Form1
                    Form1.LoggedInUserId = Convert.ToInt32(row["user_id"]);

                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    success = true;
                    break;
                }
            }

            if (!success)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }

        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txttaikhoan.Text;
            string mk = txtmatkhau.Text;
            check_login(tk, GetMD5(mk) , "SELECT * FROM tbl_admin");
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    
    }
}

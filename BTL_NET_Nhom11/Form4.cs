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
using BTL_NET_Nhom11.Resources;

namespace BTL_NET_Nhom11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            hienthi();
        }


        public void hienthi()
        {
            var reader = database.Instance.db_select("SELECT * FROM tbl_admin");
            int i = 0;
            while (reader.Read())
            {
                listView1.Items.Add(reader[0].ToString());
                listView1.Items[i].SubItems.Add(reader[1].ToString());
                listView1.Items[i].SubItems.Add(reader[2].ToString());
                listView1.Items[i].SubItems.Add(reader[4].ToString());

                i++;
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

        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            string mk = txtmk.Text;
            string xacnhanmk = txtxacnhanmk.Text;
            string fullname = txtfullname.Text;
            string tel = txtsodienthoai.Text;
            if(mk == xacnhanmk)
            {
                listView1.Items.Clear();
                Dictionary<string, string> data = new Dictionary<string, string>();

                data.Add("username", tk);
                data.Add("password", GetMD5(mk));
                data.Add("fullname", fullname);
                data.Add("tel", tel);

                database.Instance.db_insert("tbl_admin", data);

                hienthi();
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtxacnhanmk.Focus();
            }

        }
    }
}

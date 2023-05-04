using BTL_NET_Nhom11.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET_Nhom11
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int soluongphongtrong = database.Instance.db_num_rows("SELECT COUNT(*) FROM tbl_phong WHERE TinhTrang = 'Trong'");
            textBox1.Text = soluongphongtrong.ToString();
            int soluongphongdangthue = database.Instance.db_num_rows("SELECT COUNT(*) FROM tbl_phong WHERE TinhTrang = 'Có Khách'");
            textBox2.Text = soluongphongdangthue.ToString();
            int soluongkhachhang = database.Instance.db_num_rows("SELECT COUNT(*) FROM tbl_dat_phong");
            textBox3.Text = soluongkhachhang.ToString();
            int soluongadmin = database.Instance.db_num_rows("SELECT COUNT(*) FROM tbl_admin");
            textBox4.Text = soluongadmin.ToString();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}

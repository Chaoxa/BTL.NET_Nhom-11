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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi(string search = "")
        {

            listView1.Items.Clear();
            var reader = database.Instance.db_select("SELECT * FROM tbl_dat_phong WHERE TenKhachHang LIKE '%" + search + "%'");
            int i = 0;
            while (reader.Read())
            {
                listView1.Items.Add(reader[1].ToString());
                listView1.Items[i].SubItems.Add(reader[2].ToString());
                listView1.Items[i].SubItems.Add(reader[4].ToString());

                i++;
            }
            //conn.Close();
        }
        private void search_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            hienthi(search);

        }
    }
}

using BTL_NET_Nhom11.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET_Nhom11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        string Strconn = @"Data Source=CHAOXA\MSSQLSERVER01;Initial Catalog=SQLQuanlykhachsan_gr11;Integrated Security=True";

        private void Form5_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi()
        {
            var reader = database.Instance.db_select("SELECT * FROM tbl_dat_phong INNER JOIN tbl_phong ON tbl_dat_phong.Phong = tbl_phong.MaPhong");
            int i = 0;
            while (reader.Read())
            {
                //MessageBox.Show(reader[4].ToString());
                listView1.Items.Add(reader[0].ToString());
                listView1.Items[i].SubItems.Add(reader[6].ToString());
                listView1.Items[i].SubItems.Add(reader[7].ToString());
                listView1.Items[i].SubItems.Add(reader[4].ToString());

                i++;
            }
            //conn.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
            var batdau = listView1.SelectedItems[0].SubItems[3].Text;
            string thoigian = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            DateTime thoiGianDateTime = DateTime.ParseExact(thoigian, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            string ketthuc = thoiGianDateTime.ToString("dd/MM/yyyy HH:mm");

            //MessageBox.Show(ngay.ToString());

            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = ketthuc;
    

           
            DateTime start = DateTime.Parse(batdau, CultureInfo.CreateSpecificCulture("vi-VN"));
            DateTime end = DateTime.Parse(ketthuc, CultureInfo.CreateSpecificCulture("vi-VN"));

            TimeSpan duration = end - start;
            //MessageBox.Show(string.Format("Thời gian thuê phòng là {0} ngày {1} giờ {2} phút {3} giây", duration.Days, duration.Hours, duration.Minutes, duration.Seconds));

            int ngay = duration.Days;
            int gio = duration.Hours;
            int phut = duration.Minutes;
            int tongphut;

             if(gio != 0 && ngay != 0)
            {
                 tongphut = duration.Days * 24 * 60 + phut;
                //MessageBox.Show(tongphut.ToString());
            }else if(gio != 0 && ngay == 0)
            {
                tongphut = gio * 60 + phut;
            }
            else
            {
             tongphut = phut;
            }
            int price = int.Parse(textBox2.Text)/24/60;
            //MessageBox.Show(price.ToString());

            var total = tongphut * price;
          textBox6.Text=string.Format("Thời gian thuê phòng là {0} ngày {1} giờ {2} phút", ngay, gio, phut);


            textBox5.Text = total.ToString();
        }
    }
}

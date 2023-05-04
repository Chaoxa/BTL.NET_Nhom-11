using BTL_NET_Nhom11.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET_Nhom11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private Label label2;
        private Button button11;
        private Button button8;
        private Button button1;
        private Button btn_list_admin;
        private Button btn_list_guest;
        private Button button5;
        private GroupBox groupBox3;
        private Button btn_rent;
        private BackgroundWorker backgroundWorker1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ListView listView1;
        private GroupBox groupBox2;
        private Button button4;
        private Button btn_delete;
        private Button btn_update;
        private TextBox txtmaphong;
        private Button btn_add;
        private ComboBox cbotinhtrang;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txttenphong;
        private TextBox txtdongia;
        private GroupBox groupBox1;

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_list_admin = new System.Windows.Forms.Button();
            this.btn_list_guest = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_rent = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbotinhtrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fulllname = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(412, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "ỨNG DỤNG QUẢN LÝ KHÁCH SẠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 411);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 33);
            this.button11.TabIndex = 5;
            this.button11.Text = "TRA CỨU THEO NHÓM";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PaleGreen;
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Location = new System.Drawing.Point(24, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 33);
            this.button8.TabIndex = 6;
            this.button8.Text = "THỐNG KÊ ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(24, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "TRA CỨU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_list_admin
            // 
            this.btn_list_admin.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_list_admin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_list_admin.Location = new System.Drawing.Point(24, 304);
            this.btn_list_admin.Name = "btn_list_admin";
            this.btn_list_admin.Size = new System.Drawing.Size(133, 33);
            this.btn_list_admin.TabIndex = 7;
            this.btn_list_admin.Text = "ADMIN";
            this.btn_list_admin.UseVisualStyleBackColor = false;
            this.btn_list_admin.Click += new System.EventHandler(this.btn_list_admin_Click);
            // 
            // btn_list_guest
            // 
            this.btn_list_guest.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_list_guest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_list_guest.Location = new System.Drawing.Point(24, 248);
            this.btn_list_guest.Name = "btn_list_guest";
            this.btn_list_guest.Size = new System.Drawing.Size(133, 35);
            this.btn_list_guest.TabIndex = 8;
            this.btn_list_guest.Text = "DANH SÁCH KHÁCH HÀNG";
            this.btn_list_guest.UseVisualStyleBackColor = false;
            this.btn_list_guest.Click += new System.EventHandler(this.btn_list_guest_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(24, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "TÍNH TIỀN PHÒNG";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_list_admin);
            this.groupBox3.Controls.Add(this.btn_list_guest);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_rent);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(775, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(173, 411);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỨC NĂNG";
            // 
            // btn_rent
            // 
            this.btn_rent.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_rent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_rent.Location = new System.Drawing.Point(24, 134);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(133, 33);
            this.btn_rent.TabIndex = 10;
            this.btn_rent.Text = "ĐẶT PHÒNG";
            this.btn_rent.UseVisualStyleBackColor = false;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click_1);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng Thái";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Phòng";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phòng";
            this.columnHeader1.Width = 140;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 166);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(61, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 222);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết phòng";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(629, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(380, 246);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 27);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(237, 246);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 27);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtmaphong
            // 
            this.txtmaphong.HideSelection = false;
            this.txtmaphong.Location = new System.Drawing.Point(775, 496);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(25, 20);
            this.txtmaphong.TabIndex = 8;
            this.txtmaphong.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(93, 246);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 27);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // cbotinhtrang
            // 
            this.cbotinhtrang.FormattingEnabled = true;
            this.cbotinhtrang.Items.AddRange(new object[] {
            "Trong",
            "Có khách"});
            this.cbotinhtrang.Location = new System.Drawing.Point(448, 81);
            this.cbotinhtrang.Name = "cbotinhtrang";
            this.cbotinhtrang.Size = new System.Drawing.Size(179, 21);
            this.cbotinhtrang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn giá";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(113, 35);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(179, 20);
            this.txttenphong.TabIndex = 1;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(113, 82);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(179, 20);
            this.txtdongia.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbotinhtrang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phòng";
            // 
            // fulllname
            // 
            this.fulllname.BackColor = System.Drawing.SystemColors.WindowText;
            this.fulllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulllname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fulllname.Location = new System.Drawing.Point(428, 44);
            this.fulllname.Name = "fulllname";
            this.fulllname.Size = new System.Drawing.Size(187, 23);
            this.fulllname.TabIndex = 16;
            this.fulllname.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1012, 548);
            this.Controls.Add(this.fulllname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        string Strconn = @"Data Source=CHAOXA\MSSQLSERVER01;Initial Catalog=SQLQuanlykhachsan_gr11;Integrated Security=True";

        public string GetUserName(int id)
        {
            string name = "";
            string query = "SELECT fullname FROM tbl_admin WHERE user_id = @Id";

            using (SqlConnection connection = new SqlConnection(Strconn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    name = reader["fullname"].ToString();
                }
                reader.Close();
            }

            return name;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            hienthi();
            int loggedInUserId = Form1.LoggedInUserId;
            fulllname.Text = "Xin chào:" + GetUserName(loggedInUserId).ToString();
        }

        public void hienthi()
        {
            var reader = database.Instance.db_select("SELECT * FROM tbl_phong ");
            int i = 0;
            while (reader.Read())
            {
                listView1.Items.Add(reader[0].ToString());
                listView1.Items[i].SubItems.Add(reader[1].ToString());
                listView1.Items[i].SubItems.Add(reader[2].ToString());
                listView1.Items[i].SubItems.Add(reader[3].ToString());

                i++;
            }
            //conn.Close();
        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
            txtmaphong.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txttenphong.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtdongia.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbotinhtrang.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {


            if (txttenphong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenphong.Focus();
            }
            else if (txtdongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongia.Focus();
            }
            else if (cbotinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbotinhtrang.Focus();
            }
            else
            {

                listView1.Items.Clear();
                Dictionary<string, string> data = new Dictionary<string, string>();
                string DonGia = txtdongia.Text;
                string TinhTrang = cbotinhtrang.Text;
                string TenPhong = txttenphong.Text;

                data.Add("TenPhong", TenPhong);
                data.Add("DonGia", DonGia);
                data.Add("TinhTrang", TinhTrang);

                database.Instance.db_insert("tbl_phong", data);

                hienthi();
                //conn.Close();
            };


        }


        private void btn_update_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            string MaPhong = txtmaphong.Text;
            string DonGia = txtdongia.Text;
            string TinhTrang = cbotinhtrang.Text;
            string TenPhong = txttenphong.Text;

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("TenPhong", TenPhong);
            data.Add("DonGia", DonGia);
            data.Add("TinhTrang", TinhTrang);
            database.Instance.db_update("tbl_phong", data, "MaPhong = '" + MaPhong + "'");

            //conn.Close();
            hienthi();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string MaPhong = txtmaphong.Text;
            listView1.Items.Clear();
            database.Instance.db_delete("tbl_phong", "MaPhong = '" + MaPhong + "'");
            //conn.Close();
            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_rent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private Button fulllname;

        private void btn_list_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void btn_list_guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

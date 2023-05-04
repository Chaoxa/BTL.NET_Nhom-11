namespace BTL_NET_Nhom11
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbophongthue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.btn_exit_rent = new System.Windows.Forms.Button();
            this.btn_xoa_rent = new System.Windows.Forms.Button();
            this.btn_add_rent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fulllname = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 222);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết phòng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 166);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Khách hàng";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng thuê";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SĐT";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian";
            this.columnHeader4.Width = 150;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(650, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(24, 20);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // cbophongthue
            // 
            this.cbophongthue.FormattingEnabled = true;
            this.cbophongthue.Location = new System.Drawing.Point(447, 83);
            this.cbophongthue.Name = "cbophongthue";
            this.cbophongthue.Size = new System.Drawing.Size(179, 21);
            this.cbophongthue.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phòng thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(108, 81);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(179, 20);
            this.txtsodienthoai.TabIndex = 1;
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(110, 36);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(179, 20);
            this.txttenkhachhang.TabIndex = 1;
            // 
            // btn_exit_rent
            // 
            this.btn_exit_rent.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit_rent.Location = new System.Drawing.Point(626, 238);
            this.btn_exit_rent.Name = "btn_exit_rent";
            this.btn_exit_rent.Size = new System.Drawing.Size(75, 27);
            this.btn_exit_rent.TabIndex = 12;
            this.btn_exit_rent.Text = "Trang chủ";
            this.btn_exit_rent.UseVisualStyleBackColor = false;
            this.btn_exit_rent.Click += new System.EventHandler(this.btn_exit_rent_Click);
            // 
            // btn_xoa_rent
            // 
            this.btn_xoa_rent.Location = new System.Drawing.Point(196, 238);
            this.btn_xoa_rent.Name = "btn_xoa_rent";
            this.btn_xoa_rent.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa_rent.TabIndex = 13;
            this.btn_xoa_rent.Text = "Hủy phòng";
            this.btn_xoa_rent.UseVisualStyleBackColor = true;
            this.btn_xoa_rent.Click += new System.EventHandler(this.btn_xoa_rent_Click);
            // 
            // btn_add_rent
            // 
            this.btn_add_rent.Location = new System.Drawing.Point(90, 238);
            this.btn_add_rent.Name = "btn_add_rent";
            this.btn_add_rent.Size = new System.Drawing.Size(75, 27);
            this.btn_add_rent.TabIndex = 14;
            this.btn_add_rent.Text = "Thuê phòng";
            this.btn_add_rent.UseVisualStyleBackColor = true;
            this.btn_add_rent.Click += new System.EventHandler(this.btn_add_rent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbophongthue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.txttenkhachhang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(337, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "ỨNG DỤNG QUẢN LÝ KHÁCH SẠN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fulllname
            // 
            this.fulllname.BackColor = System.Drawing.SystemColors.WindowText;
            this.fulllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulllname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fulllname.Location = new System.Drawing.Point(387, 44);
            this.fulllname.Name = "fulllname";
            this.fulllname.Size = new System.Drawing.Size(124, 23);
            this.fulllname.TabIndex = 17;
            this.fulllname.Text = "Quản lý đặt phòng";
            this.fulllname.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 544);
            this.Controls.Add(this.fulllname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_exit_rent);
            this.Controls.Add(this.btn_xoa_rent);
            this.Controls.Add(this.btn_add_rent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cbophongthue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Button btn_exit_rent;
        private System.Windows.Forms.Button btn_xoa_rent;
        private System.Windows.Forms.Button btn_add_rent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fulllname;
    }
}
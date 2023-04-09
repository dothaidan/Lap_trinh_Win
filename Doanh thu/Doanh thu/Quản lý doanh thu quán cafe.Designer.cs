namespace Doanh_thu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgv_thongtin = new System.Windows.Forms.DataGridView();
            this.dtp_ngaythang = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lab_maban = new System.Windows.Forms.Label();
            this.lab_madon = new System.Windows.Forms.Label();
            this.lab_soluong = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lab_nhanvien = new System.Windows.Forms.Label();
            this.lab_tenkhach = new System.Windows.Forms.Label();
            this.lab_donvi = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongtin
            // 
            this.dgv_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtin.Location = new System.Drawing.Point(230, 188);
            this.dgv_thongtin.Name = "dgv_thongtin";
            this.dgv_thongtin.RowHeadersWidth = 51;
            this.dgv_thongtin.RowTemplate.Height = 24;
            this.dgv_thongtin.Size = new System.Drawing.Size(567, 210);
            this.dgv_thongtin.TabIndex = 0;
            // 
            // dtp_ngaythang
            // 
            this.dtp_ngaythang.CalendarFont = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaythang.Location = new System.Drawing.Point(259, 11);
            this.dtp_ngaythang.Name = "dtp_ngaythang";
            this.dtp_ngaythang.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngaythang.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_quaylai);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.lab_donvi);
            this.groupBox2.Controls.Add(this.lab_tenkhach);
            this.groupBox2.Controls.Add(this.lab_nhanvien);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lab_soluong);
            this.groupBox2.Controls.Add(this.lab_madon);
            this.groupBox2.Controls.Add(this.lab_maban);
            this.groupBox2.Controls.Add(this.dtp_ngaythang);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.groupBox2.Location = new System.Drawing.Point(142, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btn_quaylai.Location = new System.Drawing.Point(0, 13);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(75, 23);
            this.btn_quaylai.TabIndex = 2;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btn_thoat.Location = new System.Drawing.Point(0, 42);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btn_xacnhan.Location = new System.Drawing.Point(165, 262);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(39, 32);
            this.btn_xacnhan.TabIndex = 4;
            this.btn_xacnhan.Text = "✔";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btn_huy.Location = new System.Drawing.Point(165, 317);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(39, 32);
            this.btn_huy.TabIndex = 5;
            this.btn_huy.Text = "✘";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // lab_maban
            // 
            this.lab_maban.AutoSize = true;
            this.lab_maban.Location = new System.Drawing.Point(21, 42);
            this.lab_maban.Name = "lab_maban";
            this.lab_maban.Size = new System.Drawing.Size(50, 16);
            this.lab_maban.TabIndex = 4;
            this.lab_maban.Text = "Mã bàn";
            // 
            // lab_madon
            // 
            this.lab_madon.AutoSize = true;
            this.lab_madon.Location = new System.Drawing.Point(20, 82);
            this.lab_madon.Name = "lab_madon";
            this.lab_madon.Size = new System.Drawing.Size(52, 16);
            this.lab_madon.TabIndex = 5;
            this.lab_madon.Text = "Mã đơn";
            // 
            // lab_soluong
            // 
            this.lab_soluong.AutoSize = true;
            this.lab_soluong.Location = new System.Drawing.Point(20, 128);
            this.lab_soluong.Name = "lab_soluong";
            this.lab_soluong.Size = new System.Drawing.Size(62, 16);
            this.lab_soluong.TabIndex = 6;
            this.lab_soluong.Text = "Số lượng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 11;
            // 
            // lab_nhanvien
            // 
            this.lab_nhanvien.AutoSize = true;
            this.lab_nhanvien.Location = new System.Drawing.Point(330, 42);
            this.lab_nhanvien.Name = "lab_nhanvien";
            this.lab_nhanvien.Size = new System.Drawing.Size(116, 16);
            this.lab_nhanvien.TabIndex = 12;
            this.lab_nhanvien.Text = "Mã nhân viên order";
            // 
            // lab_tenkhach
            // 
            this.lab_tenkhach.AutoSize = true;
            this.lab_tenkhach.Location = new System.Drawing.Point(330, 85);
            this.lab_tenkhach.Name = "lab_tenkhach";
            this.lab_tenkhach.Size = new System.Drawing.Size(99, 16);
            this.lab_tenkhach.TabIndex = 13;
            this.lab_tenkhach.Text = "Tên khách hàng";
            // 
            // lab_donvi
            // 
            this.lab_donvi.AutoSize = true;
            this.lab_donvi.Location = new System.Drawing.Point(330, 128);
            this.lab_donvi.Name = "lab_donvi";
            this.lab_donvi.Size = new System.Drawing.Size(69, 16);
            this.lab_donvi.TabIndex = 14;
            this.lab_donvi.Text = "Đơn vị tiền";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(462, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(463, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(463, 128);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 22);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Arial", 7.8F);
            this.textBox7.Location = new System.Drawing.Point(230, 416);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(567, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Tổng tiền:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_thongtin);
            this.Name = "Form1";
            this.Text = "Quản lý doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongtin;
        private System.Windows.Forms.DateTimePicker dtp_ngaythang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lab_donvi;
        private System.Windows.Forms.Label lab_tenkhach;
        private System.Windows.Forms.Label lab_nhanvien;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab_soluong;
        private System.Windows.Forms.Label lab_madon;
        private System.Windows.Forms.Label lab_maban;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox7;
    }
}


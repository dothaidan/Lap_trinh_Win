namespace QuanLyQuanCafe
{
    partial class fMenu
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            but_AddFood = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            but_Chuyenban = new Button();
            but_Giamgia = new Button();
            but_Thanhtoan = new Button();
            comboBox4 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            listView1 = new ListView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 488);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(but_AddFood);
            panel2.Location = new Point(482, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 91);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(but_Thanhtoan);
            panel3.Controls.Add(but_Giamgia);
            panel3.Controls.Add(but_Chuyenban);
            panel3.Location = new Point(482, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 91);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView1);
            panel4.Location = new Point(482, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(439, 294);
            panel4.TabIndex = 3;
            // 
            // but_AddFood
            // 
            but_AddFood.Location = new Point(246, 0);
            but_AddFood.Name = "but_AddFood";
            but_AddFood.Size = new Size(94, 82);
            but_AddFood.TabIndex = 0;
            but_AddFood.Text = "Thêm món";
            but_AddFood.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox2.Location = new Point(3, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 28);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox3.Location = new Point(3, 47);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(244, 28);
            comboBox3.TabIndex = 3;
            // 
            // but_Chuyenban
            // 
            but_Chuyenban.Location = new Point(3, 3);
            but_Chuyenban.Name = "but_Chuyenban";
            but_Chuyenban.Size = new Size(118, 38);
            but_Chuyenban.TabIndex = 0;
            but_Chuyenban.Text = "Chuyển bàn";
            but_Chuyenban.UseVisualStyleBackColor = true;
            // 
            // but_Giamgia
            // 
            but_Giamgia.Location = new Point(172, 3);
            but_Giamgia.Name = "but_Giamgia";
            but_Giamgia.Size = new Size(106, 38);
            but_Giamgia.TabIndex = 1;
            but_Giamgia.Text = "Giảm giá";
            but_Giamgia.UseVisualStyleBackColor = true;
            // 
            // but_Thanhtoan
            // 
            but_Thanhtoan.Location = new Point(340, 3);
            but_Thanhtoan.Name = "but_Thanhtoan";
            but_Thanhtoan.Size = new Size(93, 85);
            but_Thanhtoan.TabIndex = 2;
            but_Thanhtoan.Text = "Thanh toán";
            but_Thanhtoan.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox4.Location = new Point(3, 47);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(118, 28);
            comboBox4.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(172, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(106, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(346, 32);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(430, 291);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 512);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fMenu";
            Text = "Menu";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Button but_AddFood;
        private Panel panel3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox4;
        private Button but_Thanhtoan;
        private Button but_Giamgia;
        private Button but_Chuyenban;
        private Panel panel4;
        private ListView listView1;
    }
}
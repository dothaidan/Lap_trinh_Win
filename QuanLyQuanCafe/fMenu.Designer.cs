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
            panel2 = new Panel();
            numericUpDown2 = new NumericUpDown();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            but_AddFood = new Button();
            panel3 = new Panel();
            numericUpDown1 = new NumericUpDown();
            comboBox4 = new ComboBox();
            but_Thanhtoan = new Button();
            but_Giamgia = new Button();
            but_Chuyenban = new Button();
            panel4 = new Panel();
            listView1 = new ListView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(but_AddFood);
            panel2.Location = new Point(16, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 68);
            panel2.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(303, 24);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(81, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox3.Location = new Point(3, 35);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(206, 23);
            comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox2.Location = new Point(3, 2);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 23);
            comboBox2.TabIndex = 2;
            // 
            // but_AddFood
            // 
            but_AddFood.Location = new Point(215, 0);
            but_AddFood.Margin = new Padding(3, 2, 3, 2);
            but_AddFood.Name = "but_AddFood";
            but_AddFood.Size = new Size(82, 62);
            but_AddFood.TabIndex = 0;
            but_AddFood.Text = "Thêm món";
            but_AddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(but_Thanhtoan);
            panel3.Controls.Add(but_Giamgia);
            panel3.Controls.Add(but_Chuyenban);
            panel3.Location = new Point(16, 309);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 68);
            panel3.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(150, 36);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox4.Location = new Point(3, 35);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(104, 23);
            comboBox4.TabIndex = 3;
            // 
            // but_Thanhtoan
            // 
            but_Thanhtoan.Location = new Point(298, 2);
            but_Thanhtoan.Margin = new Padding(3, 2, 3, 2);
            but_Thanhtoan.Name = "but_Thanhtoan";
            but_Thanhtoan.Size = new Size(81, 64);
            but_Thanhtoan.TabIndex = 2;
            but_Thanhtoan.Text = "Thanh toán";
            but_Thanhtoan.UseVisualStyleBackColor = true;
            // 
            // but_Giamgia
            // 
            but_Giamgia.Location = new Point(150, 2);
            but_Giamgia.Margin = new Padding(3, 2, 3, 2);
            but_Giamgia.Name = "but_Giamgia";
            but_Giamgia.Size = new Size(93, 28);
            but_Giamgia.TabIndex = 1;
            but_Giamgia.Text = "Giảm giá";
            but_Giamgia.UseVisualStyleBackColor = true;
            // 
            // but_Chuyenban
            // 
            but_Chuyenban.Location = new Point(3, 2);
            but_Chuyenban.Margin = new Padding(3, 2, 3, 2);
            but_Chuyenban.Name = "but_Chuyenban";
            but_Chuyenban.Size = new Size(103, 28);
            but_Chuyenban.TabIndex = 0;
            but_Chuyenban.Text = "Chuyển bàn";
            but_Chuyenban.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView1);
            panel4.Location = new Point(16, 84);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 220);
            panel4.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 2);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(377, 219);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 384);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
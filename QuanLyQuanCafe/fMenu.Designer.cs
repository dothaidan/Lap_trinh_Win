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
            nmFoodCount = new NumericUpDown();
            cboFood = new ComboBox();
            cboCategory = new ComboBox();
            but_AddFood = new Button();
            panel3 = new Panel();
            numericUpDown1 = new NumericUpDown();
            comboBox4 = new ComboBox();
            but_Thanhtoan = new Button();
            but_Giamgia = new Button();
            but_Chuyenban = new Button();
            panel4 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(nmFoodCount);
            panel2.Controls.Add(cboFood);
            panel2.Controls.Add(cboCategory);
            panel2.Controls.Add(but_AddFood);
            panel2.Location = new Point(16, 12);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 73);
            panel2.TabIndex = 1;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(303, 26);
            nmFoodCount.Margin = new Padding(3, 2, 3, 2);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(81, 22);
            nmFoodCount.TabIndex = 5;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboFood
            // 
            cboFood.FormattingEnabled = true;
            cboFood.Location = new Point(3, 37);
            cboFood.Margin = new Padding(3, 2, 3, 2);
            cboFood.Name = "cboFood";
            cboFood.Size = new Size(206, 24);
            cboFood.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(3, 2);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(206, 24);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // but_AddFood
            // 
            but_AddFood.Location = new Point(215, 0);
            but_AddFood.Margin = new Padding(3, 2, 3, 2);
            but_AddFood.Name = "but_AddFood";
            but_AddFood.Size = new Size(82, 66);
            but_AddFood.TabIndex = 0;
            but_AddFood.Text = "Thêm món";
            but_AddFood.UseVisualStyleBackColor = true;
            but_AddFood.Click += but_AddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(but_Thanhtoan);
            panel3.Controls.Add(but_Giamgia);
            panel3.Controls.Add(but_Chuyenban);
            panel3.Location = new Point(16, 330);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 73);
            panel3.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(150, 38);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 22);
            numericUpDown1.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox4.Location = new Point(3, 37);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(104, 24);
            comboBox4.TabIndex = 3;
            // 
            // but_Thanhtoan
            // 
            but_Thanhtoan.BackColor = Color.RoyalBlue;
            but_Thanhtoan.FlatAppearance.BorderSize = 0;
            but_Thanhtoan.FlatAppearance.MouseDownBackColor = Color.Blue;
            but_Thanhtoan.FlatStyle = FlatStyle.Flat;
            but_Thanhtoan.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            but_Thanhtoan.ForeColor = Color.WhiteSmoke;
            but_Thanhtoan.Location = new Point(265, 2);
            but_Thanhtoan.Margin = new Padding(3, 2, 3, 2);
            but_Thanhtoan.Name = "but_Thanhtoan";
            but_Thanhtoan.Size = new Size(114, 68);
            but_Thanhtoan.TabIndex = 2;
            but_Thanhtoan.Text = "Thanh toán";
            but_Thanhtoan.UseVisualStyleBackColor = false;
            but_Thanhtoan.Click += but_Thanhtoan_Click;
            // 
            // but_Giamgia
            // 
            but_Giamgia.Location = new Point(150, 2);
            but_Giamgia.Margin = new Padding(3, 2, 3, 2);
            but_Giamgia.Name = "but_Giamgia";
            but_Giamgia.Size = new Size(93, 30);
            but_Giamgia.TabIndex = 1;
            but_Giamgia.Text = "Giảm giá";
            but_Giamgia.UseVisualStyleBackColor = true;
            // 
            // but_Chuyenban
            // 
            but_Chuyenban.Location = new Point(3, 2);
            but_Chuyenban.Margin = new Padding(3, 2, 3, 2);
            but_Chuyenban.Name = "but_Chuyenban";
            but_Chuyenban.Size = new Size(103, 30);
            but_Chuyenban.TabIndex = 0;
            but_Chuyenban.Text = "Chuyển bàn";
            but_Chuyenban.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lsvBill);
            panel4.Location = new Point(16, 90);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 235);
            panel4.TabIndex = 3;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 2);
            lsvBill.Margin = new Padding(3, 2, 3, 2);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(377, 233);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 92;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 410);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += fMenu_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel2;
        private NumericUpDown nmFoodCount;
        private ComboBox cboFood;
        private ComboBox cboCategory;
        private Button but_AddFood;
        private Panel panel3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox4;
        private Button but_Thanhtoan;
        private Button but_Giamgia;
        private Button but_Chuyenban;
        private Panel panel4;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
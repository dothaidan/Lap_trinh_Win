namespace QuanLyQuanCafe
{
    partial class fCuaHang
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
            tbControl1 = new TabControl();
            tb_Bill = new TabPage();
            tb_DoiMatKhau = new TabPage();
            tb_Food = new TabPage();
            tb_FoodCategory = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dtgv_Food = new DataGridView();
            but_AddFood = new Button();
            but_DeleteFood = new Button();
            but_EditFood = new Button();
            but_ShowFood = new Button();
            but_SearchFood = new Button();
            txb_SearchFoodName = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            txb_FoodID = new TextBox();
            panel6 = new Panel();
            txb_FoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            cob_FoodCategory = new ComboBox();
            panel8 = new Panel();
            label4 = new Label();
            nm_FoodPrice = new NumericUpDown();
            dtgv_Category = new DataGridView();
            panel10 = new Panel();
            but_ShowCategory = new Button();
            but_EditCategory = new Button();
            but_DeleteCategory = new Button();
            but_AddCategory = new Button();
            panel11 = new Panel();
            panel14 = new Panel();
            txb_CategoryName = new TextBox();
            label7 = new Label();
            panel15 = new Panel();
            txb_CategoryID = new TextBox();
            label8 = new Label();
            tbControl1.SuspendLayout();
            tb_Food.SuspendLayout();
            tb_FoodCategory.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Food).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Category).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // tbControl1
            // 
            tbControl1.Controls.Add(tb_Bill);
            tbControl1.Controls.Add(tb_DoiMatKhau);
            tbControl1.Controls.Add(tb_Food);
            tbControl1.Controls.Add(tb_FoodCategory);
            tbControl1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbControl1.Location = new Point(12, 3);
            tbControl1.Name = "tbControl1";
            tbControl1.SelectedIndex = 0;
            tbControl1.Size = new Size(885, 507);
            tbControl1.TabIndex = 0;
            // 
            // tb_Bill
            // 
            tb_Bill.Location = new Point(4, 29);
            tb_Bill.Name = "tb_Bill";
            tb_Bill.Padding = new Padding(3);
            tb_Bill.Size = new Size(877, 474);
            tb_Bill.TabIndex = 0;
            tb_Bill.Text = "Doanh Thu";
            tb_Bill.UseVisualStyleBackColor = true;
            // 
            // tb_DoiMatKhau
            // 
            tb_DoiMatKhau.Location = new Point(4, 29);
            tb_DoiMatKhau.Name = "tb_DoiMatKhau";
            tb_DoiMatKhau.Padding = new Padding(3);
            tb_DoiMatKhau.Size = new Size(877, 474);
            tb_DoiMatKhau.TabIndex = 1;
            tb_DoiMatKhau.Text = "Đổi mật khẩu";
            tb_DoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // tb_Food
            // 
            tb_Food.Controls.Add(panel4);
            tb_Food.Controls.Add(panel3);
            tb_Food.Controls.Add(panel2);
            tb_Food.Controls.Add(panel1);
            tb_Food.Location = new Point(4, 29);
            tb_Food.Name = "tb_Food";
            tb_Food.Padding = new Padding(3);
            tb_Food.Size = new Size(877, 474);
            tb_Food.TabIndex = 2;
            tb_Food.Text = "Thức ăn";
            tb_Food.UseVisualStyleBackColor = true;
            // 
            // tb_FoodCategory
            // 
            tb_FoodCategory.Controls.Add(dtgv_Category);
            tb_FoodCategory.Controls.Add(panel10);
            tb_FoodCategory.Controls.Add(panel11);
            tb_FoodCategory.Location = new Point(4, 29);
            tb_FoodCategory.Name = "tb_FoodCategory";
            tb_FoodCategory.Padding = new Padding(3);
            tb_FoodCategory.Size = new Size(877, 474);
            tb_FoodCategory.TabIndex = 3;
            tb_FoodCategory.Text = "Doanh mục";
            tb_FoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgv_Food);
            panel1.Location = new Point(6, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 375);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(435, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 375);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(but_ShowFood);
            panel3.Controls.Add(but_EditFood);
            panel3.Controls.Add(but_DeleteFood);
            panel3.Controls.Add(but_AddFood);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 82);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txb_SearchFoodName);
            panel4.Controls.Add(but_SearchFood);
            panel4.Location = new Point(435, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(434, 82);
            panel4.TabIndex = 3;
            // 
            // dtgv_Food
            // 
            dtgv_Food.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Food.Location = new Point(3, 3);
            dtgv_Food.Name = "dtgv_Food";
            dtgv_Food.RowHeadersWidth = 51;
            dtgv_Food.RowTemplate.Height = 29;
            dtgv_Food.Size = new Size(417, 369);
            dtgv_Food.TabIndex = 0;
            // 
            // but_AddFood
            // 
            but_AddFood.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_AddFood.Location = new Point(3, 3);
            but_AddFood.Name = "but_AddFood";
            but_AddFood.Size = new Size(94, 76);
            but_AddFood.TabIndex = 0;
            but_AddFood.Text = "Thêm";
            but_AddFood.UseVisualStyleBackColor = true;
            // 
            // but_DeleteFood
            // 
            but_DeleteFood.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_DeleteFood.Location = new Point(103, 3);
            but_DeleteFood.Name = "but_DeleteFood";
            but_DeleteFood.Size = new Size(94, 76);
            but_DeleteFood.TabIndex = 1;
            but_DeleteFood.Text = "Xóa";
            but_DeleteFood.UseVisualStyleBackColor = true;
            // 
            // but_EditFood
            // 
            but_EditFood.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_EditFood.Location = new Point(226, 3);
            but_EditFood.Name = "but_EditFood";
            but_EditFood.Size = new Size(94, 76);
            but_EditFood.TabIndex = 2;
            but_EditFood.Text = "Sửa";
            but_EditFood.UseVisualStyleBackColor = true;
            // 
            // but_ShowFood
            // 
            but_ShowFood.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_ShowFood.Location = new Point(326, 3);
            but_ShowFood.Name = "but_ShowFood";
            but_ShowFood.Size = new Size(94, 76);
            but_ShowFood.TabIndex = 3;
            but_ShowFood.Text = "Xem";
            but_ShowFood.UseVisualStyleBackColor = true;
            // 
            // but_SearchFood
            // 
            but_SearchFood.Location = new Point(337, 3);
            but_SearchFood.Name = "but_SearchFood";
            but_SearchFood.Size = new Size(94, 76);
            but_SearchFood.TabIndex = 1;
            but_SearchFood.Text = "Tìm";
            but_SearchFood.UseVisualStyleBackColor = true;
            // 
            // txb_SearchFoodName
            // 
            txb_SearchFoodName.Location = new Point(3, 28);
            txb_SearchFoodName.Name = "txb_SearchFoodName";
            txb_SearchFoodName.Size = new Size(328, 25);
            txb_SearchFoodName.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(txb_FoodID);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 59);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(35, 27);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txb_FoodID
            // 
            txb_FoodID.Location = new Point(125, 21);
            txb_FoodID.Name = "txb_FoodID";
            txb_FoodID.ReadOnly = true;
            txb_FoodID.Size = new Size(303, 25);
            txb_FoodID.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(txb_FoodName);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 60);
            panel6.TabIndex = 1;
            // 
            // txb_FoodName
            // 
            txb_FoodName.Location = new Point(125, 23);
            txb_FoodName.Name = "txb_FoodName";
            txb_FoodName.Size = new Size(303, 25);
            txb_FoodName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(cob_FoodCategory);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(3, 134);
            panel7.Name = "panel7";
            panel7.Size = new Size(428, 66);
            panel7.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 14);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 0;
            label3.Text = "Doanh mục:";
            // 
            // cob_FoodCategory
            // 
            cob_FoodCategory.FormattingEnabled = true;
            cob_FoodCategory.Location = new Point(125, 13);
            cob_FoodCategory.Name = "cob_FoodCategory";
            cob_FoodCategory.Size = new Size(306, 28);
            cob_FoodCategory.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(nm_FoodPrice);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(3, 206);
            panel8.Name = "panel8";
            panel8.Size = new Size(428, 60);
            panel8.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 23);
            label4.Name = "label4";
            label4.Size = new Size(46, 27);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // nm_FoodPrice
            // 
            nm_FoodPrice.Location = new Point(125, 23);
            nm_FoodPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nm_FoodPrice.Name = "nm_FoodPrice";
            nm_FoodPrice.Size = new Size(300, 25);
            nm_FoodPrice.TabIndex = 1;
            // 
            // dtgv_Category
            // 
            dtgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Category.Location = new Point(6, 97);
            dtgv_Category.Name = "dtgv_Category";
            dtgv_Category.RowHeadersWidth = 51;
            dtgv_Category.RowTemplate.Height = 29;
            dtgv_Category.Size = new Size(426, 371);
            dtgv_Category.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Controls.Add(but_ShowCategory);
            panel10.Controls.Add(but_EditCategory);
            panel10.Controls.Add(but_DeleteCategory);
            panel10.Controls.Add(but_AddCategory);
            panel10.Location = new Point(9, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(423, 82);
            panel10.TabIndex = 6;
            // 
            // but_ShowCategory
            // 
            but_ShowCategory.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_ShowCategory.Location = new Point(326, 3);
            but_ShowCategory.Name = "but_ShowCategory";
            but_ShowCategory.Size = new Size(94, 76);
            but_ShowCategory.TabIndex = 3;
            but_ShowCategory.Text = "Xem";
            but_ShowCategory.UseVisualStyleBackColor = true;
            // 
            // but_EditCategory
            // 
            but_EditCategory.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_EditCategory.Location = new Point(226, 3);
            but_EditCategory.Name = "but_EditCategory";
            but_EditCategory.Size = new Size(94, 76);
            but_EditCategory.TabIndex = 2;
            but_EditCategory.Text = "Sửa";
            but_EditCategory.UseVisualStyleBackColor = true;
            // 
            // but_DeleteCategory
            // 
            but_DeleteCategory.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_DeleteCategory.Location = new Point(103, 3);
            but_DeleteCategory.Name = "but_DeleteCategory";
            but_DeleteCategory.Size = new Size(94, 76);
            but_DeleteCategory.TabIndex = 1;
            but_DeleteCategory.Text = "Xóa";
            but_DeleteCategory.UseVisualStyleBackColor = true;
            // 
            // but_AddCategory
            // 
            but_AddCategory.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            but_AddCategory.Location = new Point(3, 3);
            but_AddCategory.Name = "but_AddCategory";
            but_AddCategory.Size = new Size(94, 76);
            but_AddCategory.TabIndex = 0;
            but_AddCategory.Text = "Thêm";
            but_AddCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(438, 97);
            panel11.Name = "panel11";
            panel11.Size = new Size(434, 375);
            panel11.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.Controls.Add(txb_CategoryName);
            panel14.Controls.Add(label7);
            panel14.Location = new Point(3, 68);
            panel14.Name = "panel14";
            panel14.Size = new Size(428, 60);
            panel14.TabIndex = 1;
            // 
            // txb_CategoryName
            // 
            txb_CategoryName.Location = new Point(147, 23);
            txb_CategoryName.Name = "txb_CategoryName";
            txb_CategoryName.Size = new Size(281, 25);
            txb_CategoryName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 23);
            label7.Name = "label7";
            label7.Size = new Size(135, 27);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txb_CategoryID);
            panel15.Controls.Add(label8);
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(428, 59);
            panel15.TabIndex = 0;
            // 
            // txb_CategoryID
            // 
            txb_CategoryID.Location = new Point(147, 21);
            txb_CategoryID.Name = "txb_CategoryID";
            txb_CategoryID.ReadOnly = true;
            txb_CategoryID.Size = new Size(281, 25);
            txb_CategoryID.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 21);
            label8.Name = "label8";
            label8.Size = new Size(35, 27);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // fCuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 513);
            Controls.Add(tbControl1);
            Name = "fCuaHang";
            Text = "Cửa Hàng";
            tbControl1.ResumeLayout(false);
            tb_Food.ResumeLayout(false);
            tb_FoodCategory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Food).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_Category).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbControl1;
        private TabPage tb_Bill;
        private TabPage tb_DoiMatKhau;
        private TabPage tb_Food;
        private Panel panel4;
        private TextBox txb_SearchFoodName;
        private Button but_SearchFood;
        private Panel panel3;
        private Button but_ShowFood;
        private Button but_EditFood;
        private Button but_DeleteFood;
        private Button but_AddFood;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgv_Food;
        private TabPage tb_FoodCategory;
        private Panel panel6;
        private TextBox txb_FoodName;
        private Label label2;
        private Panel panel5;
        private TextBox txb_FoodID;
        private Label label1;
        private Panel panel8;
        private NumericUpDown nm_FoodPrice;
        private Label label4;
        private Panel panel7;
        private ComboBox cob_FoodCategory;
        private Label label3;
        private DataGridView dtgv_Category;
        private Panel panel10;
        private Button but_ShowCategory;
        private Button but_EditCategory;
        private Button but_DeleteCategory;
        private Button but_AddCategory;
        private Panel panel11;
        private Panel panel14;
        private TextBox txb_CategoryName;
        private Label label7;
        private Panel panel15;
        private TextBox txb_CategoryID;
        private Label label8;
    }
}
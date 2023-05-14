using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class fCuaHang : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList= new BindingSource();
        public fCuaHang()
        {
            InitializeComponent();
            Load();
            LoadDateTimePickerBiLL();
            LoadListBillByDate(dtp_FromDate.Value, dtp_ToDate.Value);
        }
        void Load()
        {
            dtgv_Food.DataSource = foodList;
            dtgv_Category.DataSource = categoryList;
            LoadCategoryIntoCombobox(cob_FoodCategory);
            AddFoodBinding();
            AddCategoryBinding();
            LoadListFood();
            LoadListCategory();
        }
        #region method

        #region Doanh thu
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dGV_hienthi.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }
        void LoadDateTimePickerBiLL()
        {
            DateTime today = DateTime.Now;
            dtp_FromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtp_ToDate.Value = dtp_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        #endregion
        #region tài khoản
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        void ChangeAccount(Account acc)
        {
            teB_tennguoidung.Text = LoginAccount.UserName;
            teB_tenhienthi.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = teB_tenhienthi.Text;
            string password = teB_matkhaucu.Text;
            string newpass = teB_matkhaumoi.Text;
            string reenterPass = teB_nhaplaimatkhau.Text;
            string userName = teB_tenhienthi.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");

                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }
        }
        #endregion
        #region sản phẩm
        void LoadListFood()
        {
            foodList.DataSource = foodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txb_FoodName.DataBindings.Add(new Binding("Text", dtgv_Food.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txb_FoodID.DataBindings.Add(new Binding("Text", dtgv_Food.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nm_FoodPrice.DataBindings.Add(new Binding("Value", dtgv_Food.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = foodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        #endregion
        #region danh mục
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void AddCategoryBinding()
        {
            txb_CategoryName.DataBindings.Add(new Binding("Text", dtgv_Category.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txb_CategoryID.DataBindings.Add(new Binding("Text", dtgv_Category.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = CategoryDAO.Instance.SearchCategoryByName(name);

            return listCategory;
        }
        #endregion

        #endregion

        #region Events

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler ÍnsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        #region doanh thu
        private void btn_ShowBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtp_FromDate.Value, dtp_ToDate.Value);
        }
        #endregion
        #region tài khoản
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            teB_tennguoidung.Clear();
            teB_tenhienthi.Clear();
            teB_nhaplaimatkhau.Clear();
            teB_matkhaumoi.Clear();
            teB_matkhaucu.Clear();
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        #endregion
        #region sản phẩm
        private void but_DeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txb_FoodID.Text);

            if (foodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công !!");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn !!");
            }
        }

        private void but_SearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txb_SearchFoodName.Text);
        }

        private void but_EditFood_Click(object sender, EventArgs e)
        {
            string name = txb_FoodName.Text;
            int categoryID = (cob_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;
            int id = Convert.ToInt32(txb_FoodID.Text);

            if (foodDAO.Instance.UpdateFood(name, categoryID, price, id))
            {
                MessageBox.Show("Sửa món thành công !!");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn !!");
            }
        }

        private void but_AddFood_Click(object sender, EventArgs e)
        {
            string name = txb_FoodName.Text;
            int categoryID = (cob_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;

            if (foodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công !!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn !!");
            }
        }

        private void txb_FoodID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_Food.SelectedCells.Count > 0)
                {
                    int id = (int)dtgv_Food.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cob_FoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cob_FoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cob_FoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void but_ShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion
        #region danh mục
        private void btn_SearchCategory_Click(object sender, EventArgs e)
        {
            categoryList.DataSource = SearchCategoryByName(TeB_SearchCategory.Text);
        }

        private void but_AddCategory_Click(object sender, EventArgs e)
        {
            string name = txb_CategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công !!");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục !!");
            }
        }

        private void but_DeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txb_FoodID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công !!");
                LoadListCategory();
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục !!");
            }
        }

        private void but_EditCategory_Click(object sender, EventArgs e)
        {
            string name = txb_CategoryName.Text;
            int id = Convert.ToInt32(txb_CategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công !!");
                LoadListCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục !!");
            }
        }

        private void but_ShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void txb_CategoryID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = -1;
                if (Int32.TryParse(txb_CategoryID.Text, out id))
                {
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    txb_CategoryID.Text = category.ID.ToString();
                }
            }
            catch { }
        }
        #endregion

        #endregion


    }
}












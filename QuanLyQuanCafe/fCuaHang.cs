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
        public fCuaHang()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgv_Food.DataSource = foodList;

            LoadCategoryIntoCombobox(cob_FoodCategory);
            AddFoodBinding();
            LoadListFood();
        }
        #region method
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
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = foodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }


        #endregion

        #region Events

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fCuaHang(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            teB_tennguoidung.Text = LoginAccount.UserName;
            teB_tenhienthi.Text = LoginAccount.DisplayName;
        }













        void UpdateAccountInfo()//
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
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lab_tenkhach_Click(object sender, EventArgs e)
        {

        }

        private void but_ShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }


        private void txb_FoodID_TextChanged(object sender, EventArgs e)
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

        private void but_AddFood_Click(object sender, EventArgs e)
        {
            string name = txb_FoodName.Text;
            int categoryID = (cob_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;

            if (foodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công !!");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn !!");
            }
        }

        private void but_EditFood_Click(object sender, EventArgs e)
        {
            string name = txb_FoodName.Text;
            int categoryID = (cob_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;
            int id = Convert.ToInt32(txb_FoodID.Text);

            if (foodDAO.Instance.UpdateFood(id, name, categoryID, price))
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

        private void but_SearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txb_SearchFoodName.Text);
        }
        #endregion

        private void btn_huybo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_huybo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

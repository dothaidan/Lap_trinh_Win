using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
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
            txb_FoodName.DataBindings.Add(new Binding("Text", dtgv_Food.DataSource, "Name"));
            txb_FoodID.DataBindings.Add(new Binding("Text", dtgv_Food.DataSource, "ID"));
            nm_FoodPrice.DataBindings.Add(new Binding("Value", dtgv_Food.DataSource, "Price"));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {

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

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

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
        #endregion

        private void txb_FoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgv_Food.SelectedCells.Count > 0)
            {
                int id = (int)dtgv_Food.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
               
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cob_FoodCategory.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach(Category item in cob_FoodCategory.Items)
                {
                    if(item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cob_FoodCategory.SelectedIndex = index;
            }
        }
    }
}

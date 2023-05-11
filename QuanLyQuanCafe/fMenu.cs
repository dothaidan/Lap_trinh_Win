using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fMenu : Form
    {
        private List<Menu> ListMenu;
        public fMenu(fMenu menu)
        {
            InitializeComponent();
        }
        #region method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cboCategory.DataSource = listCategory;
            cboCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = foodDAO.Instance.GetFoodByCategoryID(id);
            cboFood.DataSource = listFood;
            cboFood.DisplayMember = "Name";
        }
        public fMenu(List<Menu> ListMenu)
        {
            InitializeComponent();
            this.ListMenu = ListMenu;
            UpdateListView(ListMenu);
        }
        public void UpdateListView(List<Menu> ListMenu)
        {
            lsvBill.Items.Clear();
            this.ListMenu = ListMenu;
            double TotalPrice = 0;
            if (this.ListMenu.Count > 0)
            {
                foreach (Menu bill in ListMenu)
                {
                    ListViewItem lsvItem = new ListViewItem(bill.Name.ToString());
                    lsvItem.SubItems.Add(bill.Count.ToString());
                    lsvItem.SubItems.Add(bill.Price.ToString());
                    lsvItem.SubItems.Add(bill.TotalPrice.ToString());
                    TotalPrice += bill.Price;
                    lsvBill.Items.Add(lsvItem);
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                but_Thanhtoan.Text = TotalPrice.ToString("c", culture);
            }
            else but_Thanhtoan.Text = "Thanh toán";
        }
        #endregion

        private void but_Thanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void but_AddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDbyTableID(table.ID);
            int foodID = (cboFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInforDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInforDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
        }

        private void fMenu_Load(object sender, EventArgs e)
        { 
            LoadCategory();
        }
    }
}

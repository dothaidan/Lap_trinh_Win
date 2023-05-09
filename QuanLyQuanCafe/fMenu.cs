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
                    TotalPrice+= bill.Price;
                    lsvBill.Items.Add(lsvItem);
                }
                CultureInfo culture = new CultureInfo("vi-VN");
                but_Thanhtoan.Text= TotalPrice.ToString("c", culture);
            }
            else but_Thanhtoan.Text = "Thanh toán";
        }
        #endregion
    }
}

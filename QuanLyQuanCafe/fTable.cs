using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTable : Form
    {
        private fMenu menu;
        public fTable(fMenu menu)
        {
            InitializeComponent();
            LoadTabble();
            this.menu = menu;
        }

        void LoadTabble()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button but_ban = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                but_ban.Text = table.Name + "\r\n" + table.Status;
                but_ban.Click += But_table_Click;
                but_ban.Tag= table;
                if (table.Status == "Trống") { but_ban.BackColor = Color.Aqua; }
                else but_ban.BackColor = Color.HotPink;
                flP_table.Controls.Add(but_ban);
            }
        }
        void showBill(int id)
        {
            List<Menu> ListMenu = MenuDAO.Instance.GetListMenuByTable(id);

            if (menu == null )
            {
                return;
            }

            menu.UpdateListView(ListMenu);
        }
        void But_table_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            showBill(tableID);
            if (menu == null)
            {
                menu = new fMenu(MenuDAO.Instance.GetListMenuByTable(tableID));
                menu.ShowDialog();
            }
            else
            {
                menu.UpdateListView(MenuDAO.Instance.GetListMenuByTable(tableID));
                menu.ShowDialog();
            }
        }
    }
}

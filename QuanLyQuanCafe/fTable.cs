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
        public fTable()
        {
            InitializeComponent();
            LoadTabble();
        }

        void LoadTabble()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button but_ban = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                but_ban.Text = table.Name + "\r\n" + table.Status;
                if(table.Status == "Trống") { but_ban.BackColor= Color.Aqua; }
                else but_ban.BackColor = Color.HotPink;
                flP_table.Controls.Add(but_ban);
            }
        }
    }
}

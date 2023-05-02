using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> ListMenu = new List<Menu>();
            string query = "USP_GetBillInfoByIDTable @idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Menu menu = new Menu(row);
                ListMenu.Add(menu);
            }

            return ListMenu;
        }
    }
}

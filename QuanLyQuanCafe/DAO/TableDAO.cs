using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; } 
            private set => instance = value;
        }
        public static int TableWidth = 125;
        public static int TableHeight = 125;


        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList  = new List<Table> ();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; } 
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "select * from Account where Username = N'" + @username + "' and Password = N'" + @password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public string GetType(string username, string password)
        {
            string query = "select type from Account where Username = N'" + @username + "' and Password = N'" + @password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["type"].ToString();
            }
            else
            {
                return null; 
            }
        }

    }
}

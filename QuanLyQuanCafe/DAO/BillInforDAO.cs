using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance; }
            private set { BillInforDAO.instance = value; }
        }

        private BillInforDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> ListBillInfo = new List<BillInfo> ();
            string query = "USP_GetBillInfo @idBill " ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {id});
            foreach (DataRow row in data.Rows) 
            {
                BillInfo info = new BillInfo(row);
                ListBillInfo.Add(info);
            }

            return ListBillInfo;
        }
    }
}

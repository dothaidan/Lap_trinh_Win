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

        public void  DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idFood = " + id);
        }
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
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("create proc USP_InsertBillInfo @idBill, @idFood, @count", new object[] { idBill, idFood, count });
        }
    }
}

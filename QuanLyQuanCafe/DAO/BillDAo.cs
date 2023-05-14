﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if(instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }   
        }
        private BillDAO() { }

        public int GetUnCheckBillIDbyTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetUnCheckBillIDByTableID @idTable = " + id);
            if(data.Rows.Count > 0 )
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID; 
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}

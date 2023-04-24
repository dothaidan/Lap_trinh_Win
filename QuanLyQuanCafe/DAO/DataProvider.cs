using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string connectionstr = "Data Source=.\\ECUSSQL2008;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null )
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach ( string para in listPara )
                    {
                        if( para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapeter = new SqlDataAdapter(cmd);
                adapeter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return dt;
        }

        public object ExecuteScalar (string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteScalar();
                conn.Close();
            }
            return dt;
        }

    }

}

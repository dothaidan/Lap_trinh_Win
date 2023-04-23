using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fCuaHang : Form
    {
        public fCuaHang()
        {
            InitializeComponent();
           LoadListFood();
        }
        #region method
        void LoadListFood()
        {
            dtgv_Food.DataSource = foodDAO.Instance.GetListFood();
        }


        #endregion

        #region Events

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lab_tenkhach_Click(object sender, EventArgs e)
        {

        }

        private void but_ShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion
    }
}

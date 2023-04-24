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
    public partial class fMain_staff : Form
    {
        public fMain_staff()
        {
            InitializeComponent();
        }

        private void but_table_Click(object sender, EventArgs e)
        {
            fTable f = new fTable();
            f.ShowDialog();
        }

        private void PiB_logOut_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.ClearTeb();
            this.Close();
        }

        private void fMain_staff_Load(object sender, EventArgs e)
        {
            tltip_LogOut.SetToolTip(PiB_logOut, "Log Out");
        }
    }
}

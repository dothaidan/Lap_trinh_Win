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
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_table_Click(object sender, EventArgs e)
        {
            
        }

        private void but_manage_Click(object sender, EventArgs e)
        {
            fCuaHang f =new fCuaHang();
            f.ShowDialog();
        }

        private void fmain_Load(object sender, EventArgs e)
        {
            tltip_logOut.SetToolTip(PiB_logOut, "Log Out");
        }
    }
}

using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe
{
    public partial class fmain : Form
    {
        private fMenu menu;
        public fmain()
        {
            InitializeComponent();
        }
        #region events
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Close();
        }

        private void but_table_Click(object sender, EventArgs e)
        {
            fTable f = new fTable(menu);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void but_manage_Click(object sender, EventArgs e)
        {
            fCuaHang f = new fCuaHang();
            f.ShowDialog();
        }

        private void fmain_Load(object sender, EventArgs e)
        {
            tltip_logOut.SetToolTip(PiB_logOut, "Log Out");
        }

        #endregion
    }
}

using System.Diagnostics;

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
            fLogin f = new fLogin();
            f.ClearTeb();
            this.Close();

        }

        private void but_table_Click(object sender, EventArgs e)
        {
            fTable f = new fTable();
            f.ShowDialog();
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

        public void decentralization()
        {
            but_manage.Enabled = false;
        }
    }
}

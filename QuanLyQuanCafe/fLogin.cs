using QuanLyQuanCafe.DAO;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            string username = TeB_username.Text;
            string password = TeB_password.Text;
            if (Login(username, password))
            {
                fmain f = new fmain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            } else MessageBox.Show("Sai tài khoản hoặc mật khẩu nè!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void ChB_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_show_pass.Checked)
            {
                TeB_password.UseSystemPasswordChar = false;
            }
            else TeB_password.UseSystemPasswordChar = true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            tltip_Close.SetToolTip(but_close, "Close");
            tltip_Username.SetToolTip(TeB_username, "Nhập tên đăng nhập");
            tltip_Pass.SetToolTip(TeB_password, "Nhập mật khẩu");
        }

        public void ClearTeb()
        {
            TeB_username.Clear();
            TeB_password.Clear();
        }


    }
}
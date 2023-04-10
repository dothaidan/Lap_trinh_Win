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
            fmain f = new fmain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ChB_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if ( ChB_show_pass.Checked)
            {
                TeB_password.UseSystemPasswordChar= false;
            }
            else TeB_password.UseSystemPasswordChar= true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            tltip_Close.SetToolTip(but_close, "Close");
            tltip_Username.SetToolTip(TeB_username, "Nhập tên đăng nhập");
            tltip_Pass.SetToolTip(TeB_password, "Nhập mật khẩu");
        }
    }
}
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
    }
}
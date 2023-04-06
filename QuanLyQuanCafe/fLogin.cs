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

        
    }
}
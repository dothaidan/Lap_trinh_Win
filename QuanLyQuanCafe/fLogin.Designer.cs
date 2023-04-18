namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            panel2 = new Panel();
            ChB_show_pass = new CheckBox();
            TeB_username = new TextBox();
            pictureBox3 = new PictureBox();
            TeB_password = new TextBox();
            pictureBox2 = new PictureBox();
            but_login = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            but_close = new Button();
            tltip_Close = new ToolTip(components);
            tltip_Username = new ToolTip(components);
            tltip_Pass = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(but_login);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(41, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 380);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(ChB_show_pass);
            panel2.Controls.Add(TeB_username);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(TeB_password);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 121);
            panel2.TabIndex = 0;
            // 
            // ChB_show_pass
            // 
            ChB_show_pass.AutoSize = true;
            ChB_show_pass.Location = new Point(51, 97);
            ChB_show_pass.Name = "ChB_show_pass";
            ChB_show_pass.Size = new Size(118, 20);
            ChB_show_pass.TabIndex = 2;
            ChB_show_pass.Text = "Hiện mật khẩu";
            ChB_show_pass.UseVisualStyleBackColor = true;
            ChB_show_pass.CheckedChanged += ChB_show_pass_CheckedChanged;
            // 
            // TeB_username
            // 
            TeB_username.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeB_username.Location = new Point(51, 23);
            TeB_username.Name = "TeB_username";
            TeB_username.Size = new Size(199, 27);
            TeB_username.TabIndex = 1;
            TeB_username.WordWrap = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.keyhole;
            pictureBox3.Location = new Point(0, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // TeB_password
            // 
            TeB_password.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeB_password.Location = new Point(51, 64);
            TeB_password.Name = "TeB_password";
            TeB_password.Size = new Size(199, 27);
            TeB_password.TabIndex = 1;
            TeB_password.UseSystemPasswordChar = true;
            TeB_password.WordWrap = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(0, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // but_login
            // 
            but_login.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            but_login.FlatAppearance.MouseDownBackColor = Color.LightGray;
            but_login.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            but_login.FlatStyle = FlatStyle.Flat;
            but_login.Location = new Point(28, 331);
            but_login.Name = "but_login";
            but_login.Size = new Size(206, 33);
            but_login.TabIndex = 2;
            but_login.Text = "Đăng nhập";
            but_login.UseVisualStyleBackColor = true;
            but_login.Click += but_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(57, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(1, 431);
            label1.Name = "label1";
            label1.Size = new Size(252, 24);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Our Project";
            // 
            // but_close
            // 
            but_close.FlatAppearance.BorderSize = 0;
            but_close.FlatAppearance.MouseDownBackColor = Color.Gray;
            but_close.FlatAppearance.MouseOverBackColor = Color.Silver;
            but_close.FlatStyle = FlatStyle.Flat;
            but_close.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            but_close.ForeColor = Color.Red;
            but_close.Location = new Point(299, 0);
            but_close.Name = "but_close";
            but_close.Size = new Size(30, 29);
            but_close.TabIndex = 3;
            but_close.Text = "X";
            but_close.UseVisualStyleBackColor = true;
            but_close.Click += but_close_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(328, 473);
            Controls.Add(but_close);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox TeB_username;
        private PictureBox pictureBox3;
        private TextBox TeB_password;
        private Button but_login;
        private Label label1;
        private Button but_close;
        private ToolTip tltip_Close;
        private CheckBox ChB_show_pass;
        private ToolTip tltip_Username;
        private ToolTip tltip_Pass;
    }
}
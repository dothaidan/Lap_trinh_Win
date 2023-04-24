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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChB_show_pass = new System.Windows.Forms.CheckBox();
            this.TeB_username = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TeB_password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.but_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_close = new System.Windows.Forms.Button();
            this.tltip_Close = new System.Windows.Forms.ToolTip(this.components);
            this.tltip_Username = new System.Windows.Forms.ToolTip(this.components);
            this.tltip_Pass = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.but_login);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(41, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 380);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ChB_show_pass);
            this.panel2.Controls.Add(this.TeB_username);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.TeB_password);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 121);
            this.panel2.TabIndex = 0;
            // 
            // ChB_show_pass
            // 
            this.ChB_show_pass.AutoSize = true;
            this.ChB_show_pass.Location = new System.Drawing.Point(51, 97);
            this.ChB_show_pass.Name = "ChB_show_pass";
            this.ChB_show_pass.Size = new System.Drawing.Size(118, 20);
            this.ChB_show_pass.TabIndex = 2;
            this.ChB_show_pass.Text = "Hiện mật khẩu";
            this.ChB_show_pass.UseVisualStyleBackColor = true;
            this.ChB_show_pass.CheckedChanged += new System.EventHandler(this.ChB_show_pass_CheckedChanged);
            // 
            // TeB_username
            // 
            this.TeB_username.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeB_username.Location = new System.Drawing.Point(51, 23);
            this.TeB_username.Name = "TeB_username";
            this.TeB_username.Size = new System.Drawing.Size(199, 27);
            this.TeB_username.TabIndex = 1;
            this.TeB_username.WordWrap = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyQuanCafe.Properties.Resources.keyhole;
            this.pictureBox3.Location = new System.Drawing.Point(0, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // TeB_password
            // 
            this.TeB_password.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeB_password.Location = new System.Drawing.Point(51, 64);
            this.TeB_password.Name = "TeB_password";
            this.TeB_password.Size = new System.Drawing.Size(199, 27);
            this.TeB_password.TabIndex = 1;
            this.TeB_password.UseSystemPasswordChar = true;
            this.TeB_password.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyQuanCafe.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(0, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // but_login
            // 
            this.but_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.but_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.but_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_login.Location = new System.Drawing.Point(28, 331);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(206, 33);
            this.but_login.TabIndex = 2;
            this.but_login.Text = "Đăng nhập";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // but_close
            // 
            this.but_close.FlatAppearance.BorderSize = 0;
            this.but_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.but_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.but_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_close.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_close.ForeColor = System.Drawing.Color.Red;
            this.but_close.Location = new System.Drawing.Point(299, 0);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(30, 29);
            this.but_close.TabIndex = 3;
            this.but_close.Text = "X";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.but_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CancelButton = this.but_close;
            this.ClientSize = new System.Drawing.Size(328, 439);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private Button but_close;
        private ToolTip tltip_Close;
        private CheckBox ChB_show_pass;
        private ToolTip tltip_Username;
        private ToolTip tltip_Pass;
    }
}
namespace QuanLyQuanCafe
{
    partial class fmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PiB_logOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_manage = new System.Windows.Forms.Button();
            this.but_table = new System.Windows.Forms.Button();
            this.tltip_logOut = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiB_logOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PiB_logOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.but_manage);
            this.panel1.Controls.Add(this.but_table);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 203);
            this.panel1.TabIndex = 0;
            // 
            // PiB_logOut
            // 
            this.PiB_logOut.Image = global::QuanLyQuanCafe.Properties.Resources.exit;
            this.PiB_logOut.Location = new System.Drawing.Point(439, 163);
            this.PiB_logOut.Name = "PiB_logOut";
            this.PiB_logOut.Size = new System.Drawing.Size(40, 40);
            this.PiB_logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PiB_logOut.TabIndex = 2;
            this.PiB_logOut.TabStop = false;
            this.PiB_logOut.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(237, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 146);
            this.label1.TabIndex = 1;
            // 
            // but_manage
            // 
            this.but_manage.Location = new System.Drawing.Point(255, 27);
            this.but_manage.Name = "but_manage";
            this.but_manage.Size = new System.Drawing.Size(140, 140);
            this.but_manage.TabIndex = 1;
            this.but_manage.Text = "Cửa hàng";
            this.but_manage.UseVisualStyleBackColor = true;
            this.but_manage.Click += new System.EventHandler(this.but_manage_Click);
            // 
            // but_table
            // 
            this.but_table.Location = new System.Drawing.Point(81, 27);
            this.but_table.Name = "but_table";
            this.but_table.Size = new System.Drawing.Size(140, 140);
            this.but_table.TabIndex = 0;
            this.but_table.Text = "Khu vực";
            this.but_table.UseVisualStyleBackColor = true;
            this.but_table.Click += new System.EventHandler(this.but_table_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(494, 217);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PiB_logOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button but_manage;
        private Button but_table;
        private Label label1;
        private PictureBox PiB_logOut;
        private ToolTip tltip_logOut;
    }
}
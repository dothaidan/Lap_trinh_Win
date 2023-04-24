namespace QuanLyQuanCafe
{
    partial class fMain_staff
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
            this.but_table = new System.Windows.Forms.Button();
            this.PiB_logOut = new System.Windows.Forms.PictureBox();
            this.tltip_LogOut = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PiB_logOut)).BeginInit();
            this.SuspendLayout();
            // 
            // but_table
            // 
            this.but_table.Location = new System.Drawing.Point(181, 38);
            this.but_table.Name = "but_table";
            this.but_table.Size = new System.Drawing.Size(140, 140);
            this.but_table.TabIndex = 1;
            this.but_table.Text = "Khu vực";
            this.but_table.UseVisualStyleBackColor = true;
            this.but_table.Click += new System.EventHandler(this.but_table_Click);
            // 
            // PiB_logOut
            // 
            this.PiB_logOut.Image = global::QuanLyQuanCafe.Properties.Resources.exit;
            this.PiB_logOut.Location = new System.Drawing.Point(451, 175);
            this.PiB_logOut.Name = "PiB_logOut";
            this.PiB_logOut.Size = new System.Drawing.Size(40, 40);
            this.PiB_logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PiB_logOut.TabIndex = 3;
            this.PiB_logOut.TabStop = false;
            this.PiB_logOut.Click += new System.EventHandler(this.PiB_logOut_Click);
            // 
            // fMain_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(494, 217);
            this.Controls.Add(this.PiB_logOut);
            this.Controls.Add(this.but_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMain_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain_staff";
            this.Load += new System.EventHandler(this.fMain_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PiB_logOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button but_table;
        private PictureBox PiB_logOut;
        private ToolTip tltip_LogOut;
    }
}
namespace QuanLyQuanCafe
{
    partial class fTable
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
            this.flP_table = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flP_table
            // 
            this.flP_table.AutoScroll = true;
            this.flP_table.Location = new System.Drawing.Point(1, -1);
            this.flP_table.Name = "flP_table";
            this.flP_table.Size = new System.Drawing.Size(692, 392);
            this.flP_table.TabIndex = 0;
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 389);
            this.Controls.Add(this.flP_table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flP_table;
    }
}
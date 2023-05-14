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
            flP_table = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flP_table
            // 
            flP_table.AutoScroll = true;
            flP_table.Location = new Point(1, -1);
            flP_table.Name = "flP_table";
            flP_table.Size = new Size(692, 392);
            flP_table.TabIndex = 0;
            // 
            // fTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 389);
            Controls.Add(flP_table);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bàn";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flP_table;
    }
}
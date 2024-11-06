namespace Lib.Books.AuthorsBooks
{
    partial class frmAuthorsBook
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlAuthorsBookList1 = new Lib.Books.AuthorsBooks.ctrlAuthorsBookList();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(308, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(133, 26);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Authos Book";
            // 
            // ctrlAuthorsBookList1
            // 
            this.ctrlAuthorsBookList1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAuthorsBookList1.Location = new System.Drawing.Point(3, 90);
            this.ctrlAuthorsBookList1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAuthorsBookList1.Name = "ctrlAuthorsBookList1";
            this.ctrlAuthorsBookList1.Size = new System.Drawing.Size(737, 618);
            this.ctrlAuthorsBookList1.TabIndex = 3;
            // 
            // frmAuthorsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(748, 713);
            this.Controls.Add(this.ctrlAuthorsBookList1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAuthorsBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuthorsBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAuthorsBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private ctrlAuthorsBookList ctrlAuthorsBookList1;
    }
}
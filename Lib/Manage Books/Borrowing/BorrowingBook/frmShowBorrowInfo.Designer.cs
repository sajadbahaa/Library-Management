namespace Lib.Manage_Books.Borrowing.BorrowingBook
{
    partial class frmShowBorrowInfo
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
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlShowBorrow1 = new Lib.Manage_Books.Borrowing.BorrowingBook.Controls.ctrlShowBorrow();
            this.SuspendLayout();
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(2, 15);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(726, 50);
            this.ctrlShareScreen1.TabIndex = 0;
            // 
            // ctrlShowBorrow1
            // 
            this.ctrlShowBorrow1.Location = new System.Drawing.Point(27, 99);
            this.ctrlShowBorrow1.Name = "ctrlShowBorrow1";
            this.ctrlShowBorrow1.Size = new System.Drawing.Size(704, 420);
            this.ctrlShowBorrow1.TabIndex = 1;
            // 
            // frmShowBorrowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 559);
            this.Controls.Add(this.ctrlShowBorrow1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmShowBorrowInfo";
            this.Text = "frmShowBorrowInfo";
            this.Load += new System.EventHandler(this.frmShowBorrowInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Controls.ctrlShowBorrow ctrlShowBorrow1;
    }
}
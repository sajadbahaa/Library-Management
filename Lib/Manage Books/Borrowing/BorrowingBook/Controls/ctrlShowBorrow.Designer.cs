namespace Lib.Manage_Books.Borrowing.BorrowingBook.Controls
{
    partial class ctrlShowBorrow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlBookInfo1 = new Lib.Books.Controls.ctrlBookInfo();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBorrow = new System.Windows.Forms.Label();
            this.IsBorrow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRName = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookInfo1.Location = new System.Drawing.Point(4, 33);
            this.ctrlBookInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(678, 329);
            this.ctrlBookInfo1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Borrow ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.IsBorrow);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbBorrow);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbBorrow
            // 
            this.lbBorrow.AutoSize = true;
            this.lbBorrow.Location = new System.Drawing.Point(77, 27);
            this.lbBorrow.Name = "lbBorrow";
            this.lbBorrow.Size = new System.Drawing.Size(25, 13);
            this.lbBorrow.TabIndex = 2;
            this.lbBorrow.Text = "???";
            // 
            // IsBorrow
            // 
            this.IsBorrow.AutoSize = true;
            this.IsBorrow.Location = new System.Drawing.Point(248, 27);
            this.IsBorrow.Name = "IsBorrow";
            this.IsBorrow.Size = new System.Drawing.Size(25, 13);
            this.IsBorrow.TabIndex = 4;
            this.IsBorrow.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Is Borrow :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reader Name :";
            // 
            // lbRName
            // 
            this.lbRName.AutoSize = true;
            this.lbRName.Location = new System.Drawing.Point(466, 27);
            this.lbRName.Name = "lbRName";
            this.lbRName.Size = new System.Drawing.Size(25, 13);
            this.lbRName.TabIndex = 7;
            this.lbRName.Text = "???";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(242, 11);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(167, 13);
            this.lbMsg.TabIndex = 6;
            this.lbMsg.Text = "This Borrow Has Been un Locked";
            // 
            // ctrlShowBorrow
            // 
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctrlBookInfo1);
            this.Name = "ctrlShowBorrow";
            this.Size = new System.Drawing.Size(693, 451);
            this.Load += new System.EventHandler(this.ctrlShowBorrow_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Lib.Books.Controls.ctrlBookInfo ctrlBookInfo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbBorrow;
        private System.Windows.Forms.Label IsBorrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMsg;
    }
}

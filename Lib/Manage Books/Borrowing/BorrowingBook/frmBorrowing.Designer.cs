namespace Lib.Manage_Books.Borrowing.BorrowingBook
{
    partial class frmBorrowingBooks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFindReader = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabFindBook = new System.Windows.Forms.TabPage();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.chIsBorrow = new System.Windows.Forms.CheckBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBorrowingDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReaderName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBorrowID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.ctrlFindReader1 = new Lib.Readers.ctrlFindReader();
            this.ctrlBookInfoWithFilter1 = new Lib.Books.Controls.ctrlBookInfoWithFilter();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.tabControl1.SuspendLayout();
            this.tabFindReader.SuspendLayout();
            this.tabFindBook.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFindReader);
            this.tabControl1.Controls.Add(this.tabFindBook);
            this.tabControl1.Controls.Add(this.tabBorrow);
            this.tabControl1.Location = new System.Drawing.Point(7, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 551);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFindReader
            // 
            this.tabFindReader.Controls.Add(this.btnNext);
            this.tabFindReader.Controls.Add(this.ctrlFindReader1);
            this.tabFindReader.Location = new System.Drawing.Point(4, 25);
            this.tabFindReader.Name = "tabFindReader";
            this.tabFindReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindReader.Size = new System.Drawing.Size(744, 522);
            this.tabFindReader.TabIndex = 0;
            this.tabFindReader.Text = "Find Reader";
            this.tabFindReader.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(610, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 34);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextToTakeBook);
            // 
            // tabFindBook
            // 
            this.tabFindBook.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tabFindBook.Controls.Add(this.btnNext1);
            this.tabFindBook.Location = new System.Drawing.Point(4, 25);
            this.tabFindBook.Name = "tabFindBook";
            this.tabFindBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindBook.Size = new System.Drawing.Size(744, 522);
            this.tabFindBook.TabIndex = 1;
            this.tabFindBook.Text = "Find Book";
            this.tabFindBook.UseVisualStyleBackColor = true;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(569, 482);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(110, 34);
            this.btnNext1.TabIndex = 4;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.NextToBorrow);
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.chIsBorrow);
            this.tabBorrow.Controls.Add(this.lbUsername);
            this.tabBorrow.Controls.Add(this.label7);
            this.tabBorrow.Controls.Add(this.lbDueDate);
            this.tabBorrow.Controls.Add(this.label6);
            this.tabBorrow.Controls.Add(this.lbBorrowingDate);
            this.tabBorrow.Controls.Add(this.label5);
            this.tabBorrow.Controls.Add(this.lbBookTitle);
            this.tabBorrow.Controls.Add(this.label4);
            this.tabBorrow.Controls.Add(this.lbReaderName);
            this.tabBorrow.Controls.Add(this.label3);
            this.tabBorrow.Controls.Add(this.lbBorrowID);
            this.tabBorrow.Controls.Add(this.label1);
            this.tabBorrow.Location = new System.Drawing.Point(4, 25);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Size = new System.Drawing.Size(744, 522);
            this.tabBorrow.TabIndex = 2;
            this.tabBorrow.Text = "Borrow Book";
            this.tabBorrow.UseVisualStyleBackColor = true;
            this.tabBorrow.Visible = false;
            this.tabBorrow.Click += new System.EventHandler(this.tabBorrow_Click);
            // 
            // chIsBorrow
            // 
            this.chIsBorrow.AutoSize = true;
            this.chIsBorrow.Location = new System.Drawing.Point(32, 336);
            this.chIsBorrow.Name = "chIsBorrow";
            this.chIsBorrow.Size = new System.Drawing.Size(81, 20);
            this.chIsBorrow.TabIndex = 12;
            this.chIsBorrow.Text = "Is Borrow";
            this.chIsBorrow.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(141, 399);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(28, 16);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "???";
            this.lbUsername.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username  : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(141, 275);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(28, 16);
            this.lbDueDate.TabIndex = 9;
            this.lbDueDate.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Due Date : ";
            // 
            // lbBorrowingDate
            // 
            this.lbBorrowingDate.AutoSize = true;
            this.lbBorrowingDate.Location = new System.Drawing.Point(142, 217);
            this.lbBorrowingDate.Name = "lbBorrowingDate";
            this.lbBorrowingDate.Size = new System.Drawing.Size(28, 16);
            this.lbBorrowingDate.TabIndex = 7;
            this.lbBorrowingDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "BorrowingDate : ";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Location = new System.Drawing.Point(142, 159);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(28, 16);
            this.lbBookTitle.TabIndex = 5;
            this.lbBookTitle.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Title  : ";
            // 
            // lbReaderName
            // 
            this.lbReaderName.AutoSize = true;
            this.lbReaderName.Location = new System.Drawing.Point(142, 94);
            this.lbReaderName.Name = "lbReaderName";
            this.lbReaderName.Size = new System.Drawing.Size(28, 16);
            this.lbReaderName.TabIndex = 3;
            this.lbReaderName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reader Name : ";
            // 
            // lbBorrowID
            // 
            this.lbBorrowID.AutoSize = true;
            this.lbBorrowID.Location = new System.Drawing.Point(142, 30);
            this.lbBorrowID.Name = "lbBorrowID";
            this.lbBorrowID.Size = new System.Drawing.Size(28, 16);
            this.lbBorrowID.TabIndex = 1;
            this.lbBorrowID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow ID : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(644, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(518, 628);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(110, 34);
            this.btnCLose.TabIndex = 5;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.button1_Click);
            this.btnCLose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCLose_MouseClick);
            // 
            // ctrlFindReader1
            // 
            this.ctrlFindReader1.FilterEnable = true;
            this.ctrlFindReader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindReader1.Location = new System.Drawing.Point(3, 4);
            this.ctrlFindReader1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindReader1.Name = "ctrlFindReader1";
            this.ctrlFindReader1.Size = new System.Drawing.Size(734, 449);
            this.ctrlFindReader1.TabIndex = 2;
            this.ctrlFindReader1.OnReaderSelected += new System.EventHandler<Lib.Readers.ctrlFindReader.clsReaderInfo>(this.ctrlFindReader1_OnReaderSelected);
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.FilterEnable = true;
            this.ctrlBookInfoWithFilter1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(8, 8);
            this.ctrlBookInfoWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(728, 405);
            this.ctrlBookInfoWithFilter1.TabIndex = 5;
            this.ctrlBookInfoWithFilter1.OnBookCopySelected += new System.EventHandler<Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo>(this.ctrlBookInfoWithFilter1_OnBookCopySelected);
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(4, 3);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(727, 48);
            this.ctrlShareScreen1.TabIndex = 0;
            this.ctrlShareScreen1.Load += new System.EventHandler(this.ctrlShareScreen1_Load);
            // 
            // frmBorrowingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 679);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBorrowingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBorrowing";
            this.Load += new System.EventHandler(this.frmBorrowing_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFindReader.ResumeLayout(false);
            this.tabFindBook.ResumeLayout(false);
            this.tabBorrow.ResumeLayout(false);
            this.tabBorrow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFindReader;
        private Readers.ctrlFindReader ctrlFindReader1;
        private System.Windows.Forms.TabPage tabFindBook;
       // private Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReaderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBorrowID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBorrowingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.CheckBox chIsBorrow;
        private Lib.Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
    }
}
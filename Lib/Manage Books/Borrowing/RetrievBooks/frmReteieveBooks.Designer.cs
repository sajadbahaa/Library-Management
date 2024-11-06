namespace Lib.Manage_Books.Borrowing.RetrievBooks
{
    partial class frmReteieveBooks
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
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBorrowingDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFindBook = new System.Windows.Forms.TabPage();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReaderName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBorrowID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabFindReader = new System.Windows.Forms.TabPage();
            this.ctrlFindReader1 = new Lib.Readers.ctrlFindReader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.chIsRetrieve = new System.Windows.Forms.CheckBox();
            this.lbActualDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lShowHistoryReader = new System.Windows.Forms.LinkLabel();
            this.lShowFine = new System.Windows.Forms.LinkLabel();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlBookInfoWithFilter1 = new Lib.Books.Controls.ctrlBookInfoWithFilter();
            this.tabFindBook.SuspendLayout();
            this.tabFindReader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(543, 613);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(110, 34);
            this.btnCLose.TabIndex = 9;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.Close);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Retrieve Book";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(141, 439);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(27, 19);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username  : ";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Location = new System.Drawing.Point(141, 275);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(27, 19);
            this.lbDueDate.TabIndex = 9;
            this.lbDueDate.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Due Date : ";
            // 
            // lbBorrowingDate
            // 
            this.lbBorrowingDate.AutoSize = true;
            this.lbBorrowingDate.Location = new System.Drawing.Point(142, 217);
            this.lbBorrowingDate.Name = "lbBorrowingDate";
            this.lbBorrowingDate.Size = new System.Drawing.Size(27, 19);
            this.lbBorrowingDate.TabIndex = 7;
            this.lbBorrowingDate.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "BorrowingDate : ";
            // 
            // tabFindBook
            // 
            this.tabFindBook.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tabFindBook.Controls.Add(this.btnNext1);
            this.tabFindBook.Location = new System.Drawing.Point(4, 28);
            this.tabFindBook.Name = "tabFindBook";
            this.tabFindBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindBook.Size = new System.Drawing.Size(744, 519);
            this.tabFindBook.TabIndex = 1;
            this.tabFindBook.Text = "Find Book";
            this.tabFindBook.UseVisualStyleBackColor = true;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(597, 467);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(110, 34);
            this.btnNext1.TabIndex = 4;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.NextToRetrievBook);
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Location = new System.Drawing.Point(142, 159);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(27, 19);
            this.lbBookTitle.TabIndex = 5;
            this.lbBookTitle.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Title  : ";
            // 
            // lbReaderName
            // 
            this.lbReaderName.AutoSize = true;
            this.lbReaderName.Location = new System.Drawing.Point(142, 94);
            this.lbReaderName.Name = "lbReaderName";
            this.lbReaderName.Size = new System.Drawing.Size(27, 19);
            this.lbReaderName.TabIndex = 3;
            this.lbReaderName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reader Name : ";
            // 
            // lbBorrowID
            // 
            this.lbBorrowID.AutoSize = true;
            this.lbBorrowID.Location = new System.Drawing.Point(142, 30);
            this.lbBorrowID.Name = "lbBorrowID";
            this.lbBorrowID.Size = new System.Drawing.Size(27, 19);
            this.lbBorrowID.TabIndex = 1;
            this.lbBorrowID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow ID : ";
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
            // tabFindReader
            // 
            this.tabFindReader.Controls.Add(this.btnNext);
            this.tabFindReader.Controls.Add(this.ctrlFindReader1);
            this.tabFindReader.Location = new System.Drawing.Point(4, 28);
            this.tabFindReader.Name = "tabFindReader";
            this.tabFindReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindReader.Size = new System.Drawing.Size(744, 519);
            this.tabFindReader.TabIndex = 0;
            this.tabFindReader.Text = "Find Reader";
            this.tabFindReader.UseVisualStyleBackColor = true;
            // 
            // ctrlFindReader1
            // 
            this.ctrlFindReader1.FilterEnable = true;
            this.ctrlFindReader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindReader1.Location = new System.Drawing.Point(3, 4);
            this.ctrlFindReader1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindReader1.Name = "ctrlFindReader1";
            this.ctrlFindReader1.ReaderInfo = null;
            this.ctrlFindReader1.Size = new System.Drawing.Size(734, 449);
            this.ctrlFindReader1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFindReader);
            this.tabControl1.Controls.Add(this.tabFindBook);
            this.tabControl1.Controls.Add(this.tabBorrow);
            this.tabControl1.Location = new System.Drawing.Point(17, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 551);
            this.tabControl1.TabIndex = 7;
            // 
            // tabBorrow
            // 
            this.tabBorrow.Controls.Add(this.chIsRetrieve);
            this.tabBorrow.Controls.Add(this.lbActualDate);
            this.tabBorrow.Controls.Add(this.label8);
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
            this.tabBorrow.Location = new System.Drawing.Point(4, 28);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Size = new System.Drawing.Size(744, 519);
            this.tabBorrow.TabIndex = 2;
            this.tabBorrow.Text = "Borrow Book";
            this.tabBorrow.UseVisualStyleBackColor = true;
            this.tabBorrow.Visible = false;
            // 
            // chIsRetrieve
            // 
            this.chIsRetrieve.AutoSize = true;
            this.chIsRetrieve.Location = new System.Drawing.Point(31, 377);
            this.chIsRetrieve.Name = "chIsRetrieve";
            this.chIsRetrieve.Size = new System.Drawing.Size(91, 23);
            this.chIsRetrieve.TabIndex = 14;
            this.chIsRetrieve.Text = "Is Retrieve";
            this.chIsRetrieve.UseVisualStyleBackColor = true;
            // 
            // lbActualDate
            // 
            this.lbActualDate.AutoSize = true;
            this.lbActualDate.Location = new System.Drawing.Point(141, 334);
            this.lbActualDate.Name = "lbActualDate";
            this.lbActualDate.Size = new System.Drawing.Size(27, 19);
            this.lbActualDate.TabIndex = 13;
            this.lbActualDate.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Actual Date : ";
            // 
            // lShowHistoryReader
            // 
            this.lShowHistoryReader.AutoSize = true;
            this.lShowHistoryReader.Location = new System.Drawing.Point(45, 621);
            this.lShowHistoryReader.Name = "lShowHistoryReader";
            this.lShowHistoryReader.Size = new System.Drawing.Size(137, 19);
            this.lShowHistoryReader.TabIndex = 10;
            this.lShowHistoryReader.TabStop = true;
            this.lShowHistoryReader.Text = "Show History Reader";
            this.lShowHistoryReader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowHistoryReader);
            // 
            // lShowFine
            // 
            this.lShowFine.AutoSize = true;
            this.lShowFine.Location = new System.Drawing.Point(210, 621);
            this.lShowFine.Name = "lShowFine";
            this.lShowFine.Size = new System.Drawing.Size(72, 19);
            this.lShowFine.TabIndex = 11;
            this.lShowFine.TabStop = true;
            this.lShowFine.Text = "Show Fine";
            this.lShowFine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showFine);
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(5, 0);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(752, 37);
            this.ctrlShareScreen1.TabIndex = 6;
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
            // frmReteieveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 661);
            this.Controls.Add(this.lShowFine);
            this.Controls.Add(this.lShowHistoryReader);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReteieveBooks";
            this.Text = "frmReteieveBooks";
            this.Load += new System.EventHandler(this.frmReteieveBooks_Load);
            this.tabFindBook.ResumeLayout(false);
            this.tabFindReader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBorrow.ResumeLayout(false);
            this.tabBorrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Readers.ctrlFindReader ctrlFindReader1;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button btnSave;
       // private Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBorrowingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabFindBook;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbReaderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBorrowID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabFindReader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.Label lbActualDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chIsRetrieve;
        private System.Windows.Forms.LinkLabel lShowHistoryReader;
        private System.Windows.Forms.LinkLabel lShowFine;
        private Lib.Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
    }
}
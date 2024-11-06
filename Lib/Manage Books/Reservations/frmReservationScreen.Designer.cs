namespace Lib.Manage_Books.Reservations
{
    partial class frmReservationScreen
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
            this.tabBookInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookInfoWithFilter1 = new Lib.Books.Controls.ctrlBookInfoWithFilter();
            this.btnNextToReader = new System.Windows.Forms.Button();
            this.tabReaderInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFindReader2 = new Lib.Readers.ctrlFindReader();
            this.tabReservation = new System.Windows.Forms.TabPage();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chIsLock = new System.Windows.Forms.CheckBox();
            this.lbReaderName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReservationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lReservationHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBookInfo.SuspendLayout();
            this.tabReaderInfo.SuspendLayout();
            this.tabReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBookInfo);
            this.tabControl1.Controls.Add(this.tabReaderInfo);
            this.tabControl1.Controls.Add(this.tabReservation);
            this.tabControl1.Location = new System.Drawing.Point(13, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // tabBookInfo
            // 
            this.tabBookInfo.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tabBookInfo.Controls.Add(this.btnNextToReader);
            this.tabBookInfo.Location = new System.Drawing.Point(4, 22);
            this.tabBookInfo.Name = "tabBookInfo";
            this.tabBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookInfo.Size = new System.Drawing.Size(748, 497);
            this.tabBookInfo.TabIndex = 0;
            this.tabBookInfo.Text = "Book Info";
            this.tabBookInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.FilterEnable = true;
            this.ctrlBookInfoWithFilter1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(19, 8);
            this.ctrlBookInfoWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(721, 405);
            this.ctrlBookInfoWithFilter1.TabIndex = 7;
            this.ctrlBookInfoWithFilter1.OnBookCopySelected += new System.EventHandler<Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo>(this.ctrlBookInfoWithFilter1_OnBookCopySelected);
            // 
            // btnNextToReader
            // 
            this.btnNextToReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToReader.Location = new System.Drawing.Point(568, 434);
            this.btnNextToReader.Name = "btnNextToReader";
            this.btnNextToReader.Size = new System.Drawing.Size(118, 31);
            this.btnNextToReader.TabIndex = 6;
            this.btnNextToReader.Text = "Next";
            this.btnNextToReader.UseVisualStyleBackColor = true;
            this.btnNextToReader.Click += new System.EventHandler(this.OnClickNextToReader);
            // 
            // tabReaderInfo
            // 
            this.tabReaderInfo.Controls.Add(this.btnNext);
            this.tabReaderInfo.Controls.Add(this.ctrlFindReader2);
            this.tabReaderInfo.Location = new System.Drawing.Point(4, 22);
            this.tabReaderInfo.Name = "tabReaderInfo";
            this.tabReaderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaderInfo.Size = new System.Drawing.Size(748, 497);
            this.tabReaderInfo.TabIndex = 1;
            this.tabReaderInfo.Text = "Reader Info";
            this.tabReaderInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(614, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 31);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFindReader2
            // 
            this.ctrlFindReader2.FilterEnable = true;
            this.ctrlFindReader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindReader2.Location = new System.Drawing.Point(8, 5);
            this.ctrlFindReader2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindReader2.Name = "ctrlFindReader2";
            this.ctrlFindReader2.ReaderInfo = null;
            this.ctrlFindReader2.Size = new System.Drawing.Size(733, 454);
            this.ctrlFindReader2.TabIndex = 6;
            this.ctrlFindReader2.OnReaderSelected += new System.EventHandler<Lib.Readers.ctrlFindReader.clsReaderInfo>(this.ctrlFindReader2_OnReaderSelected);
            // 
            // tabReservation
            // 
            this.tabReservation.Controls.Add(this.lbUsername);
            this.tabReservation.Controls.Add(this.label5);
            this.tabReservation.Controls.Add(this.chIsLock);
            this.tabReservation.Controls.Add(this.lbReaderName);
            this.tabReservation.Controls.Add(this.label4);
            this.tabReservation.Controls.Add(this.lbBookName);
            this.tabReservation.Controls.Add(this.label3);
            this.tabReservation.Controls.Add(this.lbReservationID);
            this.tabReservation.Controls.Add(this.label1);
            this.tabReservation.Location = new System.Drawing.Point(4, 22);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.Size = new System.Drawing.Size(748, 497);
            this.tabReservation.TabIndex = 2;
            this.tabReservation.Text = "Reservation";
            this.tabReservation.UseVisualStyleBackColor = true;
            this.tabReservation.Click += new System.EventHandler(this.tabReservation_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(189, 220);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(36, 20);
            this.lbUsername.TabIndex = 8;
            this.lbUsername.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username  : ";
            // 
            // chIsLock
            // 
            this.chIsLock.AutoSize = true;
            this.chIsLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsLock.Location = new System.Drawing.Point(36, 273);
            this.chIsLock.Name = "chIsLock";
            this.chIsLock.Size = new System.Drawing.Size(79, 24);
            this.chIsLock.TabIndex = 6;
            this.chIsLock.Text = "Is Lock";
            this.chIsLock.UseVisualStyleBackColor = true;
            // 
            // lbReaderName
            // 
            this.lbReaderName.AutoSize = true;
            this.lbReaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReaderName.Location = new System.Drawing.Point(189, 163);
            this.lbReaderName.Name = "lbReaderName";
            this.lbReaderName.Size = new System.Drawing.Size(36, 20);
            this.lbReaderName.TabIndex = 5;
            this.lbReaderName.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reader Name  : ";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(189, 98);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(36, 20);
            this.lbBookName.TabIndex = 3;
            this.lbBookName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name  : ";
            // 
            // lbReservationID
            // 
            this.lbReservationID.AutoSize = true;
            this.lbReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservationID.Location = new System.Drawing.Point(189, 42);
            this.lbReservationID.Name = "lbReservationID";
            this.lbReservationID.Size = new System.Drawing.Size(36, 20);
            this.lbReservationID.TabIndex = 1;
            this.lbReservationID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ID  : ";
            // 
            // lReservationHistory
            // 
            this.lReservationHistory.AutoSize = true;
            this.lReservationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReservationHistory.Location = new System.Drawing.Point(17, 606);
            this.lReservationHistory.Name = "lReservationHistory";
            this.lReservationHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lReservationHistory.Size = new System.Drawing.Size(147, 20);
            this.lReservationHistory.TabIndex = 5;
            this.lReservationHistory.TabStop = true;
            this.lReservationHistory.Text = "Reservation History";
            this.lReservationHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lReservationHistory_LinkClicked);
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(15, 5);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(718, 50);
            this.ctrlShareScreen1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(506, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(647, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 643);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lReservationHistory);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmReservationScreen";
            this.Text = "frmReservationScreen";
            this.Load += new System.EventHandler(this.frmReservationScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBookInfo.ResumeLayout(false);
            this.tabReaderInfo.ResumeLayout(false);
            this.tabReservation.ResumeLayout(false);
            this.tabReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBookInfo;
        private System.Windows.Forms.TabPage tabReaderInfo;
        private System.Windows.Forms.LinkLabel lReservationHistory;
        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabReservation;
       // private Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private Readers.ctrlFindReader ctrlFindReader2;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbReservationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chIsLock;
        private System.Windows.Forms.Label lbReaderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNextToReader;
        private Lib.Books.Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
    }
}
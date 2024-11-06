namespace Lib.Readers
{
    partial class frmUpdateReader
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReaderInfo = new System.Windows.Forms.TabPage();
            this.ctrlFindReader1 = new Lib.Readers.ctrlFindReader();
            this.tabUpdateReader = new System.Windows.Forms.TabPage();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReaderID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibraryCardNumber = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabReaderInfo.SuspendLayout();
            this.tabUpdateReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(21, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Update Reader";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReaderInfo);
            this.tabControl1.Controls.Add(this.tabUpdateReader);
            this.tabControl1.Location = new System.Drawing.Point(28, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 524);
            this.tabControl1.TabIndex = 5;
            // 
            // tabReaderInfo
            // 
            this.tabReaderInfo.Controls.Add(this.btnNext);
            this.tabReaderInfo.Controls.Add(this.ctrlFindReader1);
            this.tabReaderInfo.Location = new System.Drawing.Point(4, 22);
            this.tabReaderInfo.Name = "tabReaderInfo";
            this.tabReaderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaderInfo.Size = new System.Drawing.Size(754, 498);
            this.tabReaderInfo.TabIndex = 0;
            this.tabReaderInfo.Text = "Reader Info";
            this.tabReaderInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFindReader1
            // 
            this.ctrlFindReader1.FilterEnable = true;
            this.ctrlFindReader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindReader1.Location = new System.Drawing.Point(7, 7);
            this.ctrlFindReader1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindReader1.Name = "ctrlFindReader1";
            this.ctrlFindReader1.ReaderInfo = null;
            this.ctrlFindReader1.Size = new System.Drawing.Size(733, 446);
            this.ctrlFindReader1.TabIndex = 0;
            // 
            // tabUpdateReader
            // 
            this.tabUpdateReader.Controls.Add(this.lbDate);
            this.tabUpdateReader.Controls.Add(this.label3);
            this.tabUpdateReader.Controls.Add(this.lbReaderID);
            this.tabUpdateReader.Controls.Add(this.label6);
            this.tabUpdateReader.Controls.Add(this.lbName);
            this.tabUpdateReader.Controls.Add(this.label4);
            this.tabUpdateReader.Controls.Add(this.txtLibraryCardNumber);
            this.tabUpdateReader.Controls.Add(this.lbUsername);
            this.tabUpdateReader.Controls.Add(this.label2);
            this.tabUpdateReader.Controls.Add(this.label5);
            this.tabUpdateReader.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateReader.Name = "tabUpdateReader";
            this.tabUpdateReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateReader.Size = new System.Drawing.Size(754, 468);
            this.tabUpdateReader.TabIndex = 1;
            this.tabUpdateReader.Text = "Update Reader";
            this.tabUpdateReader.UseVisualStyleBackColor = true;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(280, 255);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(60, 25);
            this.lbDate.TabIndex = 32;
            this.lbDate.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Create Date  : ";
            // 
            // lbReaderID
            // 
            this.lbReaderID.AutoSize = true;
            this.lbReaderID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReaderID.Location = new System.Drawing.Point(280, 73);
            this.lbReaderID.Name = "lbReaderID";
            this.lbReaderID.Size = new System.Drawing.Size(60, 25);
            this.lbReaderID.TabIndex = 30;
            this.lbReaderID.Text = "[????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Reader ID : ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(280, 135);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 25);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name  : ";
            // 
            // txtLibraryCardNumber
            // 
            this.txtLibraryCardNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibraryCardNumber.Location = new System.Drawing.Point(231, 199);
            this.txtLibraryCardNumber.Name = "txtLibraryCardNumber";
            this.txtLibraryCardNumber.Size = new System.Drawing.Size(190, 32);
            this.txtLibraryCardNumber.TabIndex = 26;
            this.txtLibraryCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLibraryCardNumber_Validating_1);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(280, 301);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(60, 25);
            this.lbUsername.TabIndex = 25;
            this.lbUsername.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lib.Card.Num  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Username : ";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(632, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 31);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 589);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateReader";
            this.Text = "frmUpdateReader";
            this.Load += new System.EventHandler(this.frmUpdateReader_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabReaderInfo.ResumeLayout(false);
            this.tabUpdateReader.ResumeLayout(false);
            this.tabUpdateReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReaderInfo;
        private ctrlFindReader ctrlFindReader1;
        private System.Windows.Forms.TabPage tabUpdateReader;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbReaderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLibraryCardNumber;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace Lib.Readers
{
    partial class frmAddReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReader));
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbMode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.tabReaderInfo = new System.Windows.Forms.TabPage();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReaderID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibraryCardNumber = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonWithFilter1 = new Lib.People.ctrlPersonWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabReaderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 36);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CLose);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.Location = new System.Drawing.Point(820, 23);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(119, 25);
            this.lbMode.TabIndex = 24;
            this.lbMode.Text = "Add Reader";
            this.lbMode.Click += new System.EventHandler(this.lbMode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tabReaderInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 507);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ctrlPersonWithFilter1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 28);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(947, 475);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "tab PersonInfo";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tabReaderInfo
            // 
            this.tabReaderInfo.Controls.Add(this.lbDate);
            this.tabReaderInfo.Controls.Add(this.label3);
            this.tabReaderInfo.Controls.Add(this.lbReaderID);
            this.tabReaderInfo.Controls.Add(this.label6);
            this.tabReaderInfo.Controls.Add(this.lbName);
            this.tabReaderInfo.Controls.Add(this.label4);
            this.tabReaderInfo.Controls.Add(this.txtLibraryCardNumber);
            this.tabReaderInfo.Controls.Add(this.lbUsername);
            this.tabReaderInfo.Controls.Add(this.label2);
            this.tabReaderInfo.Controls.Add(this.label1);
            this.tabReaderInfo.Location = new System.Drawing.Point(4, 28);
            this.tabReaderInfo.Name = "tabReaderInfo";
            this.tabReaderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabReaderInfo.Size = new System.Drawing.Size(947, 475);
            this.tabReaderInfo.TabIndex = 1;
            this.tabReaderInfo.Text = "tab Reader Info";
            this.tabReaderInfo.UseVisualStyleBackColor = true;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(306, 229);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(60, 25);
            this.lbDate.TabIndex = 22;
            this.lbDate.Text = "[????]";
            this.lbDate.Click += new System.EventHandler(this.lbUserID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Create Date  : ";
            // 
            // lbReaderID
            // 
            this.lbReaderID.AutoSize = true;
            this.lbReaderID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReaderID.Location = new System.Drawing.Point(306, 47);
            this.lbReaderID.Name = "lbReaderID";
            this.lbReaderID.Size = new System.Drawing.Size(60, 25);
            this.lbReaderID.TabIndex = 20;
            this.lbReaderID.Text = "[????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Reader ID : ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(306, 109);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 25);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "[????]";
            this.lbName.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name  : ";
            // 
            // txtLibraryCardNumber
            // 
            this.txtLibraryCardNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibraryCardNumber.Location = new System.Drawing.Point(257, 173);
            this.txtLibraryCardNumber.Name = "txtLibraryCardNumber";
            this.txtLibraryCardNumber.Size = new System.Drawing.Size(190, 32);
            this.txtLibraryCardNumber.TabIndex = 16;
            this.txtLibraryCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLibraryCardNumber_Validating);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(306, 275);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(60, 25);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lib.Card.Num  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username : ";
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(758, 404);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 52);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextToAddReader);
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnable = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(7, 4);
            this.ctrlPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(903, 464);
            this.ctrlPersonWithFilter1.TabIndex = 7;
            // 
            // frmAddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 586);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddReader";
            this.Text = "frmAddReader";
            this.Load += new System.EventHandler(this.frmAddReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabReaderInfo.ResumeLayout(false);
            this.tabReaderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabReaderInfo;
        private System.Windows.Forms.TextBox txtLibraryCardNumber;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbReaderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private People.ctrlPersonWithFilter ctrlPersonWithFilter1;
    }
}
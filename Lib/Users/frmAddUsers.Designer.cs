namespace Lib
{
    partial class frmAddUsers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabUserInfo = new System.Windows.Forms.TabPage();
            this.lbPermission = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbMode = new System.Windows.Forms.Label();
            this.ctrlPersonWithFilter1 = new Lib.People.ctrlPersonWithFilter();
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(11, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tabUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 507);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ctrlPersonWithFilter1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 28);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(911, 475);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "tab PersonInfo";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            this.tabPersonInfo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(763, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 39);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.Controls.Add(this.lbPermission);
            this.tabUserInfo.Controls.Add(this.label5);
            this.tabUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tabUserInfo.Controls.Add(this.label4);
            this.tabUserInfo.Controls.Add(this.txtPassword);
            this.tabUserInfo.Controls.Add(this.txtUsername);
            this.tabUserInfo.Controls.Add(this.lbUserID);
            this.tabUserInfo.Controls.Add(this.chIsActive);
            this.tabUserInfo.Controls.Add(this.label3);
            this.tabUserInfo.Controls.Add(this.label2);
            this.tabUserInfo.Controls.Add(this.label1);
            this.tabUserInfo.Location = new System.Drawing.Point(4, 28);
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserInfo.Size = new System.Drawing.Size(911, 475);
            this.tabUserInfo.TabIndex = 1;
            this.tabUserInfo.Text = "tab UserInfo";
            this.tabUserInfo.UseVisualStyleBackColor = true;
            this.tabUserInfo.Click += new System.EventHandler(this.tabUserInfo_Click);
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermission.ForeColor = System.Drawing.Color.Blue;
            this.lbPermission.Location = new System.Drawing.Point(433, 332);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(23, 25);
            this.lbPermission.TabIndex = 21;
            this.lbPermission.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Permission :  ";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(343, 224);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(190, 32);
            this.txtConfirmPassword.TabIndex = 19;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(343, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 32);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(343, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(190, 32);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(412, 72);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(60, 25);
            this.lbUserID.TabIndex = 15;
            this.lbUserID.Text = "[????]";
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsActive.Location = new System.Drawing.Point(131, 281);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(108, 29);
            this.chIsActive.TabIndex = 14;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "User name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID : ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(184, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.Location = new System.Drawing.Point(790, 21);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(96, 25);
            this.lbMode.TabIndex = 16;
            this.lbMode.Text = "Add User";
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnable = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(-1, 6);
            this.ctrlPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(903, 462);
            this.ctrlPersonWithFilter1.TabIndex = 7;
            // 
            // frmAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 571);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUsers";
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabUserInfo.ResumeLayout(false);
            this.tabUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUserInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.Button btnNext;
        private People.ctrlPersonWithFilter ctrlPersonWithFilter1;
    }
}
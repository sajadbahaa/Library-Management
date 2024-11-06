namespace ctrlAddUser
{
    partial class ctrlAddUsers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddUsers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new ctrlPersonCardWithFilter.ctrlPersonCardWithFilter();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.lbPermission = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tabAddUser);
            this.tabControl1.Location = new System.Drawing.Point(3, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1034, 480);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            this.tabPersonInfo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(799, 410);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(217, 54);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextToAddUserInfo);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnable = false;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(8, 8);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1019, 467);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.chIsActive);
            this.tabAddUser.Controls.Add(this.lbPermission);
            this.tabAddUser.Controls.Add(this.label5);
            this.tabAddUser.Controls.Add(this.txtConfirmPassword);
            this.tabAddUser.Controls.Add(this.txtPassword);
            this.tabAddUser.Controls.Add(this.txtUsername);
            this.tabAddUser.Controls.Add(this.lbUserID);
            this.tabAddUser.Controls.Add(this.label3);
            this.tabAddUser.Controls.Add(this.label4);
            this.tabAddUser.Controls.Add(this.label2);
            this.tabAddUser.Controls.Add(this.label1);
            this.tabAddUser.Location = new System.Drawing.Point(4, 29);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(1034, 480);
            this.tabAddUser.TabIndex = 1;
            this.tabAddUser.Text = "Add Users";
            this.tabAddUser.UseVisualStyleBackColor = true;
            this.tabAddUser.Click += new System.EventHandler(this.tabAddUser_Click);
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsActive.Location = new System.Drawing.Point(189, 297);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(112, 29);
            this.chIsActive.TabIndex = 10;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Location = new System.Drawing.Point(204, 354);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(18, 20);
            this.lbPermission.TabIndex = 9;
            this.lbPermission.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Permission : ";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(189, 242);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(187, 33);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 187);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 33);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(189, 134);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 33);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(185, 89);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(18, 20);
            this.lbUserID.TabIndex = 4;
            this.lbUserID.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbMode);
            this.panel1.Location = new System.Drawing.Point(361, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 48);
            this.panel1.TabIndex = 1;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.ForeColor = System.Drawing.Color.Crimson;
            this.lbMode.Location = new System.Drawing.Point(99, 11);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(76, 20);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "Add User";
            this.lbMode.Click += new System.EventHandler(this.lbMode_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(888, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlAddUsers";
            this.Size = new System.Drawing.Size(1048, 578);
            this.Load += new System.EventHandler(this.ctrlAddUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.tabAddUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMode;
        private ctrlPersonCardWithFilter.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chIsActive;
    }
}

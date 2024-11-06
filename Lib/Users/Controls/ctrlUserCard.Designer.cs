namespace Lib.Users
{
    partial class ctrlUserCard
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
            this.ctrlPersoninfo1 = new ctrlPersonCard.ctrlPersoninfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPermission = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersoninfo1
            // 
            this.ctrlPersoninfo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersoninfo1.Location = new System.Drawing.Point(20, 5);
            this.ctrlPersoninfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersoninfo1.Name = "ctrlPersoninfo1";
            this.ctrlPersoninfo1.Size = new System.Drawing.Size(722, 366);
            this.ctrlPersoninfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPermission);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbIsActive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID  : ";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(78, 48);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(36, 20);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "???";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(280, 48);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(36, 20);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username : ";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(473, 48);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(36, 20);
            this.lbIsActive.TabIndex = 5;
            this.lbIsActive.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Is Active : ";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Location = new System.Drawing.Point(708, 48);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(36, 20);
            this.lbPermission.TabIndex = 7;
            this.lbPermission.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Permission : ";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersoninfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(825, 498);
            this.Load += new System.EventHandler(this.ctrlUserCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard.ctrlPersoninfo ctrlPersoninfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label6;
    }
}

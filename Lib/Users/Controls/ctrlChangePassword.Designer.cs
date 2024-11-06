namespace Lib.Users.Controls
{
    partial class ctrlChangePassword
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
            this.ctrlUserCard1 = new Lib.Users.ctrlUserCard();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConfiPas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPas = new System.Windows.Forms.TextBox();
            this.txtCurrentPas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserCard1.Location = new System.Drawing.Point(4, 0);
            this.ctrlUserCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(809, 498);
            this.ctrlUserCard1.TabIndex = 0;
            this.ctrlUserCard1.UserID = 0;
            this.ctrlUserCard1.UserInfo = null;
            this.ctrlUserCard1.Load += new System.EventHandler(this.ctrlUserCard1_Load);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save);
            // 
            // txtConfiPas
            // 
            this.txtConfiPas.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfiPas.Location = new System.Drawing.Point(243, 609);
            this.txtConfiPas.Name = "txtConfiPas";
            this.txtConfiPas.PasswordChar = '*';
            this.txtConfiPas.Size = new System.Drawing.Size(190, 32);
            this.txtConfiPas.TabIndex = 31;
            this.txtConfiPas.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Confirm Password : ";
            // 
            // txtNewPas
            // 
            this.txtNewPas.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPas.Location = new System.Drawing.Point(243, 560);
            this.txtNewPas.Name = "txtNewPas";
            this.txtNewPas.PasswordChar = '*';
            this.txtNewPas.Size = new System.Drawing.Size(190, 32);
            this.txtNewPas.TabIndex = 29;
            // 
            // txtCurrentPas
            // 
            this.txtCurrentPas.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPas.Location = new System.Drawing.Point(243, 510);
            this.txtCurrentPas.Name = "txtCurrentPas";
            this.txtCurrentPas.PasswordChar = '*';
            this.txtCurrentPas.Size = new System.Drawing.Size(190, 32);
            this.txtCurrentPas.TabIndex = 28;
            this.txtCurrentPas.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "New Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Current Password : ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConfiPas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPas);
            this.Controls.Add(this.txtCurrentPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlUserCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlChangePassword";
            this.Size = new System.Drawing.Size(824, 660);
            this.Load += new System.EventHandler(this.ctrlChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConfiPas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPas;
        private System.Windows.Forms.TextBox txtCurrentPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

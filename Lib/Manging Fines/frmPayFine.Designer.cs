namespace Lib.Manging_Fines
{
    partial class frmPayFine
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
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlFindFineWithFilter1 = new Lib.Manging_Fines.Controls.ctrlFindFineWithFilter();
            this.chIsPay = new System.Windows.Forms.CheckBox();
            this.btnPayFine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(85, 12);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(757, 44);
            this.ctrlShareScreen1.TabIndex = 0;
            // 
            // ctrlFindFineWithFilter1
            // 
            this.ctrlFindFineWithFilter1.FilterEnable = true;
            this.ctrlFindFineWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindFineWithFilter1.Location = new System.Drawing.Point(12, 108);
            this.ctrlFindFineWithFilter1.Name = "ctrlFindFineWithFilter1";
            this.ctrlFindFineWithFilter1.Size = new System.Drawing.Size(925, 491);
            this.ctrlFindFineWithFilter1.TabIndex = 1;
            this.ctrlFindFineWithFilter1.OnFineInfoSelected += new System.Action<LibBussiness.clsFines>(this.ctrlFindFineWithFilter1_OnFineInfoSelected);
            // 
            // chIsPay
            // 
            this.chIsPay.AutoSize = true;
            this.chIsPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsPay.Location = new System.Drawing.Point(28, 622);
            this.chIsPay.Name = "chIsPay";
            this.chIsPay.Size = new System.Drawing.Size(91, 24);
            this.chIsPay.TabIndex = 2;
            this.chIsPay.Text = "Pay FIne";
            this.chIsPay.UseVisualStyleBackColor = true;
            // 
            // btnPayFine
            // 
            this.btnPayFine.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFine.Location = new System.Drawing.Point(798, 606);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(130, 40);
            this.btnPayFine.TabIndex = 3;
            this.btnPayFine.Text = "Pay Fine";
            this.btnPayFine.UseVisualStyleBackColor = true;
            this.btnPayFine.Click += new System.EventHandler(this.OnbtnPayFine);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(652, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(577, 131);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(265, 25);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "this Fine has been Locked";
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 661);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.chIsPay);
            this.Controls.Add(this.ctrlFindFineWithFilter1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmPayFine";
            this.Text = "frmPayFine";
            this.Load += new System.EventHandler(this.frmPayFine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Controls.ctrlFindFineWithFilter ctrlFindFineWithFilter1;
        private System.Windows.Forms.CheckBox chIsPay;
        private System.Windows.Forms.Button btnPayFine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbMessage;
    }
}
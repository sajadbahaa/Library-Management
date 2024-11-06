namespace Lib.Manging_Fines
{
    partial class frmShowFineInfo
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
            this.ctrlFineInfo1 = new Lib.Manging_Fines.ctrlFineInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(15, 15);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(757, 50);
            this.ctrlShareScreen1.TabIndex = 0;
            this.ctrlShareScreen1.Load += new System.EventHandler(this.ctrlShareScreen1_Load);
            // 
            // ctrlFineInfo1
            // 
            this.ctrlFineInfo1.Location = new System.Drawing.Point(12, 74);
            this.ctrlFineInfo1.Name = "ctrlFineInfo1";
            this.ctrlFineInfo1.Size = new System.Drawing.Size(791, 370);
            this.ctrlFineInfo1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(323, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // frmShowFineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 507);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlFineInfo1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmShowFineInfo";
            this.Text = "frmShowFineInfo";
            this.Load += new System.EventHandler(this.frmShowFineInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private ctrlFineInfo ctrlFineInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}
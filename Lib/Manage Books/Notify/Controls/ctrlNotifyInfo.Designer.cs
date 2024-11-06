namespace Lib.Manage_Books.Notify.Controls
{
    partial class ctrlNotifyInfo
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
            this.lbNotifyName = new System.Windows.Forms.Label();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.SuspendLayout();
            // 
            // lbNotifyName
            // 
            this.lbNotifyName.AutoSize = true;
            this.lbNotifyName.Location = new System.Drawing.Point(136, 73);
            this.lbNotifyName.Name = "lbNotifyName";
            this.lbNotifyName.Size = new System.Drawing.Size(78, 16);
            this.lbNotifyName.TabIndex = 0;
            this.lbNotifyName.Text = "NotifyName";
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(6, 6);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(803, 42);
            this.ctrlShareScreen1.TabIndex = 1;
            // 
            // ctrlNotifyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlShareScreen1);
            this.Controls.Add(this.lbNotifyName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlNotifyInfo";
            this.Size = new System.Drawing.Size(815, 115);
            this.Load += new System.EventHandler(this.ctrlNotifyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotifyName;
        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
    }
}

namespace Lib.Manage_Books.Notify
{
    partial class frmShowNotifyInfo
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
            this.ctrlNotifyInfo1 = new Lib.Manage_Books.Notify.Controls.ctrlNotifyInfo();
            this.SuspendLayout();
            // 
            // ctrlNotifyInfo1
            // 
            this.ctrlNotifyInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlNotifyInfo1.Location = new System.Drawing.Point(10, 13);
            this.ctrlNotifyInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlNotifyInfo1.Name = "ctrlNotifyInfo1";
            this.ctrlNotifyInfo1.Size = new System.Drawing.Size(828, 115);
            this.ctrlNotifyInfo1.TabIndex = 0;
            // 
            // frmShowNotifyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 141);
            this.Controls.Add(this.ctrlNotifyInfo1);
            this.Name = "frmShowNotifyInfo";
            this.Text = "frmShowNotifyInfo";
            this.Load += new System.EventHandler(this.frmShowNotifyInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlNotifyInfo ctrlNotifyInfo1;
    }
}
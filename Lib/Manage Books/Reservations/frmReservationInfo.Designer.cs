namespace Lib.Manage_Books.Reservations
{
    partial class frmReservationInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlReservationInfo1 = new Lib.Manage_Books.Reservations.ctrlReservationInfo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(2, 1);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(718, 50);
            this.ctrlShareScreen1.TabIndex = 2;
            // 
            // ctrlReservationInfo1
            // 
            this.ctrlReservationInfo1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReservationInfo1.Location = new System.Drawing.Point(2, 42);
            this.ctrlReservationInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlReservationInfo1.Name = "ctrlReservationInfo1";
            this.ctrlReservationInfo1.Size = new System.Drawing.Size(781, 599);
            this.ctrlReservationInfo1.TabIndex = 0;
            // 
            // frmReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 633);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlReservationInfo1);
            this.Name = "frmReservationInfo";
            this.Text = "frmReservationInfo";
            this.Load += new System.EventHandler(this.frmReservationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlReservationInfo ctrlReservationInfo1;
        private System.Windows.Forms.Button button1;
        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
    }
}
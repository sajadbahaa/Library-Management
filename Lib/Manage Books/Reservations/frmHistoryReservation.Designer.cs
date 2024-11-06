namespace Lib.Manage_Books.Reservations
{
    partial class frmHistoryReservation
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
            this.ctrlReservationHistory1 = new Lib.Manage_Books.Reservations.Controls.ctrlReservationHistory();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.SuspendLayout();
            // 
            // ctrlReservationHistory1
            // 
            this.ctrlReservationHistory1.Location = new System.Drawing.Point(4, 47);
            this.ctrlReservationHistory1.Name = "ctrlReservationHistory1";
            this.ctrlReservationHistory1.Size = new System.Drawing.Size(796, 585);
            this.ctrlReservationHistory1.TabIndex = 1;
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(4, 3);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(741, 50);
            this.ctrlShareScreen1.TabIndex = 0;
            // 
            // frmHistoryReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 666);
            this.Controls.Add(this.ctrlReservationHistory1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmHistoryReservation";
            this.Text = "frmHistoryReservation";
            this.Load += new System.EventHandler(this.frmHistoryReservation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Controls.ctrlReservationHistory ctrlReservationHistory1;
    }
}
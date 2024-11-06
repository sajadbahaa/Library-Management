namespace Lib.Manage_Books.Borrowing.RetrievBooks
{
    partial class frmFindReservation
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
            this.ctrlFindReservationWithFilters1 = new Lib.Manage_Books.Reservations.Controls.ctrlFindReservationWithFilters();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CLose);
            // 
            // ctrlFindReservationWithFilters1
            // 
            this.ctrlFindReservationWithFilters1.FilterEnable = true;
            this.ctrlFindReservationWithFilters1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindReservationWithFilters1.Location = new System.Drawing.Point(13, 14);
            this.ctrlFindReservationWithFilters1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFindReservationWithFilters1.Name = "ctrlFindReservationWithFilters1";
            this.ctrlFindReservationWithFilters1.Size = new System.Drawing.Size(792, 621);
            this.ctrlFindReservationWithFilters1.TabIndex = 2;
            // 
            // frmFindReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 674);
            this.Controls.Add(this.ctrlFindReservationWithFilters1);
            this.Controls.Add(this.button1);
            this.Name = "frmFindReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindReservation";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Reservations.Controls.ctrlFindReservationWithFilters ctrlFindReservationWithFilters1;
    }
}
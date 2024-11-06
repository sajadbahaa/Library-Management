namespace Lib.Manage_Books.Reservations.Controls
{
    partial class ctrlReservationHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlPersoninfo1 = new ctrlPersonCard.ctrlPersoninfo();
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrlPersoninfo1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ctrlPersoninfo1
            // 
            this.ctrlPersoninfo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersoninfo1.Location = new System.Drawing.Point(4, 14);
            this.ctrlPersoninfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersoninfo1.Name = "ctrlPersoninfo1";
            this.ctrlPersoninfo1.Size = new System.Drawing.Size(720, 366);
            this.ctrlPersoninfo1.TabIndex = 0;
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AllowUserToOrderColumns = true;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgview.Location = new System.Drawing.Point(0, 383);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(730, 158);
            this.dtgview.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(91, 555);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(36, 20);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "???";
            // 
            // ctrlReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgview);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlReservationHistory";
            this.Size = new System.Drawing.Size(730, 585);
            this.Load += new System.EventHandler(this.ctrlReservationHistory_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgview;
        private ctrlPersonCard.ctrlPersoninfo ctrlPersoninfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
    }
}

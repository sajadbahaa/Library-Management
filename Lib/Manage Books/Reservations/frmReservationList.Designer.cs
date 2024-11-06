namespace Lib
{
    partial class frmReservationList
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
            this.components = new System.ComponentModel.Container();
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showReservationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbIsLock = new System.Windows.Forms.ComboBox();
            this.btnnotifycation = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AllowUserToOrderColumns = true;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgview.Location = new System.Drawing.Point(12, 142);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(776, 226);
            this.dtgview.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReservationInfoToolStripMenuItem,
            this.addReservationToolStripMenuItem,
            this.findReservationToolStripMenuItem,
            this.btnnotifycation});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showReservationInfoToolStripMenuItem
            // 
            this.showReservationInfoToolStripMenuItem.Name = "showReservationInfoToolStripMenuItem";
            this.showReservationInfoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showReservationInfoToolStripMenuItem.Text = "Show Reservation Info";
            this.showReservationInfoToolStripMenuItem.Click += new System.EventHandler(this.showReservationInfoToolStripMenuItem_Click);
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addReservationToolStripMenuItem.Text = "Add Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // findReservationToolStripMenuItem
            // 
            this.findReservationToolStripMenuItem.Name = "findReservationToolStripMenuItem";
            this.findReservationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.findReservationToolStripMenuItem.Text = "Find Reservation";
            this.findReservationToolStripMenuItem.Click += new System.EventHandler(this.findReservationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(157, 404);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(19, 21);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "0";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "ReservationID",
            "ReaderID",
            "CopyID",
            "IsLock"});
            this.cbFilter.Location = new System.Drawing.Point(126, 93);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter BY : ";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(301, 93);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(174, 21);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbIsLock
            // 
            this.cbIsLock.FormattingEnabled = true;
            this.cbIsLock.Items.AddRange(new object[] {
            "All",
            "yes",
            "no"});
            this.cbIsLock.Location = new System.Drawing.Point(301, 92);
            this.cbIsLock.Name = "cbIsLock";
            this.cbIsLock.Size = new System.Drawing.Size(100, 21);
            this.cbIsLock.TabIndex = 6;
            this.cbIsLock.SelectedIndexChanged += new System.EventHandler(this.cbIsLock_SelectedIndexChanged);
            // 
            // btnnotifycation
            // 
            this.btnnotifycation.Name = "btnnotifycation";
            this.btnnotifycation.Size = new System.Drawing.Size(191, 22);
            this.btnnotifycation.Text = "Notifycation";
            this.btnnotifycation.Click += new System.EventHandler(this.notifycationToolStripMenuItem_Click);
            // 
            // frmReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.cbIsLock);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgview);
            this.Name = "frmReservationList";
            this.Text = "frmReservationList";
            this.Load += new System.EventHandler(this.frmReservationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showReservationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReservationToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbIsLock;
        private System.Windows.Forms.ToolStripMenuItem btnnotifycation;
    }
}
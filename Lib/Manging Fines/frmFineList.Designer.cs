namespace Lib.Manging_Fines
{
    partial class frmFineList
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
            this.btnShowFine = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.hisoryOfReaderFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgview.Location = new System.Drawing.Point(12, 106);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(993, 281);
            this.dtgview.TabIndex = 0;
            this.dtgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowFine,
            this.btnpayFine,
            this.hisoryOfReaderFinesToolStripMenuItem,
            this.findFineToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnShowFine
            // 
            this.btnShowFine.Name = "btnShowFine";
            this.btnShowFine.Size = new System.Drawing.Size(193, 22);
            this.btnShowFine.Text = "Show Fine";
            this.btnShowFine.Click += new System.EventHandler(this.showFineToolStripMenuItem_Click);
            // 
            // btnpayFine
            // 
            this.btnpayFine.Name = "btnpayFine";
            this.btnpayFine.Size = new System.Drawing.Size(193, 22);
            this.btnpayFine.Text = "PayFine";
            this.btnpayFine.Click += new System.EventHandler(this.btnpayFine_Click);
            // 
            // hisoryOfReaderFinesToolStripMenuItem
            // 
            this.hisoryOfReaderFinesToolStripMenuItem.Name = "hisoryOfReaderFinesToolStripMenuItem";
            this.hisoryOfReaderFinesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hisoryOfReaderFinesToolStripMenuItem.Text = "Hisory Of Reader Fines";
            this.hisoryOfReaderFinesToolStripMenuItem.Click += new System.EventHandler(this.hisoryOfReaderFinesToolStripMenuItem_Click);
            // 
            // findFineToolStripMenuItem
            // 
            this.findFineToolStripMenuItem.Name = "findFineToolStripMenuItem";
            this.findFineToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.findFineToolStripMenuItem.Text = "Find Fine";
            this.findFineToolStripMenuItem.Click += new System.EventHandler(this.findFineToolStripMenuItem_Click);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(164, 406);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(18, 20);
            this.lbRecord.TabIndex = 7;
            this.lbRecord.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Record : ";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(886, 58);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 31);
            this.button.TabIndex = 8;
            this.button.Text = "Pay Fine";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.OnPayFine);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmFineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgview);
            this.Name = "frmFineList";
            this.Text = "frmFineList";
            this.Load += new System.EventHandler(this.frmFineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnShowFine;
        private System.Windows.Forms.ToolStripMenuItem btnpayFine;
        private System.Windows.Forms.ToolStripMenuItem hisoryOfReaderFinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
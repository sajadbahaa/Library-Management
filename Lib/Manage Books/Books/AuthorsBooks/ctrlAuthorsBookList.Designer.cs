namespace Lib.Books.AuthorsBooks
{
    partial class ctrlAuthorsBookList
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
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlPersoninfo1 = new ctrlPersonCard.ctrlPersoninfo();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AllowUserToOrderColumns = true;
            this.dtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.Location = new System.Drawing.Point(6, 27);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(555, 174);
            this.dtgview.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Books : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Location = new System.Drawing.Point(175, 217);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(19, 21);
            this.lbRecord.TabIndex = 3;
            this.lbRecord.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgview);
            this.groupBox1.Controls.Add(this.lbRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Writer";
            // 
            // ctrlPersoninfo1
            // 
            this.ctrlPersoninfo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersoninfo1.Location = new System.Drawing.Point(4, 0);
            this.ctrlPersoninfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersoninfo1.Name = "ctrlPersoninfo1";
            this.ctrlPersoninfo1.Size = new System.Drawing.Size(722, 366);
            this.ctrlPersoninfo1.TabIndex = 5;
            // 
            // ctrlAuthorsBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersoninfo1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ctrlAuthorsBookList";
            this.Size = new System.Drawing.Size(737, 620);
            this.Load += new System.EventHandler(this.ctrlAuthorsBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrlPersonCard.ctrlPersoninfo ctrlPersoninfo1;
    }
}

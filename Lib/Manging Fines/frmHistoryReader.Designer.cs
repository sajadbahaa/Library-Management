namespace Lib.Manging_Fines
{
    partial class frmHistoryReader
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
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlReaderCard1 = new Lib.Readers.ctrlReaderCard();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.Location = new System.Drawing.Point(6, 510);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(871, 187);
            this.dtgview.TabIndex = 0;
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(31, 5);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(733, 47);
            this.ctrlShareScreen1.TabIndex = 3;
            // 
            // ctrlReaderCard1
            // 
            this.ctrlReaderCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReaderCard1.Location = new System.Drawing.Point(12, 51);
            this.ctrlReaderCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReaderCard1.Name = "ctrlReaderCard1";
            this.ctrlReaderCard1.Size = new System.Drawing.Size(782, 451);
            this.ctrlReaderCard1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Record : ";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(91, 715);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(18, 20);
            this.lbRecord.TabIndex = 5;
            this.lbRecord.Text = "0";
            // 
            // frmHistoryReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 749);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Controls.Add(this.ctrlReaderCard1);
            this.Controls.Add(this.dtgview);
            this.Name = "frmHistoryReader";
            this.Text = "frmHistoryReader";
            this.Load += new System.EventHandler(this.frmHistoryReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgview;
        private Readers.ctrlReaderCard ctrlReaderCard1;
        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
    }
}
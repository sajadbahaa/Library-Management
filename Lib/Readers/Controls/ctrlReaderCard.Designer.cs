namespace Lib.Readers
{
    partial class ctrlReaderCard
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
            this.ctrlPersoninfo1 = new ctrlPersonCard.ctrlPersoninfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHasFine = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblibCardNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbReaderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersoninfo1
            // 
            this.ctrlPersoninfo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersoninfo1.Location = new System.Drawing.Point(9, 9);
            this.ctrlPersoninfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersoninfo1.Name = "ctrlPersoninfo1";
            this.ctrlPersoninfo1.Size = new System.Drawing.Size(722, 366);
            this.ctrlPersoninfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHasFine);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblibCardNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbReaderID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader Card";
            // 
            // lbHasFine
            // 
            this.lbHasFine.AutoSize = true;
            this.lbHasFine.Location = new System.Drawing.Point(674, 32);
            this.lbHasFine.Name = "lbHasFine";
            this.lbHasFine.Size = new System.Drawing.Size(36, 20);
            this.lbHasFine.TabIndex = 7;
            this.lbHasFine.Text = "???";
            this.lbHasFine.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Has Fine  : ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(477, 30);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 20);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblibCardNum
            // 
            this.lblibCardNum.AutoSize = true;
            this.lblibCardNum.Location = new System.Drawing.Point(325, 30);
            this.lblibCardNum.Name = "lblibCardNum";
            this.lblibCardNum.Size = new System.Drawing.Size(36, 20);
            this.lblibCardNum.TabIndex = 3;
            this.lblibCardNum.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "lib.Card.Number : ";
            // 
            // lbReaderID
            // 
            this.lbReaderID.AutoSize = true;
            this.lbReaderID.Location = new System.Drawing.Point(99, 30);
            this.lbReaderID.Name = "lbReaderID";
            this.lbReaderID.Size = new System.Drawing.Size(36, 20);
            this.lbReaderID.TabIndex = 1;
            this.lbReaderID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID : ";
            // 
            // ctrlReaderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersoninfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlReaderCard";
            this.Size = new System.Drawing.Size(788, 450);
            this.Load += new System.EventHandler(this.ctrlReaderCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard.ctrlPersoninfo ctrlPersoninfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblibCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbReaderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHasFine;
        private System.Windows.Forms.Label label7;
    }
}

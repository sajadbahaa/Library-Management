namespace Lib.Manage_Books.Reservations
{
    partial class ctrlReservationInfo
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
            this.lbBookName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReservID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlReaderCard1 = new Lib.Readers.ctrlReaderCard();
            this.lbIsLock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Controls.Add(this.lbIsLock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbBookName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbReservID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctrlReaderCard1);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(127, 477);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(34, 21);
            this.lbBookName.TabIndex = 12;
            this.lbBookName.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(800, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "???";
            // 
            // lbReservID
            // 
            this.lbReservID.AutoSize = true;
            this.lbReservID.Location = new System.Drawing.Point(703, 484);
            this.lbReservID.Name = "lbReservID";
            this.lbReservID.Size = new System.Drawing.Size(34, 21);
            this.lbReservID.TabIndex = 8;
            this.lbReservID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reservation ID : ";
            // 
            // ctrlReaderCard1
            // 
            this.ctrlReaderCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReaderCard1.Location = new System.Drawing.Point(8, 22);
            this.ctrlReaderCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReaderCard1.Name = "ctrlReaderCard1";
            this.ctrlReaderCard1.Size = new System.Drawing.Size(732, 450);
            this.ctrlReaderCard1.TabIndex = 6;
            // 
            // lbIsLock
            // 
            this.lbIsLock.AutoSize = true;
            this.lbIsLock.Location = new System.Drawing.Point(128, 20);
            this.lbIsLock.Name = "lbIsLock";
            this.lbIsLock.Size = new System.Drawing.Size(34, 21);
            this.lbIsLock.TabIndex = 15;
            this.lbIsLock.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Is Locked : ";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(246, 19);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(273, 21);
            this.lbMessage.TabIndex = 16;
            this.lbMessage.Text = "this Reservation Has been Un Lock";
            // 
            // ctrlReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlReservationInfo";
            this.Size = new System.Drawing.Size(781, 529);
            this.Load += new System.EventHandler(this.ctrlReservationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Readers.ctrlReaderCard ctrlReaderCard1;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbReservID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIsLock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMessage;
    }
}

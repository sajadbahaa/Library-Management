namespace Lib.Readers
{
    partial class frmShowReaderInfo
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
            this.ctrlReaderCard1 = new Lib.Readers.ctrlReaderCard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // ctrlReaderCard1
            // 
            this.ctrlReaderCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReaderCard1.Location = new System.Drawing.Point(13, 14);
            this.ctrlReaderCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReaderCard1.Name = "ctrlReaderCard1";
            this.ctrlReaderCard1.Size = new System.Drawing.Size(891, 499);
            this.ctrlReaderCard1.TabIndex = 0;
            // 
            // frmShowReaderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlReaderCard1);
            this.Name = "frmShowReaderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowReaderInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlReaderCard ctrlReaderCard1;
        private System.Windows.Forms.Button button1;
    }
}
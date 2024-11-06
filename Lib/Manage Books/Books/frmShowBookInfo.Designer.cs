namespace Lib.Books
{
    partial class frmShowBookInfo
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
            this.ctrlBookInfo1 = new Lib.Books.Controls.ctrlBookInfo();
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookInfo1.Location = new System.Drawing.Point(10, 68);
            this.ctrlBookInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(675, 329);
            this.ctrlBookInfo1.TabIndex = 1;
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(1, 2);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(711, 45);
            this.ctrlShareScreen1.TabIndex = 0;
            // 
            // frmShowBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlBookInfo1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowBookInfo";
            this.Text = "frmShowBookInfo";
            this.Load += new System.EventHandler(this.frmShowBookInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Controls.ctrlBookInfo ctrlBookInfo1;
        private System.Windows.Forms.Button button1;
    }
}
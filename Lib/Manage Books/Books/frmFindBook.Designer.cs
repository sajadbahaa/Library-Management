namespace Lib.Books
{
    partial class frmFindBook
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
            this.ctrlBookInfoWithFilter1 = new Lib.Books.Controls.ctrlBookInfoWithFilter();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.FilterEnable = true;
            this.ctrlBookInfoWithFilter1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(55, 31);
            this.ctrlBookInfoWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(678, 405);
            this.ctrlBookInfoWithFilter1.TabIndex = 0;
            this.ctrlBookInfoWithFilter1.OnBookCopySelected += new System.EventHandler<Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo>(this.ctrlBookInfoWithFilter1_OnBookCopySelected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.Name = "frmFindBook";
            this.Text = "frmFindBook";
            this.Load += new System.EventHandler(this.frmFindBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.Button button1;
    }
}
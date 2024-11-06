namespace Lib.People
{
    partial class frmFindPerson
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
            this.ctrlPersonWithFilter1 = new Lib.People.ctrlPersonWithFilter();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnable = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(31, 12);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(735, 440);
            this.ctrlPersonWithFilter1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlPersonWithFilter1);
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonWithFilter ctrlPersonWithFilter1;
        private System.Windows.Forms.Button button1;
    }
}
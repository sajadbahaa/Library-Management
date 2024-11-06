namespace Lib.People
{
    partial class frmAddPerson
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
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlAddPerson1 = new ctrlAddPerson.ctrlAddPerson();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(309, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Close);
            // 
            // ctrlAddPerson1
            // 
            this.ctrlAddPerson1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAddPerson1.Location = new System.Drawing.Point(14, 34);
            this.ctrlAddPerson1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAddPerson1.Name = "ctrlAddPerson1";
            this.ctrlAddPerson1.Size = new System.Drawing.Size(739, 546);
            this.ctrlAddPerson1.TabIndex = 10;
            this.ctrlAddPerson1.Load += new System.EventHandler(this.ctrlAddPerson1_Load);
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 637);
            this.Controls.Add(this.ctrlAddPerson1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPerson";
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.Button btnSave;
        private ctrlAddPerson.ctrlAddPerson ctrlAddPerson1;
    }
}
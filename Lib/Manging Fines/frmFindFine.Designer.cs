namespace Lib.Manging_Fines
{
    partial class frmFindFine
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
            this.ctrlShareScreen1 = new Lib.ControlPublic.ctrlShareScreen();
            this.ctrlFindFineWithFilter1 = new Lib.Manging_Fines.Controls.ctrlFindFineWithFilter();
            this.SuspendLayout();
            // 
            // ctrlShareScreen1
            // 
            this.ctrlShareScreen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShareScreen1.Location = new System.Drawing.Point(15, 15);
            this.ctrlShareScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlShareScreen1.Name = "ctrlShareScreen1";
            this.ctrlShareScreen1.Size = new System.Drawing.Size(757, 50);
            this.ctrlShareScreen1.TabIndex = 0;
            this.ctrlShareScreen1.Load += new System.EventHandler(this.ctrlShareScreen1_Load);
            // 
            // ctrlFindFineWithFilter1
            // 
            this.ctrlFindFineWithFilter1.FilterEnable = true;
            this.ctrlFindFineWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindFineWithFilter1.Location = new System.Drawing.Point(15, 92);
            this.ctrlFindFineWithFilter1.Name = "ctrlFindFineWithFilter1";
            this.ctrlFindFineWithFilter1.Size = new System.Drawing.Size(925, 504);
            this.ctrlFindFineWithFilter1.TabIndex = 1;
            this.ctrlFindFineWithFilter1.OnFineInfoSelected += new System.Action<LibBussiness.clsFines>(this.ctrlFindFineWithFilter1_OnFineInfoSelected);
            // 
            // frmFindFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 678);
            this.Controls.Add(this.ctrlFindFineWithFilter1);
            this.Controls.Add(this.ctrlShareScreen1);
            this.Name = "frmFindFine";
            this.Text = "frmFindFine";
            this.Load += new System.EventHandler(this.frmFindFine_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPublic.ctrlShareScreen ctrlShareScreen1;
        private Controls.ctrlFindFineWithFilter ctrlFindFineWithFilter1;
    }
}
namespace Lib.Books
{
    partial class frmAddBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBook));
            this.lbMode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabFindAuthor = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.ctrlPersonWithFilter1 = new Lib.People.ctrlPersonWithFilter();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGenr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbPhilosoPhy = new System.Windows.Forms.RadioButton();
            this.rbHistorical = new System.Windows.Forms.RadioButton();
            this.rbPsycology = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.leditImage = new System.Windows.Forms.LinkLabel();
            this.lRemove = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.lbAuthorID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBookCopy = new System.Windows.Forms.TabPage();
            this.lbQuantityBook = new System.Windows.Forms.Label();
            this.chIsAvailable = new System.Windows.Forms.CheckBox();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBookCopyID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabFindAuthor.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabBookCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Location = new System.Drawing.Point(101, 6);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(77, 21);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "Add Book";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lbMode);
            this.panel1.Location = new System.Drawing.Point(413, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 32);
            this.panel1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabFindAuthor
            // 
            this.tabFindAuthor.Controls.Add(this.button3);
            this.tabFindAuthor.Controls.Add(this.ctrlPersonWithFilter1);
            this.tabFindAuthor.Controls.Add(this.label4);
            this.tabFindAuthor.Location = new System.Drawing.Point(4, 30);
            this.tabFindAuthor.Name = "tabFindAuthor";
            this.tabFindAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindAuthor.Size = new System.Drawing.Size(1154, 528);
            this.tabFindAuthor.TabIndex = 1;
            this.tabFindAuthor.Text = "Find Author";
            this.tabFindAuthor.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(937, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "Next";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NextToAddBook);
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnable = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(7, 8);
            this.ctrlPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(1140, 515);
            this.ctrlPersonWithFilter1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFindAuthor);
            this.tabControl1.Controls.Add(this.tabBook);
            this.tabControl1.Controls.Add(this.tabBookCopy);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 562);
            this.tabControl1.TabIndex = 7;
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.groupBox1);
            this.tabBook.Location = new System.Drawing.Point(4, 30);
            this.tabBook.Name = "tabBook";
            this.tabBook.Size = new System.Drawing.Size(1154, 528);
            this.tabBook.TabIndex = 2;
            this.tabBook.Text = "Add/Update Book";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGenr);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gbGenre);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAddInfo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.leditImage);
            this.groupBox1.Controls.Add(this.lRemove);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.lbAuthorID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 510);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbGenr
            // 
            this.lbGenr.AutoSize = true;
            this.lbGenr.Location = new System.Drawing.Point(165, 177);
            this.lbGenr.Name = "lbGenr";
            this.lbGenr.Size = new System.Drawing.Size(31, 21);
            this.lbGenr.TabIndex = 28;
            this.lbGenr.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "genre : ";
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbPhilosoPhy);
            this.gbGenre.Controls.Add(this.rbHistorical);
            this.gbGenre.Controls.Add(this.rbPsycology);
            this.gbGenre.Location = new System.Drawing.Point(639, 23);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(461, 69);
            this.gbGenre.TabIndex = 26;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "genre";
            // 
            // rbPhilosoPhy
            // 
            this.rbPhilosoPhy.AutoSize = true;
            this.rbPhilosoPhy.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhilosoPhy.Location = new System.Drawing.Point(15, 27);
            this.rbPhilosoPhy.Name = "rbPhilosoPhy";
            this.rbPhilosoPhy.Size = new System.Drawing.Size(132, 34);
            this.rbPhilosoPhy.TabIndex = 10;
            this.rbPhilosoPhy.TabStop = true;
            this.rbPhilosoPhy.Text = "Philosophy";
            this.rbPhilosoPhy.UseVisualStyleBackColor = true;
            // 
            // rbHistorical
            // 
            this.rbHistorical.AutoSize = true;
            this.rbHistorical.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHistorical.Location = new System.Drawing.Point(186, 28);
            this.rbHistorical.Name = "rbHistorical";
            this.rbHistorical.Size = new System.Drawing.Size(117, 34);
            this.rbHistorical.TabIndex = 8;
            this.rbHistorical.TabStop = true;
            this.rbHistorical.Text = "Historical";
            this.rbHistorical.UseVisualStyleBackColor = true;
            // 
            // rbPsycology
            // 
            this.rbPsycology.AutoSize = true;
            this.rbPsycology.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPsycology.Location = new System.Drawing.Point(325, 28);
            this.rbPsycology.Name = "rbPsycology";
            this.rbPsycology.Size = new System.Drawing.Size(123, 34);
            this.rbPsycology.TabIndex = 9;
            this.rbPsycology.TabStop = true;
            this.rbPsycology.Text = "Psycology";
            this.rbPsycology.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(904, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Next";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NextToAddBookCopy);
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.Location = new System.Drawing.Point(6, 336);
            this.txtAddInfo.Multiline = true;
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(714, 163);
            this.txtAddInfo.TabIndex = 21;
            this.txtAddInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Add.Info  : ";
            // 
            // leditImage
            // 
            this.leditImage.AutoSize = true;
            this.leditImage.Location = new System.Drawing.Point(1021, 397);
            this.leditImage.Name = "leditImage";
            this.leditImage.Size = new System.Drawing.Size(79, 21);
            this.leditImage.TabIndex = 19;
            this.leditImage.TabStop = true;
            this.leditImage.Text = "Set Image";
            this.leditImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetImage);
            // 
            // lRemove
            // 
            this.lRemove.AutoSize = true;
            this.lRemove.Location = new System.Drawing.Point(900, 397);
            this.lRemove.Name = "lRemove";
            this.lRemove.Size = new System.Drawing.Size(67, 21);
            this.lRemove.TabIndex = 18;
            this.lRemove.TabStop = true;
            this.lRemove.Text = "Remove";
            this.lRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lRemove_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(870, 129);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(230, 251);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "publication Date : ";
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(223, 217);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(156, 29);
            this.dt.TabIndex = 11;
            // 
            // lbAuthorID
            // 
            this.lbAuthorID.AutoSize = true;
            this.lbAuthorID.Location = new System.Drawing.Point(165, 119);
            this.lbAuthorID.Name = "lbAuthorID";
            this.lbAuthorID.Size = new System.Drawing.Size(38, 21);
            this.lbAuthorID.TabIndex = 10;
            this.lbAuthorID.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Authors  : ";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(85, 75);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(294, 25);
            this.txtISBN.TabIndex = 8;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "ISBN : ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(85, 28);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(443, 33);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title : ";
            // 
            // tabBookCopy
            // 
            this.tabBookCopy.Controls.Add(this.lbQuantityBook);
            this.tabBookCopy.Controls.Add(this.chIsAvailable);
            this.tabBookCopy.Controls.Add(this.nuQuantity);
            this.tabBookCopy.Controls.Add(this.label12);
            this.tabBookCopy.Controls.Add(this.lbUsername);
            this.tabBookCopy.Controls.Add(this.label9);
            this.tabBookCopy.Controls.Add(this.label2);
            this.tabBookCopy.Controls.Add(this.lbBookCopyID);
            this.tabBookCopy.Location = new System.Drawing.Point(4, 30);
            this.tabBookCopy.Name = "tabBookCopy";
            this.tabBookCopy.Size = new System.Drawing.Size(1154, 528);
            this.tabBookCopy.TabIndex = 3;
            this.tabBookCopy.Text = "Book Copy";
            this.tabBookCopy.UseVisualStyleBackColor = true;
            // 
            // lbQuantityBook
            // 
            this.lbQuantityBook.AutoSize = true;
            this.lbQuantityBook.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantityBook.Location = new System.Drawing.Point(497, 32);
            this.lbQuantityBook.Name = "lbQuantityBook";
            this.lbQuantityBook.Size = new System.Drawing.Size(182, 25);
            this.lbQuantityBook.TabIndex = 30;
            this.lbQuantityBook.Text = "you have (0) Copies ";
            // 
            // chIsAvailable
            // 
            this.chIsAvailable.AutoSize = true;
            this.chIsAvailable.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsAvailable.Location = new System.Drawing.Point(144, 253);
            this.chIsAvailable.Name = "chIsAvailable";
            this.chIsAvailable.Size = new System.Drawing.Size(143, 34);
            this.chIsAvailable.TabIndex = 29;
            this.chIsAvailable.Text = "Is Available ";
            this.chIsAvailable.UseVisualStyleBackColor = true;
            // 
            // nuQuantity
            // 
            this.nuQuantity.Location = new System.Drawing.Point(461, 184);
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(144, 29);
            this.nuQuantity.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Number Of Copies   : ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(465, 317);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(49, 30);
            this.lbUsername.TabIndex = 26;
            this.lbUsername.Text = "????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Username  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Copy ID : ";
            // 
            // lbBookCopyID
            // 
            this.lbBookCopyID.AutoSize = true;
            this.lbBookCopyID.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookCopyID.Location = new System.Drawing.Point(456, 111);
            this.lbBookCopyID.Name = "lbBookCopyID";
            this.lbBookCopyID.Size = new System.Drawing.Size(49, 30);
            this.lbBookCopyID.TabIndex = 24;
            this.lbBookCopyID.Text = "????";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1073, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(939, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 673);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAddBook";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabFindAuthor.ResumeLayout(false);
            this.tabFindAuthor.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabBookCopy.ResumeLayout(false);
            this.tabBookCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFindAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGenr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.RadioButton rbPhilosoPhy;
        private System.Windows.Forms.RadioButton rbHistorical;
        private System.Windows.Forms.RadioButton rbPsycology;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel leditImage;
        private System.Windows.Forms.LinkLabel lRemove;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label lbAuthorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabBookCopy;
        private System.Windows.Forms.Label lbQuantityBook;
        private System.Windows.Forms.CheckBox chIsAvailable;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBookCopyID;
        private System.Windows.Forms.Button button3;
        private People.ctrlPersonWithFilter ctrlPersonWithFilter1;
    }
}
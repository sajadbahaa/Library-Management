namespace Lib.Books
{
    partial class frmBookCopiesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookCopiesList));
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.findBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AllowUserToOrderColumns = true;
            this.dtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgview.Location = new System.Drawing.Point(0, 208);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(1259, 261);
            this.dtgview.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBook,
            this.btnEditBook,
            this.authorsBookToolStripMenuItem,
            this.btnShowBookInfo,
            this.findBookToolStripMenuItem,
            this.btnDeletBook,
            this.btnBorrowBook,
            this.btnReservation});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 180);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(173, 22);
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.AddBook);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(173, 22);
            this.btnEditBook.Text = "Update Book";
            this.btnEditBook.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // authorsBookToolStripMenuItem
            // 
            this.authorsBookToolStripMenuItem.Name = "authorsBookToolStripMenuItem";
            this.authorsBookToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.authorsBookToolStripMenuItem.Text = "Authors  Book";
            this.authorsBookToolStripMenuItem.Click += new System.EventHandler(this.authorsBookToolStripMenuItem_Click);
            // 
            // btnShowBookInfo
            // 
            this.btnShowBookInfo.Name = "btnShowBookInfo";
            this.btnShowBookInfo.Size = new System.Drawing.Size(173, 22);
            this.btnShowBookInfo.Text = "Show Book Info";
            this.btnShowBookInfo.Click += new System.EventHandler(this.showBookInfoToolStripMenuItem_Click);
            // 
            // findBookToolStripMenuItem
            // 
            this.findBookToolStripMenuItem.Name = "findBookToolStripMenuItem";
            this.findBookToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.findBookToolStripMenuItem.Text = "Find Book";
            this.findBookToolStripMenuItem.Click += new System.EventHandler(this.findBookToolStripMenuItem_Click);
            // 
            // btnDeletBook
            // 
            this.btnDeletBook.Name = "btnDeletBook";
            this.btnDeletBook.Size = new System.Drawing.Size(173, 22);
            this.btnDeletBook.Text = "Delete BookCopies";
            this.btnDeletBook.Click += new System.EventHandler(this.deleteBookCopiesToolStripMenuItem_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(173, 22);
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(173, 22);
            this.btnReservation.Text = "Reservation";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.BackColor = System.Drawing.Color.Gainsboro;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(111, 498);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(36, 20);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By  : ";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "CopyID",
            "AuthorName",
            "ISBN",
            "BookType",
            "Title",
            "NumberOfCopies",
            "IsAvailable"});
            this.cbFilter.Location = new System.Drawing.Point(145, 62);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(146, 29);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(440, 35);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtFilter);
            this.pnSearch.Location = new System.Drawing.Point(368, 12);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(440, 35);
            this.pnSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Bisque;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(367, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 35);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.OnClickFilter);
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsAvailable.Location = new System.Drawing.Point(319, 63);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(146, 29);
            this.cbIsAvailable.TabIndex = 8;
            this.cbIsAvailable.SelectedIndexChanged += new System.EventHandler(this.cbIsAvailable_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1139, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddBook);
            // 
            // frmBookCopiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1259, 546);
            this.Controls.Add(this.cbIsAvailable);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgview);
            this.Name = "frmBookCopiesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookList";
            this.Load += new System.EventHandler(this.frmBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddBook;
        private System.Windows.Forms.ToolStripMenuItem btnEditBook;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.ComboBox cbIsAvailable;
        private System.Windows.Forms.ToolStripMenuItem authorsBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnShowBookInfo;
        private System.Windows.Forms.ToolStripMenuItem findBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeletBook;
        private System.Windows.Forms.ToolStripMenuItem btnBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem btnReservation;
    }
}
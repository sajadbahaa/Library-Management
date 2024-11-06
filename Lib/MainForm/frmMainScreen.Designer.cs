namespace Lib
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.cmLib = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangingFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmLib
            // 
            this.cmLib.Name = "cmLib";
            this.cmLib.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.readerToolStripMenuItem,
            this.readerToolStripMenuItem1,
            this.peopleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.notifyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.mangeBorrowingToolStripMenuItem,
            this.mangingFinesToolStripMenuItem,
            this.reservationsToolStripMenuItem});
            this.libraryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryToolStripMenuItem.Image")));
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(105, 54);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.bookTypesToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.booksToolStripMenuItem.Text = "Manage Books";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bookListToolStripMenuItem.Text = "Book List";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // bookTypesToolStripMenuItem
            // 
            this.bookTypesToolStripMenuItem.Name = "bookTypesToolStripMenuItem";
            this.bookTypesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bookTypesToolStripMenuItem.Text = "Book Types";
            this.bookTypesToolStripMenuItem.Click += new System.EventHandler(this.bookTypesToolStripMenuItem_Click);
            // 
            // mangeBorrowingToolStripMenuItem
            // 
            this.mangeBorrowingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBooksToolStripMenuItem1,
            this.borrowingListToolStripMenuItem,
            this.retrieveBookToolStripMenuItem});
            this.mangeBorrowingToolStripMenuItem.Name = "mangeBorrowingToolStripMenuItem";
            this.mangeBorrowingToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mangeBorrowingToolStripMenuItem.Text = "Mange Borrowing";
            // 
            // borrowBooksToolStripMenuItem1
            // 
            this.borrowBooksToolStripMenuItem1.Name = "borrowBooksToolStripMenuItem1";
            this.borrowBooksToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.borrowBooksToolStripMenuItem1.Text = "Borrow Books";
            this.borrowBooksToolStripMenuItem1.Click += new System.EventHandler(this.borrowBooksToolStripMenuItem_Click);
            // 
            // borrowingListToolStripMenuItem
            // 
            this.borrowingListToolStripMenuItem.Name = "borrowingListToolStripMenuItem";
            this.borrowingListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.borrowingListToolStripMenuItem.Text = "Borrowing List";
            this.borrowingListToolStripMenuItem.Click += new System.EventHandler(this.borrowingListToolStripMenuItem_Click);
            // 
            // retrieveBookToolStripMenuItem
            // 
            this.retrieveBookToolStripMenuItem.Name = "retrieveBookToolStripMenuItem";
            this.retrieveBookToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.retrieveBookToolStripMenuItem.Text = "Retrieve Book";
            this.retrieveBookToolStripMenuItem.Click += new System.EventHandler(this.retrieveBookToolStripMenuItem_Click);
            // 
            // mangingFinesToolStripMenuItem
            // 
            this.mangingFinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finesListToolStripMenuItem});
            this.mangingFinesToolStripMenuItem.Name = "mangingFinesToolStripMenuItem";
            this.mangingFinesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mangingFinesToolStripMenuItem.Text = "Manging Fines";
            // 
            // finesListToolStripMenuItem
            // 
            this.finesListToolStripMenuItem.Name = "finesListToolStripMenuItem";
            this.finesListToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.finesListToolStripMenuItem.Text = "Fines List";
            this.finesListToolStripMenuItem.Click += new System.EventHandler(this.finesListToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationsToolStripMenuItem,
            this.reservationListToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // addReservationsToolStripMenuItem
            // 
            this.addReservationsToolStripMenuItem.Name = "addReservationsToolStripMenuItem";
            this.addReservationsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addReservationsToolStripMenuItem.Text = "Add Reservations";
            this.addReservationsToolStripMenuItem.Click += new System.EventHandler(this.addReservationsToolStripMenuItem_Click);
            // 
            // reservationListToolStripMenuItem
            // 
            this.reservationListToolStripMenuItem.Name = "reservationListToolStripMenuItem";
            this.reservationListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.reservationListToolStripMenuItem.Text = "Reservation List";
            this.reservationListToolStripMenuItem.Click += new System.EventHandler(this.reservationListToolStripMenuItem_Click);
            // 
            // readerToolStripMenuItem
            // 
            this.readerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readerToolStripMenuItem.Image")));
            this.readerToolStripMenuItem.Name = "readerToolStripMenuItem";
            this.readerToolStripMenuItem.Size = new System.Drawing.Size(97, 54);
            this.readerToolStripMenuItem.Text = "Users";
            this.readerToolStripMenuItem.Click += new System.EventHandler(this.readerToolStripMenuItem_Click);
            // 
            // readerToolStripMenuItem1
            // 
            this.readerToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("readerToolStripMenuItem1.Image")));
            this.readerToolStripMenuItem1.Name = "readerToolStripMenuItem1";
            this.readerToolStripMenuItem1.Size = new System.Drawing.Size(105, 54);
            this.readerToolStripMenuItem1.Text = "Reader";
            this.readerToolStripMenuItem1.Click += new System.EventHandler(this.readerToolStripMenuItem1_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(105, 54);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allRegistersToolStripMenuItem,
            this.registerUserToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 54);
            this.toolStripMenuItem1.Text = "Registers";
            // 
            // allRegistersToolStripMenuItem
            // 
            this.allRegistersToolStripMenuItem.Name = "allRegistersToolStripMenuItem";
            this.allRegistersToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.allRegistersToolStripMenuItem.Text = "All Registers";
            this.allRegistersToolStripMenuItem.Click += new System.EventHandler(this.allRegistersToolStripMenuItem_Click);
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(111, 54);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show User Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.changePasswordToolStripMenuItem.Text = "change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // notifyToolStripMenuItem
            // 
            this.notifyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notifyToolStripMenuItem.Image")));
            this.notifyToolStripMenuItem.Name = "notifyToolStripMenuItem";
            this.notifyToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.notifyToolStripMenuItem.Text = "Notify";
            this.notifyToolStripMenuItem.Click += new System.EventHandler(this.notifyToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmLib;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allRegistersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangingFinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyToolStripMenuItem;
    }
}
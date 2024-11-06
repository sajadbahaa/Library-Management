using Global;
using Lib.Books;
using Lib.Books.BookTypes;
using Lib.Manage_Books.Borrowing;
using Lib.Manage_Books.Borrowing.BorrowingBook;
using Lib.Manage_Books.Borrowing.RetrievBooks;
using Lib.Manage_Books.Reservations;
using Lib.Manging_Fines;
using Lib.People;
using Lib.Readers;
using Lib.Users;
using Lib.Users.Registers;
using Lib.Users.Registers.RegisterByUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleList frm = new frmPeopleList();
            frm.ShowDialog();

                }

        private void readerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReaderList frm = new frmReaderList();
            frm.ShowDialog();
                }

        private void readerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
       }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        
        }

        private void allRegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllRegisters frm = new frmAllRegisters();
            frm.ShowDialog();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterByUser frm = new frmRegisterByUser();
            frm.ShowDialog();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookCopiesList frm = new frmBookCopiesList();
            frm.ShowDialog();
        }

        private void bookTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookTypesList frm = new frmBookTypesList();
            frm.ShowDialog();
        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowingBooks frm = new frmBorrowingBooks();
            frm.ShowDialog();
        }

        private void borrowingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowingList frm = new frmBorrowingList();
            frm.ShowDialog();
        }

        private void retrieveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReteieveBooks frm = new frmReteieveBooks();
            frm.ShowDialog();
        }

        private void finesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFineList frm = new frmFineList();
            frm.ShowDialog();
        }

        private void addReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationScreen frm = new frmReservationScreen();
            frm.ShowDialog();
        }

        private void reservationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationList frm = new frmReservationList();
            frm.ShowDialog();
        }

        private void notifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotify frm = new frmNotify();
            frm.ShowDialog();
        }
    }
}

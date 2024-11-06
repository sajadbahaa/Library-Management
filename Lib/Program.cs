using Lib.Books;
using Lib.Books.BookTypes;
using Lib.Manage_Books.Borrowing;
using Lib.Manage_Books.Borrowing.BorrowingBook;
using Lib.Manage_Books.Borrowing.RetrievBooks;
using Lib.Manage_Books.Notify;
using Lib.Manage_Books.Reservations;
using Lib.Manging_Fines;
using Lib.People;
using Lib.Readers;
using Lib.Users;
using Lib.Users.Registers.RegisterByUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmShowBookInfo("Habit"));
             //Application.Run(new frmReservationList());
            //Application.Run(new frmBorrowingBooks());
            //Application.Run(new frmNotify());
            //Application.Run(new frmReservationScreen());
            //Application.Run(new frmFindFine());
            //Application.Run(new frmFindReservation());

            Application.Run(new frmLogin());

        }
    }
}

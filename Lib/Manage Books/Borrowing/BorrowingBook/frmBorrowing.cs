using BankSystem.GlobalClasses;
using Global;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Borrowing.BorrowingBook
{
    public partial class frmBorrowingBooks : Form
    {
        public frmBorrowingBooks()
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Borrowing Screen");
        }
        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            _RestDefaultValue();
        }
        private clsBorrowing _BorrowInfo;
        private clsNotify _Notify;
        private clsInformation _Information;
        private void _RestDefaultValue()
        {
                tabBorrow.Enabled = false;
             tabFindBook.Enabled = false;
                btnSave.Enabled = false;
                lbUsername.Text = clsGlobal.CurrentUser.Username;
                lbBorrowingDate.Text = clsFormat.DateToString(DateTime.Now);
            lbDueDate.Text = clsFormat.DateToString(DateTime.Now.AddDays((double)clsGlobal.CurrentSettings.NumberDaysBorrowing));
             _BorrowInfo = new clsBorrowing();
            chIsBorrow.Checked = true;
            _Information = new clsInformation();
            _Notify = new clsNotify();
            _Notify.SubscribeSendingNotifyUnAvailable(_Information);
        }
        private void ctrlFindReader1_OnReaderSelected(object sender, Readers.ctrlFindReader.clsReaderInfo e)
        {
            if (ctrlFindReader1.ReaderID == -1)
                return;

            if (clsFines.IsReaderHasFine(ctrlFindReader1.ReaderID))
            {
                MessageBox.Show("you have Fine , go and pay your fine");
                btnNext.Enabled = false;
                return;
            }


            btnNext.Enabled = true;
        
        }

        private void ctrlShareScreen1_Load(object sender, EventArgs e)
        {

        }

        private void NextToTakeBook(object sender, EventArgs e)
        {
            if (ctrlFindReader1.ReaderID == -1)
            {
                MessageBox.Show("Choose Another Reader");
                return;
            }
            // check if 
            lbReaderName.Text = ctrlFindReader1.ReaderInfo.PersonInfo.Name;
            tabFindBook.Enabled = true;
             tabControl1.SelectedIndex = 1;
        }

        int ReservationID = -1;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbBorrowDate_Click(object sender, EventArgs e)
        {

        }

private bool _HandelReservationExist()
        {
            if (ReservationID != -1)
            {
                bool IsReservationUnLock = clsReservation.UnLockReservation(ReservationID, clsGlobal.CurrentUser.UserID);
                if (IsReservationUnLock)
                {
                    MessageBox.Show("it has been Reservation Un lock Successfully");
                }
                else
                {
                    MessageBox.Show("Failed Reservation Unlock");
                    return false;
                }
            }
            return true;
        }
        private void NextToBorrow(object sender, EventArgs e)
        {
            if (ctrlBookInfoWithFilter1.BookCopySelected.CopyID == -1)
            {
                MessageBox.Show("choose Another CopyID");
                return;
            }
            if (!ctrlBookInfoWithFilter1.BookCopySelected.IsAvailable)
            {
                MessageBox.Show("this Book Not Available");
                return;
            }

            lbBookTitle.Text = ctrlBookInfoWithFilter1.BookCopySelected.title;
            tabControl1.SelectedIndex = 2;
            tabBorrow.Enabled = true;
            btnSave.Enabled = true;

        }
        private void _AddNotify()
        {
            _Information.SetBookCopyUnAvailable(ctrlBookInfoWithFilter1.BookCopySelected);
        }
       async public Task HandelProcessBorrowBookAsync()
        {
            bool IsProcessSuccesed = _BorrowInfo.AddBorrowing(ctrlBookInfoWithFilter1.BookCopySelected.CopyID, Convert.ToDateTime(lbDueDate.Text), ctrlFindReader1.ReaderID, clsGlobal.CurrentUser.UserID);

            if (!IsProcessSuccesed)
            {
                MessageBox.Show("Failed Borrowing Book");
                return;
            }
            MessageBox.Show("Borrowing Book Successfully");
            lbBorrowID.Text = _BorrowInfo.BorrowID.ToString();

            await Task.Delay(0);
        }
        async public Task HandelProcessResevationsAsync()
        {
            _HandelReservationExist();
            await Task.Delay(0);
        }
        


        private async void Save(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you Want to Borrow Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //if (!_HandelReservationExist())
            //    return;

            //_AddNotify();
            Task t1 = HandelProcessResevationsAsync();
            Task t2 =  HandelProcessBorrowBookAsync();

          await  Task.WhenAll(t1,t2);
            
            
            _AddNotify();

            btnSave.Enabled = false;
     
        }

        

        private void tabBorrow_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBorrowing_Load(object sender, EventArgs e)
        {
            _RestDefaultValue();
        }

        private void btnCLose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ctrlBookInfoWithFilter1_OnBookCopySelected(object sender, Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo e)
        {
            if (e.BookCopyInfo == null)
            {
                return;
            }

            if (!e.BookCopyInfo.IsAvailable)
            {
                MessageBox.Show("this  Book CopyID not Available");
                return;
            }

            //check if BookCopy reserve by Reader.
            if (clsReservation.IsBookCopyLock(e.BookCopyInfo.CopyID))
            {
                ReservationID = clsReservation.
                    GetReservationActive(ctrlFindReader1.ReaderID, ctrlBookInfoWithFilter1.CopyID);

                if (ReservationID == -1)
                {
                    MessageBox.Show("you did not Reserve  this Book");
                    btnNext1.Enabled = false;
                    return;
                }
                else
                {
                    btnNext1.Enabled = true;
                    return;
                }

            }


            if (clsBorrowing.IsReaderBorrow(ctrlFindReader1.ReaderID, ctrlBookInfoWithFilter1.BookCopySelected.CopyID))
            {
                MessageBox.Show("you can not borrow this Book again because you already take it");
                btnNext1.Enabled = false;
                return;
            }
            else
            {
                btnNext1.Enabled = true;

            }
            // after adding we 'll return Completeing rest of Processing.

        }
    }
}

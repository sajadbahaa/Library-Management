using BankSystem.GlobalClasses;
using Global;
using Lib.Manging_Fines;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.VisualStyles;
namespace Lib.Manage_Books.Borrowing.RetrievBooks
{
    public partial class frmReteieveBooks : Form
    {
    enum enMode { UpdateDirectly = 1,UpdateManualy =2}
        enMode _Mode;
        public frmReteieveBooks()
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Retrieving Screen");
            _Mode = enMode.UpdateManualy;
        }
        public frmReteieveBooks(int BorrowID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Retrieving Screen");

            _BorrowID = BorrowID;
            _Mode = enMode.UpdateDirectly;
        }
        private int _FineID =-1;

        private void frmReteieveBooks_Load(object sender, EventArgs e)
        {
            
            _RestDefaultValue();
            
            if(_Mode==enMode.UpdateDirectly)
            LoadDataBorrowing();

        }

        private clsBorrowing _BorrowInfo;
        private clsInformation _information;
        private clsNotify _Notify;
        private void LoadDataBorrowing()
        {
                _BorrowInfo = clsBorrowing.FindByBorrowID(_BorrowID);
                if (_BorrowInfo == null)
                {
                    MessageBox.Show("Borrowing Info Not Found");
                    btnNext.Enabled = false;
                    return;
                }
            ctrlFindReader1.LoadDataByReaderID(_BorrowInfo.ReaderID);
            ctrlBookInfoWithFilter1.LoadDataBookCopy(_BorrowInfo.CopyID);
            
        }
           
        
        
        
        private void _RestDefaultValue()
        {
            tabBorrow.Enabled = false;
            tabFindBook.Enabled = false;
            btnSave.Enabled = false;
            lbUsername.Text = clsGlobal.CurrentUser.Username;
            _BorrowInfo = new clsBorrowing();
            chIsRetrieve.Enabled = false;
            chIsRetrieve.Checked = true;
            lShowFine.Enabled = false;
            _information = new clsInformation();
            _Notify = new clsNotify();
            _Notify.SubscribeSendingNotify(_information);
            
        }
        private void ctrlFindReader1_OnReaderSelected(object sender, Readers.ctrlFindReader.clsReaderInfo e)
        {
            if (ctrlFindReader1.ReaderID == -1)
                return;
            lShowHistoryReader.Enabled = (ctrlFindReader1.ReaderID != -1);

            if (clsFines.IsReaderHasFine(ctrlFindReader1.ReaderID))
            {
                MessageBox.Show("you have fine , you must pay");
                return;
            }
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

        private int _BorrowID;
        private clsBookCopy BookSelected;

        

        private void NextToRetrievBook(object sender, EventArgs e)
        {
            if (ctrlBookInfoWithFilter1.CopyID == -1)
            {
                MessageBox.Show("choose Another CopyID");
                return;
            }


            if ((_BorrowID == -1))
            {
                MessageBox.Show("you Did not Borrow this Book");
                btnNext1.Enabled = false;
                return;
            }

            

            lbBookTitle.Text = ctrlBookInfoWithFilter1.BookCopySelected.title;
            tabBorrow.Enabled = true;
            tabControl1.SelectedIndex = 2;
            btnSave.Enabled = true;

        }

    public void _AddNotify()
        {
            _information.SetBookCopyAvailable(BookSelected);
        } 
    public void _AddFine()
        {
            _BorrowInfo.AddFine(clsGlobal.CurrentUser.UserID, ref _FineID, clsGlobal.CurrentSettings.FinePerDay);
            if (_FineID != -1)
            {
                MessageBox.Show("you have Fine");
                lShowFine.Enabled = true;
            }
        }
        async public Task _HandelProcessAddingNotifyAsync()
        {
            _AddNotify();
            await Task.Delay(0);
        }
        async public Task _HandelProcessRetrieveBookcopyAsync()
        {
            _ReteieveBook();
            await Task.Delay(0);
        }
        public void _ReteieveBook()
        {
            bool IsRetrieveit = _BorrowInfo.RetreivingBook(clsGlobal.CurrentUser.UserID, Convert.ToDateTime(lbActualDate.Text));

            if (!IsRetrieveit)
            {
                MessageBox.Show("Failed Retrieving Book");
                return;
            }

            MessageBox.Show("Retrieving Book Successfully");

        }
        private async void Save(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Retrieve Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Task t1 = _HandelProcessRetrieveBookcopyAsync();
            
            Task t2 = _HandelProcessAddingNotifyAsync();

            await Task.WhenAll(t1,t2);

            _AddFine();
            
            btnSave.Enabled = false;
        
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ShowHistoryReader(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHistoryReader frm = new frmHistoryReader(ctrlFindReader1.ReaderID);
            frm.ShowDialog();
        }

        private void showFine(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowFineInfo frm = new frmShowFineInfo(_FineID);
            frm.ShowDialog();
        }

        private void ctrlBookInfoWithFilter1_OnBookCopySelected(object sender, Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo e)
        {
            if (e.BookCopyInfo == null)
            {
                return;
            }
            BookSelected = e.BookCopyInfo;
            bool IsReaderBorrow = clsBorrowing.IsReaderBorrow(ctrlFindReader1.ReaderID, ctrlBookInfoWithFilter1.BookCopySelected.CopyID);
            if (_Mode == enMode.UpdateManualy)
            {
                _BorrowID = clsBorrowing.GetBorrowIDBeforeRetrieving(ctrlFindReader1.ReaderID, ctrlBookInfoWithFilter1.BookCopySelected.CopyID);

                if ((_BorrowID == -1))
                {
                    MessageBox.Show("you Did not Borrow this Book");
                    btnNext1.Enabled = false;
                    return;
                }



                _BorrowInfo = clsBorrowing.FindByBorrowID(_BorrowID);
                if (_BorrowInfo == null)
                {
                    MessageBox.Show("Borrowing Info Not Found");
                    return;
                }

                lbBorrowingDate.Text = clsFormat.DateToString(_BorrowInfo.BorrowingDate);
                lbDueDate.Text = clsFormat.DateToString(_BorrowInfo.DueDate);
                lbActualDate.Text = clsFormat.DateToString(_BorrowInfo.ActualDate);
                lbBorrowID.Text = _BorrowInfo.BorrowID.ToString();
                // after adding we 'll return Completeing rest of Processing.

                btnNext1.Enabled = true;


                return;
            }


            lbBorrowingDate.Text = clsFormat.DateToString(_BorrowInfo.BorrowingDate);
            lbDueDate.Text = clsFormat.DateToString(_BorrowInfo.DueDate);
            lbActualDate.Text = clsFormat.DateToString(_BorrowInfo.ActualDate);
            lbBorrowID.Text = _BorrowInfo.BorrowID.ToString();
            // after adding we 'll return Completeing rest of Processing.

            btnNext1.Enabled = true;

        }
    }
}

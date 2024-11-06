using Global;
using Lib.Readers;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Reservations
{
    public partial class frmReservationScreen : Form
    {
        public frmReservationScreen()
        {
            InitializeComponent();
        }
        public frmReservationScreen(int CopyID)
        {
            InitializeComponent();
            //LoadData(CopyID);           
        }
  //      private void LoadData(int CopyID)
  //      {
  //          ctrlBookInfoWithFilter1.LoadDataBookCopy(CopyID);
  //          if (ctrlBookInfoWithFilter1.BookCopySelected==null)
  //          {
  //btnNextToReader.Enabled = false;
  //              _CopyID = -1;
  //              return;
  //          }
  //          _CopyID = CopyID;
  //          BookCopyInfo = ctrlBookInfoWithFilter1.BookCopySelected;




  //  }
    public enum enMode { add =1,update =2}
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabReservation_Click(object sender, EventArgs e)
        {

        }
        //private int ReservationID;
        private int _CopyID = -1;
        private int ReaderID = -1;
        private clsBookCopy BookCopyInfo;
        private int _PersonID= -1;
        clsReservation _Reservation;
private void _RestDefaultValue()
        {
            lbBookName.Text = "???";
            lbReaderName.Text = "???";
            lbUsername.Text = clsGlobal.CurrentUser.Username;
            chIsLock.Checked = true;
            lbReservationID.Text = "???";
            tabReaderInfo.Enabled = false;
            btnSave.Enabled = false;
            tabReservation.Enabled = false;
            _Reservation = new clsReservation();
            lReservationHistory.Enabled = false;
        }
        private void OnClickNextToReader(object sender, EventArgs e)
        {
            if (_CopyID != -1)
            {
                if (BookCopyInfo.IsAvailable)
                {
                    MessageBox.Show("this book is Available");
                    return;
                }
                tabControl1.SelectedIndex = 1;
                tabReaderInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Choose another BookCopy");
                return;
            }
            }

        private void frmReservationScreen_Load(object sender, EventArgs e)
        {
            _RestDefaultValue();
        }

        private void ctrlFindReader2_OnReaderSelected(object sender, Readers.ctrlFindReader.clsReaderInfo e)
        {
            if (e.ReaderInfo==null)
            {
                return ;
            }
            lReservationHistory.Enabled = e.ReaderInfo.ReaderID != -1 ? true : false; 
            ReaderID = e.ReaderInfo.ReaderID;
            _PersonID = e.ReaderInfo.PersonInfo.PersonID;
            if (clsFines.IsReaderHasFine(ctrlFindReader2.ReaderID))
            {
               MessageBox.Show("you have Fine , go and pay your fine");
 btnNext.Enabled = false; 
        return;
            }

            if (clsReservation.HasReaderReservation(ReaderID, _CopyID))
            {
                MessageBox.Show("you already reserved , you can do it twoice.");
                btnNext.Enabled = false;
                return;
            }
            if (clsBorrowing.IsReaderBorrow(ReaderID,_CopyID))
            {
                MessageBox.Show("you already borrow this Book , you can not Reserve it");
                btnNext.Enabled = false;
                return;
            }
            
            
            btnNext.Enabled = true;
            lbReaderName.Text = e.ReaderInfo.PersonInfo.Name;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ReaderID==-1)
            {
                MessageBox.Show("Choose another ReaderID");
                return;
            }
            tabReservation.Enabled = true;
            tabControl1.SelectedIndex = 2;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }
            if (MessageBox.Show("Do you want Booking this Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _Reservation.CopyID = _CopyID;
            _Reservation.ReaderID = ReaderID;
            _Reservation.IsLock = chIsLock.Checked ? true : false;
            _Reservation.UserID = clsGlobal.CurrentUser.UserID;
            if (!_Reservation.Save())
            {
                MessageBox.Show("Failed Reservation ");
                return;
            }
            MessageBox.Show("It has been Reservation Book Successfully");
            lbReservationID.Text = _Reservation.ReservationID.ToString();
            btnSave.Enabled = true;
        }

        private void ctrlBookInfoWithFilter1_OnBookCopySelected(object sender, Lib.Books.Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo e)
        {
            BookCopyInfo = e.BookCopyInfo;

            if (BookCopyInfo == null)
            {
                return;
            }

            if (BookCopyInfo.IsAvailable)
            {
                MessageBox.Show("this book is Available");
                return;
            }
            _CopyID = e.BookCopyInfo.CopyID;
            lbBookName.Text = e.BookCopyInfo.title;

        }

        private void lReservationHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHistoryReservation frm = new frmHistoryReservation(ReaderID, _PersonID);
            frm.ShowDialog();
        }
    }
}

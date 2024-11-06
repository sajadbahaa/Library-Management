using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Borrowing.BorrowingBook.Controls
{
    public partial class ctrlShowBorrow : UserControl
    {
        public ctrlShowBorrow()
        {
            InitializeComponent();
        }
        private clsBorrowing _BorrowingInfo;
public clsBorrowing BorrowingInfo
        {
            get
            {
                return _BorrowingInfo;
            }
        }
        public void _RestDefualtValue()
        {
            //      ctrlBookInfo1._RestDefaultValue();
            lbMsg.Visible = false;
            lbBorrow.Text = "???";
           // lbIsBorrow.Text = "???";
            lbRName.Text = "???";
            _BorrowingInfo = null;
        }

        private void _LoadData()
        {
            ctrlBookInfo1.LoadBookInfoByCopyID(_BorrowingInfo.CopyID);
            lbBorrow.Text = _BorrowingInfo.BorrowID.ToString();
          //  lbIsBorrow.Text = _BorrowingInfo.IsBorrow ? "yes" : "no";
        //    lbMessage.Visible = !_BorrowingInfo.IsBorrow ? true: false;
            lbRName.Text = _BorrowingInfo.ReaderInfo.PersonInfo.Name;
        lbMsg.Visible = _BorrowingInfo.IsBorrow ? false : true;
            return;
        }
       public void LoadBorrowingData(int BorrowID)
        {
            _BorrowingInfo = clsBorrowing.FindByBorrowID(BorrowID);
            if (_BorrowingInfo==null)
            {
                MessageBox.Show("this BorrowID not Found");
                _RestDefualtValue();
                return;
            }
            _LoadData();
        }
        private void ctrlShowBorrow_Load(object sender, EventArgs e)
        {
        }

        private void ctrlShowBorrow_Load_1(object sender, EventArgs e)
        {

        }
    }
}

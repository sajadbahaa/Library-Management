using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Borrowing.BorrowingBook
{
    public partial class frmShowBorrowInfo : Form
    {
        public frmShowBorrowInfo(int ID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Borrow Info");
            ctrlShowBorrow1.LoadBorrowingData(ID);
        }

        private void frmShowBorrowInfo_Load(object sender, EventArgs e)
        {

        }

        private void ctrlShowBorrow1_Load(object sender, EventArgs e)
        {

        }
    }
}

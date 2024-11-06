using Lib.Manage_Books.Borrowing.BorrowingBook;
using Lib.Manage_Books.Borrowing.RetrievBooks;
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

namespace Lib.Manage_Books.Borrowing
{
    public partial class frmBorrowingList : Form
    {
        public frmBorrowingList()
        {
            InitializeComponent();
        }
        private int _ReaderID;
        private int _CopyID;
        DataView dtv;
        private void frmBorrowingList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            cbIsBorrow.Visible = false;

            dtv = clsBorrowing.GetAllBorrowingList().DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
if(MessageBox.Show("Are you sure?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (clsBorrowing.Delete((int)dtgview.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Deleted Successfully");
                else
                    MessageBox.Show("Falied Deleting");

                frmBorrowingList_Load(null, null);
            }
        }

        private void dtgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showBorrowInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBorrowInfo frm = new frmShowBorrowInfo((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsNone = cbFilter.Text == "None" ? true : false;
            bool IsLock = cbFilter.Text == "IsBorrow";
            txtFilter.Visible = !IsNone && !IsLock;
            cbIsBorrow.Visible = !IsNone && IsLock;

            if (cbIsBorrow.Visible)
                cbIsBorrow.SelectedIndex = 0;

        }
        private void _GetFilterIsBorrow()
        {
            if (cbIsBorrow.Text == "All")
            {
                dtv.RowFilter = "";
                return;
            }

            int result = cbIsBorrow.Text == "yes" ? 1 : 0;
            dtv.RowFilter = $"{cbFilter.Text} = {result}";

        }

        private void cbIsLock_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetFilterIsBorrow();
        }
        private void GetFilter()
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "BorrowID":
                    FilterColumn = "BorrowID";
                    break;
                case "CopyID":
                    FilterColumn = "CopyID";
                    break;
                case "ReaderID":
                    FilterColumn = "ReaderID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilter.Text == "" || FilterColumn == "None")
            {
                dtv.RowFilter = "";
                return;
            }

            dtv.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            dtgview.DataSource = dtv;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            GetFilter();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "None")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReteieveBooks frm = new frmReteieveBooks();
            frm.ShowDialog();
            frmBorrowingList_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            bool IsBorrow = (bool)dtgview.CurrentRow.Cells[6].Value;
            btnReteiev.Enabled = IsBorrow ? true : false;
    _ReaderID = (int)dtgview.CurrentRow.Cells[1].Value;
    _CopyID = (int)dtgview.CurrentRow.Cells[2].Value;

        }

        private void btnReteiev_Click(object sender, EventArgs e)
        {
            frmReteieveBooks frm = new frmReteieveBooks((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmBorrowingList_Load(null, null);
        }
    }
}

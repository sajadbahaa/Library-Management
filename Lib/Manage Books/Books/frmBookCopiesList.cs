using Lib.Books.AuthorsBooks;
using Lib.Manage_Books.Borrowing;
using Lib.Manage_Books.Borrowing.BorrowingBook;
using Lib.Manage_Books.Reservations;
using Lib.People;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Books
{
    public partial class frmBookCopiesList : Form
    {
        public frmBookCopiesList()
        {
            InitializeComponent();
        }
        private DataView dtv;
        private clsBookCopy _CopyBookInfo;
        private void frmBookList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            //cbIsAvailable.SelectedIndex = 0;
            pnSearch.Visible = false;
            cbIsAvailable.Visible = false;

            dtv  = clsBookCopy.GetBookCopiesView().DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtv.Count.ToString();
        
        }


        private void AddBook(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm.ShowDialog();
            frmBookList_Load(null, null);
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmBookList_Load(null, null);

        }

        private void showAuthorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dtgview.CurrentRow.Cells[1].Value);
        frm.ShowDialog();
            frmBookList_Load(null, null);
        }

        private void cbIsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetFilterIsAvailable();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool IsNone = (cbFilter.Text == "None" ? true : false);
            if (IsNone)
            {
                pnSearch.Visible = !IsNone;
                cbIsAvailable.Visible = !IsNone;
                return;
            }
            

            if (cbFilter.Text== "IsAvailable")
            {
                cbIsAvailable.SelectedIndex = 0;
                pnSearch.Visible = false;
                cbIsAvailable.Visible = true;
                return;
            }
            else
            {
                pnSearch.Visible = true;
                cbIsAvailable.Visible = false;
            }

                        }
        private void _GetFilter()
        {
string FilterColumn = cbFilter.Text;
            switch (cbFilter.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "CopyID":
                    FilterColumn = "CopyID";
                    break;
                case "AuthorName":
                    FilterColumn = "AuthorName";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
                case "ISBN":
                    FilterColumn = "ISBN";
                    break;
                case "BookType":
                    FilterColumn = "BookType";
                    break;
                case "NumberOfCopies":
                    FilterColumn = "NumberOfCopies";
                    break;
            }
            if (cbFilter.Text=="None"||txtFilter.Text=="")
            {
                dtv.RowFilter = "";
                return; 
            }
            if (cbFilter.Text!= "AuthorName"&&cbFilter.Text!= "Title"
                &&cbFilter.Text!= "BookType"&&cbFilter.Text!="ISBN")
            {
                dtv.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            }
            else
            {
                dtv.RowFilter = $"{FilterColumn} Like '"+ txtFilter.Text + "%'" ;
            }
            dtgview.DataSource = dtv;
        
        }

        private void OnClickFilter(object sender, EventArgs e)
        {
            _GetFilter();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (cbFilter.Text=="CopyID"||cbFilter.Text== "ISBN"
                || cbFilter.Text == "NumberOfCopies")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }
        }
    private void _GetFilterIsAvailable()
        {
            if (cbIsAvailable.Text=="All")
            {
                dtv.RowFilter = "";
                
                return;
            }
            string FilterColumn = cbFilter.Text;
           // byte value = (Byte)(cbIsAvailable.Text=="Yes"?1:0);
           
            dtv.RowFilter = $"{FilterColumn} Like '"+cbIsAvailable.Text+ "%'";
            dtgview.DataSource = dtv;
        
        }

        private void authorsBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorsBook frm = new frmAuthorsBook((int)dtgview.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookInfo frm = new frmShowBookInfo((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmBookList_Load(null,null);
        }

        private void findBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindBook frm = new frmFindBook();
            frm.ShowDialog();
            frmBookList_Load(null, null);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _CopyBookInfo = clsBookCopy.FindCopyBookByCopyID((int)dtgview.CurrentRow.Cells[0].Value);
            if (_CopyBookInfo==null)
            {
                return;
            }
            bool IsAvaliable = (string)dtgview.CurrentRow.Cells[7].Value == "yes"? true : false;

            btnReservation.Enabled = !IsAvaliable;
            btnBorrowBook.Enabled = IsAvaliable;
           
        }

        private void deleteBookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Copy Book",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (_CopyBookInfo.Delete())
                {
                    MessageBox.Show("Deleted Successfully");
                    frmBookList_Load(null,null);
                }
                else
                    MessageBox.Show("Failed Because its Related with Another Table");
                return;
            } 
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowingBooks frm = new frmBorrowingBooks();
            frm.ShowDialog();
            frmBookList_Load(null, null);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservationScreen frm = new frmReservationScreen((int)dtgview.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}

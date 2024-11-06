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

namespace Lib.Books.Controls
{

    
    public partial class ctrlBookInfoWithFilter : UserControl
    {
        public ctrlBookInfoWithFilter()
        {
            InitializeComponent();
        }
        public class clsBookCopiesInfo
        {
            public clsBookCopy BookCopyInfo { get; set; }
            public clsBookCopiesInfo(clsBookCopy BookCopyInfo)
            {
                this.BookCopyInfo = BookCopyInfo;
            }
        }
        public event EventHandler <clsBookCopiesInfo> OnBookCopySelected;
        public void OnBookSelected(clsBookCopy BookInfo)
        {
            OnBookSelected(new clsBookCopiesInfo(BookInfo));
        }
        protected  virtual void OnBookSelected(clsBookCopiesInfo e)
        {
            OnBookCopySelected?.Invoke(this,e);
        }
        
        
        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }
        }
       public clsBookCopy BookCopySelected
        {
            get
            {
                return ctrlBookInfo1.BookCopySelected;
            } 
            
        }
        public int CopyID
        {
            get
            {
                return ctrlBookInfo1.CopyID;
            }
        }
        public void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "CopyID":
                    ctrlBookInfo1.LoadBookInfoByCopyID(int.Parse(txtFilter.Text));
                    break;
                case "ISBN":
                    ctrlBookInfo1.LoadBookInfoByISBN(txtFilter.Text);
                    break;
                case "Title":
                    ctrlBookInfo1.LoadBookInfoByTitle(txtFilter.Text);
                    break;
            }
            if ( _FilterEnable&&OnBookCopySelected!=null)
            {
                OnBookSelected(BookCopySelected);
            }
        }
        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter,"this Field is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilter, "");
            }

        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch.PerformClick();
                txtFilter.Text = "".Trim();
            }
            if (cbFilter.Text=="CopyID"||cbFilter.Text=="ISBN")
            {
                e.Handled = (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar));
            }

        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "".Trim();
        }

        private void ctrlBookInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }
        public void LoadDataBookCopy(int CopyID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Text = CopyID.ToString();
            FindNow();
        }

        private void Search(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("this Field Is Required");
                return;
            }
            FindNow();
        }
        public void GetNewBookCopyID(int CopyID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Text = CopyID.ToString();
            FindNow();
        }
        private void AddCopyBook(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm._dtBack = GetNewBookCopyID;
            frm.ShowDialog();
        }
    }
}

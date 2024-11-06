using BankSystem.GlobalClasses;
using Lib.Properties;
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
    public partial class ctrlBookInfo : UserControl
    {
        /// <summary>
        /// this control can load Book info 
        /// </summary>

        private int _CopyID = -1;
        private clsBookCopy _CopyBookInfo;
        public int CopyID
        {
            get
            {
                return _CopyID;
            }
        }
        public clsBookCopy BookCopySelected
        {
            get
            {
                return _CopyBookInfo;
            }
        }
      
        public ctrlBookInfo()
        {
            InitializeComponent();
        }
        private void _HandelImage()
        {
            if (_CopyBookInfo==null)
            {
                pbImage.Image = Resources.UnKnownThng;
                return;
            }
            if (_CopyBookInfo.ImageBook==null)
            {
                pbImage.Image = Resources.BookRandom;
                return;
            }
            else
            {
                pbImage.ImageLocation = _CopyBookInfo.ImageBook;
            }
        }
        public void _RestDefaultValue()
        {
            _CopyID = -1;
            lbAuthorName.Text = "???";
            lbBookID.Text = "???";
            lbTitle.Text = "???";
            lbIsAvailable.Text = "???";
            lbISBN.Text = "???";
            lbDate.Text = "???";
            lbCopiesNumber.Text = "???";
            lEditBook.Enabled = false;
           _CopyBookInfo = new clsBookCopy();
            
            _HandelImage();
        }
        private void _LoadData()
        {
            
            lbAuthorName.Text = _CopyBookInfo.AuthorInfo.Name;
            lbBookID.Text = _CopyBookInfo.BookID.ToString();
            lbCopiesNumber.Text = _CopyBookInfo.NumberOfCopies.ToString();
            lbDate.Text = clsFormat.DateToString(_CopyBookInfo.date);
            lbIsAvailable.Text = (_CopyBookInfo.IsAvailable?"Yes":"False");
            lbISBN.Text = _CopyBookInfo.ISBN;
            lbTitle.Text = _CopyBookInfo.title;
            lEditBook.Enabled = true; 
            _HandelImage();
        } 
        
        public void LoadBookInfoByCopyID(int CopyID)
        {
            _CopyBookInfo = clsBookCopy.FindCopyBookByCopyID(CopyID);
            
            if (_CopyBookInfo==null)
            {
                MessageBox.Show("this CopyID Not Found");
                _RestDefaultValue();
                return;
            }
            _CopyID = CopyID;
            _LoadData();
        }
        public void LoadBookInfoByTitle(string title)
        {
            _CopyBookInfo = clsBookCopy.FindCopyBookByTitle(title);

            if (_CopyBookInfo == null)
            {
                MessageBox.Show("this Title Not Found");
                _RestDefaultValue();
                return;
            }
            _CopyID = _CopyBookInfo.BookID;
            _LoadData();

        }
        public void LoadBookInfoByISBN(string ISBN)
        {
            _CopyBookInfo = clsBookCopy.FindCopyBookByISBN(ISBN);

            if (_CopyBookInfo == null)
            {
                MessageBox.Show("this ISBN Not Found");
                _RestDefaultValue();
                return;
            }
            _CopyID = _CopyBookInfo.BookID;
            _LoadData();
        }

        private void ctrlBookInfo_Load(object sender, EventArgs e)
        {

        }

        private void EditBook(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddBook frm = new frmAddBook(_CopyID);
            frm.ShowDialog();
            LoadBookInfoByCopyID(_CopyID);
        }
    }
}

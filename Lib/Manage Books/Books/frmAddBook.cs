using Global;
using Lib.People;
using Lib.Properties;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOnenericControls;
using Util;
using Vaildation;

namespace Lib.Books
{
    public partial class frmAddBook : Form
    {
    public  enum enMode { add = 1,update =2}
        private enMode _Mode = enMode.add;
        private int? nullabel = null;
        private int _authorID;
        private int _BookCopyID;

        public delegate void AddNewBook(int BookICopyD);
        public AddNewBook _dtBack;
        public void GetNewCopyBook(int BookICopyD)
        {
            _BookCopyID = BookICopyD;
            lbBookCopyID.Text = BookICopyD.ToString();
        }
        public enum enBookTypes
        { enHistorical = 1, Psychology = 2, Philosophy = 3 }

        public frmAddBook()
        {
            InitializeComponent();
            _Mode = enMode.add;
            _dtBack = GetNewCopyBook;
        }

        public frmAddBook(int BookCopyID)
        {
            InitializeComponent();
            _Mode = enMode.update;
            _BookCopyID = BookCopyID;
            ctrlPersonWithFilter1.FilterEnable = false;
        }
        private clsBookCopy _clsCopyBook;
        private void _RestDefaultValue()
        {
            if (_Mode == enMode.add)
            {
                _authorID = nullabel ?? -1;
                lbAuthorID.Text = "???";
                lbBookCopyID.Text = "???";
                lbMode.Text = "Add Book";
                txtAddInfo.Text = "".Trim();
                //txtgenre.Text = "".Trim();
                txtISBN.Text = "".Trim();
                txtTitle.Text = "".Trim();
                pbImage.Image = Resources.UnKnownThng;
                dt.MaxDate = DateTime.Now;
                dt.Value = dt.MaxDate;
                _clsCopyBook = new clsBookCopy();
                lRemove.Visible = false;
                rbHistorical.Checked = true;
                enGetBookTypes();
                btnSave.Enabled = false;
                tabBook.Enabled = false;
                tabBookCopy.Enabled = false;

                lbUsername.Text = clsGlobal.CurrentUser.Username;
                chIsAvailable.Checked = true;
                lbGenr.Text = _clsCopyBook.GetBookTypeString((clsBooks.enBookTypes)enGetBookTypes());
                ShowQuantityBookCopies();
                return;
            }
            else
                lbMode.Text = "Update Book";
        }
        
        private void _GetBookType()
        {
            if (_clsCopyBook.BookTypeID == clsBooks.enBookTypes.Philosophy)
                rbPhilosoPhy.Checked = true;
            if (_clsCopyBook.BookTypeID == clsBookCopy.enBookTypes.enHistorical)
                rbHistorical.Checked = true;
            if (_clsCopyBook.BookTypeID == clsBookCopy.enBookTypes.Psychology)
                rbPsycology.Checked = true;
                    }
        private void _LoadData()
        {
            _clsCopyBook = clsBookCopy.FindCopyBookByCopyID(_BookCopyID);
            if (_clsCopyBook==null)
            {
                MessageBox.Show("this Book ID not Found");
                return;
            }
            
            ctrlPersonWithFilter1.LoadDataPerson(_clsCopyBook.authors);
            txtAddInfo.Text = _clsCopyBook.AdditionInfo;
            
            txtISBN.Text = _clsCopyBook.ISBN.Trim();
            txtTitle.Text = _clsCopyBook.title.Trim();
            lbAuthorID.Text = _clsCopyBook.authors.ToString();
            lbUsername.Text = clsGlobal.CurrentUser.Username;
            lbBookCopyID.Text = _clsCopyBook.CopyID.ToString() ;
            dt.Value = _clsCopyBook.date;
            lbGenr.Text = _clsCopyBook.BookTypeInfo.BookType;
         //   lAuthorMode.Text = "Mode Author";
            if (_clsCopyBook.ImageBook != null)
                pbImage.ImageLocation = _clsCopyBook.ImageBook;

            chIsAvailable.Checked = (_clsCopyBook.IsAvailable?true:false);
            lRemove.Visible = (pbImage.ImageLocation!="");
            _authorID = _clsCopyBook.authors;
            
            _GetBookType();
            gbGenre.Enabled = false;
            ShowQuantityBookCopies();
            _EnableDesiableConrols();
        
        }
        private void ShowQuantityBookCopies()
        {
            if (_Mode==enMode.add)
                lbQuantityBook.Text = $"you have (0) Copies ";
            else
                lbQuantityBook.Text = $"you have ({_clsCopyBook.NumberOfCopies}) Copies ";
        }
        private void _EnableDesiableConrols()
        {
            if (_Mode==enMode.update)
            {
             //   txtgenre.Enabled = false;
                txtISBN.Enabled = false;
                txtTitle.Enabled = false;
                dt.Enabled = false;
                gbGenre.Enabled = false;

                return; 
            }
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        { 
            _RestDefaultValue();

            if (_Mode == enMode.update)
                _LoadData();
        }
public  enBookTypes enGetBookTypes()
        {
            if (rbHistorical.Checked)
                return enBookTypes.enHistorical;
            if (rbPhilosoPhy.Checked)
                return enBookTypes.Philosophy;
            else
               return enBookTypes.Psychology;
        }
        
        private  bool _HandelImage()
        {
            if (pbImage.ImageLocation!=_clsCopyBook.ImageBook)
            {
                if (_clsCopyBook.ImageBook!=null)
                {
                    File.Delete(_clsCopyBook.ImageBook);
                }
                if (pbImage.ImageLocation!=null)
                {
                    string ImagePath = pbImage.ImageLocation;
                    if (clsUtil.CopyImageToProjectFolder(ref ImagePath))
                    {
                        pbImage.ImageLocation = ImagePath;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("failed Saving Photo");
                        return false;

                    }
                }

            }
            return true;
        }
        private void Close(object sender, EventArgs e)
        {
         this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }

            if (!_clsCopyBook.IncrementBookCopies(nuQuantity.Value))
            {
                MessageBox.Show("Its required adding at least one Copy");
                return;
            }
            _clsCopyBook.date = dt.Value;
            _clsCopyBook.ISBN = txtISBN.Text;
            _clsCopyBook.title = txtTitle.Text;
            _clsCopyBook.AdditionInfo = txtAddInfo.Text;
            _clsCopyBook.authors = _authorID;
            _clsCopyBook.ImageBook = (pbImage.ImageLocation != null ? pbImage.ImageLocation : null);
            _clsCopyBook.UserID = clsGlobal.CurrentUser.UserID;
            _clsCopyBook.BookTypeID = (clsBooks.enBookTypes)enGetBookTypes();

           _clsCopyBook.IsAvailable = (chIsAvailable.Checked ? true : false);
             
            if (!_clsCopyBook.Save())
            {
                MessageBox.Show("Failed Saving Data");
                return;
            }
            MessageBox.Show("Saving Successfully");
            _dtBack?.Invoke(_clsCopyBook.CopyID);
           // lAuthorMode.Text = "Mode Author";
            _Mode = enMode.update;
            lbMode.Text = "Update Book";
            btnSave.Enabled = false;
            ShowQuantityBookCopies();

            _EnableDesiableConrols();
        
        }
        private void SetImage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files| *.jpg;*.jpeg;*.png;*.bmp;*.Gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string Path = openFileDialog1.FileName;
                pbImage.ImageLocation = Path;
                lRemove.Visible = true;
                return;
            }
            
        }

        private void lRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            pbImage.Image = Resources.UnKnownThng;
            lRemove.Visible = false;
        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            TextBox t =  (TextBox)sender;
            if (string.IsNullOrEmpty(t.Text))
            {
                e.Cancel = true;
                t.Focus();
                errorProvider1.SetError(t,"this field is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(t,null);
            }
            if (clsVaildation.IsNumber(t.Text))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(t,"this field can be enter only char");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(t, null);
            }

        }
        private void OnGetBookType(object sender, EventArgs e)
        {

            enGetBookTypes();
            RadioButton r = (RadioButton)sender;
            lbGenr.Text = r.Text;
        }
        private void NextToAddBook(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
            {
                tabBook.Enabled = true;
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (ctrlPersonWithFilter1.PersonID != -1)
            {
                if (clsUser.IsPersonIDExist(ctrlPersonWithFilter1.PersonID))
                {
                    MessageBox.Show("you can not use Person ID used by another User"
                        , "Check Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (clsReader.ExistByPersonID(ctrlPersonWithFilter1.PersonID))
                {
                    MessageBox.Show("you can not use Person ID used by another Reader"
                        , "Check Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                lbAuthorID.Text = ctrlPersonWithFilter1.PersonID.ToString();
                if (clsBooks.IsAuthorExist(ctrlPersonWithFilter1.PersonID))
                {
                    tabBook.Enabled = true;
                    tabControl1.SelectedIndex = 1;
                    _authorID = ctrlPersonWithFilter1.PersonID;
                    return;
                }
                // add new Author
                tabBook.Enabled = true;
                tabControl1.SelectedIndex = 1;
                _authorID = ctrlPersonWithFilter1.PersonID;
            }
            else
            {
                MessageBox.Show("Choose another Author");
                ctrlPersonWithFilter1.FilterFocuse();
            }
            }

        private void NextToAddBookCopy(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
            {
                btnSave.Enabled = true;
                tabBookCopy.Enabled = true;
                tabControl1.SelectedIndex = 2;
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }

            if (!_HandelImage())
            {
                MessageBox.Show("Failed Loading Image");
                return;
            }
            btnSave.Enabled = true;
            tabBookCopy.Enabled = true;
            tabControl1.SelectedIndex = 2;


        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(txtISBN, "this field is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }
            if (!clsVaildation.IsNumber(txtISBN.Text))
            {
                e.Cancel = true;
                txtISBN.Focus();
                errorProvider1.SetError(txtISBN, "this field can be enter only char");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

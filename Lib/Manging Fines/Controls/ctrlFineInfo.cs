using Lib.Properties;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manging_Fines
{
    public partial class ctrlFineInfo : UserControl
    {
        public ctrlFineInfo()
        {
            InitializeComponent();
        }
        private clsFines _FineInfo;
        public clsFines FineInfo
        {
            get
            {
                return _FineInfo;
            }
        }
        private int _FineID = -1;
        
        private void _HandelImage()
        {
            if (_FineInfo==null)
            {
                pbBook.Image = Resources.BookRandom;

                pbAuthor.Image = Resources.UnKnownThng;
                return;
            }



            string ImageAuthor = _FineInfo.BorrowingInfo.BookCopyInfo.AuthorInfo.ImagePath;
            
            if (File.Exists(ImageAuthor))
                pbAuthor.ImageLocation = ImageAuthor;

            string ImageBook = _FineInfo.BorrowingInfo.BookCopyInfo.ImageBook;
            if (File.Exists(ImageBook))
                pbBook.ImageLocation = ImageBook;
        }
       public  void _RestDefaultValue()
        {
            lbAmount.Text = "???$";
            lbBookName.Text = "???";
            lbFineID.Text = "???";
            lbIsPay.Text = "???";
            lbLateDays.Text = "???";
            lbReaderName.Text = "???";
            _HandelImage();
           // lbMessage.Visible = false;
            _FineInfo = null;
        }
        private void _LoadData()
        {
            lbAmount.Text     = _FineInfo.Amount.ToString()+"$";
            lbBookName.Text   = _FineInfo.BorrowingInfo.BookCopyInfo.title;
            lbFineID.Text     = _FineInfo.FineID.ToString();
            lbIsPay.Text      = _FineInfo.IsPay ? "Yes" : "False";
            lbLateDays.Text   = _FineInfo.LateDays.ToString() + "  Day";
            lbReaderName.Text = _FineInfo.ReaderInfo.PersonInfo.Name;
            _HandelImage();
        }
        public void LoadFineInfoByFineID(int FineID)
        {
            _FineInfo = clsFines.FindByFineID(FineID);
            if (_FineInfo==null)
            {
                MessageBox.Show("this Fine Not Found");
                _RestDefaultValue();
                return;
            }
            _FineID = FineID;
            _LoadData();
        }
        public void LoadFineInfoReaderID(int ReaderID)
        {
            _FineInfo = clsFines.FindFineByReaderID(ReaderID);
            if (_FineInfo == null)
            {
                MessageBox.Show("this Fine Not Found");
                _RestDefaultValue();
                return;
            }
            _FineID = _FineInfo.FineID;
            _LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlFineInfo_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

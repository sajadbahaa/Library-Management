using BankSystem.GlobalClasses;
using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Readers
{
    public partial class ctrlReaderCard : UserControl
    {
        public ctrlReaderCard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private clsReader _ReaderInfo;
        public clsReader ReaderInfo
        {
            get
            {
                return _ReaderInfo;
            }
        }
 public  void _RestDaefaultData()
        {
            ctrlPersoninfo1._RestDefualValue();
            lbDate.Text = "????";
            lblibCardNum.Text = "????";
            lbHasFine.Text = "????";
            lbReaderID.Text = "????";
            _ReaderInfo = null;
        }
        
       public void LoadDataReader(int ReaderID)
        {
            _ReaderInfo = clsReader.FindByReaderID(ReaderID);
            if (_ReaderInfo==null)
            {
                _RestDaefaultData();
                return;
            }
            _LoadData();
        }
        private void _LoadData()
        {
            ctrlPersoninfo1.LoadPersonInfoByPersonID(_ReaderInfo.PersonID);
            lbDate.Text = clsFormat.DateToString(_ReaderInfo.CreateDate);
            lblibCardNum.Text = _ReaderInfo.LibraryCardNumber;
            lbReaderID.Text = _ReaderInfo.ReaderID.ToString();
            lbHasFine.Text = clsFines.IsReaderHasFine(_ReaderInfo.ReaderID)?"Yes":"False";
        }
        private void ctrlReaderCard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

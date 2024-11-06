using BankSystem.GlobalClasses;
using Global;
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
using TestOnenericControls;

namespace Lib.Readers
{
    public partial class frmAddReader : Form
    {
        private int _ReaderID ;


        public  enum enMode { add = 1,update =2}
        private enMode _Mode = enMode.add;
        public frmAddReader(int ReaderID)
        {
            InitializeComponent();
            _ReaderID = ReaderID;
            _Mode = enMode.update;
        }
        public Action <int>_DataBack;
        
        public frmAddReader()
        {
            InitializeComponent();
            _Mode = enMode.add;
        }
        private clsReader _ReaderInfo;
        private void _ResetDefaultValue()
        {
            btnSave.Enabled = false;
            tabReaderInfo.Enabled = false;

            if (_Mode == enMode.add)
            {
                lbMode.Text = "Add Reader";
                lbName.Text = "????";
                lbReaderID.Text = "????";
                lbDate.Text = "????";
                lbUsername.Text = "????";
                lbDate.Text = clsFormat.DateToString(DateTime.Now);
                _ReaderInfo = new clsReader();
            }
            else
                lbMode.Text = "Update Reader";
        }
     private void _FillDataBeforeSaving()
        {
            lbName.Text = ctrlPersonWithFilter1.PersonSelected.Name;
            lbUsername.Text = clsGlobal.CurrentUser.Username;
            btnSave.Enabled = true;
            tabReaderInfo.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddReader_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }

        private void lbUserID_Click(object sender, EventArgs e)
        {

        }

        private void NextToAddReader(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
            {
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                tabReaderInfo.Enabled = true;
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
                if (clsBooks.IsAuthorExist(ctrlPersonWithFilter1.PersonID))
                {
                    MessageBox.Show("you can not use Person ID used by Authors"
                        , "Check Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                _FillDataBeforeSaving();
            }
            else
            {
                MessageBox.Show("Choose person ID","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }
            if (MessageBox.Show("Do you want add Reader ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }
            _ReaderInfo.CreateDate = DateTime.Now;
            _ReaderInfo.LibraryCardNumber = txtLibraryCardNumber.Text.Trim();
            _ReaderInfo.PersonID = ctrlPersonWithFilter1.PersonID;
            _ReaderInfo.UserID = clsGlobal.CurrentUser.UserID;
            
            if (!_ReaderInfo.Save())
            {
                MessageBox.Show("Failed Saving");
                return;
            }
            MessageBox.Show("Added Reader Successfully");
            lbReaderID.Text = _ReaderInfo.ReaderID.ToString();
        
            lbMode.Text = "Update Reader";
            _Mode = enMode.update;
            btnSave.Enabled = false;
            _DataBack?.Invoke(_ReaderInfo.ReaderID);
        }

        private void CLose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLibraryCardNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibraryCardNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLibraryCardNumber,"this field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLibraryCardNumber, null);
            }
            if (_ReaderInfo.LibraryCardNumber != txtLibraryCardNumber.Text &&
                clsReader.IsLibraryCardNumberExist(txtLibraryCardNumber.Text))
            {
                e.Cancel = true;
                txtLibraryCardNumber.Focus();
                errorProvider1.SetError(txtLibraryCardNumber, "its used choose another");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLibraryCardNumber, null);
            }
        }

        private void lbMode_Click(object sender, EventArgs e)
        {

        }
    }
}

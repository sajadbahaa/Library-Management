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
using System.Xml.Linq;

namespace Lib.Readers
{
    public partial class frmUpdateReader : Form
    {
        public enum enMode { UpdateManualy =1,UpdateDirectly =2}
        public enMode Mode = enMode.UpdateManualy;
        public frmUpdateReader()
        {
            InitializeComponent();
            Mode = enMode.UpdateManualy;
        }
        public frmUpdateReader(int ReaderID)
        {
            InitializeComponent();
            ctrlFindReader1.FilterEnable = false;
            ctrlFindReader1.LoadReaderData(ReaderID);
            Mode = enMode.UpdateDirectly;
        }

        private clsReader _ReaderInfo;

        private void DefaultData()
        {

            lbName.Text = "????";
            lbReaderID.Text = "????";
            lbDate.Text = "????";
            lbUsername.Text = "????";
            _ReaderInfo = new clsReader();
            btnSave.Enabled = false;
            tabUpdateReader.Enabled = false;
            return; 
        }
        

        private void _FillDataReader()
        {
            lbReaderID.Text = ctrlFindReader1.ReaderInfo.ReaderID.ToString();

            lbDate.Text = clsFormat.DateToString(DateTime.Now);
            lbName.Text = ctrlFindReader1.ReaderInfo.PersonInfo.Name;
            lbReaderID.Text = ctrlFindReader1.ReaderInfo.ReaderID.ToString();
            lbUsername.Text = clsGlobal.CurrentUser.Username;
            txtLibraryCardNumber.Text = ctrlFindReader1.ReaderInfo.LibraryCardNumber.Trim();
            
        }
        private void txtLibraryCardNumber_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ctrlUpdateReader_Load(object sender, EventArgs e)
        {

        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
        
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
            if (MessageBox.Show("Do you want add Reader ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }
            _ReaderInfo.CreateDate = DateTime.Now;
            _ReaderInfo.LibraryCardNumber = txtLibraryCardNumber.Text.Trim();
            _ReaderInfo.PersonID = ctrlFindReader1.ReaderInfo.PersonID;
            _ReaderInfo.UserID = clsGlobal.CurrentUser.UserID;

            if (!_ReaderInfo.Save())
            {
                MessageBox.Show("Failed Saving");
                return;
            }
            MessageBox.Show("Update Reader Successfully");
            btnSave.Enabled = false;

        }

        private void frmUpdateReader_Load(object sender, EventArgs e)
        {
            DefaultData();

            if (Mode == enMode.UpdateDirectly)
                _FillDataReader();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (Mode==enMode.UpdateDirectly)
            {
                tabUpdateReader.Enabled = true;
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                _ReaderInfo = ctrlFindReader1.ReaderInfo;
                return;
            }

            if (ctrlFindReader1.ReaderInfo!=null)
            {
                _FillDataReader();
                tabUpdateReader.Enabled = true;
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                _ReaderInfo = ctrlFindReader1.ReaderInfo;
                return;
            }
            else
            {
                MessageBox.Show("Error choose another ","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                DefaultData();
            }


        }

        private void txtLibraryCardNumber_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibraryCardNumber.Text))
            {
                e.Cancel = true;
                txtLibraryCardNumber.Focus();
                errorProvider1.SetError(txtLibraryCardNumber,"field should never be empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLibraryCardNumber, null);
            }
        
            if(ctrlFindReader1.ReaderInfo.LibraryCardNumber!=txtLibraryCardNumber.Text&&
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
    }
}

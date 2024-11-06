using BankBussiness;
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
using Vaildation;

namespace Lib
{
    public partial class frmAddUsers : Form
    {
        private clsUser _clsUserInfo;
        enum enMode
        { Add = 1, update = 2 }
        private enMode _Mode = enMode.Add;

        public frmAddUsers()
        {
            InitializeComponent();
            _Mode = enMode.Add;    
        }
        private int _UserID = -1;
        public frmAddUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.update;
            ctrlPersonWithFilter1.FilterEnable = false;
        }
        private void _ResetDefaultValue()
        {
            lbMode.Text = "Add User";
            lbUserID.Text = "[????]";
            txtPassword.Text = "".Trim();
            txtUsername.Text = "".Trim();
            chIsActive.Checked = true;
            btnSave.Enabled = false;
            tabUserInfo.Enabled = false;
            // btnNext.Enabled = false;
            _clsUserInfo = new clsUser();
            return;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillUserInfo()
        {

            _clsUserInfo = clsUser.FindByUserID(_UserID);
            if (_clsUserInfo == null)
            {
                MessageBox.Show("this user ID not Found", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbMode.Text = "Update User";

            ctrlPersonWithFilter1.LoadDataPerson(_clsUserInfo.PersonID);
            lbUserID.Text = _clsUserInfo.UserID.ToString();
            txtUsername.Text = _clsUserInfo.Username;
            txtPassword.Text = _clsUserInfo.Password;
            txtConfirmPassword.Text = txtPassword.Text;
            lbPermission.Text = _clsUserInfo.Permission.ToString();
            chIsActive.Checked = (_clsUserInfo.IsActive?true:false);
        }
        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.update)
                _FillUserInfo();
        }

        private void ctrlAddUsers1_Load(object sender, EventArgs e)
        {

        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            // handel should not enter empty
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
            // you should not enter numbers
            if (clsVaildation.IsNumber(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "you should not enter Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
            if (_Mode == enMode.Add && clsUser.IsUsernameExist(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "this Username used by another user");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // handel should not enter empty
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }


        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            // check Confirm Password match with Password
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "this Confirm Password does not match with Current Password");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }


        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private int ReadPermissionToSet()
        {
            int Permission = 0;
            if
(MessageBox.Show("Do you want to give full Access", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return -1;
            }
            if
(MessageBox.Show("Do you want to give access to Show eReaderList", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eReaderList;
            }
            if
(MessageBox.Show("Do you want to give access to AddReader", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eAddReader;
            }
            if
(MessageBox.Show("Do you want to give access to UpdateReader", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eUpdateReader;
            }
            if
(MessageBox.Show("Do you want to give access to DeleteReader ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eDeleteReader;
            }
            if
(MessageBox.Show("Do you want to give access to Find Reader", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eFindReader;
            }
            if
(MessageBox.Show("Do you want to give access to Manage Users", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eManageUser;
            }

            
           
            return Permission;
        }
        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }

            _clsUserInfo.Username = txtUsername.Text;
            _clsUserInfo.Password = clsGlobal.EncryptDataByHashing(txtPassword.Text);
            _clsUserInfo.PersonID = ctrlPersonWithFilter1.PersonID;
            _clsUserInfo.IsActive = (chIsActive.Checked ? true : false);
            _clsUserInfo.Permission = ReadPermissionToSet();
            bool IsSave = _clsUserInfo.Save();
            if (!IsSave)
            {
                MessageBox.Show("Failed Saving Data", "Error Exaption",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saved Successfully");
           
            lbUserID.Text = _clsUserInfo.UserID.ToString();
            btnSave.Enabled = false;
            lbPermission.Text = _clsUserInfo.Permission.ToString();
            _Mode = enMode.Add;
            lbMode.Text = "Update User";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
            {
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                tabUserInfo.Enabled = true;
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

                // you can add User
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                tabUserInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Choose Person ID");
                ctrlPersonWithFilter1.FilterFocuse();
            }
        }

        private void tabUserInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

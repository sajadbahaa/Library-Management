using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using TestOnenericControls;
using Vaildation;
using BankBussiness;
namespace ctrlAddUser
{
    public partial class ctrlAddUsers: UserControl
    {
        public ctrlAddUsers()
        {
            InitializeComponent();
        }
        public enum enMode { add = 1, update =2}

        public enMode _Mode = enMode.add;
        private clsUser _UserInfo;
        public clsUser UserInfo
        {
            get
            {
                return _UserInfo;
            }
        }
        
       public void ResetDefaultValue()
        {
            lbMode.Text = "Add User".Trim();
            txtConfirmPassword.Text = "".Trim();
            txtPassword.Text = "".Trim();
            txtUsername.Text = "".Trim();
            lbPermission.Text = "?".Trim();
            chIsActive.Checked = true;
            btnSave.Enabled = false;
            tabAddUser.Enabled = false;
            _UserInfo = new clsUser();
        }
       public void LoadData(int UserID)
        {
            _UserInfo = clsUser.FindByUserID(UserID);
            if (_UserInfo==null)
            {
                _Mode = enMode.add;
                MessageBox.Show("this UserID not Found");
                ResetDefaultValue();
                return;
            }
            _LoadDataUser();
        }
        
        private void _LoadDataUser()
        {

            _Mode = enMode.update;
            lbMode.Text = "Upadate User";

            ctrlPersonCardWithFilter1.LoadDataPerson(_UserInfo.PersonID);
            ctrlPersonCardWithFilter1.FilterEnable = false;
            
            lbPermission.Text = _UserInfo.Permission.ToString();
            txtPassword.Text = _UserInfo.Password;
            txtUsername.Text = _UserInfo.Username;
            chIsActive.Checked = (_UserInfo.IsActive?true:false);
        }

        private void lbMode_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void NextToAddUserInfo(object sender, EventArgs e)
        {
            if (_Mode==enMode.update)
            {
                btnSave.Enabled = true;
                tabControl1.SelectedIndex = 1;
                tabAddUser.Enabled = true;
                return;
            }
            if (ctrlPersonCardWithFilter1.PersonID!=-1)
            {
                if (clsUser.IsPersonIDExist(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("sorry this PersonID used By another user");
                    return;
                }
                tabControl1.SelectedIndex =1;
                tabAddUser.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("choose another PersonID");
                ctrlPersonCardWithFilter1.FilterFocuse();
            }

            
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
        }


        private void ctrlAddUsers_Load(object sender, EventArgs e)
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
            
            if (clsUser.IsUsernameExist(txtUsername.Text)&&_Mode==enMode.add)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "this Username is used");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want?","Save Data",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==DialogResult.No)
            {
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are still not Completed");
                return;
            }
            _UserInfo.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _UserInfo.Username = txtUsername.Text.Trim();
            _UserInfo.Password = txtPassword.Text.Trim();

            if (chIsActive.Checked)
                _UserInfo.IsActive = true;
            else
                _UserInfo.IsActive = false;

            _UserInfo.Permission = ReadPermissionToSet();


            if (!_UserInfo.Save())
            {
                MessageBox.Show("Failed Adding Data");
                return;
            }
            MessageBox.Show("Saved Successfully");
        
            lbUserID.Text = _UserInfo.UserID.ToString();
            lbPermission.Text = _UserInfo.Permission.ToString();

            btnSave.Enabled = false;
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
(MessageBox.Show("Do you want to give access to Show Client List", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eReaderList;
            }
            if
(MessageBox.Show("Do you want to give access to Add Reader", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eAddReader;
            }
            if
(MessageBox.Show("Do you want to give access to Update Reader", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eUpdateReader;
            }
            if
(MessageBox.Show("Do you want to give access to Delete Reader ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

//            if
//(MessageBox.Show("Do you want to give access to TransAction", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
//            {
//                Permission += (int)clsSettings.enPermissions.eTransAction;
//            }

//            if
//(MessageBox.Show("Do you want to give access to Transfer", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
//            {
//                Permission += (int)clsSettings.enPermissions.eTransfer;
//            }

            return Permission;
        }

        private void tabAddUser_Click(object sender, EventArgs e)
        {

        }
    }
}

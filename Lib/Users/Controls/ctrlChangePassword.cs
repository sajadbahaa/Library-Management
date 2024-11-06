using Global;
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

namespace Lib.Users.Controls
{
    public partial class ctrlChangePassword : UserControl
    {
        public ctrlChangePassword()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ctrlChangePassword_Load(object sender, EventArgs e)
        {

        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfiPas.Text))
            {
                e.Cancel = true;
                txtConfiPas.Focus();
                errorProvider1.SetError(txtConfiPas, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfiPas, null);
            }

            // check Confirm Password match with Password
            if (txtConfiPas.Text != txtNewPas.Text)
            {
                e.Cancel = true;
                txtConfiPas.Focus();
                errorProvider1.SetError(txtConfiPas, "this Confirm Password does not match with Current Password");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfiPas, null);
            }

        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // handel should not enter empty
            if (string.IsNullOrEmpty(txtNewPas.Text))
            {
                e.Cancel = true;
                txtNewPas.Focus();
                errorProvider1.SetError(txtNewPas, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPas, null);
            }


        }

        public void LoadDataUser(int UserID)
        {
            ctrlUserCard1.UserInfo = clsUser.FindByUserID(UserID);
            if (ctrlUserCard1.UserInfo==null)
            {
                _ResetDefaultValue();
                return;
            }
            ctrlUserCard1.UserID = UserID;
            _LoadData();
        }
        private void _ResetDefaultValue()
        {
            ctrlUserCard1._ResetDefaultValue();
            txtConfiPas.Text = "".Trim();
            txtCurrentPas.Text = "".Trim();
            txtNewPas.Text = "".Trim();
        }
       private void _LoadData()
        {
            ctrlUserCard1.LoadDataUser(ctrlUserCard1.UserID);
            txtCurrentPas.Text = ctrlUserCard1.UserInfo.Password;
        }
        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are still not completed");
                return;
            }
            if (MessageBox.Show("are you sure?", "Change Password",
                MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.No)
                return;


         bool IsSave =    ctrlUserCard1.UserInfo.ChangePassword(clsGlobal.EncryptDataByHashing(txtNewPas.Text));
            if (!IsSave)
                MessageBox.Show("Failed Saving");
            else
                MessageBox.Show("Saved Password Successfully");
        }
    }
}

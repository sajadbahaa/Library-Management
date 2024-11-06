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

namespace Lib.Users
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }
        private int _UserID;
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        public void _ResetDefaultValue()
        {
            ctrlPersoninfo1._RestDefualValue();
            lbIsActive.Text = "????";
            lbPermission.Text = "????";
            lbUserID.Text = "????";
            lbUsername.Text = "????";
        }

        private clsUser _UserInfo;
        public clsUser UserInfo
        {
            get
            {
                return _UserInfo;
            }
            set
            {
                _UserInfo = value;
            }
        }
        public void LoadDataUser(int UserID)
        {
            _UserInfo = clsUser.FindByUserID(UserID);
            if (_UserInfo == null)
            {
                MessageBox.Show("this UserID not Found");
                _ResetDefaultValue();
                return;
            }
            _LoadData();
        }
        private void _LoadData()
        {
            _UserID = _UserInfo.UserID;
            ctrlPersoninfo1.LoadPersonInfoByPersonID(_UserInfo.PersonID);
            lbIsActive.Text = (_UserInfo.IsActive?"yes":"no");
            lbPermission.Text = _UserInfo.Permission.ToString();
            lbUserID.Text = _UserInfo.UserID.ToString();
            lbUsername.Text = _UserInfo.Username;
        }
    }
}

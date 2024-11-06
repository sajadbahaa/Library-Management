

using BankBussiness;
using Global;
using LibBussiness;
using Logger;
using Microsoft.SqlServer.Server;
using ReteieveData;

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

namespace Lib
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

                private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
       // private clsRetrievData _RetrievData;
        
        private void OnLoginClick(object sender, EventArgs e)
        {
            clsUser userInfo = clsUser.FindByUsernameAndPassword(txtUsername.Text.Trim(), clsGlobal.EncryptDataByHashing (txtPassword.Text.Trim()));

            if (userInfo==null)
            {
                MessageBox.Show("Username/Password is wrong","check Info",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            

            if (!userInfo.IsActive)
            {
            MessageBox.Show("your Card not Active");
                return;
            }

            if (chRmmberMe.Checked)
                clsGlobal.RemmberMe(txtUsername.Text.Trim());
            else
                clsGlobal.DeleteRegister();

            clsGlobal.CurrentUser = userInfo;

            //if (!clsGlobal.AddRegister())
            //    MessageBox.Show("you have to Register first");
            //else
            //{
            //}
            clsGlobal.CurrentSettings = clsSettings.GetSettingsValue();
            frmMainScreen frm = new frmMainScreen();
            frm.ShowDialog();



        }


       
          
        private  void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "";


            if (clsGlobal._ReadDataFromRegistry(ref Username))
            {
                txtUsername.Text = Username;
                chRmmberMe.Checked = true;
            }
            else
            {
                chRmmberMe.Checked = false;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        
      {
            if (e.KeyChar == (char)13)
            {
                btnClick.PerformClick();
                txtPassword.Text = txtPassword.Text.Trim();
            }
        }
    }
}

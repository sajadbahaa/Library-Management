using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Users
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            ctrlChangePassword1.LoadDataUser(UserID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ctrlChangePassword1_Load(object sender, EventArgs e)
        {

        }
    }
}

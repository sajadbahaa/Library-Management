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
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadDataUser(UserID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

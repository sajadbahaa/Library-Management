using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Notify
{
    public partial class frmShowNotifyInfo : Form
    {
        public frmShowNotifyInfo(int ID)
        {
            InitializeComponent();
            ctrlNotifyInfo1.LoadNotifyData(ID);
        }

        private void frmShowNotifyInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

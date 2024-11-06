using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Books
{
    public partial class frmShowBookInfo : Form
    {
        public frmShowBookInfo(string title)
        {
            InitializeComponent();

            ctrlShareScreen1.LoadTitleInfo("Book Info");
            ctrlBookInfo1.LoadBookInfoByTitle(title);
        }
        public frmShowBookInfo(int CopyID)
        {
            InitializeComponent();

            ctrlShareScreen1.LoadTitleInfo("Book Info");
            ctrlBookInfo1.LoadBookInfoByCopyID(CopyID);
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

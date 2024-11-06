using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Books
{
    public partial class frmFindBook : Form
    {
        public frmFindBook()
        {
            InitializeComponent();
        }
        public clsBookCopy obj;
        private void ctrlBookInfoWithFilter1_OnBookCopySelected(object sender, Controls.ctrlBookInfoWithFilter.clsBookCopiesInfo e)
        {
            if (e.BookCopyInfo.CopyID ==-1)
            {
                return;
            }
            obj = e.BookCopyInfo;
            MessageBox.Show(obj.title);
        }

        private void frmFindBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBookCopy o = obj;
            MessageBox.Show(o.title);
        }
    }
}

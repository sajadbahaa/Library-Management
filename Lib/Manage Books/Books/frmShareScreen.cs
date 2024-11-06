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
    public partial class frmShareScreen : Form
    {
        public frmShareScreen(string title)
        {
            InitializeComponent();
            lbTitle.Text = title;
        }

        private void frmShareScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

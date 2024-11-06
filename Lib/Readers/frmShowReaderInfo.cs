using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Readers
{
    public partial class frmShowReaderInfo : Form
    {
        public frmShowReaderInfo(int ReaderID)
        {
            InitializeComponent();
            ctrlReaderCard1.LoadDataReader(ReaderID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

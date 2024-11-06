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
    public partial class frmFindReader : Form
    {
        public frmFindReader()
        {
            InitializeComponent();
        }
        public frmFindReader(int ReaderID)
        {
            InitializeComponent();
            ctrlReaderInfo1.FilterEnable = false;
            ctrlReaderInfo1.LoadReaderData(ReaderID);        
        
        }

        

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindReader_Load(object sender, EventArgs e)
        {

        }
    }
}

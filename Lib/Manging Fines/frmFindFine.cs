using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manging_Fines
{
    public partial class frmFindFine : Form
    {
        public frmFindFine()
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Find Fines");
        }

        private void frmFindFine_Load(object sender, EventArgs e)
        {

        }

        private void ctrlFindFineWithFilter1_OnFineInfoSelected(LibBussiness.clsFines obj)
        {

        }

        private void ctrlShareScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}

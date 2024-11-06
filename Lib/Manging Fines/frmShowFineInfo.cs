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
    public partial class frmShowFineInfo : Form
    {
        private int _FineID = -1;
        public frmShowFineInfo(int ID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Fine Info");
            _FineID = ID;
        }


        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowFineInfo_Load(object sender, EventArgs e)
        {
            ctrlFineInfo1.LoadFineInfoByFineID(_FineID);
        }

        private void ctrlShareScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}

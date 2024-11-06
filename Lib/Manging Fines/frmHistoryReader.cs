using LibBussiness;
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
    public partial class frmHistoryReader : Form
    {
        private int _ReaderID =-1;
        public frmHistoryReader(int ReaderID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("History Reader");
            _ReaderID = ReaderID;
        }
        private DataView dtv;
        private void _LoadData()
        {
            ctrlReaderCard1.LoadDataReader(_ReaderID);
            dtv = clsFines.GetAllFinesByReaderID(_ReaderID).DefaultView;
            dtgview.DataSource = dtv;
        }
        private void frmHistoryReader_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}

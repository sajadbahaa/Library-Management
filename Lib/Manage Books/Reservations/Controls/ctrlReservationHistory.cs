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

namespace Lib.Manage_Books.Reservations.Controls
{
    public partial class ctrlReservationHistory : UserControl
    {
        public ctrlReservationHistory()
        {
            InitializeComponent();
        }
         private int _ReaderID { get; set; }
      private void _LoadData()
        {
            DataView dtv = clsReservation.GetAllReservationsByReaderID(_ReaderID).DefaultView;
            dtgview.DataSource = dtv;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
        public void LoadDataResevationByReaderID(int PersonID,int ReaderID)
        {
            ctrlPersoninfo1.LoadPersonInfoByPersonID(PersonID);
            _ReaderID = ReaderID;
            _LoadData();
        }

        private void ctrlReservationHistory_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

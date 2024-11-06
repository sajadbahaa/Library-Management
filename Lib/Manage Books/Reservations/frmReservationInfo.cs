using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Reservations
{
    public partial class frmReservationInfo : Form
    {
        public frmReservationInfo(int ReservationID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Reservation Info");
            ctrlReservationInfo1.LoadDataByReservationID(ReservationID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReservationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

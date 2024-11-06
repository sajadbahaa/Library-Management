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
    public partial class frmHistoryReservation : Form
    {
        public frmHistoryReservation(int ReaderID,int PersonID)
        {
            InitializeComponent();
            ctrlShareScreen1.LoadTitleInfo("Reservation History");
            ctrlReservationHistory1.LoadDataResevationByReaderID(PersonID, ReaderID);
        }

        private void frmHistoryReservation_Load(object sender, EventArgs e)
        {

        }
    }
}

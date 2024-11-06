using LibBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Manage_Books.Reservations
{
    public partial class ctrlReservationInfo : UserControl
    {
        public ctrlReservationInfo()
        {
            InitializeComponent();
        }
        private int _ReservationID = -1;
        public int ReservationID
        {
            get
            {
                return _ReservationID; 
            }
        }
        
        private clsReservation _ReservationInfo;
        public clsReservation ReservationInfo
        {
            get
            {
                return _ReservationInfo;
            }
        }

    public void _ResetDefaultValue()
        {
            _ReservationID = -1;
           
            ctrlReaderCard1._RestDaefaultData();
            lbBookName.Text = "???";
            lbIsLock.Text = "???";
            lbReservID.Text = "???";
            lbMessage.Visible = false;
            _ReservationInfo = null;
            _ReservationInfo = null;
        }
        private void LoadData()
        {

            ctrlReaderCard1.LoadDataReader(_ReservationInfo.ReaderID);
            lbReservID.Text = _ReservationInfo.ReservationID.ToString();
            lbBookName.Text = _ReservationInfo.CopyInfo.title;
            lbIsLock.Text = _ReservationInfo.IsLock ? "Yes":"false";
            _ReservationID = _ReservationInfo.ReservationID;
            lbMessage.Visible = _ReservationInfo.IsLock ? false : true;
        }
       public void LoadDataByReservationID(int ReservationID)
        {
            _ReservationInfo = clsReservation.FindByReservationD(ReservationID);
            if (_ReservationInfo==null)
            {
                MessageBox.Show("this ReservationID not found");
                _ResetDefaultValue();
                return; 
            }
            LoadData();
        }

        private void ctrlReservationInfo_Load(object sender, EventArgs e)
        {
            lbMessage.Visible = false;
        }
    }
}

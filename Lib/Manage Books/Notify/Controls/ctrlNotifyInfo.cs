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

namespace Lib.Manage_Books.Notify.Controls
{
    public partial class ctrlNotifyInfo : UserControl
    {
        public ctrlNotifyInfo()
        {
            InitializeComponent();
        }
        private clsNotify _NotifyInfo;
        public clsNotify NotifyInfo
        {
            get
            {
                return _NotifyInfo;
            }
        }
        
        private int _NotifyID = -1;
        public int NotifyID
        {
            get
            {
                return _NotifyID;
            }
        }
       private  void _LoadData()
        {
            ctrlShareScreen1.LoadTitleInfo("Notifycations");
            lbNotifyName.Text = _NotifyInfo.Message.ToString().Trim();
        }
        public void _RestDefualtValue()
        {
            lbNotifyName.Text = "Not Found";
            _NotifyInfo = null;
        }
        public void LoadNotifyData(int NotifyID)
        {
            _NotifyInfo = clsNotify.FindByNotifyID(NotifyID);
            if (_NotifyInfo==null)
            {
                MessageBox.Show("this NotifyID not found");
                _RestDefualtValue();
                return;
            }
            _NotifyID = NotifyID;
            _LoadData();
        }
        private void ctrlNotifyInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

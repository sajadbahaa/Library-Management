using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibBussiness
{
    public class clsNotify
    {
    public string Message { get; set; }
    public int CopyID { get; set; }
       public int NotifyID { get;}
        public clsNotify()
        {
        int ?nulla = null;
            Message = nulla?.ToString();
            CopyID = nulla ?? -1;
            NotifyID = -1;
        }
        public clsBookCopy BookCopyInfo { get; }

        private clsNotify(int NotifyID,int CopyID,string Message)
        {
            this.Message = Message;
            this.NotifyID = NotifyID;
            this.CopyID = CopyID;
            this.BookCopyInfo = clsBookCopy.FindCopyBookByCopyID(CopyID);
        }

     public static clsNotify FindByNotifyID(int NotifyID)
        {
            int CopyID = -1;
            string msg = "";
            bool IsFind = dtNotifycation.FindbyNotifyID(NotifyID, ref msg, ref CopyID);
            if (IsFind)
                return new clsNotify(NotifyID, CopyID, msg);
            else
                return null;
        }
        public void SubscribeSendingNotify(clsInformation Info)
        {
            Info.OnUpdateStatus += AddNotify;
        }

        public void SubscribeSendingNotifyUnAvailable(clsInformation Info)
        {
            Info.OnUpdateStatus += AddNotifyUnAvailable;
        }


        public void AddNotify(clsBookCopy e,string Message)
        {
            _AddAvailbale(Message,e.CopyID);
        }
        public void AddNotifyUnAvailable(clsBookCopy e, string Message)
        {
            _AddUnAvailbale(Message, e.CopyID);
        }

        static public DataTable GetAllNotify()
        {
            return dtNotifycation.GetAllNotify();
        }
        static public DataTable GetAllNotify(int CopyID)
        {
            return dtNotifycation.Find(CopyID);
        }
        private bool _AddAvailbale(string Message,int CopyID)
        {
            return dtNotifycation.AddNotifyAvailabel(Message,CopyID);
        }
        private bool _AddUnAvailbale(string Message, int CopyID)
        {
            return dtNotifycation.AddNotifyUnAvailabel(Message, CopyID);
        }

    }
}

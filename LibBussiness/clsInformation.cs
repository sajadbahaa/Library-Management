using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibBussiness
{
    public class clsInformation
    {
        public Action<clsBookCopy,string> OnUpdateStatus;
        private decimal Avialbale = 1;
        private decimal UnAvailable = 0;
        
        public void SetBookCopyAvailable(clsBookCopy CopyInfo)
        {
            if (UnAvailable == CopyInfo.NumberOfCopies)
            {
string Message = $"this Book ({CopyInfo.title}) Became Available";
                OnUpdatedStatus(CopyInfo,Message);
            }

        }
        public void SetBookCopyUnAvailable(clsBookCopy CopyInfo)
        {
            if (Avialbale == CopyInfo.NumberOfCopies)
            {
                string Message = $"this Book ({CopyInfo.title}) Became UnAvailable";
                OnUpdatedStatus(CopyInfo, Message);
            }
        }
        
        public virtual void OnUpdatedStatus(clsBookCopy e,string Message)
        {
            OnUpdateStatus?.Invoke(e,Message);
        }       
    }
}

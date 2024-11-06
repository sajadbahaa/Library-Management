using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static LibBussiness.clsBooks;

namespace LibBussiness
{
    public class clsBookNotify
    {
        public Action <clsBookCopy>OnSendingNotify;
        public bool IsAvailabel = false;
        public void UpdateValue(clsBookCopy obj)
        {
            if (obj.IsAvailable!=IsAvailabel)
            {
                OnSendingNotify?.Invoke(new clsBookCopy(

                    obj.CopyID, obj.BookID, obj.NumberOfCopies,
            obj.IsAvailable, obj.authors, obj.UserID, obj.ISBN,
     obj.title, obj.BookTypeID
            , obj.date, obj.AdditionInfo, obj.ImageBook));
                    }
        }
    
    }
}

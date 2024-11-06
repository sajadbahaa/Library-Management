using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBussiness
{
    public class clsBookTypes
    {
    
    public int BookTypeID { get;}
    public string BookType { get; }

public clsBookTypes(int BookTypeID,string BookType)
        {
            this.BookType = BookType;
            this.BookTypeID = BookTypeID;
        }
    public static clsBookTypes Find(int BookTypeID)
        {
            string bookType = "";
            if (dtBookTypes.Find(BookTypeID, ref bookType))
                return new clsBookTypes(BookTypeID, bookType);
            else
                return null;
        }
     
       public static DataTable GetAllBookType()
        {
            return (dtBookTypes.GetAllBookTypes());
        }
    }
}

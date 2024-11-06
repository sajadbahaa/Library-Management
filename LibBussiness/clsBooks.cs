using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;

namespace LibBussiness
{
    public class clsBooks
    {
    public int BookID { get; set; }
    public int authors { get; set; }
    public string title { get; set; }
    public string ISBN { get; set; }
    public DateTime date { get; set; }
    public string AdditionInfo { get; set; }
 public string ImageBook { get; set; }
        public int UserID { get; set; }
    public  enBookTypes BookTypeID { get; set; }
        public clsPerson AuthorInfo { get; set; }
    public clsUser UserInfo { get; set; }
    public  enum enBookTypes 
     {enHistorical  =1 ,Psychology  =2,Philosophy = 3}

        public enum enMode { add = 1,update =2}
        public enMode Mode = enMode.add;
public string GetBookTypeString(enBookTypes type)
        {
            switch (type)
            {
                case enBookTypes.enHistorical:
                    return "Historical";
                case enBookTypes.Psychology:
                    return "Psychology";
                case enBookTypes.Philosophy:
                    return "Philosophy";
                default:
                    return "Un Known";
            }
        }
    public clsBooks()
        {
            int? nullabe = null;
            DateTime? dt = null;
            BookID = nullabe ?? 0;
            authors = nullabe ?? 0;
            title = nullabe?.ToString();
            date = dt ?? DateTime.Now;
            UserID = nullabe ?? 0;
            AdditionInfo = nullabe?.ToString();
            ISBN = nullabe?.ToString();
            Mode = enMode.add;
            ImageBook = nullabe?.ToString();
        }
        public clsBookTypes BookTypeInfo { get; set; }
    public clsBooks(int BookID,int authors,int UserID,string ISBN,
     string title,DateTime date,string AdditionInfo, string ImageBook,enBookTypes BookTypeID)
        {
            Mode = enMode.update;
            this.UserID = UserID;
            this.date = date;
            this.authors = authors;
            this.AdditionInfo = AdditionInfo;
            this.BookID = BookID;
            this.ISBN = ISBN;
            this.title = title;
            this.ImageBook = ImageBook;
            this.BookTypeID = BookTypeID;
            this.AuthorInfo = clsPerson.FindByPersonID(authors);
            this.UserInfo = clsUser.FindByUserID(UserID);
            this.BookTypeInfo = clsBookTypes.Find((int)BookTypeID);
        }
    
    static public clsBooks FindByBookID(int bookID)
        {

            int UserID = -1, author = -1;
            string additionInfo = "", ImageBook = "", ISBN = "", title = "";
            DateTime dt  = DateTime.Now;
            int  BookTypeID = -1;
            bool IsFound = dtBooks.Find(bookID,
                ref title, ref author, ref ISBN, ref dt, ref BookTypeID,
                ref additionInfo
                , ref UserID,ref ImageBook);

            if (IsFound)
                return new clsBooks(bookID, author, UserID, ISBN, title,
 dt, additionInfo, ImageBook,(enBookTypes)BookTypeID);
            else
                return null;
        }

        static public clsBooks FindByISBN(string ISBN)
        {
            int UserID = -1, author = -1, bookID = -1;
            string additionInfo = "", ImageBook = "", title = "";
            DateTime dt = DateTime.Now;
            int BookTypeID = -1;
            bool IsFound = dtBooks.Find( ref bookID,
                ref title, ref author,  ISBN, ref dt, ref BookTypeID, ref additionInfo
                , ref UserID,ref ImageBook);

            if (IsFound)
                return new clsBooks(bookID, author, UserID, ISBN, title,
 dt, additionInfo, ImageBook, (enBookTypes)BookTypeID);
            else
                return null;
        }
        static public clsBooks FindByTitle(string title)
        {
            int UserID = -1, author = -1, bookID = -1;
            string additionInfo = "", ImageBook = "", ISBN  = "";
            DateTime dt = DateTime.Now;
            int BookTypeID = -1;
            bool IsFound = dtBooks.Find(ref bookID,
                title, ref author, ref  ISBN, ref dt, ref BookTypeID, ref additionInfo
                , ref UserID,ref ImageBook);

            if (IsFound)
                return new clsBooks(bookID, author, UserID, ISBN, title,
dt, additionInfo, ImageBook, (enBookTypes)BookTypeID);
            else
                return null;
        }
        private bool _Add()
        {
            this.BookID = dtBooks.Add(this.title,this.authors,this.ISBN,this.date,
               (int)this.BookTypeID,this.AdditionInfo,this.UserID,this.ImageBook);
            return (this.BookID>-1);
        }
       private bool _Update()
        {
            return (dtBooks.Update(this.BookID,this.AdditionInfo,this.UserID, this.ImageBook));
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.add:

                    if (_Add())
                    {
                        Mode = enMode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.update:
                    return _Update();
            }
            return false;
        }
 static public bool Delete(int BookID)
        {
            return dtBooks.Delete(BookID);
        }
         public bool Delete()
        {
            return dtBooks.Delete(this.BookID);
        }

        public static bool IsAuthorExist(int AuthorID)
        {
            return (dtBooks.IsAuthorExist(AuthorID));
        }

    public static DataTable GetAllBooks()
        {
            return (dtBooks.GetAllBooks());
        }
    public static DataTable GetAllBooksByAuthorID(int AuthorID)
        {
            return (dtBooks.GetAllBooksByAuthorID(AuthorID));
        }
    
    }
}

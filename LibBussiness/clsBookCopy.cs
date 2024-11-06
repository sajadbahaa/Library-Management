using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;

namespace LibBussiness
{
    public  class clsBookCopy:clsBooks
    {
    public int CopyID { get; set; }
    public bool IsAvailable { get; set; }
    public decimal NumberOfCopies { get; set; }
        private int? nulabl = null;
       public enum enMode { add =1,update = 2}
        public enMode Mode = enMode.add;
//        public clsInformation Inforamtions { get; set; }
        public clsBookCopy()
        {
            CopyID =nulabl??-1;
            IsAvailable = true;
            NumberOfCopies = 0;
        }
        public clsBookCopy(int CopyID,int BookID,decimal NumberOfCopies,
            bool IsAvailable, int authors, int UserID, string ISBN,
     string title, enBookTypes BookTypeID
            , DateTime date, string AdditionInfo,
     string ImageBook)
        {
            this.CopyID = CopyID;
            this.BookID = BookID;
            this.NumberOfCopies = NumberOfCopies;
            this.IsAvailable = IsAvailable;
            this.ISBN = ISBN;
            this.date = date;
            this.title = title;
            this.authors = authors;
            this.BookTypeID = BookTypeID;
            this.AdditionInfo = AdditionInfo;
            this.ImageBook = ImageBook;
            this.UserID = UserID;
            this.AuthorInfo = clsPerson.FindByPersonID(authors);
            this.UserInfo = clsUser.FindByUserID(UserID);
            this.BookTypeInfo = clsBookTypes.Find((int)BookTypeID);

            Mode = enMode.update;
        }
    
     private bool _Add()
        {
            this.CopyID = dtBookCopy.Add(this.BookID,this.NumberOfCopies,this.IsAvailable);
            return (this.CopyID!=nulabl);
        }
        public bool IncrementBookCopies(decimal Quantity)
        {

            this.NumberOfCopies += Quantity;
           
            if (NumberOfCopies <1)
                return false;
            return true;
        }
        
        private bool _Update()
        {
    return dtBookCopy.Update(this.CopyID,this.BookID, this.NumberOfCopies, this.IsAvailable);
        }

    public bool Save()
        {
            base.Mode = (clsBooks.enMode) Mode;

            if (!base.Save())
                return false;
             
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
    
    public static clsBookCopy FindCopyBookByCopyID(int CopyID)
        {
            int BookID = -1;
            decimal NumberOfCopies = 1;
            bool IsAvailable = true;
            bool IsCopyBookFind =
    dtBookCopy.Find(CopyID, ref BookID, ref NumberOfCopies, ref IsAvailable);
            if (IsCopyBookFind)
            {
                clsBooks BookInfo = clsBooks.FindByBookID(BookID);
           
               return new clsBookCopy(CopyID, BookID, NumberOfCopies, IsAvailable,
               BookInfo.authors, BookInfo.UserID, BookInfo.ISBN, BookInfo.title,
               BookInfo.BookTypeID, BookInfo.date, BookInfo.AdditionInfo,
               BookInfo.ImageBook);
            }
            else
            {
                return null;
            }

        }
    public static clsBookCopy FindCopyBookByBookID(int BookID)
        {
            int CopyID = -1;
            decimal NumberOfCopies = 1;
            bool IsAvailable = true;
            clsBooks BookInfo = clsBooks.FindByBookID(BookID);

            if (BookInfo!=null)
            {
                bool IsCopyBookFind = dtBookCopy.Find(ref CopyID, BookID, ref NumberOfCopies, ref IsAvailable);
                return new clsBookCopy(CopyID, BookID, NumberOfCopies, IsAvailable,
                BookInfo.authors, BookInfo.UserID, BookInfo.ISBN, BookInfo.title,
                BookInfo.BookTypeID, BookInfo.date, BookInfo.AdditionInfo,
                BookInfo.ImageBook);
            }

            else
            {
                return null;
            }

        }
        public static clsBookCopy FindCopyBookByTitle(string title)
        {
           
            int CopyID = -1;
            decimal NumberOfCopies = 1;
            bool IsAvailable = true;
            clsBooks BookInfo = clsBooks.FindByTitle(title);

            if (BookInfo != null)
            {
                bool IsCopyBookFind = dtBookCopy.Find(ref CopyID, BookInfo.BookID, ref NumberOfCopies, ref IsAvailable);
                return new clsBookCopy(CopyID, BookInfo.BookID, NumberOfCopies, IsAvailable,
                BookInfo.authors, BookInfo.UserID, BookInfo.ISBN, title,
                BookInfo.BookTypeID, BookInfo.date, BookInfo.AdditionInfo,
                BookInfo.ImageBook);
            }

            else
            {
                return null;
            }

        }
        public static clsBookCopy FindCopyBookByISBN(string ISBN)
        {

            int CopyID = -1;
            decimal NumberOfCopies = 1;
            bool IsAvailable = true;
            clsBooks BookInfo = clsBooks.FindByISBN(ISBN);

            if (BookInfo != null)
            {
                bool IsCopyBookFind = dtBookCopy.Find(ref CopyID, BookInfo.BookID, ref NumberOfCopies, ref IsAvailable);
                return new clsBookCopy(CopyID, BookInfo.BookID, NumberOfCopies, IsAvailable,
                BookInfo.authors, BookInfo.UserID, BookInfo.ISBN, BookInfo.title,
                BookInfo.BookTypeID, BookInfo.date, BookInfo.AdditionInfo,
                BookInfo.ImageBook);
            }

            else
            {
                return null;
            }

        }
        public static DataTable GetBookCopiesView()
        {
            return (dtBookCopy.GetCopyView());
        }

        public bool Delete()
        {
            bool IsBookCopyRemoved = false;
            bool IsBookRemoved = false;
            IsBookCopyRemoved = dtBookCopy.Delete(this.CopyID);
            
            if (!IsBookCopyRemoved)
            {
                return false;
            }
            IsBookRemoved = base.Delete();
            return IsBookRemoved;
            ;
        }

        

    }
}

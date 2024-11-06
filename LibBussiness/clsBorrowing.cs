using BankBussiness;
using LibData;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;

namespace LibBussiness
{
    public class clsBorrowing
    {
        public int BorrowID { get; set; }
        public int ReaderID { get; set; }
        public int CopyID { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ActualDate { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enMode { add = 1 , update = 2 }
        public bool IsBorrow { get; set; }
        public clsBookCopy BookCopyInfo { get; set; }
        public clsUser UserInfo { get;}
        public clsReader ReaderInfo { get; }
       
        private enMode _Mode;
        int? nul = null;

        
        public clsBorrowing()
        {
            DateTime? dtNull = null;
            int? nul = null;
            BorrowID = nul ?? -1;
            ReaderID = nul ?? -1;
            CopyID = nul ?? -1;
            BorrowingDate = dtNull ?? DateTime.MinValue;
            DueDate = dtNull ?? DateTime.MinValue;
            ActualDate = dtNull ?? DateTime.MinValue; ;
        CreatedByUserID = nul ?? -1;
            IsBorrow = false ;
            _Mode = enMode.add;

        }
        public clsBorrowing(int BorrowID,int ReaderID,int CopyID,
            DateTime BorrowingDate,DateTime DueDate, 
            DateTime ActualDate,bool IsBorrow, int CreatedByUserID)
        {
            _Mode = enMode.update;
            this.BorrowID = BorrowID;
            this.ReaderID = ReaderID;
            this.CopyID = CopyID;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualDate = ActualDate;
            this.IsBorrow = IsBorrow;
            this.BookCopyInfo = clsBookCopy.FindCopyBookByCopyID(CopyID);
            this.UserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.ReaderInfo = clsReader.FindByReaderID(ReaderID);
        }
    public static clsBorrowing FindByBorrowID(int BorrowID)
        {
            int ReaderID = -1, CopyID = -1, UserID = -1;
            DateTime? dtNull = null;

            DateTime BorrDate = dtNull??DateTime.Now,
                DueDate =  dtNull ?? DateTime.Now
                ,
                ActualDate = dtNull??DateTime.MinValue;
            bool IsBorrow = false;
            bool IsFind = dtBorrowing.Find(BorrowID, ref ReaderID, ref CopyID, ref BorrDate, ref DueDate, ref ActualDate,ref UserID, ref IsBorrow);
            if (IsFind)
                return new clsBorrowing(BorrowID, ReaderID, CopyID, BorrDate, DueDate, ActualDate,IsBorrow, UserID);
            else
                return null;

                    }
        private bool _Add()
        {
            this.BorrowID = dtBorrowing.Add(this.ReaderID, this.CopyID, this.BorrowingDate, this.DueDate, this.CreatedByUserID);
            return (this.BorrowID!=nul);
        }
        public static int GetBorrowIDBeforeRetrieving(int ReaderID,int CopyID)
        {
            return (dtBorrowing.GetBorrowID(ReaderID,CopyID));
        }
        
        public static bool IsReaderBorrow(int ReaderID, int CopyID)
        {
            return (dtBorrowing.GetBorrowID(ReaderID, CopyID)!=-1);
        }
        

        private bool _Update()
        {
            return (dtBorrowing.Update(this.BorrowID,this.CopyID,this.ActualDate,this.CreatedByUserID));
        }

        public bool IsReaderLate()
        {
          return (this.ActualDate>this.DueDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.add:

                    if (_Add())
                    {
                        _Mode = enMode.update;
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
        public static DataTable GetAllBorrowingList()
        {
            return (dtBorrowing.GetAllBorrowingList());
        }
        public bool AddBorrowing(int CopyID,DateTime DueDate,int ReaderID,int UserID)
        {
            this.DueDate = DueDate;
            this.BorrowingDate = DateTime.Now;
            this.ReaderID = ReaderID;
            this.CopyID = CopyID;
            this.CreatedByUserID = UserID;
            this.IsBorrow = true;

            return this._Add();
        }
        public bool SetBookCopyUnAvailbale(int CopyID,string title)
        {
            return dtBorrowing.UnAvailbleStatusBookCopy(CopyID, title);
        }
       public bool AddFine(int UserID,ref int FineID, decimal FinePerDay)
        {
            if (this.IsReaderLate())
            {
                clsFines FineInfo = new clsFines();
                FineInfo.ReaderID = this.ReaderID;
                FineInfo.BorrowID = BorrowID;
                FineInfo.UserID = UserID;
                FineInfo.Amount = clsCalculation.CalculateFine(this.DueDate.Day, this.ActualDate.Day, FinePerDay);
                FineInfo.LateDays = clsCalculation.Subtract(this.ActualDate.Day, this.DueDate.Day);
                FineInfo.IsPay = false;
                if (!FineInfo.Save())
                {
                    return false;
                }
                FineID = FineInfo.FineID;
            }
            return true;
        }
        public bool RetreivingBook(int UserID,DateTime ActualDate)
        {
            // check if reader late we will give him fine;
            this.ActualDate = ActualDate;
            this.IsBorrow = false;
            this.CreatedByUserID = UserID;
            if (!this.Save())
                return false;

            return true;
        }
    
        
    public static bool Delete(int BorrowID)
        {
            return dtBorrowing.Delete(BorrowID);
        }
    }
}

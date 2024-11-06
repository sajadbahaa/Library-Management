using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;

namespace LibBussiness
{
    public class clsFines
    {
    public int FineID { get; set; }
    public int ReaderID { get; set; }
    public int UserID { get; set;}
    public decimal Amount { get; set; }
    public decimal LateDays { get; set; }
    public int BorrowID { get; set; }
    public bool IsPay { get; set; }

  public enum enMode { add =1,update =2}
        private enMode _Mode;
  public clsUser UserInfo {get;set;}
  public clsReader ReaderInfo { get; set; }
      public clsBorrowing BorrowingInfo { get; set; } 
        public clsFines()
        {
            int? nullab = null;
            _Mode = enMode.add;
            FineID = nullab ?? -1;
            BorrowID = nullab ?? -1;
            UserID = nullab ?? -1;
            Amount = 0;
            LateDays = 0;
            IsPay = false;
ReaderID = nullab ?? -1;
        }
        public clsFines(int FineID,int ReaderID,int BorrowID,
        decimal Amount,decimal LateDays,bool IsPay,
        int UserID)
        {
            _Mode = enMode.update;
            this.FineID = FineID;
            this.BorrowID = BorrowID;
            this.ReaderID = ReaderID;
            this.Amount = Amount;
            this.LateDays = LateDays;
            this.IsPay = IsPay;
            this.UserID = UserID;
            this.ReaderInfo = clsReader.FindByReaderID(ReaderID);
            this.UserInfo = clsUser.FindByUserID(UserID);
            this.BorrowingInfo = clsBorrowing.FindByBorrowID(BorrowID);
        }
   public static clsFines FindByFineID(int FineID)
        {
            int BorrowID = -1, UserID = -1, ReaderID = -1;
            decimal Amount = 0, LateDays = 0;
            bool IsPay = false;
            bool IsFine = dtFines.Find(FineID, ref ReaderID, ref BorrowID, ref Amount, ref LateDays, ref IsPay, ref UserID);
            if (IsFine)
                return new clsFines(FineID, ReaderID, BorrowID, Amount, LateDays, IsPay, UserID);
            else
                return null;
        }

        public static clsFines FindFineByReaderID(int ReaderID)
        {
            int BorrowID = -1, UserID = -1, FineID  = -1;
            decimal Amount = 0, LateDays = 0;
            bool IsPay = false;
            bool IsFine = dtFines.Find(ref  FineID, ReaderID, ref BorrowID, ref Amount, ref LateDays, ref IsPay, ref UserID);
            if (IsFine)
                return new clsFines(FineID, ReaderID, BorrowID, Amount, LateDays, IsPay, UserID);
            else
                return null;
        }
        private bool _Add()
        {
            this.FineID = dtFines.Add(this.ReaderID, this.BorrowID, this.Amount, this.LateDays, this.IsPay, this.UserID);
            return (this.FineID!=-1);
        }


    private bool _Update()
        {
            return (dtFines.Update(this.FineID,this.IsPay, this.UserID));
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
                        return false;
                case enMode.update:
                    return _Update();
            }
            return false;
        }
public static bool IsFineExist(int ReaderID)
        {
            return (dtFines.GetFineID(ReaderID)!=-1);
        }
        public static bool IsReaderHasFine(int ReaderID)
        {
            return (dtFines.GetFineID(ReaderID) != -1);
        }
        public static int GetFineID(int ReaderID)
        {
            return (dtFines.GetFineID(ReaderID));
        }

        
        public static bool Delete(int FineID)
        {
            return (dtFines.Delete(FineID));
        }
public static DataTable GetAllFines()
        {
            return (dtFines.GetAllFines());
        }
    public static DataTable GetAllFinesByReaderID(int ReaderID)
        {
            return (dtFines.GetAllFinesByReaderID(ReaderID));
        }
    }
}

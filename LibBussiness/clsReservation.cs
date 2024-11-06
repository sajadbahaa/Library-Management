using LibData;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibBussiness
{
    public class clsReservation
    {
    public int ReservationID { get; set; }
    public int ReaderID { get; set; }
    public int CopyID { get; set; }
    public DateTime  ReservationDate { get; }
    public int UserID { get; set; }   
    public bool IsLock { get; set; }
        public string Message { get; set; }
    public enum enMode { add =1,update =2}
        public enMode Mode = enMode.add;
public clsReader ReaderInfo { get;}
    public clsBookCopy CopyInfo { get;}
    public clsReservation()
         {
            Mode = enMode.add;
            DateTime? dtnull = null;
            int ? nullab = null;
            ReservationID =nullab??-1;
            UserID = nullab ?? -1;
            CopyID = nullab ?? -1;
            ReservationDate = dtnull??DateTime.MinValue;
            IsLock = false;
          ReaderID = nullab ?? -1;
        }
    private clsReservation(int ReservationID,int ReaderID,int CopyID,
     DateTime ReservationDate,int UserID,bool IsLock)
        {
            this.ReservationID = ReservationID;
            this.ReservationDate = ReservationDate;
            this.IsLock = IsLock;
            this.CopyID = CopyID;
            this.ReaderID = ReaderID;
            this.UserID = UserID;
            Mode = enMode.update;
            this.ReaderInfo = clsReader.FindByReaderID(ReaderID);
            this.CopyInfo = clsBookCopy.FindCopyBookByCopyID(CopyID);
        }
    public static clsReservation FindByReservationD(int ReservationID)
        {
            int UserID = -1, CopyID = -1, ReaderID = -1;
            DateTime Date = DateTime.MinValue;
            bool IsLock = false;
            bool IsFind = dtReservations.Find(ReservationID, ref ReaderID, ref CopyID
                , ref Date, ref IsLock,ref UserID);

            if (IsFind)
                return new clsReservation(ReservationID,ReaderID,CopyID,Date,UserID,IsLock);
        else
            return null;
        }
    public static bool Delete(int ReservationID)
        {
            return (dtReservations.Delete(ReservationID));
        }
    private bool _Add()
        {
            this.ReservationID = dtReservations.Add(this.ReaderID, this.CopyID, this.UserID);
            return this.ReservationID != -1;
        }
    private bool _Update()
        {
            return dtReservations.Update(this.ReservationID,this.UserID);
        }
    public static int GetReservationActive(int ReaderID,int CopyID)
        {
            return dtReservations.GetReservationID(ReaderID,CopyID);
        }
  static public bool HasReaderReservation(int ReaderID,int CopyID)
        {
            return dtReservations.GetReservationID(ReaderID, CopyID)!=-1;
        }
    static public bool UnLockReservation(int ReservationID,int UserID)
        {
            return dtReservations.Update(ReservationID,UserID);
        }
    static public bool IsBookCopyLock(int CopyID)
        {
            return dtReservations.IsBookCopyReservation(CopyID);
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

static public DataTable GetAllReservations()
        {
            return dtReservations.GetAllReservations();
        }

        static public DataTable GetAllReservationsByReaderID(int ReaderID)
        {
            return dtReservations.GetAllReservationByReaderID(ReaderID);
        }

    }
}

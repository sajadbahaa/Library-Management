using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;


namespace LibBussiness
{
    public class clsReader
    {
        public int ReaderID { get; set; }
        public int PersonID { get; set; }
        public string LibraryCardNumber { get; set; }
        public int UserID { get; set; }
        public DateTime CreateDate { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsUser UserInfo { get; set; }
        public enum enMode { add = 1, update =2}
        private enMode _Mode = enMode.add;
        private int? nullabel = null;

        public clsReader()
        {
            _Mode = enMode.add;
            ReaderID = nullabel??-1;
            PersonID = nullabel ?? -1;
            LibraryCardNumber = "";
            UserID = nullabel ?? -1;
            CreateDate = DateTime.Now;
        }
    private clsReader(int ReaderID,int PersonID,string LibraryCardNumber,
        DateTime CreateDate,int UserID)
        {
            this.ReaderID = ReaderID;
            this.PersonID = PersonID;
            this.LibraryCardNumber = LibraryCardNumber;
            this.CreateDate = CreateDate;
            this.UserID = UserID;
            this.UserInfo = clsUser.FindByUserID(UserID);
            this.PersonInfo = clsPerson.FindByPersonID(PersonID);
            _Mode = enMode.update;
        }
    public static clsReader FindByReaderID(int ReaderID)
        {
          int? nullabel = null;
            DateTime? dt = null;
        int PersonID = nullabel??0;
            int UserID = nullabel ?? 0;
            DateTime CreateDate = dt ?? DateTime.Now;
            string LibraryCardNumber = nullabel?.ToString();
            bool IsFound = dtReaders.Find(ReaderID, ref PersonID, ref LibraryCardNumber, ref CreateDate, ref UserID);
            if (IsFound)
                return new clsReader(
                    ReaderID, PersonID, LibraryCardNumber, CreateDate, UserID);
            else
                return null;
        }
        public static clsReader FindByPersonID(int PersonID)
        {
            int? nullabel = null;
            DateTime? dt = null;
            int ReaderID = nullabel ?? 0;
            int UserID = nullabel ?? 0;
            DateTime CreateDate = dt ?? DateTime.Now;
            string LibraryCardNumber = nullabel?.ToString();
            bool IsFound = dtReaders.Find(ref ReaderID, PersonID, ref LibraryCardNumber, ref CreateDate, ref UserID);
            if (IsFound)
                return new clsReader(
                    ReaderID, PersonID, LibraryCardNumber, CreateDate, UserID);
            else
                return null;
        }
private bool _Add()
        {
            this.ReaderID = dtReaders.Add(this.PersonID,this.LibraryCardNumber,this.UserID,this.CreateDate);
            return (this.ReaderID>-1);
        }
private bool _Update()
        {
            return (dtReaders.Update(this.ReaderID,
                this.PersonID, this.LibraryCardNumber, this.UserID, this.CreateDate));
        }
static public  bool Delete(int ReaderID)
        {
            return (dtReaders.Delete(ReaderID));
        }
public bool Exist(int Reader)
        {
            return (dtReaders.Exist(ReaderID));
        }
    static    public bool ExistByPersonID(int PersonID)
        {
            return (dtReaders.ExistPersonID(PersonID));
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
public static bool  IsLibraryCardNumberExist(string LibCardNumber)
        {
            return (dtReaders.ExistLibraryCardNumber(LibCardNumber));
        }
public static DataTable GetAllReaders()
        {
            return (dtReaders.GetAllReder());
        }
        public static DataTable GetAllReader_View()
        {
            return (dtReaders.GetAllReder_View());
        }
    }
}

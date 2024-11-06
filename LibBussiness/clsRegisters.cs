using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TestOnenericControls;

namespace LibBussiness
{
    public class clsRegisters
    {
        public int UserID { get; set; }
        public DateTime dt { get; set; }

        public clsUser UserInfo { get; set; }
      public  enum enMode { add =1}
        private enMode _mode = enMode.add;
        private int value = 0;
        private int? _ID = null;
        public clsRegisters()
        {
            UserID = _ID??value;
            dt = DateTime.Now;
        }
        private clsRegisters(int UserID,DateTime dt)
        {
            this.UserID = UserID;
            this.dt = dt;
        }
        private bool _Add()
        {
            return (dtRegisters.Add(this.UserID));
        }
        public static DataTable GetRegisterByUserID(int UserID)
        {
            return (dtRegisters.GetRegisterByUserID(UserID));
        } 
        public static DataTable GetAllRegisters()
        {
            return (dtRegisters.GetAllUsersRegisters());
        }
        public bool Save()
        {
            switch (_mode)
            {
                case enMode.add:
                    if (_Add())
                    {
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }
    }
}

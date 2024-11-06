using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBussiness
{
    public class clslogger
    {
    public string Message { get; set; }
       public  enum enMode { add = 1,update = 2}
        private enMode _mod = enMode.add;
        public clslogger()
        {
            Message = "";
            _mod = enMode.add;
        }
        
        private bool _add()
        {
            return (dtLogger.AddMsg(this.Message));
        }
        public bool Save()
        {
            switch (_mod)
            {
                case enMode.add:
                    if (_add())
                    {
                        _mod = enMode.update;
                        return true;
                    }
                    return false;
            }
            return false;
        }
        public static DataTable GetAllLogger()
        {
            return (dtLogger.GetAllLoggings());
        }
        public static bool IsExist()
        {
            return (GetAllLogger()!=null);
        }
        public static bool Delete()
        {
            return (dtLogger.Delete());
        }
        public static string GetStoredData()
        {
            return (dtLogger.GetStoredData());
        }

    }
}

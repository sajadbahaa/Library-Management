using LibData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class clsSettings
    {
      public enum enPermissions
        {
 eAll = -1,eReaderList = 1,eAddReader = 2,eUpdateReader = 4,
 eDeleteReader = 8,eFindReader  = 16,
            eManageUser = 32}

        public Decimal NumberDaysBorrowing { get; }
        public Decimal FinePerDay { get; }
        public clsSettings()
        {
            int? nullable = null;
            NumberDaysBorrowing = nullable ?? 3;
            Byte? nullable1 = null;
            FinePerDay = nullable1 ?? 1;
        }
        private clsSettings(Decimal NumberDaysBorrowing, Decimal FinePerDay)
        {
            this.NumberDaysBorrowing = NumberDaysBorrowing;
            this.FinePerDay = FinePerDay;
        }
        public static clsSettings GetSettingsValue()
        {
            Decimal NumberDays = 1;
            Decimal FinePerDay = 1;
            bool IsFind = dtSettings.Find(ref NumberDays, ref FinePerDay);
            if (IsFind)
                return new clsSettings(NumberDays, FinePerDay);
            else
                return null;
        }


    }
}

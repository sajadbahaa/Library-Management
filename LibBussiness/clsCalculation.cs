using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBussiness
{
    public  class clsCalculation
    {
      public static int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        public static decimal CalculateFine(int DayDue, int DayActual, decimal FinePerDay)
        {
            return (Subtract(DayActual,DayDue) * FinePerDay);
        }
    }
}

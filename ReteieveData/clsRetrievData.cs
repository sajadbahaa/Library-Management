using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteieveData
{
    public class clsRetrievData
    {
        public delegate bool RetrieveData(ref string Username,ref string Paswored);
        public RetrieveData Action;
        public clsRetrievData(RetrieveData Action)
        {
            this.Action = Action;
        }
        public bool GetStoredData(ref string Username,ref string Password)
        {
        return   this.Action(ref Username,ref Password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class clsLogger
    {
        public delegate bool logData(string Username,string Password);
        public logData Action;
        public clsLogger(logData Action)
        {
            this.Action = Action;
        }
        public void RemmberData(string Username,string Password)
        {
            this.Action(Username, Password);
        }
    }
}

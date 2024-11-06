using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtAccess
    {
        public static string Connection =
              "Server = .;DataBase = BookLibrary;User ID = sa;Password = sa123456";
        public static void WriteExceptionOnEventViewer(string Message)
        {
            string SourceName = "LibApp";
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }
            EventLog.WriteEntry(SourceName, Message, EventLogEntryType.Error);
        }

    }
}

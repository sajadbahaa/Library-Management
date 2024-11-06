using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtSettings
    {
    public static bool Find(ref decimal NumberDaysBorrowing,ref Decimal FinePerDay)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Settings";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                            IsFind = true;
                                NumberDaysBorrowing = (Decimal)read["NumberDaysBorrowing"];
                                FinePerDay = (Decimal)read["FinePerDay"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Loading Settings Info" + ex);
            }
            return IsFind;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtBookTypes
    {
    public static DataTable GetAllBookTypes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection =new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query =
                            @"Select * from BookTypes";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.HasRows)
                                dt.Load(read);

                                    }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }
    public static bool Find(int BookTypeID,ref string BookType)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from BookTypes 
Where BookTypeID  = @BookTypeID"; 
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@BookTypeID",BookTypeID);
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                IsFind = true;
                                BookType = (string)read["BookType"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return IsFind;
        }
    }
}

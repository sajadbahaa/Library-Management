using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtRegisters
    {
        public static bool Add(int UserID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {

                    connection.Open();

                    string query = @"Insert into Registers 
(UserID,CreateDate)
Values
(@UserID,@CreateDate);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@CreateDate", DateTime.Now);

                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (Affect>0);
        }

    public static DataTable GetRegisterByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {

                    connection.Open();

                    string query = @"SELECT 
People.Name as FullName, Users.Username, Registers.CreateDate
FROM            Users INNER JOIN
People ON Users.PersonID = People.PersonID 
INNER JOIN
Registers ON 
Users.UserID = Registers.UserID 
Where  Registers.UserID = @UserID
order by CreateDate desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        using (SqlDataReader red = command.ExecuteReader())
                        {
                            if (red.HasRows)
                                dt.Load(red);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;

        }

        public static DataTable GetAllUsersRegisters()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {

                    connection.Open();

                    string query = @"select * from UserRegister
order by CreateDate desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader red = command.ExecuteReader())
                        {
                            if (red.HasRows)
                                dt.Load(red);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;

        }

    }
}

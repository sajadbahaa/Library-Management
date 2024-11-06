using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtReaders
    {
    public static int Add(int PersonID,string LibraryCardNumber,
        int UserID,DateTime CreateDate)
        {
            int ReaderID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into Readers
(
PersonID,
LibraryCardNumber,
CreateByUserID,
CreateDate
)
values(
@PersonID,
@LibraryCardNumber,
@UserID,
@CreateDate
);
select Scope_Identity();";
            using (SqlCommand command = new SqlCommand(query,connection))
            {
            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@LibraryCardNumber",LibraryCardNumber);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CreateDate", CreateDate);
                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                            ReaderID = int.Parse(res.ToString());
                        }

                    }

                }

            }
            catch (Exception)
            {

            }
            return ReaderID;
        }
    public static bool Update(int ReaderID,int PersonID, string LibraryCardNumber,
        int UserID, DateTime CreateDate)
        {
            int Affect  = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Update Readers

set  PersonID          =  @PersonID,
LibraryCardNumber =  @LibraryCardNumber , 
CreateByUserID            =  @UserID  ,
CreateDate        =  @CreateDate 
where ReaderID  = @ReaderID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@CreateDate", CreateDate);
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        
                        Affect = command.ExecuteNonQuery();


                    }

                }

            }
            catch (Exception)
            {

            }
            return (Affect>0);

        }

        public static bool Delete(int ReaderID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Delete from  Readers
where ReaderID  = ReaderID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        
                        Affect = command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception)
            {

            }
            return (Affect > 0);

        }
        public static bool Exist(int ReaderID)
        {
           bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select find = 'yes' from  Readers
where ReaderID  = @ReaderID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);

                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            IsFind = read.HasRows;
                        }
                    }

                }

            }
            catch (Exception)
            {

            }
            return IsFind;

        }
        public static bool Find(int ReaderID,ref int PersonID,ref string LibraryCardNumber
            ,ref DateTime CreateDate,ref int CreateByUserID)
        {
            bool IsFind = false;

            try
            {
            using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Readers
Where ReaderID = @ReaderID";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                CreateByUserID = (int)reader["CreateByUserID"];
                                LibraryCardNumber = (string)reader["LibraryCardNumber"];
                                PersonID = (int)reader["PersonID"];
                                CreateDate = (DateTime)reader["CreateDate"];
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
        public static bool Find(ref int ReaderID, int PersonID, ref string LibraryCardNumber
            , ref DateTime CreateDate, ref int CreateByUserID)
        {
            bool IsFind = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Readers
Where PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID",PersonID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                CreateByUserID = (int)reader["CreateByUserID"];
                                LibraryCardNumber = (string)reader["LibraryCardNumber"];
                                ReaderID = (int)reader["ReaderID"];
                                CreateDate = (DateTime)reader["CreateDate"];
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

        public static bool ExistPersonID(int PersonID)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select find = 'yes' from  Readers
where PersonID  = @PersonID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            IsFind = read.HasRows;
                        }
                    }

                }

            }
            catch (Exception)
            {

            }
            return IsFind;

        }

        public static DataTable GetAllReder()
        {
            DataTable dt = new DataTable(); 
            try
            {
                using (SqlConnection connection =new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = "Select * from Readers";
                    using ( SqlCommand command = new SqlCommand(query,connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        
        }
        //select * from Reader_View;       

        public static DataTable GetAllReder_View()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = "Select * from Reader_View";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;

        }

        //string LibraryCardNumber
        public static bool ExistLibraryCardNumber(string LibraryCardNumber)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select find = 'yes' from  Readers
where LibraryCardNumber = @LibraryCardNumber;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);

                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            IsFind = read.HasRows;
                        }
                    }

                }

            }
            catch (Exception)
            {

            }
            return IsFind;

        }
    }
}

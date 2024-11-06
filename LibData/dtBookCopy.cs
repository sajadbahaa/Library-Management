using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtBookCopy
    {
        static public int Add(int BookCopyID,
        decimal NumberOfCopies,bool IsAvailable)
        {
            int CopyID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into BookCopies
(BookCopyID,NumberOfCopies,IsAvailable) 
values(@BookCopyID,@NumberOfCopies,@IsAvailable);
select Scope_Identity();";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                        command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);
                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);

                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                            CopyID =  int.Parse(res.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return CopyID; 
        }

        static public bool Update(int CopyID,int BookCopyID,
           decimal NumberOfCopies, bool IsAvailable)
        {
            int Affect = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Update BookCopies
set 
BookCopyID = @BookCopyID 
,NumberOfCopies = @NumberOfCopies 
,IsAvailable = @IsAvailable 
where CopyID =  @CopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID",CopyID);
                        command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                        command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);
                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);

                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affect>0;
        }

        
        
        static public bool Delete(int CopyID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Delete from BookCopies
where CopyID =  @CopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);

                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affect > 0;
        }

        static public bool Find( int CopyID, ref int BookCopyID,
         ref decimal NumberOfCopies, ref bool IsAvailable)
        {
            bool  IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from BookCopies 
where CopyID =  @CopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                BookCopyID = (int)reader["BookCopyID"];
                                IsAvailable = (bool)reader["IsAvailable"];
                                NumberOfCopies = (decimal)reader["NumberOfCopies"];
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

        static public bool Find(ref  int CopyID, int BookCopyID,
          ref decimal NumberOfCopies, ref bool IsAvailable)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from BookCopies 
where BookCopyID =  @BookCopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                CopyID = (int)reader["CopyID"];
                                IsAvailable = (bool)reader["IsAvailable"];
                                NumberOfCopies = (decimal)reader["NumberOfCopies"];
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
 
        static public bool Exist(int CopyID)
        {
        
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    string query = @"select find = 'yes' BookCopies

--BookCopyID = @BookCopyID 
where CopyID =  @CopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@CopyID", CopyID);
                        //command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                        
                        //Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return true;
        }
        //select * from Copy_View;
        static public DataTable GetCopyView()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"select * from Copy_View";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader read  = command.ExecuteReader())
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


    }
}

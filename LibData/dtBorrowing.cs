using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public  class dtBorrowing
    {
    public static int Add(int ReaderID,int CopyID
        ,DateTime BorrowingDate,DateTime DueDate
        , int CreatedByUserID)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into Borrowing
(ReaderID,CopyID,BorrowingDate, DueDate,IsBorrow,CreatedByUserID)
Values(@ReaderID,@CopyID,@BorrowingDate, @DueDate,1,@CreatedByUserID);
Select Scope_Identity();


if exists(select * from BookCopies where  IsAvailable = 1 and CopyID = @CopyID and NumberOfCopies>1)
begin
Update BookCopies
set NumberOfCopies-=1
where CopyID = @CopyID
end";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                        command.Parameters.AddWithValue("@DueDate",DueDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                            NewID = int.Parse(res.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Error Adding Borrowing Book");
            }
            return NewID;
        }

        public static bool Update(int BorrowID,int CopyID,DateTime ActualDate,int CreatedByUserID)
        {
            int Affecy = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                connection.Open();
                string query = @"Update  Borrowing
Set CreatedByUserID = @CreatedByUserID ,ActualDate = @ActualDate,
IsBorrow = 0
where BorrowID = @BorrowID;

if exists(select * from BookCopies where    CopyID = @CopyID and NumberOfCopies>1)
begin
Update BookCopies
set NumberOfCopies+=1
where CopyID = @CopyID
end
";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);
                    command.Parameters.AddWithValue("@ActualDate", ActualDate);
                        command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);
                        command.Parameters.AddWithValue("@CopyID", CopyID);

                        Affecy = command.ExecuteNonQuery();
                    
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affecy>0;
        }

        public static int  GetBorrowID(int ReaderID,int CopyID)
        {
            int BorrowID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"

select BorrowID from Borrowing
			inner join Readers on Borrowing.ReaderID = Readers.ReaderID
			inner join BookCopies on Borrowing.CopyID = BookCopies.CopyID
			where BookCopies.CopyID  = @CopyID and Readers.ReaderID = @ReaderID and IsBorrow = 1;";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CopyID",CopyID);
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);

                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                            BorrowID = int.Parse(res.ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Getting  BorrowID");
            }
            return BorrowID;
        }
       
        public static bool UnAvailbleStatusBookCopy(int CopyID,string Message)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"

if exists(select * from BookCopies where  IsAvailable = 1 and CopyID = @CopyID and NumberOfCopies =1)
begin 
Update BookCopies
set IsAvailable = 0,NumberOfCopies = 0
where CopyID = @CopyID;

insert into  Notifycation(Messages,CopyID)
values(@Messages,@CopyID)
end
";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@Messages", Message);

                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Error Updating Borrowing Book to Un Availbale"+ex);
            }
            return Affect > 0;
        }
        public static bool Find(int BorrowID,ref int ReaderID,ref  int CopyID
        , ref DateTime BorrowingDate, ref  DateTime DueDate, ref DateTime ActualDate
        , ref int CreatedByUserID,ref bool IsBorrow)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Borrowing where BorrowID = @BorrowID";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@BorrowID", BorrowID);
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                IsFind = true;
                                ReaderID = (int)r["ReaderID"];
                                CopyID = (int)r["CopyID"];
                                BorrowingDate = (DateTime)r["BorrowingDate"];
                                DueDate = (DateTime)r["DueDate"];

                                if (r["ActualDate"] == DBNull.Value)
                                    ActualDate = DateTime.MinValue;
                                else
                                    ActualDate = (DateTime)r["ActualDate"];


                                CreatedByUserID = (int)r["CreatedByUserID"];
                                IsBorrow = (bool)r["IsBorrow"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               dtAccess.WriteExceptionOnEventViewer("Failed Loading Borrowing Info By BorrowID");
            }
            return IsFind;
        }
        public static bool Delete(int BorrowID)
        {
            int Affecy = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Delete from Borrowing
where BorrowID = @BorrowID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowID", BorrowID);

                        Affecy = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affecy > 0;

        }
    public static DataTable GetAllBorrowingList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Borrowing
Order by IsBorrow desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            if (r.HasRows)
                                dt.Load(r);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    /// <summary>
    /// this class is Fines it will manage
    /// if reader has been late the system will 
    /// stop him to forces him to pay
    /// </summary>
    public class dtFines
    {
    //int FineID
    // select * from Fines;
    public static int Add(int ReaderID,int BorrowID,
     decimal Amount,decimal LateDays,bool IsPay,
     int CreatedByUserID)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into Fines
(ReaderID,BorrowID,Amount,LateDays,IsPay,CreatedByUserID)
Values
(@ReaderID,@BorrowID,@Amount,@LateDays,@IsPay,@CreatedByUserID);
select Scope_Identity();";
               using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
                        command.Parameters.AddWithValue("@BorrowID",BorrowID);
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@LateDays", LateDays);
                        command.Parameters.AddWithValue("@IsPay", IsPay);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                            NewID = int.Parse(res.ToString());
                        }
                    }
                }

            }catch(Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Adding Fines");
            }
            
            return NewID;
        }
        public static bool Update(int Fine,bool IsPay,
    int CreatedByUserID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();

                    string query = @"Update Fines
Set IsPay= @IsPay,
CreatedByUserID = @CreatedByUserID
where FineID = @FineID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID",Fine);
                        command.Parameters.AddWithValue("@IsPay", IsPay);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        Affect = command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Updating Fines" + ex);
            }

            return Affect >0;
        }
        public static bool Delete(int Fine)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();

                    string query = @"Delete from  Fines
where FineID = @FineID and IsPay = 1;";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@FineID", Fine);
                        Affect = command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Deleting Fines" + ex);
            }

            return Affect > 0;
        }
        public static bool Find(int Fine,ref int ReaderID,ref  int BorrowID,
     ref decimal Amount, ref decimal LateDays, ref bool IsPay,
     ref int CreatedByUserID)
        {
            bool IsFind = false ;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @" Select * from Fines 
where FineID = @FineID";
                    
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@FineID", Fine);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()){
                                IsFind = true;
                                ReaderID = (int)reader["ReaderID"];
                                BorrowID = (int)reader["BorrowID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                Amount = (decimal)reader["Amount"];
                                LateDays = (decimal)reader["LateDays"];
                                IsPay = (bool)reader["IsPay"];
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed  Loading Fine by FineID" + ex);
            }

            return IsFind;
        }

        public static bool Find(ref  int FineID, int ReaderID, ref int BorrowID,
ref decimal Amount, ref decimal LateDays, ref bool IsPay,
ref int CreatedByUserID)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @" Select * from Fines 
where ReaderID = @ReaderID ";
                    //and IsPay = 0
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                FineID = (int)reader["FineID"];
                                BorrowID = (int)reader["BorrowID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                Amount = (decimal)reader["Amount"];
                                LateDays = (decimal)reader["LateDays"];
                                IsPay = (bool)reader["IsPay"];
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed  Loading Fine by FineID" + ex);
            }

            return IsFind;
        }


        public static int GetFineID (int ReaderID)
        {
            int FineID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"select FineID from Fines where
ReaderID= @ReaderID and IsPay = 0;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        object res = command.ExecuteScalar();
                        if (res != null)
                            FineID = int.Parse(res.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Existing FineID" + ex);
            }

            return FineID;
        }

        public static DataTable GetAllFinesByReaderID(int ReaderID)
        {
DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {

                    connection.Open();
                    string query = @"
select Fines.FineID,People.Name as ReaderName,Books.title , Fines.Amount,Fines.IsPay,Borrowing.DueDate,Borrowing.ActualDate from Borrowing
inner join Fines on Borrowing.BorrowID = Fines.BorrowID
inner join BookCopies on Borrowing.CopyID = BookCopies.CopyID
inner join Books on BookCopies.BookCopyID = Books.BookID
inner join Readers on Fines.ReaderID  = Readers.ReaderID
inner join People on Readers.PersonID = People.PersonID
Where Fines.ReaderID = @ReaderID
Order by Fines.IsPay desc;";
                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
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
                dtAccess.WriteExceptionOnEventViewer("Failed Loading Fines List By ReaderID " + ex);
            }

            return dt;
        }
        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {

                    connection.Open();
                    string query = @" Select * from Fines;
";
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
                dtAccess.WriteExceptionOnEventViewer("Failed Loading Fines List" + ex);
            }

            return dt;
        }


    }
}

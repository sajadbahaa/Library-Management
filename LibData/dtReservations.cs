using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public  class dtReservations
    {
      
       public static int Add(int ReaderID,int CopyID, int CreatedByUserID)
        {
            int NewID = -1;
            try
            {
                using ( SqlConnection connection = new  SqlConnection (dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into Reservations
(ReaderID,CopyID,ReservationDate,IsLock,CreatedByUserID)
values
(@ReaderID,@CopyID,@Date,1,@CreatedByUserID);
Select Scope_Identity();";


                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CopyID",CopyID );

                        command.Parameters.AddWithValue("@Date", DateTime.Now);
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
                dtAccess.WriteExceptionOnEventViewer("Failed Adding Reservation" + ex);
            }
            return NewID;
        }

        public static bool Update(int ReservationID,int CreatedByUserID)
        {//                    
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Update Reservations
Set 
IsLock = 0,CreatedByUserID  = @CreatedByUserID,
ReservationDate = @Date
where ReservationID =@ReservationID;";
                    
        using (SqlCommand command = new SqlCommand(query, connection))
                    {
        command.Parameters.AddWithValue("@ReservationID", ReservationID);
        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
        command.Parameters.AddWithValue("@Date", DateTime.Now);

                        Affect = command.ExecuteNonQuery();
                    
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Updating Reservation" + ex);
            }
            return Affect>0;
        }

        public static bool Delete(int ReservationID)
        {
            //connection.Open();
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Delete from Reservations
where ReservationID  = @ReservationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);

                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Deleting Reservation" + ex);
            }
            return Affect>0;
        }
        public static bool Find( int ReservationID, ref int ReaderID, ref int CopyID, ref DateTime Date
            ,  ref bool IsLock, ref int CreatedByUserID)
        { 
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from  Reservations 
Where ReservationID = @ReservationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", ReservationID);
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                IsFind = true;
                                ReaderID = (int)read["ReaderID"];
                                CopyID = (int)read["CopyID"];
                                Date = (DateTime)read["ReservationDate"];
                                IsLock = (bool)read["IsLock"];
                                CreatedByUserID = (int)read["CreatedByUserID"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Loading Reservation by ReservationID" + ex);
            }
            return  IsFind;
        }
        public static DataTable GetAllReservations()
        {//                    connection.Open();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Reservations
Order by IsLock desc ";
                    using (SqlCommand command = new SqlCommand(query, connection))
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
                dtAccess.WriteExceptionOnEventViewer("Failed Loading Reservation List" + ex);
            }
            return dt ;
        }
        public static int GetReservationID(int ReaderID,int CopyID)
        {//                    connection.Open();
            int ReservationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @" Select ReservationID from Reservations
where ReaderID = @ReaderID and CopyID = @CopyID and IsLock = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID",ReaderID);
                        command.Parameters.AddWithValue("@CopyID",CopyID);
                       
                            object res = command.ExecuteScalar();
                        if (res != null)
                            ReservationID = int.Parse(res.ToString()); 
                       
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Existing Reservation ID" + ex);
            }
            return ReservationID;
        }

        public static bool IsBookCopyReservation(int CopyID)
        {//                    connection.Open();
            int ReservationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @" Select ReservationID from Reservations
where  CopyID = @CopyID and IsLock = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);

                        object res = command.ExecuteScalar();
                        if (res != null)
                            ReservationID = int.Parse(res.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("Failed Existing Reservation ID" + ex);
            }
            return ReservationID!=-1;
        }
       public static DataTable GetAllReservationByReaderID(int ReaderID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"
select  People.Name,Books.title,IsLock,ReservationDate from Reservations
inner join Readers on Reservations.ReaderID = Readers.ReaderID
inner join BookCopies on Reservations.CopyID = BookCopies.CopyID
inner join People on Readers.PersonID = People.PersonID
inner join Books on BookCopies.BookCopyID = Books.BookID
where Reservations.ReaderID = @ReaderID
order by ReservationDate desc";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
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
                dtAccess.WriteExceptionOnEventViewer("Failed Finding Reservation for ReaderID "+ex);
            }
            return dt;
        }
    }
}

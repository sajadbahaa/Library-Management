using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtNotifycation
    {
    public static bool AddNotifyAvailabel(string Messages, int CopyID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))  
                {
                    connection.Open();
                    string query = @"Update BookCopies
set NumberOfCopies=1,IsAvailable = 1
where CopyID =@CopyID;

Insert into Notifycation
(Messages,CopyID)
Values(@Messages,@CopyID)
select scope_IDentity()
Update Reservations
set notifyID = scope_IDentity()
where copyID = @CopyID and IsLock =1;";

                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Messages",Messages);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("failed Adding Notify  "+ex);
            }
            return Affect>0;
        }
    public static bool AddNotifyUnAvailabel(string Messages, int CopyID)
        {
            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Update BookCopies
set NumberOfCopies= 0,IsAvailable = 0
where CopyID =@CopyID;

Insert into Notifycation
(Messages,CopyID)
Values(@Messages,@CopyID)
select scope_IDentity()
Update Reservations
set notifyID = scope_IDentity()
where copyID = @CopyID and IsLock =1;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Messages", Messages);
                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        Affect = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("failed Adding Notify  " + ex);
            }
            return Affect > 0;
        }
        public static bool FindbyNotifyID(int notifyID,ref string Messages,ref int CopyID)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @" Select * from Notifycation
where NotifyID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID",notifyID);
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                IsFind = true;
                                Messages = (string)r["Messages"];
                                CopyID = (int)r["CopyID"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dtAccess.WriteExceptionOnEventViewer("failed Loading  Notify Info by NotifyID  " + ex);
            }
            return IsFind ;
        }

        public static DataTable Find(int CopyID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    string query = @"Select Message from Notifycation
                                   Where  CopyID = @CopyID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", CopyID);
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
                dtAccess.WriteExceptionOnEventViewer("failed Loading Notify By ReaderID " + ex);
            }
            return dt;
        }
        public static DataTable GetAllNotify()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select NotifyID,Messages from Notifycation
                                 order By NotifyID desc;";
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
                dtAccess.WriteExceptionOnEventViewer("failed Loading Notify List" + ex);
            }
            return dt;
        }

    }
}

using LibData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    static public class dtLogger
    {
        static public bool  AddMsg(string Message)
        {
           int Affece = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Insert into Logging
(Message,CreateDate)
values(@Message,@CreateDate);

";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@Message", Message);
            command.Parameters.AddWithValue ("@CreateDate",DateTime.Now);

            try
            {
                connection.Open();
                Affece = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Affece>0);
        }
    
    static public  DataTable GetAllLoggings()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Select * from Logging";
            SqlCommand command = new SqlCommand(query,connection);
            try
            {
                connection.Open();
                SqlDataReader red = command.ExecuteReader();
                if (red.HasRows)
                {
                    dt.Load(red);
                }
                else
                {
                    dt = null;
                }
                red.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
               connection.Close(); 
            }
            return dt;
        }
        static public bool Delete()
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Delete  from Logging";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                Affect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Affect>0);
        }
        static public string GetStoredData()
        {
            string Message = "";
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Select top 1 Message  from Logging  order by CreateDate desc;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res!=null)
                {
                  Message = res.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Message;
        }
    
    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibData
{
    public class dtBooks
    {
    public static int Add(string title,int authors,
string ISBN,DateTime date,int BookTypeID,
string AdditionalDetials,int CreatedByUserID,string BookImage)
        {

            int BookID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Insert into Books
(title,authors,ISBN,date,BookTypeID,AdditionalDetials,CreatedByUserID,BookImage)
Values
(@title,@authors,@ISBN,@date,@BookTypeID,@AdditionalDetials,@CreatedByUserID,@BookImage);
select Scope_Identity();
";
    using (SqlCommand command  = new SqlCommand(query,connection))
                    {
command.Parameters.AddWithValue("@title", title);
command.Parameters.AddWithValue("@authors", authors);
command.Parameters.AddWithValue("@ISBN", ISBN);
command.Parameters.AddWithValue("@date", date);
command.Parameters.AddWithValue("@BookTypeID", BookTypeID);
command.Parameters.AddWithValue("@AdditionalDetials", AdditionalDetials);
command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);
                       if(BookImage==null)
    command.Parameters.AddWithValue("@BookImage",System.DBNull.Value);
      else
          command.Parameters.AddWithValue("@BookImage", BookImage);
                        object res = command.ExecuteScalar();
                        if (res!=null)
                        {
                        BookID = int.Parse(res.ToString());
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return BookID;
        }

        public static bool Update(int BookID,
       string AdditionalDetials, int CreatedByUserID,string BookImage)
        {

            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Update Books
set AdditionalDetials = @AdditionalDetials
,CreatedByUserID = @UserID,
BookImage = @BookImage
where BookID = @BookID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
        command.Parameters.AddWithValue("@AdditionalDetials", AdditionalDetials);
        command.Parameters.AddWithValue("@UserID", CreatedByUserID);
        command.Parameters.AddWithValue("@BookID", BookID);
                        if (BookImage == null)
                            command.Parameters.AddWithValue("@BookImage", System.DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@BookImage", BookImage);

                        Affect = command.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affect>0;
        }

        public static bool Delete(int BookID)
        {

            int Affect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Delete from Books
where BookID = @BookID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);

                        Affect = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Affect > 0;
        }

        public static bool Find(int BookID, ref string title,ref int authors,
     ref  string ISBN,ref DateTime date, ref int BookTypeID,
       ref string AdditionalDetials, ref int CreatedByUserID,ref string BookImage)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Books
                      where BookID = @BookID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", BookID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                authors = (int)reader["authors"];
                                title = (string)reader["title"];
                                ISBN = (string)reader["ISBN"];
                                date = (DateTime)reader["date"];
                                BookTypeID = (int)reader["BookTypeID"];
                                AdditionalDetials =(string)reader["AdditionalDetials"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                if (reader["BookImage"] == System.DBNull.Value)
                                    BookImage = null;
                                else
                                    BookImage = (string)reader["BookImage"];

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
        public static bool Find( ref int BookID,  string title, ref int authors,
     ref string ISBN, ref DateTime date, ref int BookTypeID,
       ref string AdditionalDetials, ref int CreatedByUserID,
        ref string BookImage)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Books
                      where title = @title;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                authors = (int)reader["authors"];
                                BookID = (int)reader["BookID"];
                                ISBN = (string)reader["ISBN"];
                                date = (DateTime)reader["date"];
                                BookTypeID = (int)reader["BookTypeID"];
                                AdditionalDetials = (string)reader["AdditionalDetials"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                if (reader["BookImage"] == System.DBNull.Value)
                                    BookImage = null;
                                else
                                    BookImage = (string)reader["BookImage"];

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

        public static bool Find( ref int BookID,ref  string title, ref int authors,
     string ISBN, ref DateTime date, ref int BookTypeID,
      ref string AdditionalDetials, ref int CreatedByUserID
            ,ref string BookImage)
        {
            bool IsFind = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Books
                      where ISBN = @ISBN;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", ISBN);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFind = true;
                                authors = (int)reader["authors"];
                                BookID = (int)reader["BookID"];
                                title = (string)reader["title"];
                                date = (DateTime)reader["date"];
                                BookTypeID = (int)reader["BookTypeID"];
                                AdditionalDetials = (string)reader["AdditionalDetials"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                if (reader["BookImage"] == System.DBNull.Value)
                                    BookImage = null;
                                else
                                    BookImage = (string)reader["BookImage"];

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

        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection  = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"Select * from Books
order by date desc";
                    using (SqlCommand command = new SqlCommand(query,connection))
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
    
        public static bool IsAuthorExist(int Author)
        {
            bool IsFind = false;
            try
            {
 using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"select find =  'yes' from Books
where authors = @author;";
                    using (SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@author",Author);
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            IsFind = read.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return IsFind;
        }
        public static DataTable GetAllBooksByAuthorID(int AuthorID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(dtAccess.Connection))
                {
                    connection.Open();
                    string query = @"
	 	 select  People.Name As AuthorName,Books.title,Books.date as Publications from Books
				 inner join People on Books.Authors = People.PersonID
				 group by People.Name,Books.Authors,Books.title,Books.date
				 having Books.Authors = @PersonID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID",AuthorID);
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


    }
}

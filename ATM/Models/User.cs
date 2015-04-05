using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using ATM.Vendor.Vileosoft.Database;

namespace ATM.Models
{
    class User
    {
        public static int UserID;
        public static string FirstName ="";
        public static string LastName ="";
        public static string UserName ="";
        public static string Password ="";
        public static string Title="";
        public static string Address = "";
        public static string City = "";
        public static string PostalCode = "";


        //validateStatus
        public static string validateFirstName = "";
        public static string validateLastName = "";

        public DataTable dataSource(string firstName = null, string lastName = null, string userName = null,string city = null)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Select_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
            cmd.Parameters.Add(new SqlParameter("@UserName",userName));
            cmd.Parameters.Add(new SqlParameter("@City", city));
            cmd.Connection = conn.OpenDB();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.CloseDB();
            return dt;
        }

        public bool DataReader()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                FirstName = DR.GetValue(1).ToString();
                LastName = DR.GetValue(2).ToString();
                UserName = DR.GetValue(3).ToString();
                Password = DR.GetValue(4).ToString();
                Title = DR.GetValue(5).ToString();
                Address = DR.GetValue(6).ToString();
                City = DR.GetValue(7).ToString();
                PostalCode = DR.GetValue(8).ToString();
            }
            //FirstName = "Test";
            conn.CloseDB();
            return true;
        }

        public bool Delete(string ID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Delete_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public bool Insert()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Insert_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", LastName));
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@Title", Title));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));
            cmd.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
            
        }

        public bool Update()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Update_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
            cmd.Parameters.Add(new SqlParameter("@FirstName", FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", LastName));
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@Title", Title));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@City", City));
            cmd.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;

        }

        public bool LoginUser()
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Login_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                LoginForm.UserId = int.Parse(DR.GetValue(0).ToString());
                LoginForm.UserName = DR.GetValue(3).ToString(); 
                conn.CloseDB();
                return true;
            }
            else
            {
                conn.CloseDB();
                return false;
            }
            
           
        }

        public bool Profile(int ProfileID)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_Single_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", ProfileID));
            cmd.Connection = conn.OpenDB();
            SqlDataReader DR = cmd.ExecuteReader();
            //binding data
            if (DR.Read())
            {
                ProfileForm.FirstName = DR.GetValue(1).ToString();
                ProfileForm.LastName = DR.GetValue(2).ToString();
                ProfileForm.UserName = DR.GetValue(3).ToString();
                ProfileForm.Password = DR.GetValue(4).ToString();
                ProfileForm.Title = DR.GetValue(5).ToString();
                ProfileForm.Address = DR.GetValue(6).ToString();
                ProfileForm.City = DR.GetValue(7).ToString();
                ProfileForm.PostalCode = DR.GetValue(8).ToString();
            }
            conn.CloseDB();
            return true;
        }

        public bool UpdateProfile(int id,string firstname,string lastname,string title,string address,string city,string postalcode)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_UpdateProfile_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", id));
            cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
            cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
            cmd.Parameters.Add(new SqlParameter("@Title", title));
            cmd.Parameters.Add(new SqlParameter("@Address", address));
            cmd.Parameters.Add(new SqlParameter("@City", city));
            cmd.Parameters.Add(new SqlParameter("@PostalCode", postalcode));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

        public bool ChangePassword(int id, string password)
        {
            SqlCommand cmd = new SqlCommand();
            Connection conn = new Connection();
            cmd.CommandText = "[dbo].[Sp_ChangePassword_User]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserID", id));
            cmd.Parameters.Add(new SqlParameter("@Password", password));
            cmd.Connection = conn.OpenDB();
            cmd.ExecuteNonQuery();
            conn.CloseDB();
            return true;
        }

    }
}
